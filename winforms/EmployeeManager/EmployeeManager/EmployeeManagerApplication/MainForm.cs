﻿using System;
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
        public MainForm()
        {
            InitializeComponent();
            grdEmployee.AutoGenerateColumns = false;
        }

        private void OnButtonLoadClick(object sender, EventArgs e)
        {
            var employeeRepository = new EmployeeRepository();
            var employees =  employeeRepository.GetEmployees();

            grdEmployee.DataSource = employees;
        }

        private void OnButtonAddClicked(object sender, EventArgs e)
        {
            MessageBox.Show(@"You clicked button add");
        }
    }
}
