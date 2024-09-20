﻿namespace GUI_EKZ_TRBZD
{
    partial class EditRequestManagerForm
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
            this.label_info = new System.Windows.Forms.Label();
            this.back_to_menu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_masters = new System.Windows.Forms.ComboBox();
            this.textBox_request_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.button_add_request = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_start_date = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_end_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(99)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.label_info);
            this.panel1.Controls.Add(this.back_to_menu);
            this.panel1.Location = new System.Drawing.Point(-8, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 123);
            this.panel1.TabIndex = 4;
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.label_info.Location = new System.Drawing.Point(187, 88);
            this.label_info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(242, 24);
            this.label_info.TabIndex = 3;
            this.label_info.Text = "Редактирование заявки на ремонт";
            // 
            // back_to_menu
            // 
            this.back_to_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(177)))), ((int)(((byte)(131)))));
            this.back_to_menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back_to_menu.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.back_to_menu.Location = new System.Drawing.Point(388, 15);
            this.back_to_menu.Margin = new System.Windows.Forms.Padding(4);
            this.back_to_menu.Name = "back_to_menu";
            this.back_to_menu.Size = new System.Drawing.Size(168, 54);
            this.back_to_menu.TabIndex = 4;
            this.back_to_menu.Text = "Вернуться в меню";
            this.back_to_menu.UseVisualStyleBackColor = false;
            this.back_to_menu.Click += new System.EventHandler(this.back_to_menu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(99)))), ((int)(((byte)(75)))));
            this.panel2.Controls.Add(this.comboBox_masters);
            this.panel2.Controls.Add(this.textBox_request_id);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label_id);
            this.panel2.Controls.Add(this.button_add_request);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dateTimePicker_start_date);
            this.panel2.Controls.Add(this.dateTimePicker_end_date);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(-8, 121);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 434);
            this.panel2.TabIndex = 5;
            // 
            // comboBox_masters
            // 
            this.comboBox_masters.FormattingEnabled = true;
            this.comboBox_masters.Location = new System.Drawing.Point(153, 158);
            this.comboBox_masters.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_masters.Name = "comboBox_masters";
            this.comboBox_masters.Size = new System.Drawing.Size(303, 24);
            this.comboBox_masters.TabIndex = 47;
            // 
            // textBox_request_id
            // 
            this.textBox_request_id.Location = new System.Drawing.Point(153, 27);
            this.textBox_request_id.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_request_id.Name = "textBox_request_id";
            this.textBox_request_id.Size = new System.Drawing.Size(308, 22);
            this.textBox_request_id.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(87, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 24);
            this.label6.TabIndex = 46;
            this.label6.Text = "Мастер:";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.label_id.ForeColor = System.Drawing.Color.White;
            this.label_id.Location = new System.Drawing.Point(68, 23);
            this.label_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(77, 24);
            this.label_id.TabIndex = 36;
            this.label_id.Text = "ID заявки:";
            // 
            // button_add_request
            // 
            this.button_add_request.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(177)))), ((int)(((byte)(131)))));
            this.button_add_request.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_request.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.button_add_request.Location = new System.Drawing.Point(191, 242);
            this.button_add_request.Margin = new System.Windows.Forms.Padding(4);
            this.button_add_request.Name = "button_add_request";
            this.button_add_request.Size = new System.Drawing.Size(215, 42);
            this.button_add_request.TabIndex = 32;
            this.button_add_request.Text = "Изменить заявку";
            this.button_add_request.UseVisualStyleBackColor = false;
            this.button_add_request.Click += new System.EventHandler(this.button_add_request_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 38;
            this.label2.Text = "Дата начала:";
            // 
            // dateTimePicker_start_date
            // 
            this.dateTimePicker_start_date.Location = new System.Drawing.Point(152, 73);
            this.dateTimePicker_start_date.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_start_date.Name = "dateTimePicker_start_date";
            this.dateTimePicker_start_date.Size = new System.Drawing.Size(305, 22);
            this.dateTimePicker_start_date.TabIndex = 37;
            // 
            // dateTimePicker_end_date
            // 
            this.dateTimePicker_end_date.Location = new System.Drawing.Point(152, 114);
            this.dateTimePicker_end_date.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_end_date.Name = "dateTimePicker_end_date";
            this.dateTimePicker_end_date.Size = new System.Drawing.Size(305, 22);
            this.dateTimePicker_end_date.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(56, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 42;
            this.label4.Text = "Дата конца:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // EditRequestManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "EditRequestManagerForm";
            this.Text = "EditRequestManagerForm";
            this.Load += new System.EventHandler(this.EditRequestManagerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Button back_to_menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox_masters;
        private System.Windows.Forms.TextBox textBox_request_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Button button_add_request;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end_date;
        private System.Windows.Forms.Label label4;
    }
}