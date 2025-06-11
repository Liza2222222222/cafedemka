using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace cafedemka
{
    public partial class adminwin : System.Windows.Forms.Form
    {
        string connStr = "server=localhost;user=root;database=cafe;password=root;";
        string glob;
        void ShowClienttInGrid(string comm, DataGridView dgv)//шаблон показа таблиц
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string query = comm;
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;
            conn.Close();
        }
        public adminwin()
        {
            InitializeComponent();
            ShowClienttInGrid("SELECT * FROM shifts", dataGridView1);
            ShowClienttInGrid("SELECT * FROM workers", dataGridView2);
            ShowClienttInGrid("SELECT * FROM orders", dataGridView3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FireUser fire = new FireUser();

            DialogResult result = fire.ShowDialog();
            if (result == DialogResult.OK)
            {
                ShowClienttInGrid("SELECT * FROM workers", dataGridView2);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.DataSource is DataTable dataTable)
                {
                    using (var connection = new MySqlConnection(connStr))
                    {
                        string query = $"SELECT * FROM workers";
                        var adapter = new MySqlDataAdapter(query, connection);
                        var commandBuilder = new MySqlCommandBuilder(adapter);
                        adapter.Update(dataTable);
                    }

                }
                MessageBox.Show("Данные успешно сохранены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddWorker add = new AddWorker();
            DialogResult result = add.ShowDialog();
            if (result == DialogResult.OK)
            {
                ShowClienttInGrid("SELECT * FROM workers", dataGridView2);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
