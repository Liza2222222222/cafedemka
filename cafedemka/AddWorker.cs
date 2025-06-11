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

namespace cafedemka
{
    public partial class AddWorker : Form//код полностью взят с интернета https://jopapopa.com
    {
        string connStr = "server=localhost;user=root;database=cafe;password=root;";
        public AddWorker()
        {
            InitializeComponent();
            RoleBox.Items.Clear();
            MySqlConnection connection = new MySqlConnection(connStr);//подключаемся к БД
            connection.Open();//открываем БД
            string query = "SELECT distinct position FROM workers";//выбираем таблицу 
            MySqlCommand command = new MySqlCommand(query, connection);//отправляем запрос
            MySqlDataReader reader = command.ExecuteReader();//получаем запрос
            //добавление вариантов выбора в комбобокс с логинами
            while (reader.Read())
            {
                string name = reader["position"].ToString();
                RoleBox.Items.Add(name);
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // создаём объект для подключения к БД
                MySqlConnection conn = new MySqlConnection(connStr);
                // устанавливаем соединение с БД
                conn.Open();
                //создаем запрос обновления параметра бана и аутентификации
                //проблемы с изменеием аутентификации
                string query = $"insert into workers (fullname,login, password,position,hire_date,ban,auth) value ('{NameBox.Text}','{LogBox.Text}','{PassBox.Text}','{RoleBox.Text}','{HireBox.Text}', 3, 0);";
                MySqlCommand command = new MySqlCommand(query, conn);
                // выполняем запрос
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Новый пользватель добавлен!", "База данных пользователей!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NameBox.Text = null;
                LogBox.Text = null;
                PassBox.Text = null;
                RoleBox.Text = null;
                HireBox.Text = null;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Не получилось добавить нового пользователя!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddWorker_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
