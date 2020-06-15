using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_System
{
    public partial class LoginForm : Form
    {
        private string username;
        private string password;

        public LoginForm()
        {
            InitializeComponent();
           // Console.WriteLine("Yallllcoooooo");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          //  Console.WriteLine("Heeyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy ");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.username = UsernameBox.Text;
            this.password = PasswordBox.Text;
            Console.WriteLine(username + " " + password);
           
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
