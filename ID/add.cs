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
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if(erorcheck()) // check for errors
            {
                //binary writer
                BinaryWriter writer = new BinaryWriter(new FileStream(Form1.FILEPATH, FileMode.Append));

                //object to use functionality of encoding
                DeleteAndSaving obj = new DeleteAndSaving();

                //writing to file in encoded form
                writer.Write(obj.encode(textBox3.Text));
                writer.Write(obj.encode(textBox1.Text));
                writer.Write(obj.encode(textBox2.Text));

                //writer closed
                writer.Close();

                MessageBox.Show("Saved successfully", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Dispose();
            }
        }

        private bool erorcheck()
        {
            //checking if one of the text field is empty
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Enter The ID and password correctly!", "EROR!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void add_Load(object sender, EventArgs e)
        {

        }
    }
}
