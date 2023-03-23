using System;

namespace Leave_Managemnt_System
{
    partial class Leaves
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leaves));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CatCb = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.EditBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmpCb = new System.Windows.Forms.ComboBox();
            this.StatusCb = new System.Windows.Forms.ComboBox();
            this.StartDateTb = new System.Windows.Forms.DateTimePicker();
            this.EndDateTb = new System.Windows.Forms.DateTimePicker();
            this.SearchCb = new System.Windows.Forms.ComboBox();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.LeavesList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeavesList)).BeginInit();
            this.SuspendLayout();
            // 
            // CatCb
            // 
            this.CatCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.CatCb.FormattingEnabled = true;
            this.CatCb.ItemHeight = 20;
            this.CatCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.CatCb.Location = new System.Drawing.Point(377, 115);
            this.CatCb.Name = "CatCb";
            this.CatCb.Size = new System.Drawing.Size(157, 28);
            this.CatCb.TabIndex = 43;
            this.CatCb.SelectedIndexChanged += new System.EventHandler(this.EmpGenCb_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.RosyBrown;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(45, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 22);
            this.label7.TabIndex = 26;
            this.label7.Text = "Leaves";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RosyBrown;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(48, 522);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 22);
            this.label6.TabIndex = 25;
            this.label6.Text = "Logout";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.ForeColor = System.Drawing.Color.RosyBrown;
            this.label4.Location = new System.Drawing.Point(460, 230);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(92, 22);
            this.label4.TabIndex = 42;
            this.label4.Text = "Leave List";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RosyBrown;
            this.panel4.Location = new System.Drawing.Point(160, 222);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(758, 5);
            this.panel4.TabIndex = 40;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RosyBrown;
            this.panel3.Location = new System.Drawing.Point(158, 233);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(762, 10);
            this.panel3.TabIndex = 21;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.SaveBtn.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SaveBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SaveBtn.Location = new System.Drawing.Point(777, 150);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(117, 30);
            this.SaveBtn.TabIndex = 39;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DeleteBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteBtn.Location = new System.Drawing.Point(777, 186);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(117, 30);
            this.DeleteBtn.TabIndex = 38;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.RosyBrown;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(42, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Leave MS";
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.LightCoral;
            this.EditBtn.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EditBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.EditBtn.Location = new System.Drawing.Point(777, 113);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(117, 30);
            this.EditBtn.TabIndex = 37;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.ForeColor = System.Drawing.Color.RosyBrown;
            this.label10.Location = new System.Drawing.Point(186, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "End Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.ForeColor = System.Drawing.Color.RosyBrown;
            this.label9.Location = new System.Drawing.Point(572, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Start Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.Color.RosyBrown;
            this.label8.Location = new System.Drawing.Point(374, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.RosyBrown;
            this.label3.Location = new System.Drawing.Point(176, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Employees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.ForeColor = System.Drawing.Color.RosyBrown;
            this.label2.Location = new System.Drawing.Point(456, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "Add Leaves";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(158, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(758, 38);
            this.panel2.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Leave Management System";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.ForeColor = System.Drawing.Color.RosyBrown;
            this.label11.Location = new System.Drawing.Point(374, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "Categories";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 567);
            this.panel1.TabIndex = 25;
            // 
            // EmpCb
            // 
            this.EmpCb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EmpCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.EmpCb.FormattingEnabled = true;
            this.EmpCb.ItemHeight = 20;
            this.EmpCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.EmpCb.Location = new System.Drawing.Point(179, 116);
            this.EmpCb.Name = "EmpCb";
            this.EmpCb.Size = new System.Drawing.Size(157, 28);
            this.EmpCb.TabIndex = 44;
            this.EmpCb.SelectedIndexChanged += new System.EventHandler(this.EmpCb_SelectedIndexChanged);
            // 
            // StatusCb
            // 
            this.StatusCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.StatusCb.FormattingEnabled = true;
            this.StatusCb.ItemHeight = 20;
            this.StatusCb.Items.AddRange(new object[] {
            "Pending",
            "Approved",
            "Rejected"});
            this.StatusCb.Location = new System.Drawing.Point(377, 181);
            this.StatusCb.Name = "StatusCb";
            this.StatusCb.Size = new System.Drawing.Size(157, 28);
            this.StatusCb.TabIndex = 45;
            this.StatusCb.SelectedIndexChanged += new System.EventHandler(this.StatusCb_SelectedIndexChanged);
            // 
            // StartDateTb
            // 
            this.StartDateTb.AllowDrop = true;
            this.StartDateTb.CalendarFont = new System.Drawing.Font("Microsoft Yi Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateTb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDateTb.Location = new System.Drawing.Point(559, 121);
            this.StartDateTb.MaximumSize = new System.Drawing.Size(300, 30);
            this.StartDateTb.MinimumSize = new System.Drawing.Size(50, 4);
            this.StartDateTb.Name = "StartDateTb";
            this.StartDateTb.Size = new System.Drawing.Size(161, 22);
            this.StartDateTb.TabIndex = 10;
            this.StartDateTb.ValueChanged += new System.EventHandler(this.StartDateTb_ValueChanged);
            // 
            // EndDateTb
            // 
            this.EndDateTb.AllowDrop = true;
            this.EndDateTb.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EndDateTb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDateTb.Location = new System.Drawing.Point(179, 182);
            this.EndDateTb.MaximumSize = new System.Drawing.Size(300, 30);
            this.EndDateTb.MinimumSize = new System.Drawing.Size(50, 4);
            this.EndDateTb.Name = "EndDateTb";
            this.EndDateTb.Size = new System.Drawing.Size(157, 23);
            this.EndDateTb.TabIndex = 46;
            this.EndDateTb.ValueChanged += new System.EventHandler(this.EndDateTb_ValueChanged);
            // 
            // SearchCb
            // 
            this.SearchCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.SearchCb.FormattingEnabled = true;
            this.SearchCb.ItemHeight = 20;
            this.SearchCb.Items.AddRange(new object[] {
            "Pending",
            "Approved",
            "Rejected"});
            this.SearchCb.Location = new System.Drawing.Point(366, 255);
            this.SearchCb.Name = "SearchCb";
            this.SearchCb.Size = new System.Drawing.Size(168, 28);
            this.SearchCb.TabIndex = 48;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.RefreshBtn.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RefreshBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RefreshBtn.Location = new System.Drawing.Point(575, 255);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(69, 28);
            this.RefreshBtn.TabIndex = 49;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // LeavesList
            // 
            this.LeavesList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.LeavesList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.LeavesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LeavesList.BackgroundColor = System.Drawing.Color.White;
            this.LeavesList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.LeavesList.ColumnHeadersHeight = 18;
            this.LeavesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.LeavesList.Location = new System.Drawing.Point(160, 289);
            this.LeavesList.Name = "LeavesList";
            this.LeavesList.RowHeadersWidth = 20;
            this.LeavesList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.LeavesList.Size = new System.Drawing.Size(756, 266);
            this.LeavesList.TabIndex = 25;
            this.LeavesList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LeavesList_CellContentClick_1);
            // 
            // Leaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(98F, 189F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(916, 567);
            this.Controls.Add(this.LeavesList);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.SearchCb);
            this.Controls.Add(this.EndDateTb);
            this.Controls.Add(this.StartDateTb);
            this.Controls.Add(this.StatusCb);
            this.Controls.Add(this.EmpCb);
            this.Controls.Add(this.CatCb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 125F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(49, 44, 49, 44);
            this.Name = "Leaves";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leaves";
            this.Load += new System.EventHandler(this.Leaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeavesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void EmpGenCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.ComboBox CatCb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox EmpCb;
        private System.Windows.Forms.ComboBox StatusCb;
        private System.Windows.Forms.DateTimePicker StartDateTb;
        private System.Windows.Forms.DateTimePicker EndDateTb;
        private System.Windows.Forms.ComboBox SearchCb;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.DataGridView LeavesList;
    }
}