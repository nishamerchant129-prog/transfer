using Oracle.ManagedDataAccess.Client;
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

namespace EmployeeManagementSystem
{

    public partial class practice : Form
    {
        string cos = "User Id=System;Password=Stuti;Data Source=localhost:1521;";
        OracleConnection oc;
        OracleCommand cmd;
        OracleDataAdapter da;
        DataSet ds;
        OracleDataReader dr;
        public practice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oc = new OracleConnection(cos);
            oc.Open();
            cmd = new OracleCommand($@"insert into employee values(
                        {txtid.Text},
                        '{txtname.Text}',
                        TO_DATE('{dateTimePicker1.Value:yyyy-MM-dd}','YYYY-MM-DD'),
                {cmbdesignation.SelectedValue},
                TO_DATE('{dateTimePicker2.Value:yyyy-MM-dd}','YYYY-MM-DD'),
                {cmbcountry.SelectedValue},
                {cmbstate.SelectedValue},
                {cmbcity.SelectedValue},
                NULL)", oc);
            cmd.ExecuteNonQuery();
            display();
            oc.Close();
            MessageBox.Show("data inserted");
        }
        void display()
        {
            oc = new OracleConnection(cos);
            oc.Open();
            da = new OracleDataAdapter("select e.eid,e.ename,e.dob,d.design,e.doj,c.name,s.statename,ci.cityname from " +
                "employee e,designation d,country c,state s,city ci where e.cid=c.cid and " +
                "e.stateid=s.stateid and e.cityid=ci.cityid and e.id=d.id ", oc);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void designation()
        {
            string query = "select*from designation";
            cmd = new OracleCommand(query, oc);
            dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);

            cmbdesignation.DisplayMember = "design";
            cmbdesignation.ValueMember = "id";
            cmbdesignation.DataSource = dt;

        }
        void loadcountry()
        {
            string query = "select*from country";
            cmd = new OracleCommand(query, oc);
            dr = cmd.ExecuteReader();

            DataTable dt2 = new DataTable();
            dt2.Load(dr);

            cmbcountry.DisplayMember = "name";
            cmbcountry.ValueMember = "cid";
            cmbcountry.DataSource = dt2;
        }
        private void practice_Load(object sender, EventArgs e)
        {
            oc = new OracleConnection(cos);
            oc.Open();
            display();
            loadcountry();
            designation();

            DataGridViewButtonColumn btndel = new DataGridViewButtonColumn();
            btndel.HeaderText = "Delete";
            btndel.Name = "btndel";
            btndel.Text = "Delete";
            btndel.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btndel);

            DataGridViewButtonColumn btnedit = new DataGridViewButtonColumn();
            btnedit.HeaderText = "Edit";
            btnedit.Name = "btnedit";
            btnedit.Text = "Edit";
            btnedit.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnedit);

        }

        private void cmbcountry_DropDownClosed(object sender, EventArgs e)
        {
            string query = "select*from state where cid=" + cmbcountry.SelectedValue;
            cmd = new OracleCommand(query, oc);
            dr = cmd.ExecuteReader();

            DataTable dt3 = new DataTable();
            dt3.Load(dr);

            cmbstate.DisplayMember = "statename";
            cmbstate.ValueMember = "stateid";
            cmbstate.DataSource = dt3;

        }

        private void cmbstate_DropDownClosed(object sender, EventArgs e)
        {
            string query = "select*from city where stateid =" + cmbstate.SelectedValue;
            cmd = new OracleCommand(query, oc);
            dr = cmd.ExecuteReader();

            DataTable dt4 = new DataTable();
            dt4.Load(dr);

            cmbcity.DisplayMember = "cityname";
            cmbcity.ValueMember = "cityid";
            cmbcity.DataSource = dt4;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnedit")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                MessageBox.Show("Edit button clicked");
                txtid.Text = row.Cells["eid"].Value.ToString();
                txtname.Text = row.Cells["ename"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["dob"].Value);
                cmbdesignation.Text = row.Cells["design"].Value.ToString();
                dateTimePicker2.Value = Convert.ToDateTime(row.Cells["doj"].Value);
                cmbcountry.Text = row.Cells["name"].Value.ToString();
                cmbstate.Text = row.Cells["statename"].Value.ToString();
                cmbcity.Text = row.Cells["cityname"].Value.ToString();
            }


            if (e.RowIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "btndel")
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["eid"].Value);
                DialogResult dir = MessageBox.Show("Do you want to delete", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dir == DialogResult.Yes)
                {
                    try
                    {
                        //oc.Open();
                        cmd = new OracleCommand($"delete from employee where eid={id}", oc);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record deleted");
                        display();
                        //oc.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string updatequery = $@"update employee set ename='{txtname.Text}',
              dob=to_date('{dateTimePicker1.Value:yyyy-MM-dd}','YYYY-MM-DD'),
             id={cmbdesignation.SelectedValue},
               doj=to_date('{dateTimePicker2.Value:yyyy-MM-dd}','YYYY-MM-DD'),
               cid={cmbcountry.SelectedValue},
               stateid={cmbstate.SelectedValue},
               cityid={cmbcity.SelectedValue}
            where eid={txtid.Text}";
                //oc.Open();
                OracleCommand cmd = new OracleCommand(updatequery, oc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("data updated");
                // oc.Close();
                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
