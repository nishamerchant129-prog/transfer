namespace EmployeeManagementSystem
{
    partial class practice
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
            button3 = new Button();
            pictureBox1 = new PictureBox();
            addprofilebtn = new Button();
            cmbcity = new ComboBox();
            cmbstate = new ComboBox();
            cmbcountry = new ComboBox();
            cmbdesignation = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtname = new TextBox();
            txtid = new TextBox();
            lblcityid = new Label();
            lblstateid = new Label();
            lblcountryid = new Label();
            lbljoiningdate = new Label();
            lbldesignationid = new Label();
            lbldob = new Label();
            lblname = new Label();
            lblid = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(319, 421);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 49;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1169, 477);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 244);
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // addprofilebtn
            // 
            addprofilebtn.Location = new Point(993, 477);
            addprofilebtn.Name = "addprofilebtn";
            addprofilebtn.Size = new Size(150, 46);
            addprofilebtn.TabIndex = 46;
            addprofilebtn.Text = "Add profile";
            addprofilebtn.UseVisualStyleBackColor = true;
            // 
            // cmbcity
            // 
            cmbcity.FormattingEnabled = true;
            cmbcity.Location = new Point(1169, 393);
            cmbcity.Name = "cmbcity";
            cmbcity.Size = new Size(242, 40);
            cmbcity.TabIndex = 45;
            // 
            // cmbstate
            // 
            cmbstate.FormattingEnabled = true;
            cmbstate.Location = new Point(1169, 283);
            cmbstate.Name = "cmbstate";
            cmbstate.Size = new Size(242, 40);
            cmbstate.TabIndex = 44;
            cmbstate.DropDownClosed += cmbstate_DropDownClosed;
            // 
            // cmbcountry
            // 
            cmbcountry.FormattingEnabled = true;
            cmbcountry.Location = new Point(1169, 185);
            cmbcountry.Name = "cmbcountry";
            cmbcountry.Size = new Size(242, 40);
            cmbcountry.TabIndex = 43;
            cmbcountry.DropDownClosed += cmbcountry_DropDownClosed;
            // 
            // cmbdesignation
            // 
            cmbdesignation.FormattingEnabled = true;
            cmbdesignation.Items.AddRange(new object[] { "Manager", "CEO", "Sales Executive", "Software Developer", "Accountant" });
            cmbdesignation.Location = new Point(746, 401);
            cmbdesignation.Name = "cmbdesignation";
            cmbdesignation.Size = new Size(242, 40);
            cmbdesignation.TabIndex = 42;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(1185, 87);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(258, 39);
            dateTimePicker2.TabIndex = 41;
            // 
            // button1
            // 
            button1.Location = new Point(37, 506);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 40;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(697, 299);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(258, 39);
            dateTimePicker1.TabIndex = 39;
            // 
            // txtname
            // 
            txtname.Location = new Point(715, 188);
            txtname.Name = "txtname";
            txtname.Size = new Size(200, 39);
            txtname.TabIndex = 38;
            // 
            // txtid
            // 
            txtid.Location = new Point(715, 97);
            txtid.Name = "txtid";
            txtid.Size = new Size(200, 39);
            txtid.TabIndex = 37;
            // 
            // lblcityid
            // 
            lblcityid.AutoSize = true;
            lblcityid.Location = new Point(1017, 401);
            lblcityid.Name = "lblcityid";
            lblcityid.Size = new Size(82, 32);
            lblcityid.TabIndex = 36;
            lblcityid.Text = "City Id";
            // 
            // lblstateid
            // 
            lblstateid.AutoSize = true;
            lblstateid.Location = new Point(1017, 291);
            lblstateid.Name = "lblstateid";
            lblstateid.Size = new Size(94, 32);
            lblstateid.TabIndex = 35;
            lblstateid.Text = "State Id";
            // 
            // lblcountryid
            // 
            lblcountryid.AutoSize = true;
            lblcountryid.Location = new Point(1017, 188);
            lblcountryid.Name = "lblcountryid";
            lblcountryid.Size = new Size(126, 32);
            lblcountryid.TabIndex = 34;
            lblcountryid.Text = "Country Id";
            // 
            // lbljoiningdate
            // 
            lbljoiningdate.AutoSize = true;
            lbljoiningdate.Location = new Point(1017, 87);
            lbljoiningdate.Name = "lbljoiningdate";
            lbljoiningdate.Size = new Size(148, 32);
            lbljoiningdate.TabIndex = 33;
            lbljoiningdate.Text = "Joining Date";
            // 
            // lbldesignationid
            // 
            lbldesignationid.AutoSize = true;
            lbldesignationid.Location = new Point(536, 409);
            lbldesignationid.Name = "lbldesignationid";
            lbldesignationid.Size = new Size(169, 32);
            lbldesignationid.TabIndex = 32;
            lbldesignationid.Text = "Designation Id";
            // 
            // lbldob
            // 
            lbldob.AutoSize = true;
            lbldob.Location = new Point(558, 306);
            lbldob.Name = "lbldob";
            lbldob.Size = new Size(63, 32);
            lbldob.TabIndex = 31;
            lbldob.Text = "DOB";
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Location = new Point(558, 188);
            lblname.Name = "lblname";
            lblname.Size = new Size(78, 32);
            lblname.TabIndex = 30;
            lblname.Text = "Name";
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(558, 87);
            lblid.Name = "lblid";
            lblid.Size = new Size(34, 32);
            lblid.TabIndex = 29;
            lblid.Text = "Id";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(480, 300);
            dataGridView1.TabIndex = 50;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // practice
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1491, 770);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(addprofilebtn);
            Controls.Add(cmbcity);
            Controls.Add(cmbstate);
            Controls.Add(cmbcountry);
            Controls.Add(cmbdesignation);
            Controls.Add(dateTimePicker2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtname);
            Controls.Add(txtid);
            Controls.Add(lblcityid);
            Controls.Add(lblstateid);
            Controls.Add(lblcountryid);
            Controls.Add(lbljoiningdate);
            Controls.Add(lbldesignationid);
            Controls.Add(lbldob);
            Controls.Add(lblname);
            Controls.Add(lblid);
            Name = "practice";
            Text = "practice";
            Load += practice_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private PictureBox pictureBox1;
        private Button addprofilebtn;
        private ComboBox cmbcity;
        private ComboBox cmbstate;
        private ComboBox cmbcountry;
        private ComboBox cmbdesignation;
        private DateTimePicker dateTimePicker2;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private TextBox txtname;
        private TextBox txtid;
        private Label lblcityid;
        private Label lblstateid;
        private Label lblcountryid;
        private Label lbljoiningdate;
        private Label lbldesignationid;
        private Label lbldob;
        private Label lblname;
        private Label lblid;
        private DataGridView dataGridView1;
    }
}