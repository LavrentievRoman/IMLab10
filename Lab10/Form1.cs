using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            double lamb1, lamb2;
            Random rand = new Random();

            lamb1 = (double)lamb1Num.Value;
            lamb2 = (double)lamb2Num.Value;

            double a1, a2;
            double sum1 = 0, sum2 = 0;
            int point1 = 0, point2 = 0;

            while (sum1 >= -lamb1 || sum2 >= -lamb2)
            {
                a1 = rand.NextDouble();
                a2 = rand.NextDouble();

                if (sum1 >= -lamb1)
                {
                    sum1 += Math.Log10(a1);
                    point1++;
                }

                if (sum2 >= -lamb2)
                {
                    sum2 += Math.Log10(a2);
                    point2++;
                }
            }

            resultLabel.Visible = true;

            if (point1 > point2) resultLabel.Text = $"Победила первая команда со счётом {point1} : {point2}";
            else if (point2 > point1) resultLabel.Text = $"Победила вторая команда со счётом {point1} : {point2}";
            else resultLabel.Text = $"Ничья со счётом {point2} : {point1}";
        }
    }
}
