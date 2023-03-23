using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Leave_Managemnt_System
{
    public partial class Login : Form
    {
        Functions Con;
        public Login()
        {
            InitializeComponent();
            Con = new Functions();
            PasswordTb.PasswordChar = '*';
        }

        public static int EmpId;
        public static string EmpName = "";
        public static string UserRole = "";
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UNameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Information!");

            } else 
            {
                if (UNameTb.Text == "Admin" && PasswordTb.Text == "Password")
                {
                    UserRole = "Admin";
                    Employees Obj = new Employees();
                    Obj.Show();
                    this.Hide();
                }
                else
                {
                    try
                    {
                        string Query = "SELECT * FROM EmployeeTbl WHERE EmpName = '{0}' AND EmpPass = '{1}'";
                        Query = string.Format(Query, UNameTb.Text, PasswordTb.Text);

                        DataTable dt = Con.GetData(Query);
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Incorrect Password!");
                            UNameTb.Text = "";
                            PasswordTb.Text = "";

                        }
                        else
                        {
                            EmpId = Convert.ToInt32(dt.Rows[0][0].ToString());
                            EmpName = dt.Rows[0][1].ToString();
                            UserRole = dt.Rows[0]["Role"].ToString();
                            ViewLeave Obj = new ViewLeave();
                            Obj.Show();
                            this.Hide();


                        

                            //roleCb.Visible = false;
                        }
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                  
                }
             }
        }


    

        private void Closelbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PasswordTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
