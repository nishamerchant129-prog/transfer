namespace EmployeeManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblid = new Label();
            lblname = new Label();
            lbldob = new Label();
            lbldesignationid = new Label();
            lbljoiningdate = new Label();
            lblcountryid = new Label();
            lblstateid = new Label();
            lblcityid = new Label();
            txtid = new TextBox();
            txtname = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            dateTimePicker2 = new DateTimePicker();
            cmbdesignation = new ComboBox();
            cmbcountry = new ComboBox();
            cmbstate = new ComboBox();
            cmbcity = new ComboBox();
            addprofilebtn = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            Delete = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(684, 62);
            lblid.Name = "lblid";
            lblid.Size = new Size(34, 32);
            lblid.TabIndex = 0;
            lblid.Text = "Id";
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Location = new Point(684, 163);
            lblname.Name = "lblname";
            lblname.Size = new Size(78, 32);
            lblname.TabIndex = 1;
            lblname.Text = "Name";
            // 
            // lbldob
            // 
            lbldob.AutoSize = true;
            lbldob.Location = new Point(684, 281);
            lbldob.Name = "lbldob";
            lbldob.Size = new Size(63, 32);
            lbldob.TabIndex = 2;
            lbldob.Text = "DOB";
            // 
            // lbldesignationid
            // 
            lbldesignationid.AutoSize = true;
            lbldesignationid.Location = new Point(662, 384);
            lbldesignationid.Name = "lbldesignationid";
            lbldesignationid.Size = new Size(169, 32);
            lbldesignationid.TabIndex = 3;
            lbldesignationid.Text = "Designation Id";
            // 
            // lbljoiningdate
            // 
            lbljoiningdate.AutoSize = true;
            lbljoiningdate.Location = new Point(1143, 62);
            lbljoiningdate.Name = "lbljoiningdate";
            lbljoiningdate.Size = new Size(148, 32);
            lbljoiningdate.TabIndex = 4;
            lbljoiningdate.Text = "Joining Date";
            // 
            // lblcountryid
            // 
            lblcountryid.AutoSize = true;
            lblcountryid.Location = new Point(1143, 163);
            lblcountryid.Name = "lblcountryid";
            lblcountryid.Size = new Size(126, 32);
            lblcountryid.TabIndex = 5;
            lblcountryid.Text = "Country Id";
            // 
            // lblstateid
            // 
            lblstateid.AutoSize = true;
            lblstateid.Location = new Point(1143, 266);
            lblstateid.Name = "lblstateid";
            lblstateid.Size = new Size(94, 32);
            lblstateid.TabIndex = 6;
            lblstateid.Text = "State Id";
            // 
            // lblcityid
            // 
            lblcityid.AutoSize = true;
            lblcityid.Location = new Point(1143, 376);
            lblcityid.Name = "lblcityid";
            lblcityid.Size = new Size(82, 32);
            lblcityid.TabIndex = 7;
            lblcityid.Text = "City Id";
            // 
            // txtid
            // 
            txtid.Location = new Point(841, 72);
            txtid.Name = "txtid";
            txtid.Size = new Size(200, 39);
            txtid.TabIndex = 9;
            // 
            // txtname
            // 
            txtname.Location = new Point(841, 163);
            txtname.Name = "txtname";
            txtname.Size = new Size(200, 39);
            txtname.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(823, 274);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(258, 39);
            dateTimePicker1.TabIndex = 17;
            // 
            // button1
            // 
            button1.Location = new Point(54, 396);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 18;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(1311, 62);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(258, 39);
            dateTimePicker2.TabIndex = 19;
            // 
            // cmbdesignation
            // 
            cmbdesignation.FormattingEnabled = true;
            cmbdesignation.Items.AddRange(new object[] { "Manager", "CEO", "Sales Executive", "Software Developer", "Accountant" });
            cmbdesignation.Location = new Point(872, 376);
            cmbdesignation.Name = "cmbdesignation";
            cmbdesignation.Size = new Size(242, 40);
            cmbdesignation.TabIndex = 20;
            // 
            // cmbcountry
            // 
            cmbcountry.FormattingEnabled = true;
            cmbcountry.Location = new Point(1295, 160);
            cmbcountry.Name = "cmbcountry";
            cmbcountry.Size = new Size(242, 40);
            cmbcountry.TabIndex = 21;
            cmbcountry.DropDownClosed += cmbcountry_DropDownClosed;
            // 
            // cmbstate
            // 
            cmbstate.FormattingEnabled = true;
            cmbstate.Location = new Point(1295, 258);
            cmbstate.Name = "cmbstate";
            cmbstate.Size = new Size(242, 40);
            cmbstate.TabIndex = 22;
            cmbstate.DropDownClosed += cmbstate_DropDownClosed;
            // 
            // cmbcity
            // 
            cmbcity.FormattingEnabled = true;
            cmbcity.Location = new Point(1295, 368);
            cmbcity.Name = "cmbcity";
            cmbcity.Size = new Size(242, 40);
            cmbcity.TabIndex = 23;
            // 
            // addprofilebtn
            // 
            addprofilebtn.Location = new Point(1119, 452);
            addprofilebtn.Name = "addprofilebtn";
            addprofilebtn.Size = new Size(150, 46);
            addprofilebtn.TabIndex = 24;
            addprofilebtn.Text = "Add profile";
            addprofilebtn.UseVisualStyleBackColor = true;
            addprofilebtn.Click += addprofilebtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1295, 452);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 244);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(248, 396);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 26;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(445, 396);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 27;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Delete, Edit });
            dataGridView1.Location = new Point(25, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(638, 322);
            dataGridView1.TabIndex = 28;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 10;
            Delete.Name = "Delete";
            Delete.Width = 200;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 10;
            Edit.Name = "Edit";
            Edit.Width = 200;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1683, 757);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
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
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblid;
        private Label lblname;
        private Label lbldob;
        private Label lbldesignationid;
        private Label lbljoiningdate;
        private Label lblcountryid;
        private Label lblstateid;
        private Label lblcityid;
        private TextBox txtid;
        private TextBox txtname;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private DateTimePicker dateTimePicker2;
        private ComboBox cmbdesignation;
        private ComboBox cmbcountry;
        private ComboBox cmbstate;
        private ComboBox cmbcity;
        private Button addprofilebtn;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Delete;
        private DataGridViewTextBoxColumn Edit;
    }
}
