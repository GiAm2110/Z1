using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using L1_1;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DataBaceWorker.OpenConnection();


            Console.WriteLine("База данных Taxi");

            Console.WriteLine("Данные таблицы cars");
            List<string[]> response = DataBaceWorker.ExecuteQuery("SELECT model,reg_number,id FROM cars",3);
            foreach(string[] item in response)
                Console.WriteLine(item[0] + " " + item[1] + " " + item[2]);

            Console.WriteLine("Данные таблицы passangers");
            List<string[]> response2 = DataBaceWorker.ExecuteQuery("SELECT * FROM passangers", 3);
            foreach (string[] item in response2)
                Console.WriteLine(item[0] + " " + item[1] + " " + item[2]);



            DataBaceWorker.CloseConnection();

            Console.ReadLine();
            





            /*
            String connStr = "Server=localhost;Database=Taxi;User=root;password=;";

            MySqlConnection conn = new MySqlConnection(connStr);

            conn.Open();

            Console.WriteLine("База данных Taxi");

            string sql = "SELECT * FROM cars";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();
            Console.WriteLine("Данные таблицы cars");
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
            }
            reader.Close();

            string sql1 = "SELECT * FROM passangers ORDER BY id";

            MySqlCommand command1 = new MySqlCommand(sql1, conn);

            MySqlDataReader reader1 = command1.ExecuteReader();
            Console.WriteLine("Данные таблицы passangers");
            while (reader1.Read())
            {
                Console.WriteLine(reader1[0].ToString() + " " + reader1[1].ToString() + " " + reader1[2].ToString() + " " + reader1[3].ToString());
            }
            reader1.Close();

            conn.Close();
            */






        }
    }
}