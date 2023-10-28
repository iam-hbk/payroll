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
    public partial class frm_update : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DSAPO5U\\SQLEXPRESS;Initial Catalog=dp_payroll;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public frm_update()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "" || txt_firstname.Text == "" || txt_lastname.Text == "" || txt_address.Text == "" || cbx_gender.Text == "" || cbx_status.Text == "" || cbx_position.Text == "" || cbx_basicrate.Text == "")
            {
                MessageBox.Show("Please fill up all fields.");

            }
            else
            {
                con.Open();
                cmd = new SqlCommand("UPDATE tbl_addemp SET firstname = '" + txt_firstname.Text+"', lastname = '" +txt_lastname.Text+"', Address = '" +txt_address.Text+"', Gender = '"+cbx_gender.Text+"', Status = '"+cbx_status.Text+ "',TEL_number = '"+txt_telnumber.Text+"', Phone_number = '"+txt_phonenumber.Text+"', sss = '"+txt_sss.Text+"', Position = '"+cbx_position.Text+"',Basic_rate = '"+cbx_basicrate.Text+"' WHERE ID =  '" +txt_id.Text+"'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("  Updated. ");
                //refresh();
                con.Close();
            }
        }

        private void frm_update_Load(object sender, EventArgs e)
        {

        }
    }
}
