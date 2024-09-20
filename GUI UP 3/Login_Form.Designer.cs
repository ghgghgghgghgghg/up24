namespace GUI
{
    partial class Login_Form_Window
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_Captcha = new System.Windows.Forms.Label();
            this.button_RefreshCaptcha = new System.Windows.Forms.Button();
            this.textBox_Captcha = new System.Windows.Forms.TextBox();
            this.pictureBox_Captcha = new System.Windows.Forms.PictureBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.textBox_PasswordField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_LoginField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer_Block = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Captcha)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(99)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 144);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(145, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(99)))), ((int)(((byte)(75)))));
            this.panel2.Controls.Add(this.label_Captcha);
            this.panel2.Controls.Add(this.button_RefreshCaptcha);
            this.panel2.Controls.Add(this.textBox_Captcha);
            this.panel2.Controls.Add(this.pictureBox_Captcha);
            this.panel2.Controls.Add(this.btn_Login);
            this.panel2.Controls.Add(this.textBox_PasswordField);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox_LoginField);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 143);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 431);
            this.panel2.TabIndex = 1;
            // 
            // label_Captcha
            // 
            this.label_Captcha.AutoSize = true;
            this.label_Captcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Captcha.ForeColor = System.Drawing.Color.White;
            this.label_Captcha.Location = new System.Drawing.Point(183, 246);
            this.label_Captcha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Captcha.Name = "label_Captcha";
            this.label_Captcha.Size = new System.Drawing.Size(0, 20);
            this.label_Captcha.TabIndex = 9;
            // 
            // button_RefreshCaptcha
            // 
            this.button_RefreshCaptcha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(177)))), ((int)(((byte)(131)))));
            this.button_RefreshCaptcha.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_RefreshCaptcha.Location = new System.Drawing.Point(180, 270);
            this.button_RefreshCaptcha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_RefreshCaptcha.Name = "button_RefreshCaptcha";
            this.button_RefreshCaptcha.Size = new System.Drawing.Size(219, 43);
            this.button_RefreshCaptcha.TabIndex = 8;
            this.button_RefreshCaptcha.Text = "Обновить капчу";
            this.button_RefreshCaptcha.UseVisualStyleBackColor = false;
            this.button_RefreshCaptcha.Click += new System.EventHandler(this.button_RefreshCaptcha_Click);
            // 
            // textBox_Captcha
            // 
            this.textBox_Captcha.Location = new System.Drawing.Point(185, 174);
            this.textBox_Captcha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Captcha.Name = "textBox_Captcha";
            this.textBox_Captcha.Size = new System.Drawing.Size(217, 22);
            this.textBox_Captcha.TabIndex = 7;
            // 
            // pictureBox_Captcha
            // 
            this.pictureBox_Captcha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox_Captcha.Location = new System.Drawing.Point(185, 105);
            this.pictureBox_Captcha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_Captcha.Name = "pictureBox_Captcha";
            this.pictureBox_Captcha.Size = new System.Drawing.Size(219, 62);
            this.pictureBox_Captcha.TabIndex = 6;
            this.pictureBox_Captcha.TabStop = false;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(177)))), ((int)(((byte)(131)))));
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F);
            this.btn_Login.Location = new System.Drawing.Point(159, 321);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(259, 62);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Авторизоваться";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // textBox_PasswordField
            // 
            this.textBox_PasswordField.Location = new System.Drawing.Point(185, 73);
            this.textBox_PasswordField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_PasswordField.Name = "textBox_PasswordField";
            this.textBox_PasswordField.Size = new System.Drawing.Size(212, 22);
            this.textBox_PasswordField.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(79, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "ПАРОЛЬ:";
            // 
            // textBox_LoginField
            // 
            this.textBox_LoginField.Location = new System.Drawing.Point(185, 18);
            this.textBox_LoginField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_LoginField.Multiline = true;
            this.textBox_LoginField.Name = "textBox_LoginField";
            this.textBox_LoginField.Size = new System.Drawing.Size(212, 24);
            this.textBox_LoginField.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(93, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "ЛОГИН:";
            // 
            // timer_Block
            // 
            this.timer_Block.Interval = 1000;
            this.timer_Block.Tick += new System.EventHandler(this.timer_Block_Tick);
            // 
            // Login_Form_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 556);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(566, 603);
            this.MinimumSize = new System.Drawing.Size(566, 603);
            this.Name = "Login_Form_Window";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Login_Form_Window_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Captcha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox textBox_PasswordField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_LoginField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_Captcha;
        private System.Windows.Forms.TextBox textBox_Captcha;
        private System.Windows.Forms.Button button_RefreshCaptcha;
        private System.Windows.Forms.Label label_Captcha;
        private System.Windows.Forms.Timer timer_Block;
    }
}

