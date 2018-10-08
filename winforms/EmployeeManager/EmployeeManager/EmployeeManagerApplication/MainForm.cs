using System;
using System.IO;
using System.Windows.Forms;
using EmployeeManagerApplication.Business;

namespace EmployeeManagerApplication
{
    public partial class MainForm : Form
    {
        private EmployeeRepository _employeeRepository;
        public MainForm()
        {
            InitializeComponent();
            grdEmployee.AutoGenerateColumns = false;
            _employeeRepository = new EmployeeRepository();
        }

        private void OnButtonLoadClick(object sender, EventArgs e)
        {
            var employees = _employeeRepository.GetEmployees();

            grdEmployee.DataSource = employees;
        }

        private void OnButtonAddClicked(object sender, EventArgs e)
        {
            MessageBox.Show(@"You clicked button add");
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

        private void OnButtonExportClicked(object sender, EventArgs e)
        {
            
        }

        private void ExportEmployees()
        {
            var employees = _employeeRepository.GetEmployees();
            var exportEmployeeString = "";

            var order = 0;
            foreach (var emp in employees)
            {
                order = order + 1;

                exportEmployeeString += $"{emp.FirstName} {emp.LastName} {Environment.NewLine}";
            }

            File.WriteAllText(@"E:\dotNet\temp\employee.txt", exportEmployeeString);
            //File.WriteAllText("D:\\trainning\\temp\\employee.txt", exportEmployeeString);
        }
    }
}
