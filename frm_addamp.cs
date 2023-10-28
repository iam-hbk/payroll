using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Payroll
{
    public partial class frm_addamp : Form
    {
        //private readonly SqlConnection con;
        
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DSAPO5U\\SQLEXPRESS;Initial Catalog=dp_payroll;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public frm_addamp()
        {
            
            InitializeComponent();
        }
        public void refresh()
        {
            string query = "SELECT * FROM tbl_addemp";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Employee info");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Employee info";
            dataGridView1.DataSource = dataGridView1.DataSource;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "" || txt_firstname.Text == "" || txt_lastname.Text == "" || txt_address.Text == "" || cbx_gender.Text == "" || cbx_status.Text == "" || cbx_position.Text == "" || cbx_basicrate.Text == "")
            {
                MessageBox.Show("Please fill up all fields.");

            }
            else { 
            con.Open();
            cmd = new SqlCommand("INSERT INTO tbl_addemp(ID,Firstname,Lastname, Address, Gender, Status,Tel_number, Phone_number, SSS, Position, Basic_rate ) VALUES( '" +txt_id.Text+ "', '" +txt_firstname.Text+"', '" +txt_lastname.Text+ "', '" +txt_address.Text+ "', '" +cbx_gender.Text+ "', '" +cbx_status.Text+"', '" +txt_telnumber.Text+ "', '" +txt_phonenumber.Text+"', '" +txt_sss.Text+"', '" +cbx_position.Text+"', '" +cbx_basicrate.Text+"' ) ", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("  Saved. ");
            refresh();
            con.Close();
            }



        }

        private void frm_addamp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dp_payrollDataSet1.tbl_addemp' table. You can move, or remove it, as needed.
            this.tbl_addempTableAdapter.Fill(this.dp_payrollDataSet1.tbl_addemp);

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 1){
                    if (dataGridView1.CurrentRow.Index == dataGridView1.Rows.Count - 1)
                    {
                        MessageBox.Show("Please select data.");

                    }

                    else { 
                        if(MessageBox.Show(" Do you want to delete this data?","Delete", MessageBoxButtons.YesNo,MessageBoxIcon.Warning )== DialogResult.Yes) { 
                

                string del = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                con.Open();
                cmd = new SqlCommand("DELETE FROM tbl_addemp WHERE ID = '" + del + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data deleted");

                        refresh();

                con.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show(" No more data. ");
                }
            }

            catch(Exception ex){
                MessageBox.Show(ex.Message);

            }

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Payroll.frm_update frm = new frm_update();
            frm.txt_id.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txt_firstname.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txt_lastname.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txt_address.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.cbx_gender.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.cbx_status.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm.txt_telnumber.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm.txt_phonenumber.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frm.txt_sss.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frm.cbx_position.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            frm.cbx_basicrate.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            frm.ShowDialog();
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_id.Text))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_addemp WHERE ID=@Name ",con);
                cmd.Parameters.AddWithValue("@Name", txt_id.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows) 
                {
                    lbl_status.Visible = true;
                    lbl_status.Text = "ID is already taken.";
                    lbl_status.ForeColor = Color.Red;
                }
                else if (txt_id.Text == "")
                {
                    lbl_status.Visible = false;

                }
                else
                {
                    lbl_status.Visible = true;
                    lbl_status.Text = "This ID is available.";
                    lbl_status.ForeColor = Color.Green;

                }
                con.Close();

            }
            

        }

        private void lbl_status_Click(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
