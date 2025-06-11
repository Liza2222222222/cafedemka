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
    public partial class FireUser : Form
    {
        string connStr = "server=localhost;user=root;database=cafe;password=root;";
        public FireUser()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(FireUser_FormClosing);
            DelBox.Items.Clear();
            MySqlConnection connection = new MySqlConnection(connStr);//подключаемся к БД
            connection.Open();//открываем БД
            string query = "SELECT login FROM workers WHERE status = 'Работает'";//выбираем таблицу 
            MySqlCommand command = new MySqlCommand(query, connection);//отправляем запрос
            MySqlDataReader reader = command.ExecuteReader();//получаем запрос
            //добавление вариантов выбора в комбобокс с логинами
            while (reader.Read())
            {
                string name = reader["login"].ToString();
                DelBox.Items.Add(name);
            }
            connection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DelBox.Text))
            {
                MessageBox.Show("Пустое поле, выберите сотрудника!", "База данных пользователей!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try//удачное удаление пользователя
                {
                    MySqlConnection conn = new MySqlConnection(connStr);
                    conn.Open();
                    string qu = $"UPDATE workers set status = 'Уволен' WHERE login = '{DelBox.Text}'";
                    MySqlCommand comm = new MySqlCommand(qu, conn);
                    MySqlDataReader read = comm.ExecuteReader();
                    conn.Close();

                    MessageBox.Show("Сотрудник уволен!", "База данных пользователей!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DelBox.Items.Clear();
                    //обновление списка
                    MySqlConnection connection = new MySqlConnection(connStr);
                    connection.Open();
                    string query = "SELECT login FROM workers WHERE status = 'Работает'";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    DelBox.Items.Clear();
                    while (reader.Read())
                    {
                        string name = reader["login"].ToString();
                        DelBox.Items.Add(name);
                    }
                    connection.Close();
                    DelBox.Text = null;
                }
                catch (Exception ex)//неудачное удаление пользователя
                {
                    MessageBox.Show(ex.ToString(), "Ошибка подключения к БД!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            
        }
        private void FireUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
