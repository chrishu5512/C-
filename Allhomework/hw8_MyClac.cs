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
    public partial class hw8_MyClac : Form
    {
        public hw8_MyClac()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            double n1, n2;
            bool a = double.TryParse(txtN1.Text, out n1);
            bool b = double.TryParse(txtN2.Text, out n2);
            if (a == false || b == false)
            {
                MessageBox.Show("請輸入數值");
            }
            else
                txtAnswer.Text = Convert.ToString(n1 + n2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n1, n2;
            bool a = double.TryParse(txtN1.Text, out n1);
            bool b = double.TryParse(txtN2.Text, out n2);
            if (a == false || b == false)
            {
                MessageBox.Show("請輸入數值");
            }
            else
                txtAnswer.Text = Convert.ToString(n1 - n2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double n1, n2;
            bool a = double.TryParse(txtN1.Text, out n1);
            bool b = double.TryParse(txtN2.Text, out n2);
            if (a == false || b == false)
            {
                MessageBox.Show("請輸入數值");
            }
            else
                txtAnswer.Text = Convert.ToString(n1 * n2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double n1, n2;
            bool a = double.TryParse(txtN1.Text, out n1);
            bool b = double.TryParse(txtN2.Text, out n2);
            if (a == false || b == false)
            {
                MessageBox.Show("請輸入數值");
            }
            else
                txtAnswer.Text = Convert.ToString(n1 / n2);
        }
    }
}
