using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ISS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            labelWelc.Text = "Добро пожаловать, " + Transfer.Welcome;
            if(Transfer.Welcome == "admin")
            {
                pictureBoxEdit.Visible = true;
            }
            else
            {
                pictureBoxEdit.Visible = false;
            }

            textBoxSearch.Text = "Поиск судна";
            textBoxSearch.ForeColor = Color.Gray;

            mainTable.Visible = false;

            textBoxNum.Text = "Введите номер судна";
            textBoxNum.ForeColor = Color.Gray;

            textBoxOwner.Text = "Введите логин владельца";
            textBoxOwner.ForeColor = Color.Gray;

            textBoxBrand.Text = "Введите марку судна";
            textBoxBrand.ForeColor = Color.Gray;

            textBoxStartDate.Text = "Введите дату начала аренды";
            textBoxStartDate.ForeColor = Color.Gray;

            textBoxEndDate.Text = "Введите дату конца аренды";
            textBoxEndDate.ForeColor = Color.Gray;

            tableDelete.Visible = false;
            labelCheckDel.Visible = false;
            buttonDelete.Visible = false;
            pictureBoxDel.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

       
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureSearch_Click(object sender, EventArgs e)
        {
            

            string request = textBoxSearch.Text;



            DataBase DB = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();


            if (request == "Поиск судна" || request == "")
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `ships`", DB.getConnection());
                adapter.SelectCommand = command;
            }
            else
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `ships` WHERE `id`= @search OR `board number`= @search OR `owner`= @search OR `brand`= @search", DB.getConnection());
                command.Parameters.Add("@search", MySqlDbType.VarChar).Value = request;
                adapter.SelectCommand = command;
            }

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {

                mainTable.DataSource = table;
                mainTable.Visible = true;
            }
            else
            {
                MessageBox.Show("Ошибка! Такой записи не существует!");
                
            }

        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Поиск судна")
            {
                textBoxSearch.Text = "";
                textBoxSearch.ForeColor = Color.Black;
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
            {
                textBoxSearch.Text = "Поиск судна";
                textBoxSearch.ForeColor = Color.Gray;
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {

            string numBoard = textBoxDelete.Text;

            if (numBoard == "")
            {
                MessageBox.Show("Введите номер судна!");
                return;
            }
            string com = "SELECT * FROM `ships` WHERE `board number`= @del";


            DataBase DB = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand(com, DB.getConnection());
            command.Parameters.Add("@del", MySqlDbType.VarChar).Value = numBoard;

            adapter.SelectCommand = command;



            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                tableDelete.Visible = true;
                labelCheckDel.Visible = true;
                buttonDelete.Visible = true;
                pictureBoxDel.Visible = true;
                tableDelete.DataSource = table;

            } else
            {
                MessageBox.Show("Ошибка! Такой записи не существует!");
                textBoxDelete.Text = "";
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string num = textBoxNum.Text;
            string owner = textBoxOwner.Text;
            string brand = textBoxBrand.Text;
            string startDate = textBoxStartDate.Text;
            string endDate = textBoxEndDate.Text;


            if (num == "Введите номер судна" || owner == "Введите логин владельца" || brand == "Введите марку судна" || startDate == "Введите дату начала аренды" || endDate == "Введите дату конца аренды")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            if (checkNum(textBoxNum.Text))
            {
                return;
            }

            DataBase DB_UP = new DataBase();

            DataTable table = new DataTable();

            if (DB_UP.AddNote(num, owner, brand, startDate, endDate))
            {
                MessageBox.Show("Запись успешно добалена!");
                textBoxNum.Text = "Введите номер судна";
                textBoxNum.ForeColor = Color.Gray;

                textBoxOwner.Text = "Введите логин владельца";
                textBoxOwner.ForeColor = Color.Gray;

                textBoxBrand.Text = "Введите марку судна";
                textBoxBrand.ForeColor = Color.Gray;

                textBoxStartDate.Text = "Введите дату начала аренды";
                textBoxStartDate.ForeColor = Color.Gray;

                textBoxEndDate.Text = "Введите дату конца аренды";
                textBoxEndDate.ForeColor = Color.Gray;
            }
            else
            {
                MessageBox.Show("Ошибка! Запись не была добавлена!");
            }

        }

        public Boolean checkNum(string check)
        {
            DataBase DB_UP = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `ships` WHERE `board number` = @num", DB_UP.getConnection());
            command.Parameters.Add("@num", MySqlDbType.VarChar).Value = check;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("У данного судного уже есть запись!");
                return true;
            }
            else
            {
                return false;
            }


        }

        private void textBoxNum_Enter(object sender, EventArgs e)
        {
            if (textBoxNum.Text == "Введите номер судна")
            {
                textBoxNum.Text = "";
                textBoxNum.ForeColor = Color.Black;
            }
        }

        private void textBoxNum_Leave(object sender, EventArgs e)
        {
            if (textBoxNum.Text == "")
            {
                textBoxNum.Text = "Введите номер судна";
                textBoxNum.ForeColor = Color.Gray;
            }
        }

        private void textBoxOwner_Enter(object sender, EventArgs e)
        {
            if (textBoxOwner.Text == "Введите логин владельца")
            {
                textBoxOwner.Text = "";
                textBoxOwner.ForeColor = Color.Black;
            }
        }

        private void textBoxOwner_Leave(object sender, EventArgs e)
        {
            if (textBoxOwner.Text == "")
            {
                textBoxOwner.Text = "Введите логин владельца";
                textBoxOwner.ForeColor = Color.Gray;
            }
        }

        private void textBoxBrand_Enter(object sender, EventArgs e)
        {
            if (textBoxBrand.Text == "Введите марку судна")
            {
                textBoxBrand.Text = "";
                textBoxBrand.ForeColor = Color.Black;
            }
        }

        private void textBoxBrand_Leave(object sender, EventArgs e)
        {
            if (textBoxBrand.Text == "")
            {
                textBoxBrand.Text = "Введите марку судна";
                textBoxBrand.ForeColor = Color.Gray;
            }
        }

        private void textBoxStartDate_Enter(object sender, EventArgs e)
        {
            if (textBoxStartDate.Text == "Введите дату начала аренды")
            {
                textBoxStartDate.Text = "";
                textBoxStartDate.ForeColor = Color.Black;
            }
        }

        private void textBoxStartDate_Leave(object sender, EventArgs e)
        {
            if (textBoxStartDate.Text == "")
            {
                textBoxStartDate.Text = "Введите дату начала аренды";
                textBoxStartDate.ForeColor = Color.Gray;
            }
        }

        private void textBoxEndDate_Enter(object sender, EventArgs e)
        {
            if (textBoxEndDate.Text == "Введите дату конца аренды")
            {
                textBoxEndDate.Text = "";
                textBoxEndDate.ForeColor = Color.Black;
            }
        }

        private void textBoxEndDate_Leave(object sender, EventArgs e)
        {
            if (textBoxEndDate.Text == "")
            {
                textBoxEndDate.Text = "Введите дату конца аренды";
                textBoxEndDate.ForeColor = Color.Gray;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            string noteDel = textBoxDelete.Text;

            DataBase DB = new DataBase();

            if (DB.DeleteNote(noteDel) == true)
            {
                MessageBox.Show("Запись успешно удалена!");

                tableDelete.Visible = false;
                labelCheckDel.Visible = false;
                buttonDelete.Visible = false;
                pictureBoxDel.Visible = false;

                textBoxDelete.Text = "";
            }
            else
            {
                MessageBox.Show("Ошибка! Запись не была удалена!");
            }

        }

        private void pictureBoxEdit_Click(object sender, EventArgs e)
        {
            mainTable.Visible = false;
            tabControl.Visible = true;
            pictureBoxEdit.Visible = false;
            pictureBoxBackAdd.Visible = true;
            textBoxSearch.Visible = false;
            pictureSearch.Visible = false;

        }

        private void pictureBoxBackAdd_Click(object sender, EventArgs e)
        {
            pictureBoxEdit.Visible = true;
            pictureBoxBackAdd.Visible = false;
            tabControl.Visible = false;
            textBoxSearch.Text = "Поиск судна";
            textBoxSearch.ForeColor = Color.Gray;
            textBoxSearch.Visible = true;
            pictureSearch.Visible = true;

            tableDelete.Visible = false;
            labelCheckDel.Visible = false;
            buttonDelete.Visible = false;
            pictureBoxDel.Visible = false;
            textBoxBrandEdit.Visible = false;
            textBoxEndDateEdit.Visible = false;
            textBoxNumEdit.Visible = false;
            textBoxOwnerEdit.Visible = false;
            textBoxStartDateEdit.Visible = false;
            buttonSaveEdit.Visible = false;

            textBoxDelete.Text = "";
            textBoxEdit.Text = "";
        }

        private void pictureBoxEditNote_Click(object sender, EventArgs e)
        {

            string numBoard = textBoxEdit.Text;

            if (numBoard == "")
            {
                MessageBox.Show("Введите номер судна!");
                return;
            }
            string com = "SELECT * FROM `ships` WHERE `board number`= @edit";


            DataBase DB = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand(com, DB.getConnection());
            command.Parameters.Add("@edit", MySqlDbType.VarChar).Value = numBoard;

            adapter.SelectCommand = command;



            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                textBoxBrandEdit.Visible = true;
                textBoxEndDateEdit.Visible = true;
                textBoxNumEdit.Visible = true;
                textBoxOwnerEdit.Visible = true;
                textBoxStartDateEdit.Visible = true;
                buttonSaveEdit.Visible = true;

                textBoxNumEdit.Text = table.Rows[0].ItemArray[1].ToString();
                textBoxOwnerEdit.Text = table.Rows[0].ItemArray[2].ToString();
                textBoxBrandEdit.Text = table.Rows[0].ItemArray[3].ToString();
                textBoxStartDateEdit.Text = table.Rows[0].ItemArray[4].ToString();
                textBoxEndDateEdit.Text = table.Rows[0].ItemArray[5].ToString();
                
            }
            else
            {
                MessageBox.Show("Ошибка! Такой записи не существует!");
                textBoxDelete.Text = "";
            }



        }

        private void buttonSaveEdit_Click(object sender, EventArgs e)
        {
            string num = textBoxNumEdit.Text;
            string owner = textBoxOwnerEdit.Text;
            string brand = textBoxBrandEdit.Text;
            string startDate = textBoxStartDateEdit.Text;
            string endDate = textBoxEndDateEdit.Text;


            if (num == "" || owner == "" || brand == "" || startDate == "" || endDate == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            if (checkNum(textBoxNumEdit.Text))
            {
                return;
            }

            DataBase DB_UP = new DataBase();

            DataTable table = new DataTable();

            if (DB_UP.AddNote(num, owner, brand, startDate, endDate))
            {
                MessageBox.Show("Запись успешно добалена!");
                textBoxNumEdit.Visible = false;
                textBoxOwnerEdit.Visible = false;
                textBoxBrandEdit.Visible = false;
                textBoxStartDateEdit.Visible = false;
                textBoxEndDateEdit.Visible = false;
                buttonSaveEdit.Visible = false;
            }
            else
            {
                MessageBox.Show("Ошибка! Запись не была добавлена!");
            }

        }
    }
}
