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

namespace EmployeeManagementSystem
{
    public partial class Form2 : Form
    {
        string cos = "User Id=System;Password=Stuti;Data Source=localhost:1521;";
        OracleConnection con;
        OracleCommand cmd;
        OracleDataAdapter da;
        OracleDataReader dr;
        DataSet ds;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new OracleConnection(cos);
            con.Open();
            cmd = new OracleCommand($@"insert into employee values(
                                    {txtid},
                                    '{txtname}'
                                    TO_DATE('{DOB.Value:yyyy-MM-dd}','YYYY-MM-DD'),
                                    TO_DATE('{JOD.Value:yyyy-MM-dd}','YYYY-MM-DD'),
                                    {cmbdesign.SelectedValue},
                                    {cmbcountry.SelectedValue},
                                    {cmbstate.SelectedValue})", con);
            cmd.ExecuteNonQuery();
            display();
            con.Close();
            MessageBox.Show("Data inserted");
        }
        void display()
        {
            con = new OracleConnection(cos);
            con.Open();
            cmd = new OracleCommand("select e.eid,e.ename,e.dob,d.design,e.doj,c.name,s.statename,ci.cityname from" +
                "\r\nemployee e,designation d,country c,state s,city ci " +
                "where e.cid=c.cid and e.stateid=s.stateid " +
                "and e.cityid=ci.cityid and e.id=d.id \r\n", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void loaddesign()
        {
            string query = "select * from designation";
            cmd = new OracleCommand(query, con);
            dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);

            cmbdesign.ValueMember = "id";
            cmbdesign.DisplayMember = "design";
            cmbdesign.DataSource = dt;





        }

        private void Form2_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(cos);
            con.Open();
            loaddesign();
        }
    }
}
