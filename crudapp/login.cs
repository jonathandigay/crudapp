namespace crudapp
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }


        public static string name = "Jonthan";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void logIn()
        {
 string usernameInput = Iusername.Text;
            string passwordInput = Ipassword.Text;


            if (usernameInput != "admin" && passwordInput != "admin")
                MessageBox.Show("Please Check your credential", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                dashboard form2 = new dashboard();
                this.Hide();
                form2.Show();
                form2.displayData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logIn();
        }


        public static string test()
        {
            return "Hellow World";
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            logIn();

        }

       


        private void Iusername_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData.ToString() == "Return")
            {
                logIn();
            }
        }

        private void Ipassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString() == "Return")
            {
                logIn();
            }
        }

        private void Iusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ipassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}