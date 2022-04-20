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
    public partial class hw02_loan : Form
    {
        public hw02_loan()
        {
            InitializeComponent();
        }
        //每月應付本息金額之平均攤還率 ＝{[(1＋月利率)^月數]×月利率}÷{[(1＋月利率)^月數]－1}
        //(公式中：月利率 ＝ 年利率／12 ； 月數 = 貸款年期 ｘ 12; ^ 次方)
        int PMT = 0;
        int Total = 0;
        public void Count()
        {
            Double Money = Convert.ToDouble(txtMoney.Text);
            Double Year = Convert.ToDouble(txtYear.Text) * 12;
            Double InterestRate = Convert.ToDouble(txtInterestRate.Text);
            Double DownPayment = Convert.ToDouble(txtDownPayment.Text);
            Double MonthRate = (InterestRate / 100) / 12;
            Double MonthAverage = (Math.Pow(1 + MonthRate, Year) * MonthRate) / (Math.Pow(1 + MonthRate, Year) - 1);
            if (InterestRate == 0)
            {
                PMT = (int)(Convert.ToInt32(Money - DownPayment) / Year);
            }
            else
            {
                PMT = (int)(Convert.ToInt32(Money - DownPayment) * MonthAverage);
            }

            Total = (int)(PMT * Year);
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            Count();
            MessageBox.Show("月付額" + PMT + "元");
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            Count();
            MessageBox.Show("總金額:" + Total + "元");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            loanshow Report = new loanshow();
            Count();
            Report.labMoneyShow.Text = txtMoney.Text;
            Report.labYearShow.Text = txtYear.Text;
            Report.labInterestRateShow.Text = txtInterestRate.Text;
            Report.labMonthPayment.Text = PMT.ToString();
            Report.labTotalShow.Text = Total.ToString();
            Report.Show();
        }
    }
}
