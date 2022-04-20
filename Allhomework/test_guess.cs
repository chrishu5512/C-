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
    public partial class test_guess : Form
    {
        public static test_guess instance;
        public Label lab_topic;
        public int Guessnum;
        public test_guess()
        {
            InitializeComponent();
            instance = this;
        }

        private void btn_Guess_Click(object sender, EventArgs e)
        {
            test_guess_number ts = new test_guess_number();
            ts.Show();
            Random gsnum = new Random();
            Guessnum = gsnum.Next(1, 100);
        }

        private void btn_ShowAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Correct Answer is : " + test_guess.instance.Guessnum, "Answer", MessageBoxButtons.OK);
        }

        private void test_guess_Load(object sender, EventArgs e)
        {
            lab_topic = lab_Topic;
        }
    }
}
