using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        public void btngo_Click(object sender, EventArgs e)
        {
            Game frm = new Game();
            frm.ShowDialog();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult rsl = MessageBox.Show("You are sure to quit game?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rsl == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
