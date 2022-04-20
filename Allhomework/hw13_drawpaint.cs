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
    public partial class hw13_drawpaint : Form
    {

        Graphics g;
        Pen pen;
        bool lsmousedown = false;//紀錄滑鼠按下
        List<Point> points = new List<Point>();//紀錄滑鼠軌跡
        public hw13_drawpaint()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            pen = new Pen(Color.Black, 1);
        }

        private void hw13_drawpaint_MouseDown(object sender, MouseEventArgs e)
        {
            lsmousedown = true;
            //points.Add(new Point (e.X, e.Y));
            points.Add(e.Location);
        }

        private void hw13_drawpaint_MouseUp(object sender, MouseEventArgs e)
        {
            points.Add(new Point(-1, -1));//插入一個斷點
            lsmousedown = false;
        }

        private void hw13_drawpaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (lsmousedown)
            {
                points.Add(e.Location);
                g.DrawLine(pen, points[points.Count - 2], points[points.Count - 1]);
            }
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog1.Color;
                pen.Color = color;
                picbox_color.BackColor = color;

            }
        }

        private void traBox_PenSize_Scroll(object sender, EventArgs e)
        {
            pen.Width = traBox_PenSize.Value;
            lab_ColorSize.Text = traBox_PenSize.Value.ToString();
        }
    }
}
