using Microsoft.VisualBasic.Logging;
using System.Net.Sockets;
using MySql.Data.MySqlClient;
using System.Net;

namespace cafedemka
{
    public partial class autorization : System.Windows.Forms.Form
    {
        public autorization()
        {
            InitializeComponent();
        }
        string connStr = "server=localhost;user=root;database=cafe;password=root;";
        string login;
        string password;
        int block = 3;
        int auth = 1;
        bool schet = true;
        private void button1_Click(object sender, EventArgs e)
        {
            //�������� ������ �����
            login = loginBox.Text.Trim();
            password = passBox.Text.Trim();
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("����� � ������ ����������� ��� ����������!", "��������������!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // ������ ������ ��� ����������� � ��
            MySqlConnection conn = new MySqlConnection(connStr);
            // ������������� ���������� � ��
            conn.Open();
            // ������
            string sql = "SELECT * FROM workers";
            // ������ ��� ���������� SQL-�������
            MySqlCommand command = new MySqlCommand(sql, conn);
            // ������ ��� ������ ������ �������
            MySqlDataReader reader = command.ExecuteReader();
            // ������ ���������
            //// ������ ���������
            while (reader.Read())
            {
                //��������� ������
                try
                {
                    //���� ����� � ������ �����
                    if (reader["login"].ToString() == login && reader["password"].ToString() == password)
                    {
                        ID.value = reader["id"].ToString();
                        //���� ������� �������
                        if (reader["ban"].ToString() == "0")
                        {
                            MessageBox.Show("���� ������� ��� ������������ �� ���������� ���������� ������������ ������� �����!\n���������� � ��������������.", "���������!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else //���� �� �������
                        { // ���� ���� �������� ��� �������������
                            if (reader["position"].ToString() == "�������������")
                            {
                                adminwin adm = new adminwin();
                                MessageBox.Show("�� ������� ��������������, �������������!", "�����������!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                adm.Show();
                                this.Hide();
                                return;
                            }
                            else if (reader["position"].ToString() == "��������") //���� �������� ���� ������������, �� ������� ����� ������������� ���� �� swithc case
                            {
                                waiterwin user = new waiterwin();
                                passChange pass = new passChange();
                                MessageBox.Show("�� ������� �������������� ��� ��������!", "�����������!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (reader["auth"].ToString() == "0") //���� ��� ������ ��������������(������� ����� ����)
                                {
                                    pass.Show();
                                }
                                else//����� ������ ��������� �����
                                {
                                    user.Show();
                                }
                                this.Hide();
                                return;
                            }
                            else //���� �������� ���� ������������, �� ������� ����� ������������� ���� �� swithc case
                            {
                                povarwin user = new povarwin();
                                passChange pass = new passChange();
                                MessageBox.Show("�� ������� �������������� ��� �����!", "�����������!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (reader["auth"].ToString() == "0") //���� ��� ������ ��������������(������� ����� ����)
                                {
                                    pass.Show();
                                }
                                else//����� ������ ��������� �����
                                {
                                    user.Show();
                                }
                                this.Hide();
                                return;
                            }
                            

                        }

                    }
                    else if (reader["login"].ToString() == login && reader["password"].ToString() != password)
                    {
                        if (schet)//������� ������� ����������
                        {
                            block = Convert.ToInt32(reader["ban"]);
                            schet = false;
                        }
                        //�������� �� ����������
                        block--;
                        if (block == 2)
                        {
                            MessageBox.Show("����� ��� ������ ����� �������,�������� " + block + " ������� �� ����������!", "��������������!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (block == 1)
                        {
                            MessageBox.Show("����� ��� ������ ����� �������,�������� " + block + " ������� �� ����������!", "��������������!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            loginBox.Enabled = false;
                            passBox.Enabled = false;
                            MessageBox.Show("�� �������������. \n���������� � ��������������!", "���������!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        return;

                    }

                }
                //���� ���-�� �� ������ ���������, ������ ������
                catch { MessageBox.Show("�������� ������ � ��!", "��������!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            reader.Close(); // ��������� reader
            // ��������� ���������� � ��
            conn.Close();
        }
    }
}
