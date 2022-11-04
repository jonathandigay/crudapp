using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace crudapp
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        public  MySqlCommand cmd;
        public  MySqlDataReader Reader;

     public string test { get { return "Jonathan"; } }


        public  void  displayData()

        {
            connection.Aname = "Jonathan";
            MessageBox.Show(connection.Aname);
            DbStudents dbstudents = new DbStudents();
            dbstudents.getAllStudents(dataGridView1);
        }

      

        private void form2textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentform StudentForm = new studentform(this);
            using (StudentForm)
            {
                StudentForm.ShowDialog();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void third_year_btn_Click(object sender, EventArgs e)
        {
            ThirdYear thirdyearform = new ThirdYear();
            dashboard_wall_panel.Controls.Clear();
            thirdyearform.TopLevel = false;
            thirdyearform.AutoScroll = true; 
            thirdyearform.Dock = DockStyle.Fill;
            dashboard_wall_panel.Controls.Add(thirdyearform);
            thirdyearform.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid obj = Guid.NewGuid();
           
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string gender = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string birthdate = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                string age = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                studentform Studentform = new studentform(this);
                Studentform.ShowDialog();

                 


            }
            else if(dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                MessageBox.Show("Delete Button");
            }
        }

        private void fourth_year_btn_Click(object sender, EventArgs e)
        {
            FourthYear fourthyearform = new FourthYear();
            dashboard_wall_panel.Controls.Clear();
            fourthyearform.TopLevel = false;
            fourthyearform.AutoScroll = true;
            fourthyearform.Dock = DockStyle.Fill;
            dashboard_wall_panel.Controls.Add(fourthyearform);
            fourthyearform.Show();
        }
    }
}
