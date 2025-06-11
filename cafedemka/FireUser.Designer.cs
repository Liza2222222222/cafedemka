namespace cafedemka
{
    partial class FireUser
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
            DelBox = new ComboBox();
            delBtn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DelBox);
            groupBox1.Controls.Add(delBtn);
            groupBox1.Location = new Point(42, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(286, 130);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Уволить сотрудника";
            // 
            // DelBox
            // 
            DelBox.FormattingEnabled = true;
            DelBox.Location = new Point(29, 40);
            DelBox.Name = "DelBox";
            DelBox.Size = new Size(205, 23);
            DelBox.TabIndex = 1;
            // 
            // delBtn
            // 
            delBtn.Location = new Point(89, 91);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(75, 23);
            delBtn.TabIndex = 0;
            delBtn.Text = "Уволить";
            delBtn.UseVisualStyleBackColor = true;
            delBtn.Click += button1_Click;
            // 
            // FireUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 165);
            Controls.Add(groupBox1);
            Name = "FireUser";
            Text = "Fireuser";
            FormClosing += FireUser_FormClosing;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox DelBox;
        private Button delBtn;
    }
}