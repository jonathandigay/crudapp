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
    public partial class studentform : Form
    {

        public MySqlCommand cmd;
        public MySqlDataReader Reader;

        private readonly dashboard _parent;
        public studentform(dashboard parent)
        {
            InitializeComponent();
            _parent = parent;
        }





        private void button1_Click_1(object sender, EventArgs e)
        {
            DbStudents dbstudents = new DbStudents();
            dbstudents.createstudentrecord(Iname, Igender, Iage,Ibirthdate);
            _parent.displayData();
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
