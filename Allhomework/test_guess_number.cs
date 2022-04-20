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
    public partial class test_guess_number : Form
    {
        public static test_guess_number instance;

        int min = 1;    //猜完數字後的範圍最小值
        int max = 100;    //猜完數字後的範圍最大值
        int num;
        public test_guess_number()
        {
            InitializeComponent();
            instance = this;
        }


        private void btn_Enter_Click(object sender, EventArgs e)
        {
            int gNum = test_guess.instance.Guessnum;
            bool isNum = int.TryParse(txtBox_GuessNumber.Text, out num);
            if(isNum==true)
            {
                //答案            //猜的數字
                if (gNum == num)
                {
                    MessageBox.Show("U Got the Right Answer!", "Congratulations!");
                    //break;
                }
                else if (gNum > num)
                {
                    min = num;
                    test_guess.instance.lab_topic.Text = "Too small! Between " + min + " ~ " + max;

                }
                else if (gNum < num)
                {
                    max = num;
                    test_guess.instance.lab_topic.Text = "Too big! Between " + min + " ~ " + max;
                }
            }

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
