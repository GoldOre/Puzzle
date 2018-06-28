using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleRefactor
{
    public partial class PuzzleRefactor : Form
    {
        private PictureBox currentPicture;

        public PuzzleRefactor()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            //aici scrii tot ce trebuie sa se intimple dupa initialize
            //intro metoda aparte
        }

        private void global_pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            currentPicture = (PictureBox)sender;
            currentPicture.DoDragDrop(currentPicture.Image, DragDropEffects.Move);
        }

        private void global_pictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void global_pictureBox_DragDrop(object sender, DragEventArgs e)
        {
            ((PictureBox)sender).Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            if (currentPicture != null)
                currentPicture.Image = null;
        }
    }
}
