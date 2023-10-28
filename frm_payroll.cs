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
using Microsoft.Office.Interop.Excel;

namespace Payroll
{
    public partial class frm_payroll : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DSAPO5U\\SQLEXPRESS;Initial Catalog=dp_payroll;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public frm_payroll()
        {
            InitializeComponent();
        }
        public void computation()
        {
            // number of worked days

            string a = txt_noworkday.Text;
            int noworkday = int.Parse(a);

            string b = txt_salaryperday.Text;
            int salaryperday = int.Parse(b);

            int totalsalaryperday = noworkday * salaryperday;
            txt_totalsalaryperday.Text = totalsalaryperday.ToString();

            //Overtime
            string c = txt_regot.Text;
            int regot = int.Parse(c);
            int totalot = regot * 50;
            txt_totalot.Text = totalot.ToString();

            // Deduction
            string d = txt_late.Text;
            int late = int.Parse(d);
            int totallate = late * 20;
            txt_totallate.Text = totallate.ToString();

            string f = txt_absent.Text;
            int absent = int.Parse(f);
            int totalabsent = absent * salaryperday;

            int totaldeduction = totallate + totalabsent;
            txt_totaldeduction.Text = totaldeduction.ToString();

            // Total Salary
            int totalsalary = (totalsalaryperday + totalot) - totaldeduction;
            txt_totalsalary.Text = totalsalary.ToString();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_compute_Click(object sender, EventArgs e)
        {
            btn_excel.Enabled = true;
            btn_saverec.Enabled = true;
            btn_print.Enabled = true;
            if (txt_regot.Text == "" && txt_late.Text == "" && txt_absent.Text ==  "" )
            {
                txt_regot.Text = "0";
                txt_late.Text = "0";
                txt_absent.Text = "0";


            }
            if (txt_regot.Text == "" )
            {
                txt_regot.Text = "0";

            }
            if (txt_late.Text == "")
            {
                txt_late.Text = "0";

            }
            if (txt_absent.Text == "")
            {
                txt_absent.Text = "0";

            }

            computation();
           



        }

        private void btn_excel_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel.Application xls = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = xls.Workbooks.Add(XlSheetType.xlWorksheet); 
            Worksheet ws = (Worksheet)xls.ActiveSheet;
            
            ws.Columns.ColumnWidth = 20; 
            xls.Visible = true;
            
            //Celss
            ws.Cells[1, 1] = "Number of Work days:";
            ws.Cells[2, 1] = "Salary per day:";
            ws.Cells[4, 1] = "Total Salaryper day:";
            ws.Cells[6, 1] = "Regular OT (hr/s):";
            ws.Cells[7, 1] = "Total amount of OT:";
            ws.Cells[9, 1] = "Late (hr/s):";
            ws.Cells[10, 1] = "Total amount of late:";
            ws.Cells[11, 1] = "Absent:";
            ws.Cells[12, 1] = "Total Deduction:";
            ws.Cells[14, 1] = "Total Salary:";

            //
            ws.Cells[1, 2] = txt_noworkday.Text;
            ws.Cells[2, 2] = txt_salaryperday.Text;
            ws.Cells[4, 2] = txt_totalsalary.Text;
            ws.Cells[6, 2] = txt_regot.Text;
            ws.Cells[7, 2] = txt_totalot.Text;
            ws.Cells[9, 2] = txt_late.Text;
            ws.Cells[10, 2] = txt_totallate.Text;
            ws.Cells[11, 2] = txt_absent.Text;
            ws.Cells[12, 2] = txt_totaldeduction.Text;
            ws.Cells[14, 2] = txt_totalsalary.Text;


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_time_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            lbl_date.Text = DateTime.Now.ToLongDateString();
        }

        private void frm_payroll_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dp_payrollDataSet2.tbl_addemp' table. You can move, or remove it, as needed.
            this.tbl_addempTableAdapter.Fill(this.dp_payrollDataSet2.tbl_addemp);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_compute.Enabled = true;
            lbl_ID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            lbl_firstname.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lbl_lastname.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_salaryperday.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
           // System.Windows.Forms.Application.Exit();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_noworkday.Text = "";
            txt_salaryperday.Text = "";
            txt_regot.Text = "";
            txt_late.Text = "";
            txt_absent.Text = "";

            txt_totalsalaryperday.Text = "0";
            txt_totalot.Text = "0";
            txt_totallate.Text = "0";
            txt_totaldeduction.Text = "0";
            txt_totalsalary.Text = "0";

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.EM_PAYROLL__2_;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 110, -80, newImage.Width, newImage.Height);
            //Time and Date
            e.Graphics.DrawString("Time: ", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 250));
            e.Graphics.DrawString("Date: ", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 270));
            e.Graphics.DrawString(lbl_dash.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(30, 290));
            // Names
            e.Graphics.DrawString("Firstname: ", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 310));
            e.Graphics.DrawString("Lastname: ", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 330));
            e.Graphics.DrawString(lbl_dash.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(30, 350));
            // Salary
            e.Graphics.DrawString("no. of work day(s): ", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 370));
            e.Graphics.DrawString("Basic rate: ", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 390));
            e.Graphics.DrawString("Total Basic rate: ", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 410));
            e.Graphics.DrawString(lbl_dash.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(30, 430));
            //Pvertime
            e.Graphics.DrawString("Regular OT (hr/s): ", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 450));
            e.Graphics.DrawString("Total amount of OT: ", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 470));
            e.Graphics.DrawString(lbl_dash.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(30, 490));
            //Deduction
            e.Graphics.DrawString("Late: ", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 510));
            e.Graphics.DrawString("Total amount of late: ", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 530));
            e.Graphics.DrawString("Absent: ", new System.Drawing.Font("Arial", 12 , FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 550));
            e.Graphics.DrawString("Total Deduction: ", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Red, new System.Drawing.Point(50, 570));
            e.Graphics.DrawString(lbl_dash.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(30, 590));
            e.Graphics.DrawString("Total Salary: ", new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(50, 610));


            //Data

            //Time and Date
            e.Graphics.DrawString(lbl_time.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(300, 250));
            e.Graphics.DrawString(lbl_date.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(300, 270));
            
            // Names
            e.Graphics.DrawString(lbl_firstname.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(300, 310));
            e.Graphics.DrawString(lbl_lastname.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(300, 330));
            
            // Salary
            e.Graphics.DrawString(txt_noworkday.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(300, 370));
            e.Graphics.DrawString(txt_salaryperday.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(300, 390));
            e.Graphics.DrawString(txt_totalsalaryperday.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(300, 410));
            
            //Pvertime
            e.Graphics.DrawString(txt_regot.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(300, 450));
            e.Graphics.DrawString(txt_totalot.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(300, 470));
            
            //Deduction
            e.Graphics.DrawString(txt_late.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(300, 510));
            e.Graphics.DrawString(txt_totallate.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(300, 530));
            e.Graphics.DrawString(txt_absent.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(300, 550));
            e.Graphics.DrawString(txt_totaldeduction.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Red, new System.Drawing.Point(300, 570));
            
            e.Graphics.DrawString(txt_totalsalary.Text, new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Blue, new System.Drawing.Point(300, 610));



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_saverec_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("INSERT INTO tbl_salaryrec(Time, Date, ID, Lastname, Firstname, no_Workdays, SalaryPerDay, TotalSalaryPerDay, RegularOT, TotalOT, Late, TotalLate, Absent, TotalDeduction, TotalSalary) VALUES('"+lbl_time.Text+"', '"+lbl_date.Text+"', '"+lbl_ID.Text+"','"+lbl_lastname.Text+"','"+lbl_firstname.Text+"', '"+txt_noworkday.Text+"', '"+txt_salaryperday.Text+"', '"+txt_totalsalaryperday.Text+"', '"+txt_regot.Text+"', '"+txt_totalot.Text+"', '"+txt_late.Text+"', '"+txt_totallate.Text+"', '"+txt_absent.Text+"', '"+txt_totaldeduction.Text+"', '"+txt_totalsalary.Text+"')",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved. ");
            con.Close();
        }
    }
}
