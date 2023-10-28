namespace Payroll
{
    partial class frm_payroll
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_payroll));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_excel = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_compute = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_totalsalary = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_totaldeduction = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_absent = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_totallate = new System.Windows.Forms.TextBox();
            this.txt_late = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_totalot = new System.Windows.Forms.TextBox();
            this.txt_regot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_totalsalaryperday = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_salaryperday = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_noworkday = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbladdempBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dp_payrollDataSet2 = new Payroll.dp_payrollDataSet2();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbl_addempTableAdapter = new Payroll.dp_payrollDataSet2TableAdapters.tbl_addempTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lbl_dash = new System.Windows.Forms.Label();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basicrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_saverec = new System.Windows.Forms.Button();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbladdempBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dp_payrollDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_saverec);
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_excel);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_compute);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txt_totalsalary);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txt_totalsalaryperday);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_salaryperday);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_noworkday);
            this.panel1.Controls.Add(this.label2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.btn_print, "btn_print");
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Name = "btn_print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.btn_exit, "btn_exit");
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_excel
            // 
            this.btn_excel.BackColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.btn_excel, "btn_excel");
            this.btn_excel.ForeColor = System.Drawing.Color.White;
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.UseVisualStyleBackColor = false;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.btn_clear, "btn_clear");
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_compute
            // 
            this.btn_compute.BackColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.btn_compute, "btn_compute");
            this.btn_compute.ForeColor = System.Drawing.Color.White;
            this.btn_compute.Name = "btn_compute";
            this.btn_compute.UseVisualStyleBackColor = false;
            this.btn_compute.Click += new System.EventHandler(this.btn_compute_Click);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txt_totalsalary
            // 
            resources.ApplyResources(this.txt_totalsalary, "txt_totalsalary");
            this.txt_totalsalary.Name = "txt_totalsalary";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txt_totaldeduction);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txt_absent);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txt_totallate);
            this.panel3.Controls.Add(this.txt_late);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // txt_totaldeduction
            // 
            resources.ApplyResources(this.txt_totaldeduction, "txt_totaldeduction");
            this.txt_totaldeduction.Name = "txt_totaldeduction";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // txt_absent
            // 
            resources.ApplyResources(this.txt_absent, "txt_absent");
            this.txt_absent.Name = "txt_absent";
            this.txt_absent.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // txt_totallate
            // 
            resources.ApplyResources(this.txt_totallate, "txt_totallate");
            this.txt_totallate.Name = "txt_totallate";
            this.txt_totallate.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txt_late
            // 
            resources.ApplyResources(this.txt_late, "txt_late");
            this.txt_late.Name = "txt_late";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_totalot);
            this.panel2.Controls.Add(this.txt_regot);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // txt_totalot
            // 
            resources.ApplyResources(this.txt_totalot, "txt_totalot");
            this.txt_totalot.Name = "txt_totalot";
            // 
            // txt_regot
            // 
            resources.ApplyResources(this.txt_regot, "txt_regot");
            this.txt_regot.Name = "txt_regot";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // txt_totalsalaryperday
            // 
            resources.ApplyResources(this.txt_totalsalaryperday, "txt_totalsalaryperday");
            this.txt_totalsalaryperday.Name = "txt_totalsalaryperday";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txt_salaryperday
            // 
            resources.ApplyResources(this.txt_salaryperday, "txt_salaryperday");
            this.txt_salaryperday.Name = "txt_salaryperday";
            this.txt_salaryperday.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_noworkday
            // 
            resources.ApplyResources(this.txt_noworkday, "txt_noworkday");
            this.txt_noworkday.Name = "txt_noworkday";
            this.txt_noworkday.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lbl_ID);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.lbl_date);
            this.groupBox1.Controls.Add(this.lbl_time);
            this.groupBox1.Controls.Add(this.lbl_lastname);
            this.groupBox1.Controls.Add(this.lbl_firstname);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.basicrateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbladdempBindingSource;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // tbladdempBindingSource
            // 
            this.tbladdempBindingSource.DataMember = "tbl_addemp";
            this.tbladdempBindingSource.DataSource = this.dp_payrollDataSet2;
            // 
            // dp_payrollDataSet2
            // 
            this.dp_payrollDataSet2.DataSetName = "dp_payrollDataSet2";
            this.dp_payrollDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_date
            // 
            resources.ApplyResources(this.lbl_date, "lbl_date");
            this.lbl_date.Name = "lbl_date";
            // 
            // lbl_time
            // 
            resources.ApplyResources(this.lbl_time, "lbl_time");
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Click += new System.EventHandler(this.lbl_time_Click);
            // 
            // lbl_lastname
            // 
            resources.ApplyResources(this.lbl_lastname, "lbl_lastname");
            this.lbl_lastname.Name = "lbl_lastname";
            // 
            // lbl_firstname
            // 
            resources.ApplyResources(this.lbl_firstname, "lbl_firstname");
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Click += new System.EventHandler(this.label14_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbl_addempTableAdapter
            // 
            this.tbl_addempTableAdapter.ClearBeforeFill = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            resources.ApplyResources(this.printPreviewDialog1, "printPreviewDialog1");
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            // 
            // lbl_dash
            // 
            resources.ApplyResources(this.lbl_dash, "lbl_dash");
            this.lbl_dash.Name = "lbl_dash";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            resources.ApplyResources(this.iDDataGridViewTextBoxColumn, "iDDataGridViewTextBoxColumn");
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            resources.ApplyResources(this.firstnameDataGridViewTextBoxColumn, "firstnameDataGridViewTextBoxColumn");
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            resources.ApplyResources(this.lastnameDataGridViewTextBoxColumn, "lastnameDataGridViewTextBoxColumn");
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // basicrateDataGridViewTextBoxColumn
            // 
            this.basicrateDataGridViewTextBoxColumn.DataPropertyName = "Basic_rate";
            resources.ApplyResources(this.basicrateDataGridViewTextBoxColumn, "basicrateDataGridViewTextBoxColumn");
            this.basicrateDataGridViewTextBoxColumn.Name = "basicrateDataGridViewTextBoxColumn";
            // 
            // btn_saverec
            // 
            this.btn_saverec.BackColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.btn_saverec, "btn_saverec");
            this.btn_saverec.ForeColor = System.Drawing.Color.White;
            this.btn_saverec.Name = "btn_saverec";
            this.btn_saverec.UseVisualStyleBackColor = false;
            this.btn_saverec.Click += new System.EventHandler(this.btn_saverec_Click);
            // 
            // lbl_ID
            // 
            resources.ApplyResources(this.lbl_ID, "lbl_ID");
            this.lbl_ID.Name = "lbl_ID";
            // 
            // frm_payroll
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_dash);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_payroll";
            this.Load += new System.EventHandler(this.frm_payroll_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbladdempBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dp_payrollDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_noworkday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_salaryperday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_totalsalaryperday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_totallate;
        private System.Windows.Forms.TextBox txt_late;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_totalot;
        private System.Windows.Forms.TextBox txt_regot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_absent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_totalsalary;
        private System.Windows.Forms.TextBox txt_totaldeduction;
        private System.Windows.Forms.Button btn_compute;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_excel;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.Label lbl_firstname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Timer timer1;
        private dp_payrollDataSet2 dp_payrollDataSet2;
        private System.Windows.Forms.BindingSource tbladdempBindingSource;
        private dp_payrollDataSet2TableAdapters.tbl_addempTableAdapter tbl_addempTableAdapter;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Label lbl_dash;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basicrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_saverec;
        private System.Windows.Forms.Label lbl_ID;
    }
}