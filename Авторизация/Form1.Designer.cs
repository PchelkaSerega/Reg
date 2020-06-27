namespace Авторизация
{
    partial class Menu
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
            this.BackgroundText = new System.Windows.Forms.Label();
            this.TbLogin = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.ButLogin = new System.Windows.Forms.Button();
            this.ButReg = new System.Windows.Forms.Button();
            this.LbLogin = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackgroundText
            // 
            this.BackgroundText.AutoSize = true;
            this.BackgroundText.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackgroundText.Location = new System.Drawing.Point(68, 25);
            this.BackgroundText.Name = "BackgroundText";
            this.BackgroundText.Size = new System.Drawing.Size(144, 26);
            this.BackgroundText.TabIndex = 0;
            this.BackgroundText.Text = "Авторизация";
            // 
            // TbLogin
            // 
            this.TbLogin.Location = new System.Drawing.Point(73, 99);
            this.TbLogin.Name = "TbLogin";
            this.TbLogin.Size = new System.Drawing.Size(139, 20);
            this.TbLogin.TabIndex = 1;
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(73, 170);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(139, 20);
            this.TbPassword.TabIndex = 2;
            // 
            // ButLogin
            // 
            this.ButLogin.Location = new System.Drawing.Point(12, 220);
            this.ButLogin.Name = "ButLogin";
            this.ButLogin.Size = new System.Drawing.Size(119, 23);
            this.ButLogin.TabIndex = 3;
            this.ButLogin.Text = "Войти";
            this.ButLogin.UseVisualStyleBackColor = true;
            this.ButLogin.Click += new System.EventHandler(this.ButLogin_Click);
            // 
            // ButReg
            // 
            this.ButReg.Location = new System.Drawing.Point(153, 220);
            this.ButReg.Name = "ButReg";
            this.ButReg.Size = new System.Drawing.Size(112, 23);
            this.ButReg.TabIndex = 4;
            this.ButReg.Text = "Регистрация ";
            this.ButReg.UseVisualStyleBackColor = true;
            this.ButReg.Click += new System.EventHandler(this.ButReg_Click);
            // 
            // LbLogin
            // 
            this.LbLogin.AutoSize = true;
            this.LbLogin.Location = new System.Drawing.Point(13, 99);
            this.LbLogin.Name = "LbLogin";
            this.LbLogin.Size = new System.Drawing.Size(38, 13);
            this.LbLogin.TabIndex = 5;
            this.LbLogin.Text = "Логин";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(13, 170);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(45, 13);
            this.lbPassword.TabIndex = 6;
            this.lbPassword.Text = "Пароль";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(277, 252);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.LbLogin);
            this.Controls.Add(this.ButReg);
            this.Controls.Add(this.ButLogin);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbLogin);
            this.Controls.Add(this.BackgroundText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BackgroundText;
        private System.Windows.Forms.TextBox TbLogin;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.Button ButLogin;
        private System.Windows.Forms.Button ButReg;
        private System.Windows.Forms.Label LbLogin;
        private System.Windows.Forms.Label lbPassword;
    }
}

