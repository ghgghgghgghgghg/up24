using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
namespace GUI
{
    public partial class Client : Form
    {
        private string userNF;
        private string userR;
        private int userID;

        DataBase database = new DataBase();

        public Client(string fullName, string role, int id)
        {
            InitializeComponent();
            userNF = fullName;
            userR = role;
            userID = id;

           
            clear.Visible = false;
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            Fio.Text = $"ФИО: {userNF}";
            Role.Text = $"Роль:{userR}";
            const string imagePath = "images/base_photo.jpg";

            if (File.Exists(imagePath))
            {
                pictureBox_base_photo.Image = Image.FromFile(imagePath);
            }
            LoadR(userID);
            UpdateCount(userID);
        }

        private void btn_create_request_Click(object sender, EventArgs e)
        {
            cr_r_f requestForm = new cr_r_f(userNF, userID);
            this.Hide();
            requestForm.ShowDialog();

            LoadR(userID);
            UpdateCount(userID);

            this.Show();
        }

        private void btn_edit_request_Click(object sender, EventArgs e)
        {
            if (dgw1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите заявку для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string requestStatus = dgw1.SelectedRows[0].Cells["requestStatus"].Value.ToString();

            if (requestStatus != "Новая")
            {
                MessageBox.Show("Редактировать можно только заявки со статусом 'Новая'.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int requestID = (int)dgw1.SelectedRows[0].Cells["requestID"].Value;
            string deviceModel = dgw1.SelectedRows[0].Cells["modelName"].Value.ToString();
            string problemDescription = dgw1.SelectedRows[0].Cells["problemDescription"].Value.ToString();
            string deviceType = GetDeviceTypeByModel(deviceModel);
            E_r_f requestForm = new E_r_f(requestID, userNF, deviceType, deviceModel, problemDescription, userID);
            this.Hide();
            requestForm.ShowDialog();
            LoadR(userID);
            UpdateCount(userID);
            this.Show();
        }

        public string GetDeviceTypeByModel(string modelName)
        {
            string deviceType = null;
            string query = "SELECT DeviceTypes.typeName FROM DeviceModels " + "JOIN DeviceTypes ON DeviceModels.typeID = DeviceTypes.typeID " + "WHERE DeviceModels.modelName = @ModelName";

            using (SqlCommand command = new SqlCommand(query, database.GetConnection()))
            {
                command.Parameters.AddWithValue("@ModelName", modelName);

                try
                {
                    database.GetConnection().Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        deviceType = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при получении типа устройства: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    database.GetConnection().Close();
                }
            }

            return deviceType;
        }

        private void SetupDataGridViewColumns()
        {
            var columns = new Dictionary<string, string>
{
    { "requestID", "Номер заявки" },
    { "startDate", "Дата начала" },
    { "problemDescription", "Описание проблемы" },
    { "requestStatus", "Статус заявки" },
    { "completionDate", "Дата завершения" },
    { "modelName", "Модель устройства" },
    { "typeName", "Тип устройства" }
};

            foreach (var column in columns)
            {
                dgw1.Columns[column.Key].HeaderText = column.Value;
            }

            dgw1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void LoadR(int clientID)
        {
            string query = @"
            SELECT r.requestID, 
                   r.startDate, 
                   r.problemDescription, 
                   r.requestStatus, 
                   r.completionDate, 
                   dm.modelName, 
                   dt.typeName
            FROM Requests r
            INNER JOIN DeviceModels dm ON r.modelID = dm.modelID
            INNER JOIN DeviceTypes dt ON dm.typeID = dt.typeID
            WHERE r.clientID = @clientID";

            using (SqlCommand command = new SqlCommand(query, database.GetConnection()))
            {
                command.Parameters.AddWithValue("@clientID", clientID);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgw1.DataSource = table;

                SetupDataGridViewColumns();
            }
        }

        private void btn_found_requests_by_user_Click(object sender, EventArgs e)//поменять
        {
            string searchText = textBox_found_requests.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Введите текст для поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadR(userID);
                return;
            }

            string query = @"
                SELECT r.requestID,
                     r.startDate,
                     r.problemDescription,
                     r.requestStatus,
                     r.completionDate,
                     dm.modelName,
                     dt.typeName
                FROM Requests r
                INNER JOIN DeviceModels dm ON r.modelID = dm.modelID
                INNER JOIN DeviceTypes dt ON dm.typeID = dt.typeID
                WHERE r.clientID = @clientID AND
                CONCAT(r.requestID, r.problemDescription, dm.modelName, dt.typeName) LIKE '%' + @searchText + '%'";

            using (SqlCommand command = new SqlCommand(query, database.GetConnection()))
            {
                command.Parameters.AddWithValue("@clientID", userID);
                command.Parameters.AddWithValue("@searchText", searchText);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgw1.DataSource = table;

                SetupDataGridViewColumns();

                clear.Visible = true;
               

                int recordCount = table.Rows.Count;
           

                if (recordCount == 0)
                {
                    MessageBox.Show("Не найдено заявок по заданным критериям.", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadR(userID);
                }
            }
        }

        private void btn_reset_filters_Click(object sender, EventArgs e)
        {
            textBox_found_requests.Text = string.Empty;
            LoadR(userID);
         
            clear.Visible = false;
        }

        private void UpdateCount(int userID)
        {
            string countQuery = @"
            SELECT COUNT(*) 
            FROM Requests 
            WHERE clientID = @UserID";

            using (SqlCommand countCommand = new SqlCommand(countQuery, database.GetConnection()))
            {
                countCommand.Parameters.AddWithValue("@UserID", userID);

                try
                {
                    database.openConnection();
                    using (SqlDataReader reader = countCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int requestCount = reader.GetInt32(0);
                         
                        }
                    }
                    database.closeConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при получении количества заявок: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы хотите вернуться в меню?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void label_found_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string googleFormsUrl = "https://docs.google.com/forms";

            QRCodeEncoder qrEncoder = new QRCodeEncoder();

            Bitmap qrCodeImage = qrEncoder.Encode(googleFormsUrl);

            pictureBox_QR_code.Image = qrCodeImage;

            qrEncoder.QRCodeScale = 1;

            pictureBox_QR_code.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox_QR_code.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgw1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
