using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagerApplication
{
    public partial class EmployeeDetailForm : Form
    {
        private readonly EditModeEnum _editMode;
        public EmployeeDetailForm(EditModeEnum editMode)
        {
            InitializeComponent();
            _editMode = editMode;
        }

        private void EmployeeDetailForm_Load(object sender, EventArgs e)
        {
            switch (_editMode)
            {
                case EditModeEnum.View:
                    this.Text = "View Employee";
                    break;
                case EditModeEnum.AddNew:
                    this.Text = "Add New Employee";
                    break;
                case EditModeEnum.Edit:
                    this.Text = "Edit Employee";
                    break;
            }
        }
    }
}
