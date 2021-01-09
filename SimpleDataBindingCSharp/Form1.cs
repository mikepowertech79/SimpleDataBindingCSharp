using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleDataBindingCSharp
{
    public partial class frmGenericBinding : Form
    {
        #region  Modular Variables 

            // Provides generic collection data binding. Notice that we are specifying 
            // the type of object that is allowed to be added to the BindingList
            BindingList<Employee> moEmployeeBindingList;

        #endregion

        #region

            public frmGenericBinding()
            {
                InitializeComponent();

                // Instantiate the needed BindingList
                moEmployeeBindingList = new BindingList<Employee>();
            }

        #endregion

        #region Private Methods

        private void PopulateBindingList()
        {
            Employee oEmployee;
            int nCnt;

            for (nCnt = 0; nCnt < 50; nCnt++)
            {
                oEmployee = new Employee();
                
                //Create a employee first/last name using the counter
                oEmployee.FirstName = "Employee_" + nCnt.ToString();
                oEmployee.LastName = "Last_" + nCnt.ToString();
                oEmployee.MiddleInitial = "A";

                // Create a employee street address using the counter
                oEmployee.Address1 = "12" + nCnt.ToString() + " Happy Street";
                oEmployee.City = "Charlotte";
                oEmployee.State = "NC";
                oEmployee.ZipCode = "28211";

                // Create a manager id
                oEmployee.Manager = Guid.NewGuid();

                // Add new employee to the BindingList
                moEmployeeBindingList.Add(oEmployee);
            }

        }

        #endregion

        private void btnLoadEmployees_Click(object sender, EventArgs e)
        {
            PopulateBindingList();

            //Bind the BindingList of Employee objects to the DataGridView
            this.dgvEmployees.DataSource = moEmployeeBindingList;
        }

    }
}