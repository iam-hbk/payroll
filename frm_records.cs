using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class frm_records : Form
    {
        public frm_records()
        {
            InitializeComponent();
        }

        private void frm_records_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dp_payrollDataSet3.tbl_salaryrec' table. You can move, or remove it, as needed.
            this.tbl_salaryrecTableAdapter.Fill(this.dp_payrollDataSet3.tbl_salaryrec);

        }
    }
}
