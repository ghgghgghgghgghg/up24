﻿namespace GUI
{
    partial class E_r_f
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
            this.comboBox_DeviceModels = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_add_request = new System.Windows.Forms.Button();
            this.textBox_Description_problem = new System.Windows.Forms.TextBox();
            this.label_dicription = new System.Windows.Forms.Label();
            this.comboBox_DeviceTypes = new System.Windows.Forms.ComboBox();
            this.label_device = new System.Windows.Forms.Label();
            this.textBox_FIO = new System.Windows.Forms.TextBox();
            this.label_FIO = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(99)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.label_info);
            this.panel1.Controls.Add(this.back_to_menu);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 100);
            this.panel1.TabIndex = 0;
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.label_info.Location = new System.Drawing.Point(98, 63);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(230, 23);
            this.label_info.TabIndex = 3;
            this.label_info.Text = "Редактирование заявки на ремонт";
            // 
            // back_to_menu
            // 
            this.back_to_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(177)))), ((int)(((byte)(131)))));
            this.back_to_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_to_menu.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.back_to_menu.Location = new System.Drawing.Point(268, 12);
            this.back_to_menu.Name = "back_to_menu";
            this.back_to_menu.Size = new System.Drawing.Size(126, 44);
            this.back_to_menu.TabIndex = 4;
            this.back_to_menu.Text = "Вернуться в меню";
            this.back_to_menu.UseVisualStyleBackColor = false;
            this.back_to_menu.Click += new System.EventHandler(this.back_to_menu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(99)))), ((int)(((byte)(75)))));
            this.panel2.Controls.Add(this.comboBox_DeviceModels);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button_add_request);
            this.panel2.Controls.Add(this.textBox_Description_problem);
            this.panel2.Controls.Add(this.label_dicription);
            this.panel2.Controls.Add(this.comboBox_DeviceTypes);
            this.panel2.Controls.Add(this.label_device);
            this.panel2.Controls.Add(this.textBox_FIO);
            this.panel2.Controls.Add(this.label_FIO);
            this.panel2.Location = new System.Drawing.Point(-1, 89);
            this.panel2.MaximumSize = new System.Drawing.Size(400, 320);
            this.panel2.MinimumSize = new System.Drawing.Size(400, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 320);
            this.panel2.TabIndex = 1;
            // 
            // comboBox_DeviceModels
            // 
            this.comboBox_DeviceModels.FormattingEnabled = true;
            this.comboBox_DeviceModels.Location = new System.Drawing.Point(140, 116);
            this.comboBox_DeviceModels.Name = "comboBox_DeviceModels";
            this.comboBox_DeviceModels.Size = new System.Drawing.Size(228, 21);
            this.comboBox_DeviceModels.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(74, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Модель:";
            // 
            // button_add_request
            // 
            this.button_add_request.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(177)))), ((int)(((byte)(131)))));
            this.button_add_request.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_request.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.button_add_request.Location = new System.Drawing.Point(142, 241);
            this.button_add_request.Name = "button_add_request";
            this.button_add_request.Size = new System.Drawing.Size(161, 34);
            this.button_add_request.TabIndex = 19;
            this.button_add_request.Text = "Изменить заявку";
            this.button_add_request.UseVisualStyleBackColor = false;
            this.button_add_request.Click += new System.EventHandler(this.button_add_request_Click);
            // 
            // textBox_Description_problem
            // 
            this.textBox_Description_problem.Location = new System.Drawing.Point(140, 157);
            this.textBox_Description_problem.Name = "textBox_Description_problem";
            this.textBox_Description_problem.Size = new System.Drawing.Size(228, 20);
            this.textBox_Description_problem.TabIndex = 16;
            // 
            // label_dicription
            // 
            this.label_dicription.AutoSize = true;
            this.label_dicription.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.label_dicription.ForeColor = System.Drawing.Color.Black;
            this.label_dicription.Location = new System.Drawing.Point(68, 151);
            this.label_dicription.Name = "label_dicription";
            this.label_dicription.Size = new System.Drawing.Size(76, 23);
            this.label_dicription.TabIndex = 15;
            this.label_dicription.Text = "Описание:";
            // 
            // comboBox_DeviceTypes
            // 
            this.comboBox_DeviceTypes.FormattingEnabled = true;
            this.comboBox_DeviceTypes.Location = new System.Drawing.Point(142, 84);
            this.comboBox_DeviceTypes.Name = "comboBox_DeviceTypes";
            this.comboBox_DeviceTypes.Size = new System.Drawing.Size(228, 21);
            this.comboBox_DeviceTypes.TabIndex = 14;
            // 
            // label_device
            // 
            this.label_device.AutoSize = true;
            this.label_device.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.label_device.ForeColor = System.Drawing.Color.Black;
            this.label_device.Location = new System.Drawing.Point(53, 84);
            this.label_device.Name = "label_device";
            this.label_device.Size = new System.Drawing.Size(92, 23);
            this.label_device.TabIndex = 13;
            this.label_device.Text = "Вид техники:";
            // 
            // textBox_FIO
            // 
            this.textBox_FIO.Location = new System.Drawing.Point(140, 49);
            this.textBox_FIO.Name = "textBox_FIO";
            this.textBox_FIO.Size = new System.Drawing.Size(228, 20);
            this.textBox_FIO.TabIndex = 12;
            // 
            // label_FIO
            // 
            this.label_FIO.AutoSize = true;
            this.label_FIO.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.label_FIO.ForeColor = System.Drawing.Color.Black;
            this.label_FIO.Location = new System.Drawing.Point(89, 53);
            this.label_FIO.Name = "label_FIO";
            this.label_FIO.Size = new System.Drawing.Size(40, 23);
            this.label_FIO.TabIndex = 11;
            this.label_FIO.Text = "ФИО:";
            // 
            // Edit_request_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 410);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(420, 449);
            this.MinimumSize = new System.Drawing.Size(420, 449);
            this.Name = "Edit_request_form";
            this.Text = "Изменение заявки на ремонт";
            this.Load += new System.EventHandler(this.Edit_request_form_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_add_request;
        private System.Windows.Forms.TextBox textBox_Description_problem;
        private System.Windows.Forms.Label label_dicription;
        private System.Windows.Forms.ComboBox comboBox_DeviceTypes;
        private System.Windows.Forms.Label label_device;
        private System.Windows.Forms.TextBox textBox_FIO;
        private System.Windows.Forms.Label label_FIO;
        private System.Windows.Forms.ComboBox comboBox_DeviceModels;
    }
}