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
    public partial class show : Form
    {
        public show()
        {
            InitializeComponent();
            
            //showing all data
            show_data();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void show_Load(object sender, EventArgs e)
        {
           
        }

        private void show_data()
        {
            //clearing listview
            listView1.Items.Clear();

            try
            {
                //binary reader
                BinaryReader reader = new BinaryReader(new FileStream(Form1.FILEPATH, FileMode.Open));

                try
                {
                    int i = 0;

                    while(true)
                    {
                        //object created to use the functionality of decoding
                        DeleteAndSaving obj = new DeleteAndSaving();

                        //reading from file and decoding
                        string site = obj.decode(reader.ReadString());
                        string id = obj.decode(reader.ReadString());
                        string password = obj.decode(reader.ReadString());

                        //adding to list view
                        listView1.Items.Add(site);
                        listView1.Items[i].SubItems.Add(id);
                        listView1.Items[i].SubItems.Add(password);

                        i++;
                    }
                }

                catch(EndOfStreamException)
                {
                    reader.Close();
                }

                finally
                {
                    reader.Close();
                }
            }

            catch(IOException)
            {
                MessageBox.Show("Could not open the file", "EROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            //clearing items
            listView1.Items.Clear();

            try
            {
                BinaryReader reader = new BinaryReader(new FileStream(Form1.FILEPATH, FileMode.Open));

                int i = 0;
                try
                {
                    while (true)
                    {
                        //object created to use the functionality of decoding
                        DeleteAndSaving obj = new DeleteAndSaving();

                        //reading from file and decoding
                        string site = obj.decode(reader.ReadString());
                        string id = obj.decode(reader.ReadString());
                        string password = obj.decode(reader.ReadString());

                        if (site.Equals(textBox1.Text, StringComparison.OrdinalIgnoreCase))
                        {
                            //if matched the searched item adding to list view
                            listView1.Items.Add(site);
                            listView1.Items[i].SubItems.Add(id);
                            listView1.Items[i].SubItems.Add(password);

                            i++;
                        }
                    }
                }
                catch (EndOfStreamException)
                {
                    reader.Close();

                    if (i == 0)
                    {
                        //if no data is found through search
                        MessageBox.Show("No Data found!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        //showing all data                       
                       // show_data();

                    }
                }
                finally
                {
                    reader.Close();
                }
            }
            catch (IOException)
            {
                //if file not found
                MessageBox.Show("No data to display!", "EROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //enter button is clicked and continued searching
                searchbtn_Click(sender, e);
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            string site = listView1.Items[0].Text;
            string id = listView1.Items[0].SubItems[1].Text;
            string password = listView1.Items[0].SubItems[2].Text;

            modify obj = new modify(site, id, password);
            obj.ShowDialog();

            //showing data after modification and did some tricks to prevent bugs
            show obj1 = new show();
            this.Hide();
            obj1.ShowDialog();
            this.Dispose();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
