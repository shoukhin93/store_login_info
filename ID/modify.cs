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
using System.Collections;

namespace ID
{
    public partial class modify : Form
    {
        //variables
        string s_site;
        string s_id;
        string s_password;

        
        public modify()
        {
            InitializeComponent();
        }

        public modify(string site,string id, string password)
        {
            InitializeComponent();

            s_site = site;
            s_id = id;
            s_password = password;
            appearance();
        }

        private void appearance()
        {
            textBox3.Text = s_site;
            textBox1.Text = s_id;
            textBox2.Text = s_password;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            DeleteAndSaving obj = new DeleteAndSaving();
            obj.delete_and_save(s_site, s_id, s_password);
            this.Dispose();
        }

      

       
        private bool erorcheck()
        {
            //checking if one of the text field is empty
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Enter The Site, ID and password correctly!", "EROR!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void modify_Load(object sender, EventArgs e)
        {

        }

        private void modifybtn_Click(object sender, EventArgs e)
        {
            if(erorcheck())
            {
                DeleteAndSaving obj = new DeleteAndSaving();

                obj.delete_and_save(s_site,s_id, s_password);
                obj.modified_save(textBox3.Text, textBox1.Text, textBox2.Text);

                this.Dispose();
            }
        }

 
    }
}
