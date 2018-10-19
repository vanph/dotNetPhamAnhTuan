using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using EmployeeBusiness.Business;
using EmployeeBusiness.Models;

namespace EmployeeManagerApplication
{
    public partial class MainForm : Form
    {
        private EmployeeRepository _employeeRepository;
        private EmployeeExporter _employeeExporter;

        public MainForm()
        {
            InitializeComponent();
            grdEmployee.AutoGenerateColumns = false;
            _employeeRepository = new EmployeeRepository();
            _employeeExporter = new EmployeeExporter();
        }

        private void OnButtonLoadClick(object sender, EventArgs e)
        {
            var employees = _employeeRepository.GetEmployees();

            grdEmployee.DataSource = employees;
        }

        private void OnButtonAddClicked(object sender, EventArgs e)
        {
            var frm = new EmployeeDetailForm();
            frm.ShowDialog();
        }

        private void OnButtonEditClicked(object sender, EventArgs e)
        {
            MessageBox.Show(@"You clicked button edit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OnButtonDeleteClicked(object sender, EventArgs e)
        {
            MessageBox.Show(@"You clicked button Delete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void OnMainFormLoaded(object sender, EventArgs e)
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
                MessageBox.Show(@"Successfully exported", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                MessageBox.Show(@"Successfully exported", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
