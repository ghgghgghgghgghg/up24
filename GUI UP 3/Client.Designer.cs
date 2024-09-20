namespace GUI
{
    partial class Client
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.clear = new System.Windows.Forms.Button();
            this.Role = new System.Windows.Forms.Label();
            this.pictureBox_base_photo = new System.Windows.Forms.PictureBox();
            this.textBox_found_requests = new System.Windows.Forms.TextBox();
            this.label_found = new System.Windows.Forms.Label();
            this.Fio = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_found_requests_by_user = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.fio_role_label = new System.Windows.Forms.Label();
            this.btn_create_request = new System.Windows.Forms.Button();
            this.dgw1 = new System.Windows.Forms.DataGridView();
            this.btn_edit_request = new System.Windows.Forms.Button();
            this.pictureBox_QR_code = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_base_photo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_QR_code)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(99)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.clear);
            this.panel1.Controls.Add(this.Role);
            this.panel1.Controls.Add(this.pictureBox_base_photo);
            this.panel1.Controls.Add(this.textBox_found_requests);
            this.panel1.Controls.Add(this.label_found);
            this.panel1.Controls.Add(this.Fio);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_found_requests_by_user);
            this.panel1.Controls.Add(this.menu);
            this.panel1.Controls.Add(this.fio_role_label);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 488);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(177)))), ((int)(((byte)(131)))));
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.clear.ForeColor = System.Drawing.Color.Black;
            this.clear.Location = new System.Drawing.Point(645, 55);
            this.clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(179, 43);
            this.clear.TabIndex = 10;
            this.clear.Text = "Сбросить параметры";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.btn_reset_filters_Click);
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.Role.ForeColor = System.Drawing.Color.Black;
            this.Role.Location = new System.Drawing.Point(185, 117);
            this.Role.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(0, 28);
            this.Role.TabIndex = 5;
            // 
            // pictureBox_base_photo
            // 
            this.pictureBox_base_photo.Location = new System.Drawing.Point(16, 15);
            this.pictureBox_base_photo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_base_photo.Name = "pictureBox_base_photo";
            this.pictureBox_base_photo.Size = new System.Drawing.Size(148, 108);
            this.pictureBox_base_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_base_photo.TabIndex = 4;
            this.pictureBox_base_photo.TabStop = false;
            // 
            // textBox_found_requests
            // 
            this.textBox_found_requests.BackColor = System.Drawing.Color.White;
            this.textBox_found_requests.Location = new System.Drawing.Point(809, 21);
            this.textBox_found_requests.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_found_requests.Name = "textBox_found_requests";
            this.textBox_found_requests.Size = new System.Drawing.Size(223, 22);
            this.textBox_found_requests.TabIndex = 7;
            // 
            // label_found
            // 
            this.label_found.AutoSize = true;
            this.label_found.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(99)))), ((int)(((byte)(75)))));
            this.label_found.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.label_found.ForeColor = System.Drawing.Color.Black;
            this.label_found.Location = new System.Drawing.Point(640, 20);
            this.label_found.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_found.Name = "label_found";
            this.label_found.Size = new System.Drawing.Size(144, 28);
            this.label_found.TabIndex = 8;
            this.label_found.Text = "Критерий поиска:";
            this.label_found.Click += new System.EventHandler(this.label_found_Click);
            // 
            // Fio
            // 
            this.Fio.AutoSize = true;
            this.Fio.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.Fio.ForeColor = System.Drawing.Color.Black;
            this.Fio.Location = new System.Drawing.Point(185, 55);
            this.Fio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Fio.Name = "Fio";
            this.Fio.Size = new System.Drawing.Size(0, 28);
            this.Fio.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox_QR_code);
            this.panel2.Controls.Add(this.dgw1);
            this.panel2.Controls.Add(this.btn_edit_request);
            this.panel2.Controls.Add(this.btn_create_request);
            this.panel2.Location = new System.Drawing.Point(0, 131);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1069, 355);
            this.panel2.TabIndex = 1;
            // 
            // btn_found_requests_by_user
            // 
            this.btn_found_requests_by_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(177)))), ((int)(((byte)(131)))));
            this.btn_found_requests_by_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_found_requests_by_user.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.btn_found_requests_by_user.ForeColor = System.Drawing.Color.Black;
            this.btn_found_requests_by_user.Location = new System.Drawing.Point(453, 12);
            this.btn_found_requests_by_user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_found_requests_by_user.Name = "btn_found_requests_by_user";
            this.btn_found_requests_by_user.Size = new System.Drawing.Size(179, 43);
            this.btn_found_requests_by_user.TabIndex = 6;
            this.btn_found_requests_by_user.Text = "Поиск заявок";
            this.btn_found_requests_by_user.UseVisualStyleBackColor = false;
            this.btn_found_requests_by_user.Click += new System.EventHandler(this.btn_found_requests_by_user_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(177)))), ((int)(((byte)(131)))));
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.menu.Location = new System.Drawing.Point(901, 53);
            this.menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(132, 39);
            this.menu.TabIndex = 2;
            this.menu.Text = "Выйти";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
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
            // btn_create_request
            // 
            this.btn_create_request.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(177)))), ((int)(((byte)(131)))));
            this.btn_create_request.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.btn_create_request.Location = new System.Drawing.Point(487, 308);
            this.btn_create_request.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_create_request.Name = "btn_create_request";
            this.btn_create_request.Size = new System.Drawing.Size(297, 42);
            this.btn_create_request.TabIndex = 1;
            this.btn_create_request.Text = "Составить заявку на ремонт";
            this.btn_create_request.UseVisualStyleBackColor = false;
            this.btn_create_request.Click += new System.EventHandler(this.btn_create_request_Click);
            // 
            // dgw1
            // 
            this.dgw1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(54)))));
            this.dgw1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw1.Location = new System.Drawing.Point(13, 113);
            this.dgw1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgw1.Name = "dgw1";
            this.dgw1.RowHeadersVisible = false;
            this.dgw1.RowHeadersWidth = 51;
            this.dgw1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw1.Size = new System.Drawing.Size(684, 166);
            this.dgw1.TabIndex = 4;
            this.dgw1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw1_CellContentClick);
            // 
            // btn_edit_request
            // 
            this.btn_edit_request.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(177)))), ((int)(((byte)(131)))));
            this.btn_edit_request.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.btn_edit_request.Location = new System.Drawing.Point(190, 308);
            this.btn_edit_request.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_edit_request.Name = "btn_edit_request";
            this.btn_edit_request.Size = new System.Drawing.Size(297, 43);
            this.btn_edit_request.TabIndex = 3;
            this.btn_edit_request.Text = "Редактировать заявку";
            this.btn_edit_request.UseVisualStyleBackColor = false;
            this.btn_edit_request.Click += new System.EventHandler(this.btn_edit_request_Click);
            // 
            // pictureBox_QR_code
            // 
            this.pictureBox_QR_code.BackColor = System.Drawing.Color.White;
            this.pictureBox_QR_code.Location = new System.Drawing.Point(730, 34);
            this.pictureBox_QR_code.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_QR_code.Name = "pictureBox_QR_code";
            this.pictureBox_QR_code.Size = new System.Drawing.Size(254, 234);
            this.pictureBox_QR_code.TabIndex = 13;
            this.pictureBox_QR_code.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(99)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1072, 485);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Client";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Ваши заявки:";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_base_photo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_QR_code)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_create_request;
        private System.Windows.Forms.DataGridView dgw1;
        private System.Windows.Forms.Button btn_found_requests_by_user;
        private System.Windows.Forms.PictureBox pictureBox_base_photo;
        private System.Windows.Forms.Label Fio;
        private System.Windows.Forms.Label fio_role_label;
        private System.Windows.Forms.TextBox textBox_found_requests;
        private System.Windows.Forms.Label label_found;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button btn_edit_request;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.PictureBox pictureBox_QR_code;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}