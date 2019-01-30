using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BindingExpressionData();
        }

        private void BindingExpressionData()
        {           
            var expressions = new List<string> { Constants.AddExpression, Constants.SubtractExpression, Constants.MultipleExpression, Constants.DevideExpression };

            //option 1
            //foreach (var item in expressions)
            //{
            //    cbxExpression.Items.Add(item);
            //}

            //option 2
            cbxExpression.DataSource = expressions;
            cbxExpression.SelectedIndex = 0;
        }
        
        private void OnCalculateButtonClicked(object sender, EventArgs e)
        {
            //number1
            if (string.IsNullOrEmpty(txtNumber1.Text))
            {
                MessageBox.Show(@"Number 1 cannot be null");

                return;
            }

            int number1;
            if (!int.TryParse(txtNumber1.Text, out number1))
            {
                MessageBox.Show(@"Number 1 must be a number");
                return;
            }
            //number2
            if (string.IsNullOrEmpty(txtNumber2.Text))
            {
                MessageBox.Show(@"Number 2 cannot be null");

                return;
            }

            int number2;
            if (!int.TryParse(txtNumber2.Text, out number2))
            {
                MessageBox.Show(@"Number 2 must be a number");
                return;
            }

            //expression
            if (cbxExpression.SelectedItem == null)
            {
                MessageBox.Show("Please choose an expression");
                return;
            }

            var selectedExpression = cbxExpression.SelectedItem.ToString();

            //calculate here

            //if(selectedExpression == Constants.AddExpression)
            //{
            //    txtResult.Text = (number1 + number2).ToString();
            //}

            switch (selectedExpression)
            {
                case Constants.AddExpression:
                    txtResult.Text = (number1 + number2).ToString();
                    break;
                case Constants.SubtractExpression:
                    txtResult.Text = (number1 - number2).ToString();
                    break;
                case Constants.MultipleExpression:
                    txtResult.Text = (number1 * number2).ToString();
                    break;
                case Constants.DevideExpression:
                    txtResult.Text = (number1 / number2).ToString();
                    break;
            }


        }

        private void cbxExpression_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
