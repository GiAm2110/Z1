using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace L1_1
{
    static class DataBaceWorker
    {
        public static string connectString;
        static MySqlConnection myConnection;
        //static string SQLServer = "localhost";
        //static string dataBaseName = "Taxi";

        public static void OpenConnection()
        {
            string connectString = "Server=localhost;Database=Taxi;User=root;password=;";
            myConnection = new MySqlConnection(connectString);
            myConnection.Open();
        }
        /*
        public static void OpenConnection(string login, string password)
        {
            connectString = "Data Source =" + SQLServer + "; Initial Catalog = " + dataBaseName + "; User ID = " + login + "password = " + password;
            myConnection = new SqlConnection(connectString);
            myConnection.Open();
        }

        public static void OpenConnection(string SQLServer, string dataBaseName, string login, string password)
        {
            connectString = "Data Source =" + SQLServer + "; Initial Catalog = " + dataBaseName + "; User ID = " + login + "password = " + password;
            myConnection = new SqlConnection(connectString);
            myConnection.Open();
        }

        public static void OpenConnection(string userConnectString)
        {
            connectString = userConnectString;
            myConnection = new SqlConnection(connectString);
            myConnection.Open();
        }
        */

        public static List<string[]> ExecuteQuery(string query, int col)
        {
            MySqlCommand command = new MySqlCommand(query, myConnection);
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> response = new List<string[]>();
            while (reader.Read())
            {
                response.Add(new string[col]);
                for (int i = 0; i < col; i++)
                    response[response.Count - 1][i] = reader[i].ToString();
            }

            reader.Close();

            if (response.Count != 0)
                return response;
            else
                return null;
        }

        public static string ExecuteQuery(string query)
        {
            MySqlCommand command = new MySqlCommand(query, myConnection);
            MySqlDataReader reader = command.ExecuteReader();
            string response = null;
            while (reader.Read())
            {
                response = reader[0].ToString();
            }
            reader.Close();
            return response;
        }

        public static void ExecuteQueryWithoutResponse(string query)
        {
            MySqlCommand command = new MySqlCommand(query, myConnection);
            command.ExecuteNonQuery();
        }

        public static void CloseConnection()
        {
            myConnection.Close();
        }


    }
}
