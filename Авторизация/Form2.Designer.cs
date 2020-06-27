namespace Авторизация
{
    partial class RegMenu
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
            this.BackgroundText = new System.Windows.Forms.Label();
            this.LbLogin = new System.Windows.Forms.Label();
            this.LbPassword = new System.Windows.Forms.Label();
            this.TbLogin = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.BackgroundTextTwo = new System.Windows.Forms.Label();
            this.ButRegTwo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackgroundText
            // 
            this.BackgroundText.AutoSize = true;
            this.BackgroundText.Location = new System.Drawing.Point(99, 29);
            this.BackgroundText.Name = "BackgroundText";
            this.BackgroundText.Size = new System.Drawing.Size(72, 13);
            this.BackgroundText.TabIndex = 0;
            this.BackgroundText.Text = "Регистрация";
            // 
            // LbLogin
            // 
            this.LbLogin.AutoSize = true;
            this.LbLogin.Location = new System.Drawing.Point(7, 71);
            this.LbLogin.Name = "LbLogin";
            this.LbLogin.Size = new System.Drawing.Size(38, 13);
            this.LbLogin.TabIndex = 1;
            this.LbLogin.Text = "Логин";
            // 
            // LbPassword
            // 
            this.LbPassword.AutoSize = true;
            this.LbPassword.Location = new System.Drawing.Point(7, 134);
            this.LbPassword.Name = "LbPassword";
            this.LbPassword.Size = new System.Drawing.Size(45, 13);
            this.LbPassword.TabIndex = 2;
            this.LbPassword.Text = "Пароль";
            // 
            // TbLogin
            // 
            this.TbLogin.Location = new System.Drawing.Point(65, 67);
            this.TbLogin.Name = "TbLogin";
            this.TbLogin.Size = new System.Drawing.Size(100, 20);
            this.TbLogin.TabIndex = 3;
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(65, 130);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(100, 20);
            this.TbPassword.TabIndex = 4;
            // 
            // BackgroundTextTwo
            // 
            this.BackgroundTextTwo.AutoSize = true;
            this.BackgroundTextTwo.Location = new System.Drawing.Point(187, 71);
            this.BackgroundTextTwo.Name = "BackgroundTextTwo";
            this.BackgroundTextTwo.Size = new System.Drawing.Size(143, 65);
            this.BackgroundTextTwo.TabIndex = 5;
            this.BackgroundTextTwo.Text = "Пароль дожен содержать:\r\n1.Заглавную букву \r\n2.Один из знаков(!@#$%^)\r\n3.Больше ш" +
    "ести знаков\r\n4.Цифру \r\n";
            // 
            // ButRegTwo
            // 
            this.ButRegTwo.Location = new System.Drawing.Point(12, 183);
            this.ButRegTwo.Name = "ButRegTwo";
            this.ButRegTwo.Size = new System.Drawing.Size(217, 23);
            this.ButRegTwo.TabIndex = 6;
            this.ButRegTwo.Text = "Сохранить и зарегистрироваться";
            this.ButRegTwo.UseVisualStyleBackColor = true;
            this.ButRegTwo.Click += new System.EventHandler(this.ButRegTwo_Click);
            // 
            // RegMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(344, 228);
            this.Controls.Add(this.ButRegTwo);
            this.Controls.Add(this.BackgroundTextTwo);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbLogin);
            this.Controls.Add(this.LbPassword);
            this.Controls.Add(this.LbLogin);
            this.Controls.Add(this.BackgroundText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegMenu";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BackgroundText;
        private System.Windows.Forms.Label LbLogin;
        private System.Windows.Forms.Label LbPassword;
        private System.Windows.Forms.TextBox TbLogin;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.Label BackgroundTextTwo;
        private System.Windows.Forms.Button ButRegTwo;
    }
}