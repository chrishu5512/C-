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
    public partial class hw07_method : Form
    {
        public hw07_method()
        {
            InitializeComponent();
        }
        int[] arr0711 = new int[]{ 1, 5, 6, 8, 7, 97,54,887,65,578};
        string[] arr0711_str = new string[] { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };
        private void btnodd_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtInput.Text);
                if (a % 2 == 0)
                    txtResult.Text = $"輸入的數{a}為偶數";
                if (a % 2 != 0)
                    txtResult.Text = $"輸入的數{a}為奇數";
            }
            catch
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void txtCompare_Click(object sender, EventArgs e)
        {
            int[] arr0711 = new int[] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int max = arr0711[0];
            int min = arr0711[0];
            for (int i = 0;i < arr0711.Length; i++)
            {
                if (max < arr0711[i])
                    max = arr0711[i];
            }
            for (int i = 0; i < arr0711.Length; i++)
            {
                if (min > arr0711[i])
                    min = arr0711[i];
            }
            txtResult.Text = "int陣列arr0711{ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 }\n" +
                $"最大值為{max}\n" + $"最小值為{min}\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = 0;
            txtResult.Text = "arr0711_str陣列:";
            for(int i = 0;i<arr0711_str.Length; i++)
            {
                txtResult.Text += "   "+arr0711_str[i];
                if (arr0711_str[i].IndexOf('C') != -1 || arr0711_str[i].IndexOf('c') != -1)
                    c++;
            }
            txtResult.Text += $"\n有C或c的名字共{c}個";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            for (int i = 0; i < arr0711.Length; i++)
            {
                if (arr0711[i] % 2 == 0)
                {
                    a++;
                }
                else
                    b++;
            }
            txtResult.Text = "int陣列arr0711{ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 }\n" + $"偶數共{a}\n" + $"奇數共{b}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int max = arr0711_str[0].Length;
            int j = 0;
            txtResult.Text = "陣列arr0711_str[mother張,emma,迪克蕭, J40, Candy, Cindy, Coconut, Motherfacker]";
            for (int i = 0; i < arr0711_str.Length; i++)
            {
                if (max < arr0711_str[i].Length)
                    max = arr0711_str[i].Length;
                    j = i;
            }
            txtResult.Text += $"\n最長的名字為{arr0711_str[j]}";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResult.Text = "int陣列arr0711{ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 }\n" + "加總為" + arr0711.Sum();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResult.Text = "int陣列arr0711{ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 }\n" + "最大值為" + arr0711.Max();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResult.Text = "int陣列arr0711{ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 }\n" + "最小值為" + arr0711.Min();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int n1 = 100;
            int n2=200;
            txtResult.Text = "換位前n1=" + n1 + "," + "n2=" + n2+"\n";
            swap(ref n1, ref n2);
            txtResult.Text += "換位後n1=" + n1 + "," + "n2=" + n2;



        }
        public void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int n1, n2, n3;
            bool a = int.TryParse(txtFrom.Text, out n1);
            bool b = int.TryParse(txtTo.Text, out n2);
            bool c = int.TryParse(txtStep.Text, out n3);
            if(a==false||b==false||c==false)
            {
                MessageBox.Show("請輸入數值");
            }
            else
            {
                int sum = 0;
                for(int i=n1;i<=n2;i+=n3)
                {
                    sum += i;
                }
                txtResult.Text = $"{n1}到{n2}相隔{n3 - 1}\n加總為{sum}";
            }


        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int n1, n2, n3;
            bool a = int.TryParse(txtFrom.Text, out n1);
            bool b = int.TryParse(txtTo.Text, out n2);
            bool c = int.TryParse(txtStep.Text, out n3);
            if (a == false || b == false || c == false)
            {
                MessageBox.Show("請輸入數值");
            }
            else
            {
                int sum = 0;
                int i = n1;
                while (i <= n2)
                {
                    sum += i;
                    i += n3;
                }
                txtResult.Text = $"{n1}到{n2}相隔{n3 - 1}\n加總為{sum}";
            }

        }

        private void BtnDO_Click(object sender, EventArgs e)
        {
            int n1, n2, n3;
            bool a = int.TryParse(txtFrom.Text, out n1);
            bool b = int.TryParse(txtTo.Text, out n2);
            bool c = int.TryParse(txtStep.Text, out n3);
            if (a == false || b == false || c == false)
            {
                MessageBox.Show("請輸入數值");
            }
            else
            {
                int sum = 0;
                int i = n1;
                do
                {
                    sum += i;
                    i += n3;
                } while (i <= n2);
                txtResult.Text = $"{n1}到{n2}相隔{n3 - 1}\n加總為{sum}";
            }
        }

        private void btnChrismas_Click(object sender, EventArgs e)
        {
            int n;
            bool a = int.TryParse(txtRow.Text, out n);
            if (a == false)
            {
                MessageBox.Show("請輸入數值");
            }
            else
            {
                txtResult.Text = "";
                for(int i=1;i<=n;i++)
                {
                    for(int j = 1; j <= n; j++)
                    {
                        txtResult.Text += "*";
                    }
                    txtResult.Text += "\n";
                }
            }
        }

        private void btn9x9_Click(object sender, EventArgs e)
        {
            txtResult.Text = "九九乘法表\n";
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    int sum = i * j;
                    if (sum < 10)
                        txtResult.Text += String.Format("{0,3}x{1,2}={2,3}|", j, i, sum);
                    else
                        txtResult.Text += String.Format("{0,3}x{1,2}={2,2}|", j, i, sum);


                }
                txtResult.Text += "\n";
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            int value = 100;
            txtResult.Text = Convert.ToString(value, 2);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int[] randomArray = new int[6];
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                randomArray[i] = rnd.Next(1, 50);
                for (int j = 0; j < i; j++)
                {
                    while (randomArray[j] == randomArray[i])
                    {
                        j = 0;
                        randomArray[i] = rnd.Next(1, 50);
                    }
                }
            }
            txtResult.Text = "樂透號碼\n";
            for (int i = 0; i < 6; i++)
            {
                txtResult.Text += "  " + randomArray[i];
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
