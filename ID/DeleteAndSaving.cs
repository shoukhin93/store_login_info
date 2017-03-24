using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Windows.Forms;

namespace ID
{
    class DeleteAndSaving
    {
        //vaiables to store the data from file
        ArrayList arraylistsite = new ArrayList();
         ArrayList arraylistid = new ArrayList();
         ArrayList arraylistpassword = new ArrayList();

        public void delete_and_save(string s_site, string s_id, string s_password)
        {
            try
            {
                //binary reader
                BinaryReader reader = new BinaryReader(new FileStream(Form1.FILEPATH, FileMode.Open));

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

                        if (site == s_site && id == s_id && password == s_password)
                        {
                            //if the name matched ignore it and thats how delete the data
                            continue;
                        }
                        else
                        {
                            //storing the data
                            arraylistsite.Add(site);
                            arraylistid.Add(id);
                            arraylistpassword.Add(password);


                        }
                    }
                }
                catch (EndOfStreamException)
                {
                    reader.Close();
                }
                finally
                {
                    reader.Close();

                    //after modifying saving data
                    modify_and_save();
                }
            }
            catch (IOException exc)
            {
                MessageBox.Show(exc.Message, "EROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void modify_and_save()
        {
            //deleting previous file to save in a new file
            try
            {
                File.Delete(Form1.FILEPATH);
            }

            catch (FileNotFoundException exc)
            {
                MessageBox.Show(exc.Message, "EROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //saving to a new file
            try
            {
                //binary writer
                BinaryWriter writer = new BinaryWriter(new FileStream(Form1.FILEPATH, FileMode.Append));

                try
                {
                    for (int i = 0; i < arraylistid.Count; i++)
                    {
                        //object created to use the functionality of encoding
                        DeleteAndSaving obj = new DeleteAndSaving();

                        //writing data to file in encoded form
                        writer.Write(obj.encode((string)arraylistsite[i]));
                        writer.Write(obj.encode((string)arraylistid[i]));
                        writer.Write(obj.encode((string)arraylistpassword[i]));

                    }
                }
                catch (IOException exc)
                {
                    writer.Close();
                    MessageBox.Show(exc.Message, "EROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    writer.Close();
                    MessageBox.Show("Modified successfully!", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (IOException exc)
            {
                MessageBox.Show(exc.Message, "EROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void modified_save(string m_site, string m_id, string m_password)
        {

            try
            {
                //binary writer
                BinaryWriter writer = new BinaryWriter(new FileStream(Form1.FILEPATH, FileMode.Append));

                try
                {
                    //object to use functionality of encoding
                    DeleteAndSaving obj = new DeleteAndSaving();

                    //writing to file in encoded form
                    writer.Write(obj.encode(m_site));
                    writer.Write(obj.encode(m_id));
                    writer.Write(obj.encode(m_password));

                }

                catch (IOException exc)
                {
                    writer.Close();
                    MessageBox.Show(exc.Message, "EROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    writer.Close();
                }
            }
            catch (IOException exc)
            {
                MessageBox.Show(exc.Message, "EROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //function for encoding string
        public string encode(string EntryString)
        {
            string ReturnString = "";
            int i = 0;

            foreach(char ch in EntryString)
            {
                i++;

                if( i % 2 == 0)
                {
                    ReturnString += (char)(ch + 5);
                }
                else
                {
                    ReturnString += (char)(ch - 5);
                }

            }

            return ReturnString;

        }

        //function for decoding string
        public string decode(string EntryString)
        {
            string ReturnString = "";
            int i = 0;

            foreach (char ch in EntryString)
            {
                i++;

                if (i % 2 == 0)
                {
                    ReturnString += (char)(ch - 5);
                }
                else
                {
                    ReturnString += (char)(ch + 5);
                }

            }


            return ReturnString;
        }
    }
}
