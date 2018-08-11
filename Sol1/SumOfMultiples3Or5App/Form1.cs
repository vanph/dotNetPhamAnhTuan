using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumOfMultiples3Or5App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelResult.Text = "";
        }

        private void buttonShowResult_Click(object sender, EventArgs e)
        {
            labelResult.Text = "";
            var inputNumberString = textBoxNumber.Text;

            int number;
            bool success = int.TryParse(inputNumberString, out number);
            if (success)
            {
                int sum = SumOfMultiplesThreeOrFiveLessThanGivenNumber(number);

                labelResult.Text = $"Tong cac so chia het cho 3 hoac 5 nho hon {number} la {sum}";
            }
            else
            {
                MessageBox.Show("Invalid input number.");
            }

        }

        private int SumOfMultiplesThreeOrFiveLessThanGivenNumber(int number)
        {
            int sum = 0;

            for (int i = 0; i < number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum = sum + i;
                }
            }

            return sum;
        }
    }
}
