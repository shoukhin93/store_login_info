using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ID
{
    public partial class Form1 : Form
    {

        //static variable indicating directory path
        public static string directory = "D:" + Path.DirectorySeparatorChar + "ID And Password";

        //static variable indicating file path
        public static string FILEPATH  = "D:" + Path.DirectorySeparatorChar + "ID And Password" + Path.DirectorySeparatorChar + "data.bin";

        //variable to prevent closing problem
        public bool m_existing = false;

        public Form1()
        {
            InitializeComponent();
            directory_and_file();
        }

        private void directory_and_file()
        {
            // check if directory exist or not
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            // check if file exist or not
            if (!File.Exists(FILEPATH))
            {
                File.Create(FILEPATH).Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            add obj = new add();

            obj.ShowDialog();
        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            show obj = new show();

            this.Hide();
            obj.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //condition checked for preventing closing problem
            if (!m_existing)
            {
                //checking if user is sure to exit or not
                DialogResult d = MessageBox.Show("Do you really want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (d == DialogResult.Yes)
                {
                    m_existing = true;
                    Application.Exit();
                }

                else
                    e.Cancel = true;
            }
        }
    }
}
