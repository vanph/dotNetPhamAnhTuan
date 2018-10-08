using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            MessageBox.Show(@"You clicked button Export", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
