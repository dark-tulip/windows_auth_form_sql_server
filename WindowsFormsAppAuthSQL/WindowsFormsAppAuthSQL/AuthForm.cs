using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsAppAuthSQL
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {

            InitializeComponent();
        }

        private string login = "";
        private string password = "";

        private void AuthForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.login = textBox1.Text.ToString();  // Попытаться взять логин из текстбокса Логина;
                this.password = textBox2.Text.ToString(); //  взять пароль из текстбокса Пароля;

                Console.WriteLine("TRY TO CONNECT, LOGIN IS " + login + ", PASSWORD IS " + password);


                SqlConnection conn = new SqlConnection();   // Создаем новое соединение чтобы соединиться сбазой

                conn.ConnectionString = "Data Source=DESKTOP-B32C0H6\\DEV;" +  // Локальный сервер
                                        "Initial Catalog=rgr_1;" +             // название БД 
                                        $"User id={login};" +                  // Логин с SQL-сервера
                                        $"Password={password};";               // Пароль

                conn.Open(); // Открываем текущее соединение с сервером
                this.Hide(); // Скрываем текущую форму авторизации

                Main_Form main_form = new Main_Form();  // Дальше Открываем форму главного меню 
                main_form.Show();

                Console.WriteLine("!!!===========CONNECTED SUCCESSFUL==========!!!");
            }
            catch (System.Data.SqlClient.SqlException)  // Если не удалось войти, выводим исключение
            {
                Console.WriteLine("!!!===========AUTHORIZATION FAILED==========!!!");

                // Выводим Алерт или предупреждающее окно
                MessageBox.Show("!!! AUTHORIZATION FAILED !!!\nНеверный логин или пароль", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
