using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


namespace ISS
{
    class DataBase
    {

        //подключение к базе данных
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=db_ships");


        // соединение с бд
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }


        // закрывает соеденение с бд
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }


        // возвращает соединение
        public MySqlConnection getConnection()
        {
            return connection;
        }

        

        public bool AddNote(string num, string owner, string brand, string startDate, string endDate)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("INSERT INTO `ships`(`board number`, `owner`, `brand`, `start date`, `end date`) VALUES (@num , @owner, @brand, @startDate , @endDate)", getConnection());
            command.Parameters.Add("@num", MySqlDbType.VarChar).Value = num;
            command.Parameters.Add("@owner", MySqlDbType.VarChar).Value = owner;
            command.Parameters.Add("@brand", MySqlDbType.VarChar).Value = brand;
            command.Parameters.Add("@startDate", MySqlDbType.VarChar).Value = startDate;
            command.Parameters.Add("@endDate", MySqlDbType.VarChar).Value = endDate;

            openConnection();

            if(command.ExecuteNonQuery() == 1) {return true;} 
            else { return false; }

            closeConnection();
        }

        public bool DeleteNote(string noteDel)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("DELETE FROM `ships` WHERE `board number` = @del", getConnection());
            command.Parameters.Add("@del", MySqlDbType.VarChar).Value = noteDel;

            adapter.SelectCommand = command;

            openConnection();

            if (command.ExecuteNonQuery() == 1) { return true; }
            else { return false; }

            closeConnection();
        }


    }
}
