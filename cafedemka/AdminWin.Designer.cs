namespace cafedemka
{
    partial class adminwin
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
            dataGridView1 = new DataGridView();
            tab = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            dataGridView2 = new DataGridView();
            tabPage3 = new TabPage();
            dataGridView3 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tab.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(197, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(590, 307);
            dataGridView1.TabIndex = 0;
            // 
            // tab
            // 
            tab.Controls.Add(tabPage1);
            tab.Controls.Add(tabPage2);
            tab.Controls.Add(tabPage3);
            tab.Location = new Point(22, 12);
            tab.Name = "tab";
            tab.SelectedIndex = 0;
            tab.Size = new Size(848, 499);
            tab.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(840, 471);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Смены";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(840, 471);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Сотрудники";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(49, 153);
            button2.Name = "button2";
            button2.Size = new Size(109, 65);
            button2.TabIndex = 4;
            button2.Text = "Уволить сотрудника";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(49, 332);
            button3.Name = "button3";
            button3.Size = new Size(109, 45);
            button3.TabIndex = 3;
            button3.Text = "Сохранить изменения";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(49, 53);
            button1.Name = "button1";
            button1.Size = new Size(109, 65);
            button1.TabIndex = 1;
            button1.Text = "Добавить сотрудника";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(200, 53);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(607, 345);
            dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(840, 471);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Заказы";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(136, 75);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(563, 297);
            dataGridView3.TabIndex = 0;
            // 
            // adminwin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 549);
            Controls.Add(tab);
            Name = "adminwin";
            Text = "AdminWin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tab.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TabControl tab;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView2;
        private TabPage tabPage3;
        private DataGridView dataGridView3;
        private Button button1;
        private Button button3;
        private Button button2;
    }
}