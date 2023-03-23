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
    public partial class ViewLeave : Form
    {
        Functions Con;

        public ViewLeave()
        {
            InitializeComponent();
            Con = new Functions();
            EmpIdlbl.Text = Login.EmpId.ToString();
            EmpNamelbl.Text = Login.EmpName;
            ShowLeaves();
            CustomizeLeaveList();
            this.BackColor = Color.White;
            SetControlTextColors(Color.Black);
        }

        private void CustomizeLeaveList()
        {
            // Set DataGridView column headers style
            LeaveList.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            LeaveList.ColumnHeadersDefaultCellStyle.BackColor = Color.RosyBrown;
            LeaveList.EnableHeadersVisualStyles = false;
            LeaveList.ColumnHeadersHeight = 30;

            // Adjust column widths
            foreach (DataGridViewColumn col in LeaveList.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // Set DataGridView row style
            LeaveList.DefaultCellStyle.Font = new Font("Arial", 10);

            // Set alternating row color
            LeaveList.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;

            // Disable row headers
            LeaveList.RowHeadersVisible = false;

            // Set selection color
            LeaveList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LeaveList.DefaultCellStyle.SelectionBackColor = Color.LightYellow;
            LeaveList.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Allow user to resize columns
            LeaveList.AllowUserToResizeColumns = true;
        }

        private void SetControlTextColors(Color color)
        {
            foreach (Control control in this.Controls)
            {
                control.ForeColor = color;
            }
        }
        private void ShowLeaves()
        {
            string Query = "select * from LeaveTbl where Employee = {0}";
            Query = string.Format(Query, Login.EmpId);
            LeaveList.DataSource = Con.GetData(Query);
            LeaveList.DataSource = Con.GetData(Query);
        }

        private void Logoutlbl_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

    

        private void Leavelbl_Click(object sender, EventArgs e)
        {
            Leaves Obj = new Leaves();
            Obj.Show();
            this.Hide();
        }

     
        private void label12_Click(object sender, EventArgs e)
         {
            
         }

        private void Emplbl_Click(object sender, EventArgs e)
        {
          
        }

        private void LeaveList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ViewLeave Obj = new ViewLeave();
            Obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
