using System;
using System.Linq;
using System.Windows.Forms;
using DataAccess;


namespace EmployeeManagerApplication
{
    public partial class MainForm : Form
    {
       
        
        public MainForm()
        {
            InitializeComponent();
            grdEmployee.AutoGenerateColumns = false;
        
         }

        private void OnButtonLoadClick(object sender, EventArgs e)
        {
           LoadEmployees();
        }

        private void OnButtonAddClicked(object sender, EventArgs e)
        {
            var frm = new EmployeeDetailForm(EditModeEnum.AddNew);
            frm.ShowDialog();
        }

        private void OnButtonEditClicked(object sender, EventArgs e)
        {
            var frm = new EmployeeDetailForm(EditModeEnum.Edit);
            frm.ShowDialog();
        }

        private void OnButtonDeleteClicked(object sender, EventArgs e)
        {
            MessageBox.Show(@"You clicked button Delete", Constants.Messages.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void OnMainFormLoaded(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            var dbContext = new EmployeeEntities();

            var employees = dbContext.Employees.ToList();

            grdEmployee.DataSource = employees;
        }

        private void OnExportMenuItemClicked(object sender, EventArgs e)
        {
            saveFileExportDialog.Title = "Save Employee File";
            saveFileExportDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileExportDialog.FilterIndex = 1;
            if (saveFileExportDialog.ShowDialog() == DialogResult.OK)
            {
               //Todo: 
                MessageBox.Show(@"Successfully exported", Constants.Messages.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OnExportCsvMenuItemClicked(object sender, EventArgs e)
        {
            saveFileExportDialog.Title = "Save Employee CSV File";
            saveFileExportDialog.Filter = "Text files (*.csv)|*.csv";
            saveFileExportDialog.FilterIndex = 1;
            if (saveFileExportDialog.ShowDialog() == DialogResult.OK)
            {
                //Todo: 
                MessageBox.Show(@"Successfully exported", Constants.Messages.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
       

    }
}
