using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HelloApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // string connectionString = "Server=localhost;Port=3306;Database=Taxi;Trusted_Connection=True;";
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
        }
    }
}