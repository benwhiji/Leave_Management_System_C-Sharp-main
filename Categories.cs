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
    public partial class Categories : Form
    {
        Functions Con;
        public Categories()
        {
            InitializeComponent();
            Con = new Functions();
            ShowCategories();
            CustomizeCategoriesList();
            this.BackColor = Color.White;
            SetControlTextColors(Color.Black);
        }

        private void CustomizeCategoriesList()
        {
            // Set DataGridView column headers style
            CategoriesList.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            CategoriesList.ColumnHeadersDefaultCellStyle.BackColor = Color.RosyBrown;
            CategoriesList.EnableHeadersVisualStyles = false;
            CategoriesList.ColumnHeadersHeight = 30;

            // Adjust column widths
            foreach (DataGridViewColumn col in CategoriesList.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // Set DataGridView row style
            CategoriesList.DefaultCellStyle.Font = new Font("Arial", 10);

            // Set alternating row color
            CategoriesList.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;

            // Disable row headers
            CategoriesList.RowHeadersVisible = false;

            // Set selection color
            CategoriesList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CategoriesList.DefaultCellStyle.SelectionBackColor = Color.LightYellow;
            CategoriesList.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Allow user to resize columns
            CategoriesList.AllowUserToResizeColumns = true;
        }

        private void SetControlTextColors(Color color)
        {
            foreach (Control control in this.Controls)
            {
                control.ForeColor = color;
            }
        }

        private void ShowCategories()
        {
            string Query = "select * from CategoryTbl";
            CategoriesList.DataSource = Con.GetData(Query);
        }
     

    
        int Key = 0;
     
    

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CapNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    string Category = CapNameTb.Text;
                    string Query = "INSERT INTO CategoryTbl (CatName) VALUES ('{0}')";
                    Query = string.Format(Query, Category);
                    Con.SetData(Query);
                    ShowCategories();
                    CapNameTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CapNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    string Category = CapNameTb.Text;
                    string Query = "UPDATE CategoryTbl SET CatName = '{0}' WHERE CatId = {1}";
                    Query = string.Format(Query, Category, Key);
                    Con.SetData(Query);
                    ShowCategories();
                    CapNameTb.Text = "";
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
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    string Query = "DELETE FROM CategoryTbl WHERE CatId = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    ShowCategories();
                    CapNameTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }



        private void label5_Click(object sender, EventArgs e)
        {
            Employees Obj = new Employees();
            Obj.Show();
            this.Hide();
        }

    
   
     
        private void label6_Click_1(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label12_Click_1(object sender, EventArgs e)
        {
            Categories Obj = new Categories();
            Obj.Show();
            this.Hide();
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            Leaves Obj = new Leaves();
            Obj.Show();
            this.Hide();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Employees Obj = new Employees();
            Obj.Show();
            this.Hide();
        }

        private void CategoriesList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < CategoriesList.Rows.Count)
            {
                CapNameTb.Text = CategoriesList.Rows[e.RowIndex].Cells[1].Value.ToString();

                if (CategoriesList.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    Key = Convert.ToInt32(CategoriesList.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
                else
                {
                    Key = 0;
                }
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
