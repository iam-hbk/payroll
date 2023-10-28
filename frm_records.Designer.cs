namespace Payroll
{
    partial class frm_records
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dp_payrollDataSet3 = new Payroll.dp_payrollDataSet3();
            this.tblsalaryrecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_salaryrecTableAdapter = new Payroll.dp_payrollDataSet3TableAdapters.tbl_salaryrecTableAdapter();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noWorkdaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryPerDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSalaryPerdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regularOTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalOTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalLateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.absentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDeductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dp_payrollDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsalaryrecBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.noWorkdaysDataGridViewTextBoxColumn,
            this.salaryPerDayDataGridViewTextBoxColumn,
            this.totalSalaryPerdayDataGridViewTextBoxColumn,
            this.regularOTDataGridViewTextBoxColumn,
            this.totalOTDataGridViewTextBoxColumn,
            this.lateDataGridViewTextBoxColumn,
            this.totalLateDataGridViewTextBoxColumn,
            this.absentDataGridViewTextBoxColumn,
            this.totalDeductionDataGridViewTextBoxColumn,
            this.totalSalaryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblsalaryrecBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(12, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(910, 420);
            this.dataGridView1.TabIndex = 0;
            // 
            // dp_payrollDataSet3
            // 
            this.dp_payrollDataSet3.DataSetName = "dp_payrollDataSet3";
            this.dp_payrollDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblsalaryrecBindingSource
            // 
            this.tblsalaryrecBindingSource.DataMember = "tbl_salaryrec";
            this.tblsalaryrecBindingSource.DataSource = this.dp_payrollDataSet3;
            // 
            // tbl_salaryrecTableAdapter
            // 
            this.tbl_salaryrecTableAdapter.ClearBeforeFill = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // noWorkdaysDataGridViewTextBoxColumn
            // 
            this.noWorkdaysDataGridViewTextBoxColumn.DataPropertyName = "no_Workdays";
            this.noWorkdaysDataGridViewTextBoxColumn.HeaderText = "no_Workdays";
            this.noWorkdaysDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noWorkdaysDataGridViewTextBoxColumn.Name = "noWorkdaysDataGridViewTextBoxColumn";
            this.noWorkdaysDataGridViewTextBoxColumn.Width = 125;
            // 
            // salaryPerDayDataGridViewTextBoxColumn
            // 
            this.salaryPerDayDataGridViewTextBoxColumn.DataPropertyName = "SalaryPerDay";
            this.salaryPerDayDataGridViewTextBoxColumn.HeaderText = "SalaryPerDay";
            this.salaryPerDayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salaryPerDayDataGridViewTextBoxColumn.Name = "salaryPerDayDataGridViewTextBoxColumn";
            this.salaryPerDayDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalSalaryPerdayDataGridViewTextBoxColumn
            // 
            this.totalSalaryPerdayDataGridViewTextBoxColumn.DataPropertyName = "TotalSalaryPerday";
            this.totalSalaryPerdayDataGridViewTextBoxColumn.HeaderText = "TotalSalaryPerday";
            this.totalSalaryPerdayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalSalaryPerdayDataGridViewTextBoxColumn.Name = "totalSalaryPerdayDataGridViewTextBoxColumn";
            this.totalSalaryPerdayDataGridViewTextBoxColumn.Width = 125;
            // 
            // regularOTDataGridViewTextBoxColumn
            // 
            this.regularOTDataGridViewTextBoxColumn.DataPropertyName = "RegularOT";
            this.regularOTDataGridViewTextBoxColumn.HeaderText = "RegularOT";
            this.regularOTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.regularOTDataGridViewTextBoxColumn.Name = "regularOTDataGridViewTextBoxColumn";
            this.regularOTDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalOTDataGridViewTextBoxColumn
            // 
            this.totalOTDataGridViewTextBoxColumn.DataPropertyName = "TotalOT";
            this.totalOTDataGridViewTextBoxColumn.HeaderText = "TotalOT";
            this.totalOTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalOTDataGridViewTextBoxColumn.Name = "totalOTDataGridViewTextBoxColumn";
            this.totalOTDataGridViewTextBoxColumn.Width = 125;
            // 
            // lateDataGridViewTextBoxColumn
            // 
            this.lateDataGridViewTextBoxColumn.DataPropertyName = "Late";
            this.lateDataGridViewTextBoxColumn.HeaderText = "Late";
            this.lateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lateDataGridViewTextBoxColumn.Name = "lateDataGridViewTextBoxColumn";
            this.lateDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalLateDataGridViewTextBoxColumn
            // 
            this.totalLateDataGridViewTextBoxColumn.DataPropertyName = "TotalLate";
            this.totalLateDataGridViewTextBoxColumn.HeaderText = "TotalLate";
            this.totalLateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalLateDataGridViewTextBoxColumn.Name = "totalLateDataGridViewTextBoxColumn";
            this.totalLateDataGridViewTextBoxColumn.Width = 125;
            // 
            // absentDataGridViewTextBoxColumn
            // 
            this.absentDataGridViewTextBoxColumn.DataPropertyName = "Absent";
            this.absentDataGridViewTextBoxColumn.HeaderText = "Absent";
            this.absentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.absentDataGridViewTextBoxColumn.Name = "absentDataGridViewTextBoxColumn";
            this.absentDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDeductionDataGridViewTextBoxColumn
            // 
            this.totalDeductionDataGridViewTextBoxColumn.DataPropertyName = "TotalDeduction";
            this.totalDeductionDataGridViewTextBoxColumn.HeaderText = "TotalDeduction";
            this.totalDeductionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDeductionDataGridViewTextBoxColumn.Name = "totalDeductionDataGridViewTextBoxColumn";
            this.totalDeductionDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalSalaryDataGridViewTextBoxColumn
            // 
            this.totalSalaryDataGridViewTextBoxColumn.DataPropertyName = "TotalSalary";
            this.totalSalaryDataGridViewTextBoxColumn.HeaderText = "TotalSalary";
            this.totalSalaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalSalaryDataGridViewTextBoxColumn.Name = "totalSalaryDataGridViewTextBoxColumn";
            this.totalSalaryDataGridViewTextBoxColumn.Width = 125;
            // 
            // frm_records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 568);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_records";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_records";
            this.Load += new System.EventHandler(this.frm_records_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dp_payrollDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsalaryrecBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dp_payrollDataSet3 dp_payrollDataSet3;
        private System.Windows.Forms.BindingSource tblsalaryrecBindingSource;
        private dp_payrollDataSet3TableAdapters.tbl_salaryrecTableAdapter tbl_salaryrecTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noWorkdaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryPerDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSalaryPerdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regularOTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalOTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalLateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn absentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDeductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSalaryDataGridViewTextBoxColumn;
    }
}