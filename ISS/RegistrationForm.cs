using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISS
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();

            textBoxLog.Text = "Введите логин";
            textBoxLog.ForeColor = Color.Gray;

            textBoxPass.Text = "Введите пароль";
            textBoxPass.ForeColor = Color.Gray;
            textBoxPass.PasswordChar = (char)0;


            textBoxName.Text = "Введите имя";
            textBoxName.ForeColor = Color.Gray;

        }

        private void textBoxLog_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLog_Enter(object sender, EventArgs e)
        {
            if (textBoxLog.Text == "Введите логин")
            {
                textBoxLog.Text = "";
                textBoxLog.ForeColor = Color.Black;
            }
        }

        private void textBoxLog_Leave(object sender, EventArgs e)
        {
            if (textBoxLog.Text == "")
            {
                textBoxLog.Text = "Введите логин";
                textBoxLog.ForeColor = Color.Gray;
            }

        }

        private void textBoxPass_Enter(object sender, EventArgs e)
        {
            if (textBoxPass.Text == "Введите пароль")
            {
                textBoxPass.Text = "";
                textBoxPass.ForeColor = Color.Black;
                textBoxPass.PasswordChar = '*';

            }
        }

        private void textBoxPass_Leave(object sender, EventArgs e)
        {
            if (textBoxPass.Text == "")
            {
                textBoxPass.Text = "Введите пароль";
                textBoxPass.ForeColor = Color.Gray;
                textBoxPass.PasswordChar = (char)0;
            }
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Введите имя")
            {
                textBoxName.Text = "";
                textBoxName.ForeColor = Color.Black;
            }
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                textBoxName.Text = "Введите имя";
                textBoxName.ForeColor = Color.Gray;
            }
        }

        private void reg_button_enter_Click(object sender, EventArgs e)
        {
            string logUser = textBoxLog.Text;
            string passUser = textBoxPass.Text;
            string nameUser = textBoxName.Text;

            if(logUser == "Введите логин" || passUser == "Введите пароль" || nameUser == "Введите имя")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            if (checkLoggin())
            {
                return;
            }

            DataBase DB_UP = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("INSERT INTO `users`( `login`, `password`, `name`) VALUES (@log , @pass, @name)", DB_UP.getConnection());
            command.Parameters.Add("@log", MySqlDbType.VarChar).Value = logUser;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passUser;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameUser;

            DB_UP.openConnection();


            if (command.ExecuteNonQuery() == 1)
            {
                Authorization form = new Authorization();
                form.Show();
                this.Hide();
            }
            


            DB_UP.closeConnection();


        }

        public Boolean checkLoggin()
        {
            DataBase DB_UP = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @Log", DB_UP.getConnection());
            command.Parameters.Add("@Log", MySqlDbType.VarChar).Value = textBoxLog.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Данный логин уже существует");
                return true;
            }
            else
            {
                return false;
            }


        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBackAuth_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization auth = new Authorization();
            auth.Show();
        }
    }
}
