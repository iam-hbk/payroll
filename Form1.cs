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
    public partial class frm_login : Form
    {
        private readonly SqlConnection con;
        
        public frm_login()
        {
             con = new SqlConnection("Data Source=DESKTOP-DSAPO5U\\SQLEXPRESS;Initial Catalog=dp_payroll;Integrated Security=True");

            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string query = "Select * From tbl_userpass Where Username = '" + txt_username.Text.Trim() + "' and Password = '" + txt_password.Text.Trim() + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                timer1.Start();
                progressBar1.Show();
                
            }
            else if(txt_username.Text == "" && txt_password.Text == "")
            {
                MessageBox.Show("Please fill up all the filleds");
            }
            else
            {
                MessageBox.Show("Incorrect username/password");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(35);
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1 .Stop();
                Mainform a = new Mainform();
                a.Show();
                this.Hide();
                


            }
            
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;

            }
        }
    }
}
