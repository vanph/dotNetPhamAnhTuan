using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EmployeeBusiness.Business;
using EmployeeBusiness.Models;

namespace EmployeeManagerApplication
{
    public partial class MainForm : Form
    {
        private readonly EmployeeRepository _employeeRepository;
        private readonly EmployeeExporter _employeeExporter;
        
        public MainForm()
        {
            InitializeComponent();
            grdEmployee.AutoGenerateColumns = false;
            _employeeRepository = new EmployeeRepository();
            _employeeExporter = new EmployeeExporter();
            grdEmployee.Visible = false;
            lblUserName.Text = string.Empty;
        }

        private void OnButtonLoadClick(object sender, EventArgs e)
        {
            var employees = _employeeRepository.GetEmployees();

            grdEmployee.DataSource = employees.Take(Constants.Settings.PageSize).ToList();
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
            SetControlsStatus();
        }

        private void LoadEmployees()
        {
            var employees = _employeeRepository.GetEmployees();

            grdEmployee.DataSource = employees;
        }

        private void OnExportMenuItemClicked(object sender, EventArgs e)
        {
            saveFileExportDialog.Title = "Save Employee File";
            saveFileExportDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileExportDialog.FilterIndex = 1;
            if (saveFileExportDialog.ShowDialog() == DialogResult.OK)
            {
                var employees = _employeeRepository.GetEmployees();
                _employeeExporter.Export(employees, saveFileExportDialog.FileName);
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
                var employees = _employeeRepository.GetEmployees();
                _employeeExporter.ExportCsv(employees, saveFileExportDialog.FileName, "|");

                MessageBox.Show(@"Successfully exported", Constants.Messages.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OnButtonLoginClicked(object sender, EventArgs e)
        {
            var userManager = new UserManager();
            var result = userManager.Login();
            if (result)
            {
                lblUserName.Text = UserContext.UserName;
                SetControlsStatus();
                LoadEmployees();
            }
           
        }

        private void SetControlsStatus()
        {
            grdEmployee.Visible = UserContext.IsLoggedIn;
            btnLogout.Visible = UserContext.IsLoggedIn;
            btnAdd.Visible = UserContext.IsLoggedIn;
            btnEdit.Visible = UserContext.IsLoggedIn;
            btnDelete.Visible = UserContext.IsLoggedIn;
            btnLogin.Visible = !UserContext.IsLoggedIn;
        }

       
        //private void ExportEmployeesBadVersion(List<Employee> employees)
        //{
        //    var employeeString = "";

        //    foreach (var emp in employees)
        //    {
        //        employeeString += $"{emp.FirstName} {emp.LastName} {Environment.NewLine}";
        //    }

        //    File.WriteAllText(@"D:\trainning\temp\employee.txt", employeeString);
        //}

    }
}
