using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Allhomework
{
    public partial class hw_14_picture_viewer : Form
    {
        public hw_14_picture_viewer()
        {
            InitializeComponent();
        }
        private void picClick(object sender, EventArgs e)
        {
            Form f = new Form();
            f.BackgroundImage = ((PictureBox)sender).Image;
            f.BackgroundImageLayout = ImageLayout.Zoom;
            f.Show();
        }
    }
}
