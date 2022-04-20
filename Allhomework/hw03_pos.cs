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
    public partial class hw03_pos : Form
    {
        int Beer;
        int Tequila;
        int Whisky;
        int Wine;

        public void totalprice()
        {
            int total = Beer * 120 + Tequila * 180 + Whisky * 330 + Wine * 320;
            labTotalPrice.Text = "NT$"+total.ToString();
        }
        private void cost()
        {
            labList.Text = "";
            if (Beer > 0)
                labList.Text += "啤酒Beer*" + Beer + ",共" + Beer * 120 + "元\n";
            if (Tequila > 0)
            {
                labList.Text += "龍舌蘭Tequila * " + Tequila + ",共" + Tequila * 180 + "元\n";
            }
            if (Whisky > 0)
            {
                labList.Text += "威士忌Whisky * " + Whisky + ",共" + Whisky * 330 + "元\n";
            }
            if (Wine > 0)
            {
                labList.Text += "紅酒Wine * " + Wine + ",共" + Wine * 320 + "元";
            }


        }

        public hw03_pos()
        {
            InitializeComponent();
        }

        private void btnBeer_Click(object sender, EventArgs e)
        {
            Beer += 1;
            totalprice();
            cost();
        }

        private void btnTequila_Click(object sender, EventArgs e)
        {
            Tequila += 1;
            totalprice();
            cost();
        }

        private void btnWhisky_Click(object sender, EventArgs e)
        {
            Whisky += 1;
            totalprice();
            cost();
        }

        private void btnWine_Click(object sender, EventArgs e)
        {
            Wine += 1;
            totalprice();
            cost();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            int total = Beer * 120 + Tequila * 180 + Whisky * 330 + Wine * 320;
            if (total > 0)
                MessageBox.Show("總金額NT$" + total, "確認付款", MessageBoxButtons.OKCancel);
            else
                MessageBox.Show("尚未點餐", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            int total = Beer * 120 + Tequila * 180 + Whisky * 330 + Wine * 320;
            if (total > 0)
                MessageBox.Show("總金額NT$" + total+"\n折扣後的金額"+total*0.9, "確認付款", MessageBoxButtons.OKCancel);
            else
                MessageBox.Show("尚未點餐", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Beer = 0;
            Tequila = 0;
            Whisky = 0;
            Wine = 0;
            labTotalPrice.Text = "NT$0";
            labList.Text = "尚未點餐";
        }
    }
}
