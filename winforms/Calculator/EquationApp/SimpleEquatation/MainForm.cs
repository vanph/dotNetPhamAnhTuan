using System.Windows.Forms;

namespace SimpleEquotation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonSolve_Click(object sender, System.EventArgs e)
        {
            //ax+b= 0;
            //validate a:
            if (string.IsNullOrEmpty(textBoxA.Text))
            {
                MessageBox.Show(@"a cannot be null");

                return;
            }

            int a;
            if (!int.TryParse(textBoxA.Text, out a))
            {
                MessageBox.Show(@"a must be a number");
                return;
            }

            if (a == 0)
            {
                MessageBox.Show(@"a cannot be zero.");
                return;
            }

            if (string.IsNullOrEmpty(textBoxB.Text))
            {
                MessageBox.Show(@"b cannot be null");

                return;
            }
            
            int b;
            if (!int.TryParse(textBoxB.Text, out b))
            {
                MessageBox.Show(@"b must be a number");
                return;
            }
            
            var result = b* (-1.0m)/a;
            
            labelResult.Text = $"Result: {result}";
        }


    }
}
