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
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_payroll a = new frm_payroll();
            a.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_records a = new frm_records();
            a.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            frm_addamp a = new frm_addamp();
            a.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_login a = new frm_login();
            a.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }
    }
}
