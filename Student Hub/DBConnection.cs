using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Student_Hub
{
    internal class DBConnection
    {
        //to connect database
        private MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=db_acad");
        
        //to return function
        public MySqlConnection GetConnection()
        {
            return connection;
        }
        //the function to open the connection
        public void OpenCon()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        //function to close connection
        public void CloseCon()
        {
            if(connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
