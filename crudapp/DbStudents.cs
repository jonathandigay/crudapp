using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace crudapp
{
    public class DbStudents
    {
        private MySqlCommand cmd;
        private MySqlDataReader Reader;
        public DataGridView _dgv;
        //Get All Students
        public void getAllStudents( DataGridView dgv )
        {

            dgv.Rows.Clear();
            string query = "SELECT * FROM students";
            cmd = new MySqlCommand(query, connection.dbConnection());
            Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                string uid = Reader.GetString("uid");
                string name = Reader.GetString("name");
                string age = Reader.GetString("age");
                string gender = Reader.GetString("gender");
                string birthdate = Reader.GetString("birthdate");
                dgv.Rows.Add(uid,name,gender, birthdate, age);

            }
            Reader.Close();
        }

        //Create Student Record

        public void createstudentrecord( TextBox Iname,TextBox Ipassword , TextBox Iage,DateTimePicker Ibirthdate)
        {
            string nameInput = Iname.Text;
            string genderInput = Ipassword.Text;
            string ageInput = Iage.Text;
            string birthdateInput = Ibirthdate.Text;
            Guid uid = Guid.NewGuid();

            if (string.IsNullOrEmpty(birthdateInput) || string.IsNullOrEmpty(nameInput) || string.IsNullOrEmpty(genderInput) || string.IsNullOrEmpty(ageInput))
            {
                MessageBox.Show("Please complete the form");
            }
            else
            {
                string query = $"INSERT INTO students(uid,name,gender,age,birthdate) VALUES ('sci-{uid}','{nameInput}','{genderInput}','{birthdateInput}','{ageInput}')";
                cmd = new MySqlCommand(query, connection.mysqlconnection);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully add Record");
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
