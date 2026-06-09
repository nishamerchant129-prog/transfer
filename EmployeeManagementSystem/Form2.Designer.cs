namespace EmployeeManagementSystem
{
    partial class Form2
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
            txtname = new TextBox();
            txtid = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            DOB = new DateTimePicker();
            JOD = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            cmbdesign = new ComboBox();
            cmbcountry = new ComboBox();
            cmbstate = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtname
            // 
            txtname.Location = new Point(208, 34);
            txtname.Name = "txtname";
            txtname.Size = new Size(100, 23);
            txtname.TabIndex = 0;
            // 
            // txtid
            // 
            txtid.Location = new Point(208, 96);
            txtid.Name = "txtid";
            txtid.Size = new Size(100, 23);
            txtid.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 40);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 104);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 3;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 147);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 4;
            label3.Text = "DOB";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 187);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 5;
            label4.Text = "joing Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(128, 234);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 6;
            label5.Text = "desi";
            // 
            // DOB
            // 
            DOB.Location = new Point(192, 147);
            DOB.Name = "DOB";
            DOB.Size = new Size(200, 23);
            DOB.TabIndex = 7;
            // 
            // JOD
            // 
            JOD.Location = new Point(192, 187);
            JOD.Name = "JOD";
            JOD.Size = new Size(200, 23);
            JOD.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(519, 42);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 9;
            label6.Text = "Country";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(519, 99);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 10;
            label7.Text = "State";
            // 
            // button1
            // 
            button1.Location = new Point(317, 322);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(122, 426);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(482, 150);
            dataGridView1.TabIndex = 12;
            // 
            // cmbdesign
            // 
            cmbdesign.FormattingEnabled = true;
            cmbdesign.Location = new Point(208, 234);
            cmbdesign.Name = "cmbdesign";
            cmbdesign.Size = new Size(121, 23);
            cmbdesign.TabIndex = 13;
            // 
            // cmbcountry
            // 
            cmbcountry.FormattingEnabled = true;
            cmbcountry.Location = new Point(601, 32);
            cmbcountry.Name = "cmbcountry";
            cmbcountry.Size = new Size(121, 23);
            cmbcountry.TabIndex = 14;
            // 
            // cmbstate
            // 
            cmbstate.FormattingEnabled = true;
            cmbstate.Location = new Point(611, 91);
            cmbstate.Name = "cmbstate";
            cmbstate.Size = new Size(121, 23);
            cmbstate.TabIndex = 15;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 708);
            Controls.Add(cmbstate);
            Controls.Add(cmbcountry);
            Controls.Add(cmbdesign);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(JOD);
            Controls.Add(DOB);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtid);
            Controls.Add(txtname);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtname;
        private TextBox txtid;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker DOB;
        private DateTimePicker JOD;
        private Label label6;
        private Label label7;
        private Button button1;
        private DataGridView dataGridView1;
        private ComboBox cmbdesign;
        private ComboBox cmbcountry;
        private ComboBox cmbstate;
    }
}