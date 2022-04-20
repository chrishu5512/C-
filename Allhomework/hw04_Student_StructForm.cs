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
    public partial class hw04_Student_StructForm : Form
    {
        int[] ScoreArray = new int[3];
        string Myname;
        public hw04_Student_StructForm()
        {
            InitializeComponent();
        }

        private void btnSaveArray_Click(object sender, EventArgs e)
        {
            
            ScoreArray[0] = Convert.ToInt32(txtCH.Text);
            ScoreArray[1] = Convert.ToInt32(txtEN.Text);
            ScoreArray[2] = Convert.ToInt32(txtMath.Text);
            Myname = txtName.Text;


        }

        private void btnShowArray_Click(object sender, EventArgs e)
        {
            string ShowAll = "姓名 : " + Myname
              + "\n國文 : " + ScoreArray[0]
              + "\n英文 : " + ScoreArray[1]
              + "\n數學 : " + ScoreArray[2];
            labelShowAll.Text = ShowAll;

        }

        private void btnShowBest_Click(object sender, EventArgs e)
        {
            int Maxvalue = ScoreArray.Max();
            int Minvalue = ScoreArray.Min();
            int maxSubjectIndex = Array.IndexOf(ScoreArray, Maxvalue);
            int minSubjectIndex = Array.IndexOf(ScoreArray, Minvalue);
            string Maxsubject = foundSuject(maxSubjectIndex);
            string Minsubject = foundSuject(minSubjectIndex);

            string ShowBest = "最高成績為:" + Maxsubject + Maxvalue + "分\n"
                + "最低成績為:" + Minsubject + Minvalue + "分\n";
            labelShowBest.Text = ShowBest;


            string foundSuject(int i)
            {
                if (i == 0)
                {
                    return "國文";
                }
                else if (i == 1)
                {
                    return "英文";
                }
                else 
                {
                    return "數學";
                }
            }




        }

        
    }
}
