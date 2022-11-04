using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace crudapp
{
    public class connection
    {

        public string name = "Jonathan";
        public string server = "localhost";
        public string database = "schoolform";
        public string username = "root";
        public string password = "";
        public static MySqlConnection mysqlconnection;

        //Reader

        public static MySqlCommand cmd { get; set; }
        public static MySqlDataReader Reader { get; set; }

        private static string Uname;
        public  static string  Aname { 
            get { return Uname; }
            set {  Uname = value; }
        }


        public static MySqlConnection dbConnection() {
            string connString = "server=localhost;uid=root;pwd=;database=schoolform";
            try
            {
                mysqlconnection = new MySqlConnection(connString);
                mysqlconnection.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex){
                MessageBox.Show(ex.Message);
            }
            return mysqlconnection;
            }

       

        }
    } 
