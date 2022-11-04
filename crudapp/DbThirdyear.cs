using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudapp
{
    public class DbThirdyear
    {

        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }

        //retrieve all students


        public void getallthirdyear( DataGridView dgv)
        {
            string Query = "SELECT * FROM third_year";


        } 

    }
}
