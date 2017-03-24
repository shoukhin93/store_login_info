using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ID
{
    public partial class LOGIN : Form
    {
        //password
        string password = "A";
        public LOGIN()
        {
            InitializeComponent();

            //initializing passwordchar
            textBox1.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if(authanticated())
            {
                Form1 obj = new Form1();

                this.Hide();
                obj.ShowDialog();
                this.Dispose();
            }

            else
            {
                MessageBox.Show("Incorrect Password!", "Authantication Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool authanticated()
        {
            if(textBox1.Text.Equals(password))
            {
                return true;
            }

            return false;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //enter button is clicked and continued searching
                loginbtn_Click(sender, e);
            }
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
