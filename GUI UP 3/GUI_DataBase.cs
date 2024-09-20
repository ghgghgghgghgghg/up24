using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_DataBase : Form
    {
        DataBase database = new DataBase();

        public GUI_DataBase()
        {
            InitializeComponent();

            LoadDataIntoDataGridViews();
        }

        private void LoadDataIntoDataGridViews()
        {
            // Поменять названия таблиц
            ShowTableData("SELECT * FROM Customers", dataGridViewTable_1);
            ShowTableData("SELECT * FROM Employees", dataGridViewTable_2);
            ShowTableData("SELECT * FROM login", dataGridViewTable_3);
            ShowTableData("SELECT * FROM Orders", dataGridViewTable_4);
            ShowTableData("SELECT * FROM Warehouse", dataGridViewTable_5);
        }

        // Метод запроса для получения содержимого таблицы
        private DataTable GetTableData(string query)
        {
            DataTable table = new DataTable();
            try
            {
                database.openConnection();
                SqlCommand command = new SqlCommand(query, database.GetConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                database.closeConnection();
            }
            return table;
        }

        // Общий метод для отображения данных
        private void ShowTableData(string query, DataGridView dataGridView)
        {
            DataTable table = GetTableData(query);

            if (table != null)
            {
                dataGridView.DataSource = table;
            }
        }

        private void Table1_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = TablePage_1;
            // Поменять название запроса
            ShowTableData("SELECT * FROM Customers", dataGridViewTable_1);
        }

        private void Table2_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = TablePage_2;
            // Поменять название запроса
            ShowTableData("SELECT * FROM Employees", dataGridViewTable_2);
        }

        private void Table3_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = TablePage_3;
            // Поменять название запроса
            ShowTableData("SELECT * FROM login", dataGridViewTable_3);
        }

        private void Table4_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = TablePage_4;
            // Поменять название запроса
            ShowTableData("SELECT * FROM Orders", dataGridViewTable_4);
        }

        private void Table5_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = TablePage_5;
            // Поменять название запроса
            ShowTableData("SELECT * FROM Warehouse", dataGridViewTable_5);
        }

        // Кнопка добавления записи в таблице 1
        private void btnAdd_Table1_Click(object sender, EventArgs e)
        {
            DataTable table = (DataTable)dataGridViewTable_1.DataSource;
            if (table != null)
            {
                DataRow newRow = table.NewRow();
                table.Rows.Add(newRow);

                dataGridViewTable_1.DataSource = null;
                dataGridViewTable_1.DataSource = table; 
            }
        }

        // Кнопка удаления записи в таблице 1
        private void btnDelete_Table1_Click(object sender, EventArgs e)
        {
            if (dataGridViewTable_1.SelectedRows.Count > 0)
            {
                dataGridViewTable_1.Rows.Remove(dataGridViewTable_1.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления!");
            }
        }

        // Кнопка сохранения записи в таблице 1
        private void btnSave_Table1_Click(object sender, EventArgs e)
        {
            DataTable table = (DataTable)dataGridViewTable_1.DataSource;
            if (table != null)
            {
                try
                {
                    database.openConnection();
                    // Поменять название запроса
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Customers", database.GetConnection());
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                    adapter.Update(table);
                    MessageBox.Show("Изменения сохранены успешно!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка во время сохранения: " + ex.Message);
                }
                finally
                {
                    database.closeConnection();
                }
            }
        }

        // Кнопка добавления записи в таблице 2
        private void btnAdd_Table2_Click(object sender, EventArgs e)
        {
            DataTable table = (DataTable)dataGridViewTable_2.DataSource;
            if (table != null)
            {
                DataRow newRow = table.NewRow();
                table.Rows.Add(newRow);

                dataGridViewTable_2.DataSource = null;
                dataGridViewTable_2.DataSource = table;
            }
        }

        // Кнопка удаления записи в таблице 2
        private void btnDelete_Table2_Click(object sender, EventArgs e)
        {
            if (dataGridViewTable_2.SelectedRows.Count > 0)
            {
                dataGridViewTable_2.Rows.Remove(dataGridViewTable_2.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления!");
            }
        }

        // Кнопка сохранения записи в таблице 2
        private void btnSave_Table2_Click(object sender, EventArgs e)
        {
            DataTable table = (DataTable)dataGridViewTable_2.DataSource;
            if (table != null)
            {
                try
                {
                    database.openConnection();
                    // Поменять название запроса
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Employees", database.GetConnection());
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                    adapter.Update(table);
                    MessageBox.Show("Изменения сохранены успешно!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка во время сохранения: " + ex.Message);
                }
                finally
                {
                    database.closeConnection();
                }
            }
        }

        // Кнопка добавления записи в таблице 3
        private void btnAdd_Table3_Click(object sender, EventArgs e)
        {
            DataTable table = (DataTable)dataGridViewTable_3.DataSource;
            if (table != null)
            {
                DataRow newRow = table.NewRow();
                table.Rows.Add(newRow);

                dataGridViewTable_3.DataSource = null;
                dataGridViewTable_3.DataSource = table;
            }
        }

        // Кнопка удаления записи в таблице 3
        private void btnDelete_Table3_Click(object sender, EventArgs e)
        {
            if (dataGridViewTable_3.SelectedRows.Count > 0)
            {
                dataGridViewTable_3.Rows.Remove(dataGridViewTable_3.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления!");
            }
        }

        // Кнопка сохранения записи в таблице 3
        private void btnSave_Table3_Click(object sender, EventArgs e)
        {
            DataTable table = (DataTable)dataGridViewTable_3.DataSource;
            if (table != null)
            {
                try
                {
                    database.openConnection();
                    // Поменять название запроса
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM login", database.GetConnection());
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                    adapter.Update(table);
                    MessageBox.Show("Изменения сохранены успешно!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка во время сохранения: " + ex.Message);
                }
                finally
                {
                    database.closeConnection();
                }
            }
        }

        // Кнопка добавления записи в таблице 4
        private void btnAdd_Table4_Click(object sender, EventArgs e)
        {
            DataTable table = (DataTable)dataGridViewTable_4.DataSource;
            if (table != null)
            {
                DataRow newRow = table.NewRow();
                table.Rows.Add(newRow);

                dataGridViewTable_4.DataSource = null;
                dataGridViewTable_4.DataSource = table;
            }
        }

        // Кнопка удаления записи в таблице 4
        private void btnDelete_Table4_Click(object sender, EventArgs e)
        {
            if (dataGridViewTable_4.SelectedRows.Count > 0)
            {
                dataGridViewTable_4.Rows.Remove(dataGridViewTable_4.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления!");
            }
        }

        // Кнопка сохранения записи в таблице 4
        private void btnSave_Table4_Click(object sender, EventArgs e)
        {
            DataTable table = (DataTable)dataGridViewTable_4.DataSource;
            if (table != null)
            {
                try
                {
                    database.openConnection();
                    // Поменять название запроса
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Orders", database.GetConnection());
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                    adapter.Update(table);
                    MessageBox.Show("Изменения сохранены успешно!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка во время сохранения: " + ex.Message);
                }
                finally
                {
                    database.closeConnection();
                }
            }
        }

        // Кнопка добавления записи в таблице 5
        private void btnAdd_Table5_Click(object sender, EventArgs e)
        {
            DataTable table = (DataTable)dataGridViewTable_5.DataSource;
            if (table != null)
            {
                DataRow newRow = table.NewRow();
                table.Rows.Add(newRow);

                dataGridViewTable_5.DataSource = null;
                dataGridViewTable_5.DataSource = table;
            }
        }

        // Кнопка удаления записи в таблице 5
        private void btnDelete_Table5_Click(object sender, EventArgs e)
        {
            if (dataGridViewTable_5.SelectedRows.Count > 0)
            {
                dataGridViewTable_5.Rows.Remove(dataGridViewTable_5.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления!");
            }
        }

        // Кнопка сохранения записи в таблице 5
        private void btnSave_Table5_Click(object sender, EventArgs e)
        {
            DataTable table = (DataTable)dataGridViewTable_5.DataSource;
            if (table != null)
            {
                try
                {
                    database.openConnection();
                    // Поменять название запроса
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Warehouse", database.GetConnection());
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                    adapter.Update(table);
                    MessageBox.Show("Изменения сохранены успешно!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка во время сохранения: " + ex.Message);
                }
                finally
                {
                    database.closeConnection();
                }
            }
        }
    }
}
