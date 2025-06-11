namespace cafedemka
{
    partial class AddWorker
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
            groupBox1 = new GroupBox();
            label6 = new Label();
            HireBox = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            RoleBox = new ComboBox();
            PassBox = new TextBox();
            NameBox = new TextBox();
            LogBox = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(HireBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(RoleBox);
            groupBox1.Controls.Add(PassBox);
            groupBox1.Controls.Add(NameBox);
            groupBox1.Controls.Add(LogBox);
            groupBox1.Location = new Point(40, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(328, 521);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавить сотрудника";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 241);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 12;
            label6.Text = "Дата найма:";
            // 
            // HireBox
            // 
            HireBox.Location = new Point(35, 259);
            HireBox.Name = "HireBox";
            HireBox.Size = new Size(249, 23);
            HireBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 315);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 10;
            label5.Text = "Роль:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 167);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 8;
            label3.Text = "ФИО:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 97);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 7;
            label2.Text = "Пароль:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 36);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 6;
            label1.Text = "Логин:";
            // 
            // button1
            // 
            button1.Location = new Point(89, 437);
            button1.Name = "button1";
            button1.Size = new Size(138, 48);
            button1.TabIndex = 5;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RoleBox
            // 
            RoleBox.FormattingEnabled = true;
            RoleBox.Location = new Point(35, 333);
            RoleBox.Name = "RoleBox";
            RoleBox.Size = new Size(249, 23);
            RoleBox.TabIndex = 4;
            // 
            // PassBox
            // 
            PassBox.Location = new Point(35, 115);
            PassBox.Name = "PassBox";
            PassBox.Size = new Size(249, 23);
            PassBox.TabIndex = 2;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(35, 185);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(249, 23);
            NameBox.TabIndex = 1;
            // 
            // LogBox
            // 
            LogBox.Location = new Point(35, 54);
            LogBox.Name = "LogBox";
            LogBox.Size = new Size(249, 23);
            LogBox.TabIndex = 0;
            // 
            // AddWorker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 578);
            Controls.Add(groupBox1);
            Name = "AddWorker";
            Text = "AddWorker";
            FormClosing += AddWorker_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox LogBox;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private ComboBox RoleBox;
        private TextBox PassBox;
        private TextBox NameBox;
        private TextBox HireBox;
        private Label label6;
    }
}