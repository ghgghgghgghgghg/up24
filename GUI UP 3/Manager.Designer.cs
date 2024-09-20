namespace GUI_EKZ_TRBZD
{
    partial class Manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_edit_request = new System.Windows.Forms.Button();
            this.btn_found_requests_by_user = new System.Windows.Forms.Button();
            this.label_found = new System.Windows.Forms.Label();
            this.textBox_found_requests = new System.Windows.Forms.TextBox();
            this.btn_reset_filters = new System.Windows.Forms.Button();
            this.label_count_of_reports = new System.Windows.Forms.Label();
            this.label_requests = new System.Windows.Forms.Label();
            this.dataGridView_requests_for_manager = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_photo = new System.Windows.Forms.PictureBox();
            this.fio_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back_to_menu = new System.Windows.Forms.Button();
            this.fio_role_label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_requests_for_manager)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_edit_request
            // 
            this.btn_edit_request.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(177)))), ((int)(((byte)(131)))));
            this.btn_edit_request.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_request.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.btn_edit_request.ForeColor = System.Drawing.Color.Black;
            this.btn_edit_request.Location = new System.Drawing.Point(433, 62);
            this.btn_edit_request.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit_request.Name = "btn_edit_request";
            this.btn_edit_request.Size = new System.Drawing.Size(261, 41);
            this.btn_edit_request.TabIndex = 15;
            this.btn_edit_request.Text = "Взять заявку в работу";
            this.btn_edit_request.UseVisualStyleBackColor = false;
            this.btn_edit_request.Click += new System.EventHandler(this.btn_edit_request_Click);
            // 
            // btn_found_requests_by_user
            // 
            this.btn_found_requests_by_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(177)))), ((int)(((byte)(131)))));
            this.btn_found_requests_by_user.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_found_requests_by_user.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.btn_found_requests_by_user.ForeColor = System.Drawing.Color.Black;
            this.btn_found_requests_by_user.Location = new System.Drawing.Point(232, 161);
            this.btn_found_requests_by_user.Margin = new System.Windows.Forms.Padding(4);
            this.btn_found_requests_by_user.Name = "btn_found_requests_by_user";
            this.btn_found_requests_by_user.Size = new System.Drawing.Size(179, 44);
            this.btn_found_requests_by_user.TabIndex = 14;
            this.btn_found_requests_by_user.Text = "Поиск заявок";
            this.btn_found_requests_by_user.UseVisualStyleBackColor = false;
            this.btn_found_requests_by_user.Click += new System.EventHandler(this.btn_found_requests_by_user_Click);
            // 
            // label_found
            // 
            this.label_found.AutoSize = true;
            this.label_found.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.label_found.ForeColor = System.Drawing.Color.White;
            this.label_found.Location = new System.Drawing.Point(415, 107);
            this.label_found.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_found.Name = "label_found";
            this.label_found.Size = new System.Drawing.Size(126, 24);
            this.label_found.TabIndex = 13;
            this.label_found.Text = "Критерий поиска:";
            // 
            // textBox_found_requests
            // 
            this.textBox_found_requests.BackColor = System.Drawing.Color.White;
            this.textBox_found_requests.Location = new System.Drawing.Point(419, 135);
            this.textBox_found_requests.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_found_requests.Name = "textBox_found_requests";
            this.textBox_found_requests.Size = new System.Drawing.Size(223, 22);
            this.textBox_found_requests.TabIndex = 12;
            // 
            // btn_reset_filters
            // 
            this.btn_reset_filters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(177)))), ((int)(((byte)(131)))));
            this.btn_reset_filters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset_filters.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.btn_reset_filters.ForeColor = System.Drawing.Color.Black;
            this.btn_reset_filters.Location = new System.Drawing.Point(232, 96);
            this.btn_reset_filters.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reset_filters.Name = "btn_reset_filters";
            this.btn_reset_filters.Size = new System.Drawing.Size(179, 53);
            this.btn_reset_filters.TabIndex = 11;
            this.btn_reset_filters.Text = "Сбросить параметры";
            this.btn_reset_filters.UseVisualStyleBackColor = false;
            this.btn_reset_filters.Click += new System.EventHandler(this.btn_reset_filters_Click);
            // 
            // label_count_of_reports
            // 
            this.label_count_of_reports.AutoSize = true;
            this.label_count_of_reports.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.label_count_of_reports.ForeColor = System.Drawing.Color.White;
            this.label_count_of_reports.Location = new System.Drawing.Point(664, 135);
            this.label_count_of_reports.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_count_of_reports.Name = "label_count_of_reports";
            this.label_count_of_reports.Size = new System.Drawing.Size(117, 24);
            this.label_count_of_reports.TabIndex = 7;
            this.label_count_of_reports.Text = "Кол-во записей";
            // 
            // label_requests
            // 
            this.label_requests.AutoSize = true;
            this.label_requests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_requests.ForeColor = System.Drawing.Color.White;
            this.label_requests.Location = new System.Drawing.Point(17, 169);
            this.label_requests.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_requests.Name = "label_requests";
            this.label_requests.Size = new System.Drawing.Size(0, 20);
            this.label_requests.TabIndex = 6;
            // 
            // dataGridView_requests_for_manager
            // 
            this.dataGridView_requests_for_manager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_requests_for_manager.Location = new System.Drawing.Point(16, 213);
            this.dataGridView_requests_for_manager.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_requests_for_manager.Name = "dataGridView_requests_for_manager";
            this.dataGridView_requests_for_manager.RowHeadersVisible = false;
            this.dataGridView_requests_for_manager.RowHeadersWidth = 51;
            this.dataGridView_requests_for_manager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_requests_for_manager.Size = new System.Drawing.Size(1031, 185);
            this.dataGridView_requests_for_manager.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(99)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox_photo);
            this.panel1.Controls.Add(this.fio_label);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_back_to_menu);
            this.panel1.Controls.Add(this.fio_role_label);
            this.panel1.Location = new System.Drawing.Point(17, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 155);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(189, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 5;
            // 
            // pictureBox_photo
            // 
            this.pictureBox_photo.Location = new System.Drawing.Point(16, 15);
            this.pictureBox_photo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_photo.Name = "pictureBox_photo";
            this.pictureBox_photo.Size = new System.Drawing.Size(148, 108);
            this.pictureBox_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_photo.TabIndex = 4;
            this.pictureBox_photo.TabStop = false;
            // 
            // fio_label
            // 
            this.fio_label.AutoSize = true;
            this.fio_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio_label.ForeColor = System.Drawing.Color.White;
            this.fio_label.Location = new System.Drawing.Point(181, 26);
            this.fio_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fio_label.Name = "fio_label";
            this.fio_label.Size = new System.Drawing.Size(0, 20);
            this.fio_label.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 151);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1069, 404);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(348, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Критерий поиска:";
            // 
            // btn_back_to_menu
            // 
            this.btn_back_to_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(177)))), ((int)(((byte)(131)))));
            this.btn_back_to_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back_to_menu.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.btn_back_to_menu.Location = new System.Drawing.Point(919, 15);
            this.btn_back_to_menu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back_to_menu.Name = "btn_back_to_menu";
            this.btn_back_to_menu.Size = new System.Drawing.Size(132, 39);
            this.btn_back_to_menu.TabIndex = 2;
            this.btn_back_to_menu.Text = "Выйти";
            this.btn_back_to_menu.UseVisualStyleBackColor = false;
            this.btn_back_to_menu.Click += new System.EventHandler(this.btn_back_to_menu_Click);
            // 
            // fio_role_label
            // 
            this.fio_role_label.AutoSize = true;
            this.fio_role_label.Location = new System.Drawing.Point(147, 4);
            this.fio_role_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fio_role_label.Name = "fio_role_label";
            this.fio_role_label.Size = new System.Drawing.Size(0, 16);
            this.fio_role_label.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(99)))), ((int)(((byte)(75)))));
            this.panel3.Controls.Add(this.btn_edit_request);
            this.panel3.Controls.Add(this.btn_found_requests_by_user);
            this.panel3.Controls.Add(this.label_found);
            this.panel3.Controls.Add(this.textBox_found_requests);
            this.panel3.Controls.Add(this.btn_reset_filters);
            this.panel3.Controls.Add(this.label_count_of_reports);
            this.panel3.Controls.Add(this.label_requests);
            this.panel3.Controls.Add(this.dataGridView_requests_for_manager);
            this.panel3.Location = new System.Drawing.Point(17, 125);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1069, 425);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "Manager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_requests_for_manager)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_edit_request;
        private System.Windows.Forms.Button btn_found_requests_by_user;
        private System.Windows.Forms.Label label_found;
        private System.Windows.Forms.TextBox textBox_found_requests;
        private System.Windows.Forms.Button btn_reset_filters;
        private System.Windows.Forms.Label label_count_of_reports;
        private System.Windows.Forms.Label label_requests;
        private System.Windows.Forms.DataGridView dataGridView_requests_for_manager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_photo;
        private System.Windows.Forms.Label fio_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back_to_menu;
        private System.Windows.Forms.Label fio_role_label;
        private System.Windows.Forms.Panel panel3;
    }
}