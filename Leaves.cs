using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leave_Managemnt_System
{
    public partial class Leaves : Form
    {
        Functions Con;
        string userRole;
        // Inside your Leaves constructor
        public Leaves()
        {
            InitializeComponent();
            Con = new Functions();
            ShowLeaves();
            GetEmployees();
            GetCategories();
            SetUserRole();

            // Apply the customization to LeavesList
            CustomizeDataGridView(LeavesList);

            // Set other specific properties for LeavesList
            LeavesList.BackgroundColor = Color.White;
           LeavesList.DefaultCellStyle.SelectionBackColor = Color.LightYellow;
            LeavesList.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

     

        private void CustomizeDataGridView(DataGridView dataGridView)
        {
            // Set DataGridView column headers style
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.RosyBrown;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersHeight = 30;

            // Adjust column widths
            foreach (DataGridViewColumn col in dataGridView.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // Set DataGridView row style
            dataGridView.DefaultCellStyle.Font = new Font("Arial", 10);

            // Set alternating row color
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;

            // Disable row headers
            dataGridView.RowHeadersVisible = false;

            // Set selection color
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.LightYellow;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Allow user to resize columns
            dataGridView.AllowUserToResizeColumns = true;
        }

     


        private void ShowLeaves()
        {
            string Query = "select * from LeaveTbl";
            LeavesList.DataSource = Con.GetData(Query);
        }
        private void FilterLeaves()
        {
            string Query = "select * from LeaveTbl where Status = '{0}'";
            Query = string.Format(Query, SearchCb.SelectedItem.ToString());
            LeavesList.DataSource = Con.GetData(Query);
        }


        private void GetEmployees()
        {
            string Query;

            if (userRole == "Employee")
            {
                // If the user's role is "Employee," filter by the current employee based on the user's identity.
                // Replace 'UserID' with the actual identifier you use for the current user.
                int currentEmployeeId = GetEmployeeIdForCurrentUser(); // Implement this method to get the current employee's ID.
                Query = $"SELECT * FROM EmployeeTbl WHERE EmpId = {currentEmployeeId}";
            }
            else
            {
                // If the user's role is not "Employee," show all employees.
                Query = "SELECT * FROM EmployeeTbl";
            }

            EmpCb.DisplayMember = "EmpName"; // Set the display member to the employee name.
            EmpCb.ValueMember = "EmpId";     // Set the value member to the employee ID.
            EmpCb.DataSource = Con.GetData(Query);
        }

        // Implement this method to get the current employee's ID based on the user's identity.
        private int GetEmployeeIdForCurrentUser()
        {
            // Implement the logic to retrieve the current employee's ID based on the user's identity.
            // You might fetch this information from your authentication system or user profile.
            // Return the current employee's ID.
            // Example:
            // int currentEmployeeId = GetCurrentEmployeeIdFromAuthSystem();
            // return currentEmployeeId;
            return 0; // Replace with the actual ID.
        }

        private void GetCategories()
        {
            string Query = "select *  from CategoryTbl";
            CatCb.DisplayMember = Con.GetData(Query).Columns["CatName"].ToString();
            CatCb.ValueMember = Con.GetData(Query).Columns["CatId"].ToString();
            CatCb.DataSource = Con.GetData(Query);
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatCb.SelectedIndex == -1 || EmpCb.SelectedIndex == -1 || StatusCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    int Emp = Convert.ToInt32(EmpCb.SelectedValue.ToString());
                    int Category = Convert.ToInt32(CatCb.SelectedValue.ToString());
                    string StartDate = StartDateTb.Value.Date.ToString();
                    string EndDate = EndDateTb.Value.Date.ToString();
                    string DateApplied = DateTime.Today.Date.ToString();

                    string Status = "Applied";
                    string Query = "Insert into LeaveTbl Values({0} ,{1},'{2}','{3}','{4}','{5}')";
                    Query = string.Format(Query, Emp, Category, StartDate, EndDate, DateApplied, Status);
                    Con.SetData(Query);
                    ShowLeaves();
                    MessageBox.Show("Leave Added!");
                    /* EmpNameTb.Text = "";
                     EmpPhoneTb.Text = "";
                     PasswordTb.Text = "";
                     AddressTb.Text = "";*/


                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

      
        int Key = 0;
        private object roleCb;

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatCb.SelectedIndex == -1 || EmpCb.SelectedIndex == -1 || StatusCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    int Emp = Convert.ToInt32(EmpCb.SelectedValue);
                    int Category = Convert.ToInt32(CatCb.SelectedValue);
                    string StartDate = StartDateTb.Value.ToString("yyyy-MM-dd");
                    string EndDate = EndDateTb.Value.ToString("yyyy-MM-dd");
                    string DateApplied = DateTime.Today.ToString("yyyy-MM-dd");
                    string Status = StatusCb.SelectedItem.ToString();

                    // Assuming Key is a string representing the LId
                    string Query = "Delete from LeaveTbl WHERE LId = {0}";
                    Query = string.Format(Query, Key);
                    using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\Documents\\LeaveDb.mdf;Integrated Security=True;Connect Timeout=30"))
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(Query, connection);
                        cmd.Parameters.AddWithValue("@Emp", Emp);
                        cmd.Parameters.AddWithValue("@Category", Category);
                        cmd.Parameters.AddWithValue("@StartDate", StartDate);
                        cmd.Parameters.AddWithValue("@EndDate", EndDate);
                        cmd.Parameters.AddWithValue("@Status", Status);
                        cmd.Parameters.AddWithValue("@LId", Key); // Assuming Key is the LId you want to update
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Leave Deleted!");
                            ShowLeaves();
                        }
                        else
                        {
                            MessageBox.Show("Leave not updated. Check your input data and try again.");
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void StatusCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if the userRole is "Employee" and the selected item is not "Applied"
            if (userRole == "Employee" && StatusCb.SelectedItem.ToString() != "Applied")
            {
                // Set the ComboBox to "Applied" if the selected status is not "Applied"
                StatusCb.SelectedItem = "Applied";
            }
        }


        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FilterLeaves();
        }

        private void Emplbl_Click(object sender, EventArgs e)
        {
            Employees Obj = new Employees();
            Obj.Show();
            this.Hide();
        }

     

        private void catlbl_Click(object sender, EventArgs e)
        {
            Categories Obj = new Categories();
            Obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

      

        private void label7_Click(object sender, EventArgs e)
        {
            Leaves Obj = new Leaves();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Employees Obj = new Employees();
            Obj.Show();
            this.Hide();
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the logged-in user has the "Admin" role
                if (userRole != "Admin")
                {
                    MessageBox.Show("You do not have permission to edit leave records.");
                    return;
                }

                if (CatCb.SelectedIndex == -1 || EmpCb.SelectedIndex == -1 || StatusCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    int Emp = Convert.ToInt32(EmpCb.SelectedValue);
                    int Category = Convert.ToInt32(CatCb.SelectedValue);
                    string StartDate = StartDateTb.Value.ToString("yyyy-MM-dd");
                    string EndDate = EndDateTb.Value.ToString("yyyy-MM-dd");
                    string DateApplied = DateTime.Today.ToString("yyyy-MM-dd");
                    string Status = StatusCb.SelectedItem.ToString();

                    // Assuming Key is a string representing the LId
                    string Query = "UPDATE LeaveTbl SET Employee = @Emp, Category = @Category, StartDate = @StartDate, EndDate = @EndDate, Status = @Status WHERE LId = @LId";

                    using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\Documents\\LeaveDb.mdf;Integrated Security=True;Connect Timeout=30"))
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(Query, connection);
                        cmd.Parameters.AddWithValue("@Emp", Emp);
                        cmd.Parameters.AddWithValue("@Category", Category);
                        cmd.Parameters.AddWithValue("@StartDate", StartDate);
                        cmd.Parameters.AddWithValue("@EndDate", EndDate);
                        cmd.Parameters.AddWithValue("@Status", Status);
                        cmd.Parameters.AddWithValue("@LId", Key); // Assuming Key is the LId you want to update
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Leave Updated!");
                            ShowLeaves();
                        }
                        else
                        {
                            MessageBox.Show("Leave not updated. Check your input data and try again.");
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void SetUserRole()
        {
            // Here you can set the userRole based on your logic.
            // For demonstration purposes, I'm assuming it's "Admin" by default.
            userRole = "Admin";
            EditBtn.Enabled = (userRole == "Admin");

            // Assuming that Login.UserRole stores the user's role from the login
            userRole = Login.UserRole;

            // If the user role is "Employee," disable the StatusCb combo box.
            if (userRole == "Employee")
            {
               // StatusCb.Enabled = false;
                StatusCb.SelectedItem = "Applied";
                StatusCb.Items.Clear();
                StatusCb.Items.Add("Applied");

            }
            else
            {
                StatusCb.Enabled = true;
            }
        }

        private void LeavesList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < LeavesList.Rows.Count)
            {
                if (e.ColumnIndex >= 0 && e.ColumnIndex < LeavesList.Columns.Count)
                {
                    EmpCb.SelectedValue = LeavesList.Rows[e.RowIndex].Cells[1].Value;
                    CatCb.SelectedValue = LeavesList.Rows[e.RowIndex].Cells[2].Value;

                    string startDateStr = LeavesList.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string endDateStr = LeavesList.Rows[e.RowIndex].Cells[4].Value.ToString();

                    DateTime startDate;
                    if (DateTime.TryParseExact(startDateStr, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out startDate))
                    {
                        StartDateTb.Value = startDate;
                    }
                    else
                    {
                       StartDateTb.Value = DateTime.Now; 
                    }

                    DateTime endDate;
                    if (DateTime.TryParseExact(endDateStr, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out endDate))
                    {
                        EndDateTb.Value = endDate;
                    }
                    else
                    {
                       EndDateTb.Value = DateTime.Now; 
                    }

                    StatusCb.SelectedItem = LeavesList.Rows[e.RowIndex].Cells[6].Value.ToString();

                    Key = Convert.ToInt32(LeavesList.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
            else
            {
               
                EmpCb.SelectedIndex = -1;
                CatCb.SelectedIndex = -1;
                StartDateTb.Value = DateTime.Now;
                EndDateTb.Value = DateTime.Now;
                StatusCb.SelectedIndex = -1;

                Key = 0;
            }
        }

        private void EmpCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Leaves_Load(object sender, EventArgs e)
        {

        }
        private void StartDateTb_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedStartDate = StartDateTb.Value;
            DateTime selectedEndDate = EndDateTb.Value;
            DateTime currentDate = DateTime.Now;

       
            if (selectedStartDate < currentDate)
            {
                MessageBox.Show("Start date cannot be in the past");
               
                return; 
            }

            if (selectedStartDate > selectedEndDate)
            {
                MessageBox.Show("Start date cannot be greater than end date");
            
            }
        }

        private void EndDateTb_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedStartDate = StartDateTb.Value;
            DateTime selectedEndDate = EndDateTb.Value;
            DateTime currentDate = DateTime.Now;

      
            if (selectedEndDate < currentDate)
            {
                MessageBox.Show("End date cannot be in the past");

                return; 
            }


            if (selectedStartDate > selectedEndDate)
            {
                MessageBox.Show("Start date cannot be greater than end date");
                
            }
        }


    }
}
