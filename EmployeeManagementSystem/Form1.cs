using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
namespace EmployeeManagementSystem
{
    public partial class Form1 : Form
    {
        string connectionString = "User Id=System;Password=rashi123;Data Source=Localhost:1521;";
        OracleConnection connection;
        OracleDataAdapter da;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //    connection=new OracleConnection(connectionString);
            //    connection.Open();
            try
            {
                connection = new OracleConnection(connectionString);
                connection.Open();
                //LoadGrid();
                //display();
                //LoadState();
                //LoadCity();

                string query = "SELECT * FROM employee";
                //string query = "select e.eid, e.ename,e.dob,e.doj," +
                //    "c.name as Country_Name," +
                //    "d.designation," +
                //    "s.statename as State_Name," +
                //    "ci.cityname as CITY_NAME," +
                //    "from employee e," +
                //    "join country c on e.cid=c.cid," +
                //    "join state s on e.stateid=s.stateid," +
                //    "join city ci on e.cityid=ci.cityid," +
                //    "join designation d on e.id=d.id";
                OracleCommand cmd = new OracleCommand(query, connection);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dt.Columns.Add("PROFILE_IMAGE", typeof(Image));
                foreach (DataRow row in dt.Rows)
                {
                    if (row["IMAGE"] != DBNull.Value)
                    {
                        string path = row["IMAGE"].ToString();
                        if (File.Exists(path))
                        {
                            row["PROFILE_IMAGE"] = Image.FromFile(path);
                        }
                    }
                }
                dataGridView1.DataSource = dt;
                //Set image layout
                DataGridViewImageColumn imgCol = (DataGridViewImageColumn)dataGridView1.Columns["PROFILE_IMAGE"];
                imgCol.HeaderText = "Profile";
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

                dataGridView1.RowTemplate.Height = 60;
                //Hide path column
                //dataGridView1.Columns["IMAGE"].Visible = false;


                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "btnEdit";
                btn.HeaderText = "Action";
                btn.Text = "Edit";
                btn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btn);
                DataGridViewButtonColumn btnd = new DataGridViewButtonColumn();
                btnd.Name = "btnDelete";
                btnd.HeaderText = "Action";
                btnd.Text = "Delete";
                btnd.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btnd);
                LoadDesignation();
                LoadCountry();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void LoadGrid()
        {
            //string query = "SELECT * FROM employee";
            string query = "select e.eid, e.ename,e.dob,e.doj," +
                "c.name as Country_Name," +
                "d.designation," +
                "s.statename as State_Name," +
                "ci.cityname as CITY_NAME," +
                "e.IMAGE" +
                "from employee e," +
                "join country c on e.cid=c.cid," +
                "join state s on e.stateid=s.stateid," +
                "join city ci on e.cityid=ci.cityid," +
                "join designation d on e.id=d.id";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns.Add("PROFILE_IMAGE", typeof(Image));
            foreach (DataRow row in dt.Rows)
            {
                if (row["IMAGE"] != DBNull.Value)
                {
                    string path = row["IMAGE"].ToString();
                    if (File.Exists(path))
                    {
                        row["PROFILE_IMAGE"] = Image.FromFile(path);
                    }
                }
            }
            dataGridView1.DataSource = dt;
            //Set image layout
            DataGridViewImageColumn imgCol = (DataGridViewImageColumn)dataGridView1.Columns["PROFILE_IMAGE"];
            imgCol.HeaderText = "Profile";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

            dataGridView1.RowTemplate.Height = 60;
            //Hide path column
            //dataGridView1.Columns["IMAGE"].Visible = false;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new OracleConnection(connectionString);
                connection.Open();
                string imagePath = pictureBox1.Tag == null ? "" : pictureBox1.Tag.ToString();
                string name = txtname.Text;
                string insertquery = $@"INSERT INTO employee 
                (eid, ename, dob, id, doj, cid, stateid, cityid, image)
                VALUES
                ({txtid.Text},
                '{txtname.Text}',
                TO_DATE('{dateTimePicker1.Value:yyyy-MM-dd}','YYYY-MM-DD'),
                {cmbdesignation.SelectedValue},
                TO_DATE('{dateTimePicker2.Value:yyyy-MM-dd}','YYYY-MM-DD'),
                {cmbcountry.SelectedValue},
                {cmbstate.SelectedValue},
                {cmbcity.SelectedValue},
                '{imagePath}')";

                OracleCommand cmd = new OracleCommand(insertquery, connection);
                cmd.ExecuteNonQuery();
                display();
                connection.Close();
                MessageBox.Show("Data Inserted");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadDesignation()
        {
            try
            {
                string Desqurey = "SELECT id, design FROM designation";

                OracleCommand cmd = new OracleCommand(Desqurey, connection);
                OracleDataReader reader = cmd.ExecuteReader();

                DataTable dt2 = new DataTable();
                dt2.Load(reader);

                cmbdesignation.DisplayMember = "design";
                cmbdesignation.ValueMember = "id";
                cmbdesignation.DataSource = dt2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadCountry()
        {
            try
            {
                string query = "SELECT CID, NAME FROM country";

                OracleCommand cmd = new OracleCommand(query, connection);
                OracleDataReader reader = cmd.ExecuteReader();

                DataTable dt2 = new DataTable();
                dt2.Load(reader);

                cmbcountry.DisplayMember = "NAME";
                cmbcountry.ValueMember = "CID";
                cmbcountry.DataSource = dt2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void display()
        {
            string query = "SELECT * FROM employee";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "btnEdit";
            btn.HeaderText = "Action";
            btn.Text = "Edit";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn);
            DataGridViewButtonColumn btnd = new DataGridViewButtonColumn();
            btnd.Name = "btnDelete";
            btnd.HeaderText = "Action";
            btnd.Text = "Delete";
            btnd.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnd);

        }
        private void LoadState()
        {
            try
            {
                string query = "SELECT stateid, statename FROM state WHERE cid=" + cmbcountry.SelectedValue;

                OracleCommand cmd = new OracleCommand(query, connection);
                OracleDataReader reader = cmd.ExecuteReader();

                DataTable dt3 = new DataTable();
                dt3.Load(reader);

                cmbstate.DisplayMember = "statename";
                cmbstate.ValueMember = "stateid";
                cmbstate.DataSource = dt3;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadCity()
        {
            try
            {
                string query = "SELECT CITYID, CITYNAME FROM city WHERE STATEID=" + cmbstate.SelectedValue;


                OracleCommand cmd = new OracleCommand(query, connection);
                OracleDataReader reader = cmd.ExecuteReader();

                DataTable dt4 = new DataTable();
                dt4.Load(reader);

                cmbcountry.DisplayMember = "CITYNAME";
                cmbcountry.ValueMember = "CITYID";
                cmbcountry.DataSource = dt4;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void addprofilebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "Image files|*.jpg;*.jpeg;*.png;*.bmp;*.";
            openFileDialog.Title = "Select a profile picture";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileName = Path.GetFileName(filePath);
                pictureBox1.Image = Image.FromFile(filePath);
                pictureBox1.Tag = filePath;

            }
        }

        private void cmbcountry_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT stateid, statename FROM state WHERE cid=" + cmbcountry.SelectedValue;

                OracleCommand cmd = new OracleCommand(query, connection);
                OracleDataReader reader = cmd.ExecuteReader();

                DataTable dt3 = new DataTable();
                dt3.Load(reader);

                cmbstate.DisplayMember = "statename";
                cmbstate.ValueMember = "stateid";
                cmbstate.DataSource = dt3;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void cmbstate_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT CITYID, CITYNAME FROM city WHERE STATEID=" + cmbstate.SelectedValue;


                OracleCommand cmd = new OracleCommand(query, connection);
                OracleDataReader reader = cmd.ExecuteReader();

                DataTable dt4 = new DataTable();
                dt4.Load(reader);

                cmbcity.DisplayMember = "CITYNAME";
                cmbcity.ValueMember = "CITYID";
                cmbcity.DataSource = dt4;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //    // Ignore header clicks
        //    if (e.RowIndex < 0)
        //        return;

        //    // EDIT BUTTON
        //    if (dataGridView1.Columns[e.ColumnIndex].Name == "btnEdit")
        //    {
        //        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

        //        txtid.Text = row.Cells["ID"].Value.ToString();
        //        txtname.Text = row.Cells["NAME"].Value.ToString();

        //        dateTimePicker1.Value = Convert.ToDateTime(row.Cells["DOB"].Value);
        //        dateTimePicker2.Value = Convert.ToDateTime(row.Cells["DOJ"].Value);

        //        string path = row.Cells["IMAGE"].Value.ToString();
        //        // Set Designation
        //        cmbdesignation.Text = row.Cells["DESIGNATION"].Value.ToString();

        //        // Set Country
        //        cmbcountry.Text = row.Cells["COUNTRY_NAME"].Value.ToString();
        //        LoadState();

        //        // Set State
        //        cmbstate.Text = row.Cells["STATE_NAME"].Value.ToString();
        //        LoadCity();

        //        // Set City
        //        cmbcity.Text = row.Cells["CITY_NAME"].Value.ToString();
        //        try
        //        {
        //            pictureBox1.Image = Image.FromFile(row.Cells["Image"].Value.ToString());
        //        }
        //        catch (Exception ex)
        //        {

        //        }

        //    }

        //    // DELETE BUTTON
        //    if (dataGridView1.Columns[e.ColumnIndex].Name == "btnDelete")
        //    {
        //        int empId = Convert.ToInt32(
        //            dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);

        //        DialogResult dr = MessageBox.Show(
        //            "Are you sure you want to delete this employee?",
        //            "Confirm Delete",
        //            MessageBoxButtons.YesNo,
        //            MessageBoxIcon.Warning);

        //        if (dr == DialogResult.Yes)
        //        {
        //            try
        //            {
        //                connection.Open();
        //                OracleCommand cmd = new OracleCommand(
        //                    $"DELETE FROM EMPLOYEE_TB WHERE ID = {empId}", connection);
        //                cmd.ExecuteNonQuery();
        //                connection.Close();

        //                MessageBox.Show("Employee deleted successfully");
        //                LoadGrid();
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show(ex.Message);
        //                connection.Close();
        //            }
        //        }
        //    }

        //}

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex<0)
                return;
            //EDIT button 
            if (dataGridView1.Columns[e.ColumnIndex].Name=="btnEdit")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                //Example: load data into controls
                txtid.Text = row.Cells["eid"].Value.ToString();
                txtname.Text = row.Cells["ename"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["DOB"].Value);
                dateTimePicker2.Value = Convert.ToDateTime(row.Cells["DOJ"].Value);
                string path = row.Cells["IMAGE"].Value.ToString();
                if (File.Exists(path))
                {
                    pictureBox1.Image = Image.FromFile(path);
                    pictureBox1.Tag = path;
                }
                MessageBox.Show("Edit button clicked");
            }
        
        }
    }
}