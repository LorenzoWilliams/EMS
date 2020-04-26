namespace Ember_Medical_Services
{
    partial class Edit_Patient
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
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_address = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_address_em = new System.Windows.Forms.TextBox();
            this.tb_phone_em = new System.Windows.Forms.TextBox();
            this.tb_lastname_em = new System.Windows.Forms.TextBox();
            this.tb_firstname_em = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_emailaddress = new System.Windows.Forms.TextBox();
            this.tb_ptlastname = new System.Windows.Forms.TextBox();
            this.tb_ptfirstname = new System.Windows.Forms.TextBox();
            this.dtp_dob = new System.Windows.Forms.DateTimePicker();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.lbid = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(63, 510);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(115, 25);
            this.bt_save.TabIndex = 1;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(371, 510);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(115, 25);
            this.bt_cancel.TabIndex = 2;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Edit Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Phone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "D.O.B";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Gender";
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Location = new System.Drawing.Point(3, 216);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(45, 13);
            this.lb_address.TabIndex = 12;
            this.lb_address.Text = "Address";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 252);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Emergency First Name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 288);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(114, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "Emergency Last Name";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 324);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 13);
            this.label20.TabIndex = 18;
            this.label20.Text = "Emergency Phone";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 360);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(101, 13);
            this.label22.TabIndex = 20;
            this.label22.Text = "Emergency Address";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tb_address_em, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.tb_phone_em, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.tb_lastname_em, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.tb_firstname_em, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.tb_address, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tb_phone, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_emailaddress, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_ptlastname, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label22, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label20, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label18, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lb_address, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_ptfirstname, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtp_dob, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cb_gender, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 82);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(540, 403);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tb_address_em
            // 
            this.tb_address_em.Location = new System.Drawing.Point(273, 363);
            this.tb_address_em.Name = "tb_address_em";
            this.tb_address_em.Size = new System.Drawing.Size(206, 20);
            this.tb_address_em.TabIndex = 33;
            // 
            // tb_phone_em
            // 
            this.tb_phone_em.Location = new System.Drawing.Point(273, 327);
            this.tb_phone_em.Name = "tb_phone_em";
            this.tb_phone_em.Size = new System.Drawing.Size(206, 20);
            this.tb_phone_em.TabIndex = 32;
            // 
            // tb_lastname_em
            // 
            this.tb_lastname_em.Location = new System.Drawing.Point(273, 291);
            this.tb_lastname_em.Name = "tb_lastname_em";
            this.tb_lastname_em.Size = new System.Drawing.Size(206, 20);
            this.tb_lastname_em.TabIndex = 31;
            // 
            // tb_firstname_em
            // 
            this.tb_firstname_em.Location = new System.Drawing.Point(273, 255);
            this.tb_firstname_em.Name = "tb_firstname_em";
            this.tb_firstname_em.Size = new System.Drawing.Size(206, 20);
            this.tb_firstname_em.TabIndex = 30;
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(273, 219);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(206, 20);
            this.tb_address.TabIndex = 29;
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(273, 111);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(206, 20);
            this.tb_phone.TabIndex = 26;
            // 
            // tb_emailaddress
            // 
            this.tb_emailaddress.Location = new System.Drawing.Point(273, 75);
            this.tb_emailaddress.Name = "tb_emailaddress";
            this.tb_emailaddress.Size = new System.Drawing.Size(206, 20);
            this.tb_emailaddress.TabIndex = 25;
            // 
            // tb_ptlastname
            // 
            this.tb_ptlastname.Location = new System.Drawing.Point(273, 39);
            this.tb_ptlastname.Name = "tb_ptlastname";
            this.tb_ptlastname.Size = new System.Drawing.Size(206, 20);
            this.tb_ptlastname.TabIndex = 24;
            // 
            // tb_ptfirstname
            // 
            this.tb_ptfirstname.Location = new System.Drawing.Point(273, 3);
            this.tb_ptfirstname.Name = "tb_ptfirstname";
            this.tb_ptfirstname.Size = new System.Drawing.Size(206, 20);
            this.tb_ptfirstname.TabIndex = 23;
            // 
            // dtp_dob
            // 
            this.dtp_dob.Location = new System.Drawing.Point(273, 147);
            this.dtp_dob.Name = "dtp_dob";
            this.dtp_dob.Size = new System.Drawing.Size(206, 20);
            this.dtp_dob.TabIndex = 35;
            // 
            // cb_gender
            // 
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cb_gender.Location = new System.Drawing.Point(273, 183);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(207, 21);
            this.cb_gender.TabIndex = 36;
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(16, 54);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(0, 13);
            this.lbid.TabIndex = 4;
            this.lbid.Visible = false;
            // 
            // Edit_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 560);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Edit_Patient";
            this.Text = "Edit Patient";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_address_em;
        private System.Windows.Forms.TextBox tb_phone_em;
        private System.Windows.Forms.TextBox tb_lastname_em;
        private System.Windows.Forms.TextBox tb_firstname_em;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_emailaddress;
        private System.Windows.Forms.TextBox tb_ptlastname;
        private System.Windows.Forms.TextBox tb_ptfirstname;
        private System.Windows.Forms.DateTimePicker dtp_dob;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.Label lbid;
    }
}