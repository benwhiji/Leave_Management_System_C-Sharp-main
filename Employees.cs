using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leave_Managemnt_System
{
    public partial class Employees : Form
    {
        Functions Con;
        public Employees()
        {
            InitializeComponent();
            Con = new Functions();
            ShowEmployees();
            CustomizeEmployeesList();
            this.BackColor = Color.White;
            SetControlTextColors(Color.Black);
        }

        private void CustomizeEmployeesList()
        {
            // Set DataGridView column headers style
            EmployeesList.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            EmployeesList.ColumnHeadersDefaultCellStyle.BackColor = Color.RosyBrown;
            EmployeesList.EnableHeadersVisualStyles = false;
            EmployeesList.ColumnHeadersHeight = 30;

            // Adjust column widths
            foreach (DataGridViewColumn col in EmployeesList.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // Set DataGridView row style
            EmployeesList.DefaultCellStyle.Font = new Font("Arial", 10);

            // Set alternating row color
            EmployeesList.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;

            // Disable row headers
            EmployeesList.RowHeadersVisible = false;

            // Set selection color
            EmployeesList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EmployeesList.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Allow user to resize columns
            EmployeesList.AllowUserToResizeColumns = true;

            // Exclude the first column from having the blue selection color
            for (int i = 1; i < EmployeesList.Columns.Count; i++)
            {
              EmployeesList.Columns[i].DefaultCellStyle.SelectionBackColor = Color.White;
            }
        }


        private void SetControlTextColors(Color color)
        {
            foreach (Control control in this.Controls)
            {
                control.ForeColor = color;
            }
        }

        private void ShowEmployees()
        {
            string Query = "select * from EmployeeTbl";
            EmployeesList.DataSource = Con.GetData(Query);

        }
      

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || EmpPhoneTb.Text == "" || PasswordTb.Text == "" || EmpGenCb.SelectedIndex == -1   )
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = EmpGenCb.Text;
                    string Phone = EmpPhoneTb.Text;
                    string Password = PasswordTb.Text;
                    string Address = AddressTb.Text;
                    string role = roleCb.Text;
                   
                    string Query = "Insert into EmployeeTbl Values('{0}' ,'{1}','{2}','{3}','{4}','{5}' )";
                    Query = string.Format(Query, Name,Gender,Phone,Password,Address,role);
                    Con.SetData(Query);
                    ShowEmployees();
                    MessageBox.Show("Employee Added!");
                    EmpNameTb.Text = "";
                    EmpPhoneTb.Text = "";
                    PasswordTb.Text = "";
                    AddressTb.Text = "";
                    roleCb.Text = "";


                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int Key = 0;
        private void EmployeesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
      if (e.RowIndex >= 0 && e.RowIndex < EmployeesList.Rows.Count)
            {
                if (e.ColumnIndex >= 0 && e.ColumnIndex < EmployeesList.Columns.Count)
                {
                    EmpNameTb.Text = EmployeesList.Rows[e.RowIndex].Cells[1].Value.ToString();
                    EmpGenCb.Text = EmployeesList.Rows[e.RowIndex].Cells[2].Value.ToString();
                    EmpPhoneTb.Text = EmployeesList.Rows[e.RowIndex].Cells[3].Value.ToString();
                    PasswordTb.Text = EmployeesList.Rows[e.RowIndex].Cells[4].Value.ToString();
                    AddressTb.Text = EmployeesList.Rows[e.RowIndex].Cells[5].Value.ToString();

                    if (EmployeesList.Rows[e.RowIndex].Cells[0].Value != null)
                    {
                        Key = Convert.ToInt32(EmployeesList.Rows[e.RowIndex].Cells[0].Value.ToString());
                    }
                    else
                    {
                        Key = 0;
                    }
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || EmpPhoneTb.Text == "" || PasswordTb.Text == "" || EmpGenCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = EmpGenCb.Text;
                    string Phone = EmpPhoneTb.Text;
                    string Password = PasswordTb.Text;
                    string Address = AddressTb.Text;

                    string Query = "Update  EmployeeTbl set EmpName = '{0}' ,EmpGen ='{1}',EmpPhone= '{2}',EmpPass = '{3}',EmpAddress = '{4}' where EmpId = {5} ";
                    Query = string.Format(Query, Name, Gender, Phone, Password, Address, Key);
                    Con.SetData(Query);
                    ShowEmployees();
                    MessageBox.Show("Employee Updated!");
                    EmpNameTb.Text = "";
                    EmpPhoneTb.Text = "";
                    PasswordTb.Text = "";
                    AddressTb.Text = "";


                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show("No employee selected for deletion.");
                    return;
                }

                // Delete related records in LeaveTbl first
                string deleteLeaveQuery = "DELETE FROM LeaveTbl WHERE Employee = {0}";
                deleteLeaveQuery = string.Format(deleteLeaveQuery, Key);
                Con.SetData(deleteLeaveQuery);

                // Now, delete the employee
                string deleteEmployeeQuery = "DELETE FROM EmployeeTbl WHERE EmpId = {0}";
                deleteEmployeeQuery = string.Format(deleteEmployeeQuery, Key);
                Con.SetData(deleteEmployeeQuery);

                ShowEmployees();
                MessageBox.Show("Employee Deleted!");
                EmpNameTb.Text = "";
                EmpPhoneTb.Text = "";
                PasswordTb.Text = "";
                AddressTb.Text = "";
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error deleting employee: " + Ex.Message);
            }
        }



        private void categorylbl_Click(object sender, EventArgs e)
        {
            Categories Obj = new Categories();
            Obj.Show();
            this.Hide();
        }

        private void Leavelbl_Click(object sender, EventArgs e)
        {
            Leaves Obj = new Leaves();
            Obj.Show();
            this.Hide();
        }

        private void Emplbl_Click(object sender, EventArgs e)
        {
            Employees Obj = new Employees();
            Obj.Show();
            this.Hide();
        }

        private void EmpLogoutlbl_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.ForeColor = Color.RosyBrown;
         
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            label2.ForeColor = Color.RosyBrown;
        }
    }
}

