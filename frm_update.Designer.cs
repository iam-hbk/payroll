namespace Payroll
{
    partial class frm_update
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
            this.btn_save = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.cbx_basicrate = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbx_position = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_sss = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_telnumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_phonenumber = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_status = new System.Windows.Forms.ComboBox();
            this.cbx_gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.LightBlue;
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_save.Location = new System.Drawing.Point(377, 375);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 33);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Update";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.cbx_basicrate);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cbx_position);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txt_sss);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_telnumber);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_phonenumber);
            this.panel2.Location = new System.Drawing.Point(535, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 317);
            this.panel2.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "*Basic rate";
            // 
            // cbx_basicrate
            // 
            this.cbx_basicrate.BackColor = System.Drawing.Color.White;
            this.cbx_basicrate.FormattingEnabled = true;
            this.cbx_basicrate.Items.AddRange(new object[] {
            "300",
            "400",
            "500",
            "600"});
            this.cbx_basicrate.Location = new System.Drawing.Point(14, 252);
            this.cbx_basicrate.Name = "cbx_basicrate";
            this.cbx_basicrate.Size = new System.Drawing.Size(210, 24);
            this.cbx_basicrate.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "*Position";
            // 
            // cbx_position
            // 
            this.cbx_position.BackColor = System.Drawing.Color.White;
            this.cbx_position.FormattingEnabled = true;
            this.cbx_position.Items.AddRange(new object[] {
            "Secretary",
            "Technician",
            "Engineer",
            "Intern",
            "Driver",
            "Helper"});
            this.cbx_position.Location = new System.Drawing.Point(14, 195);
            this.cbx_position.Name = "cbx_position";
            this.cbx_position.Size = new System.Drawing.Size(210, 24);
            this.cbx_position.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "*SSS:";
            // 
            // txt_sss
            // 
            this.txt_sss.BackColor = System.Drawing.Color.White;
            this.txt_sss.Location = new System.Drawing.Point(14, 141);
            this.txt_sss.Name = "txt_sss";
            this.txt_sss.Size = new System.Drawing.Size(216, 22);
            this.txt_sss.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "*TEL number:";
            // 
            // txt_telnumber
            // 
            this.txt_telnumber.BackColor = System.Drawing.Color.White;
            this.txt_telnumber.Location = new System.Drawing.Point(14, 35);
            this.txt_telnumber.Name = "txt_telnumber";
            this.txt_telnumber.Size = new System.Drawing.Size(216, 22);
            this.txt_telnumber.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "*Phone number:";
            // 
            // txt_phonenumber
            // 
            this.txt_phonenumber.BackColor = System.Drawing.Color.White;
            this.txt_phonenumber.Location = new System.Drawing.Point(14, 92);
            this.txt_phonenumber.Name = "txt_phonenumber";
            this.txt_phonenumber.Size = new System.Drawing.Size(216, 22);
            this.txt_phonenumber.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbx_status);
            this.panel1.Controls.Add(this.cbx_gender);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_address);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_lastname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_firstname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Location = new System.Drawing.Point(23, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 317);
            this.panel1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(260, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "*Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "*Gender";
            // 
            // cbx_status
            // 
            this.cbx_status.BackColor = System.Drawing.Color.White;
            this.cbx_status.FormattingEnabled = true;
            this.cbx_status.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Divorced"});
            this.cbx_status.Location = new System.Drawing.Point(263, 278);
            this.cbx_status.Name = "cbx_status";
            this.cbx_status.Size = new System.Drawing.Size(216, 24);
            this.cbx_status.TabIndex = 9;
            // 
            // cbx_gender
            // 
            this.cbx_gender.BackColor = System.Drawing.Color.White;
            this.cbx_gender.FormattingEnabled = true;
            this.cbx_gender.Items.AddRange(new object[] {
            "Male ",
            "Female",
            "Non binary"});
            this.cbx_gender.Location = new System.Drawing.Point(28, 279);
            this.cbx_gender.Name = "cbx_gender";
            this.cbx_gender.Size = new System.Drawing.Size(210, 24);
            this.cbx_gender.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "*Address:";
            // 
            // txt_address
            // 
            this.txt_address.BackColor = System.Drawing.Color.White;
            this.txt_address.Location = new System.Drawing.Point(18, 132);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(461, 117);
            this.txt_address.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "*Lastname:";
            // 
            // txt_lastname
            // 
            this.txt_lastname.BackColor = System.Drawing.Color.White;
            this.txt_lastname.Location = new System.Drawing.Point(263, 81);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(216, 22);
            this.txt_lastname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "*Firstname:";
            // 
            // txt_firstname
            // 
            this.txt_firstname.BackColor = System.Drawing.Color.White;
            this.txt_firstname.Location = new System.Drawing.Point(18, 81);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(220, 22);
            this.txt_firstname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "*ID:";
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.White;
            this.txt_id.Location = new System.Drawing.Point(18, 35);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(220, 22);
            this.txt_id.TabIndex = 0;
            // 
            // frm_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update";
            this.Load += new System.EventHandler(this.frm_update_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_id;
        public System.Windows.Forms.ComboBox cbx_basicrate;
        public System.Windows.Forms.ComboBox cbx_position;
        public System.Windows.Forms.TextBox txt_sss;
        public System.Windows.Forms.TextBox txt_telnumber;
        public System.Windows.Forms.TextBox txt_phonenumber;
        public System.Windows.Forms.ComboBox cbx_status;
        public System.Windows.Forms.ComboBox cbx_gender;
        public System.Windows.Forms.TextBox txt_address;
        public System.Windows.Forms.TextBox txt_lastname;
        public System.Windows.Forms.TextBox txt_firstname;
        public System.Windows.Forms.Button btn_save;
    }
}