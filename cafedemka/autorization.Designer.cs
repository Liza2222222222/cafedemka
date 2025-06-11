namespace cafedemka
{
    partial class autorization
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnLogin = new Button();
            passBox = new TextBox();
            loginBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(passBox);
            panel1.Controls.Add(loginBox);
            panel1.Location = new Point(113, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(538, 366);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(217, 13);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 5;
            label3.Text = "Вход в систему";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 180);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 85);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 3;
            label1.Text = "Логин";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(199, 270);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(108, 44);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // passBox
            // 
            passBox.Location = new Point(151, 172);
            passBox.Name = "passBox";
            passBox.Size = new Size(234, 23);
            passBox.TabIndex = 1;
            // 
            // loginBox
            // 
            loginBox.Location = new Point(151, 82);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(234, 23);
            loginBox.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 482);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLogin;
        private TextBox passBox;
        private TextBox loginBox;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
