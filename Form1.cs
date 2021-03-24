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
using Microsoft.WindowsAPICodePack.Dialogs;

namespace CAN_GEN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
           
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form1 tb = new Form1();
            
            //string timestamp = DateTime.Now.ToString();
            Int32 unixTimestamp = (Int32 )(DateTime.Now.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            //DateTimeOffset labukas = new DateTimeOffset(1995, 5, 10, 23, 17, 10, TimeSpan.Zero);
            //string labukas_date = labukas.ToString("dd-MM-yyyy H:mm:ss");
            string pathX = "";
            location_selector();
            string path = pathX + @"\" + unixTimestamp +".txt";
            Form1 objektas = new Form1();
            int intervalas = Int32.Parse(lineCTR.Text);
            string byte1 =  tB1.Text;
            string byte2 =  tB2.Text;
            string byte3 =  tB3.Text;
            string byte4 =  tB4.Text;
            string byte5 =  tB5.Text;
            string byte6 =  tB6.Text;
            string byte7 =  tB7.Text;
            string byte8 =  tB8.Text;
            string canID = tbCANID.Text;


            file_creator ();
            void file_creator ()
            {
                int lineCTRint;
                int j = 0;

                try
                {
                    lineCTRint = Int32.Parse(tbLineCTR.Text);
                    using (StreamWriter sw = File.CreateText(path))
                    {

                        for (int min = 0; min <= 59 && j < lineCTRint; min++)
                        { //Minutes interval
                            for (int sec = 0; sec <= 59 && j < lineCTRint; sec++)  // Seconds interval
                            {
                                for (int ms = 0; ms <= 999 && j < lineCTRint; ms = ms + intervalas) //Milliseconds interval

                                {
                                    DateTime date_args = new DateTime(1995, 5, 10, 23, min, sec, ms);
                                    string time = date_args.ToString("dd-MM-yyyy H:mm:ss.fff");
                                    sw.WriteLine("" + time + "    29  " + canID + "   0   8   " + byte1 + " " + byte2 + " " + byte3 + " " + byte4 + " " + byte5 + " " + byte6 + " " + byte7 + " " + byte8 + "");
                                    j++;
                                }
                            }
                        }
                        MessageBox.Show("File created and located in " + path);


                    }
                }
                catch
                {
                    MessageBox.Show("Error occured with given parameters");
                    
                }
            };
            void location_selector ()
            {
                CommonOpenFileDialog dialog = new CommonOpenFileDialog();
                dialog.InitialDirectory = "C:\\Users";
                dialog.IsFolderPicker = true;
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                   pathX = dialog.FileName;
                }
            }

            // Create a file to write to.


          
        }

        private void lineCTR_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblByte1_Click(object sender, EventArgs e)
        {

        }
    }
}
