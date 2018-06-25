using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace Puzzle
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();

            if (File.Exists("D:\\Puzzle_Save.xml"))
            {
                DataSet ds = new DataSet();
                ds.ReadXml("D:\\Puzzle_Save.xml");
                foreach (DataRow item in ds.Tables["record"].Rows)
                {
                    label5.Text = item["hh"].ToString();
                    label6.Text = item["mm"].ToString();
                    label7.Text = item["ss"].ToString();

                    record_h = Convert.ToInt16(item["rhh"]);
                    record_m = Convert.ToInt16(item["rmm"]);
                    record_s = Convert.ToInt16(item["rss"]);
                }
            }     
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.DoDragDrop(pictureBox1.Image, DragDropEffects.Move);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.DoDragDrop(pictureBox2.Image, DragDropEffects.Move);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox3.DoDragDrop(pictureBox3.Image, DragDropEffects.Move);
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox4.DoDragDrop(pictureBox4.Image, DragDropEffects.Move);
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox5.DoDragDrop(pictureBox5.Image, DragDropEffects.Move);
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox6.DoDragDrop(pictureBox6.Image, DragDropEffects.Move);
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox7.DoDragDrop(pictureBox7.Image, DragDropEffects.Move);
        }

        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox8.DoDragDrop(pictureBox8.Image, DragDropEffects.Move);
        }

        public void pictureBox9_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox9.DoDragDrop(pictureBox9.Image, DragDropEffects.Move);
        }






        private void pictureBox10_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox10.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox11_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox11.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox12_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox12.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox13_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox13.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox14_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox14.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox15_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox15.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox16_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox16.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox17_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox17.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox18_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox18.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);

            //asta ii metoda sei lunga care spunem
            if ((Bitmap)e.Data.GetData(DataFormats.Bitmap) == pictureBox1.Image)
            {
                pictureBox1.Image = null;
            }
            else if ((Bitmap)e.Data.GetData(DataFormats.Bitmap) == pictureBox2.Image)
            {
                pictureBox2.Image = null;
            }
        }








        private void Game_Load(object sender, EventArgs e)
        {
            pictureBox10.AllowDrop = true;
            pictureBox11.AllowDrop = true;
            pictureBox12.AllowDrop = true;
            pictureBox13.AllowDrop = true;
            pictureBox14.AllowDrop = true;
            pictureBox15.AllowDrop = true;
            pictureBox16.AllowDrop = true;
            pictureBox17.AllowDrop = true;
            pictureBox18.AllowDrop = true;
        }

        private void pictureBox10_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBox11_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBox12_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBox13_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBox14_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBox15_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBox16_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBox17_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBox18_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        int seconds = 0;

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (seconds == 60)
            {
                seconds = 0;
            }
            seconds++;
            label1.Text = seconds.ToString();

            if (pictureBox10.Image == pictureBox4.Image && pictureBox11.Image == pictureBox6.Image && pictureBox12.Image == pictureBox8.Image && pictureBox13.Image == pictureBox9.Image && pictureBox14.Image == pictureBox3.Image && pictureBox15.Image == pictureBox2.Image && pictureBox16.Image == pictureBox7.Image && pictureBox17.Image == pictureBox1.Image && pictureBox18.Image == pictureBox5.Image)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                button2.Enabled = true;

                if (hours <= record_h)
                {
                    if (minutes <= record_m)
                    {
                        if (seconds < record_s)
                        {
                            DataSet ds = new DataSet();
                            DataTable dt = new DataTable();

                            dt.TableName = "record";
                            dt.Columns.Add("hh");
                            dt.Columns.Add("mm");
                            dt.Columns.Add("ss");
                            dt.Columns.Add("rhh");
                            dt.Columns.Add("rmm");
                            dt.Columns.Add("rss");
                            ds.Tables.Add(dt);

                            DataRow row = ds.Tables["record"].NewRow();
                            row["hh"] = label3.Text;
                            row["mm"] = label2.Text;
                            row["ss"] = label1.Text;
                            row["rhh"] = label3.Text;
                            row["rmm"] = label2.Text;
                            row["rss"] = label1.Text;
                            ds.Tables["record"].Rows.Add(row);

                            ds.WriteXml("D:\\Puzzle_Save.xml");

                            record_h = Convert.ToInt32(label3.Text);
                            record_m = Convert.ToInt32(label2.Text);
                            record_s = Convert.ToInt32(label1.Text);
                        }
                    }
                }
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
            button1.Enabled = false;
        }

        int minutes = 0;

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (minutes == 60)
            {
                minutes = 0;
            }
            minutes++;
            label2.Text = minutes.ToString();
        }

        int hours = 0;

        private void timer3_Tick(object sender, EventArgs e)
        {
            hours++;
            label3.Text = hours.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Preview = new Preview();
            Preview.Show();
        }

        int record_s = 60;
        int record_m = 60;
        int record_h = 25;

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are sure want to exit?", "Quit game", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
