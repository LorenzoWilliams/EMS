namespace Ember_Medical_Services
{
    partial class ViewPatients
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_pat_search = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_editpatient = new System.Windows.Forms.Button();
            this.bt_deletepatient = new System.Windows.Forms.Button();
            this.dg_patientlist = new System.Windows.Forms.DataGridView();
            this.bt_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_patientlist)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Patients";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_pat_search
            // 
            this.tb_pat_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_pat_search.Location = new System.Drawing.Point(82, 79);
            this.tb_pat_search.Name = "tb_pat_search";
            this.tb_pat_search.Size = new System.Drawing.Size(162, 20);
            this.tb_pat_search.TabIndex = 26;
            this.tb_pat_search.TextChanged += new System.EventHandler(this.tb_pat_search_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Search : ";
            // 
            // bt_editpatient
            // 
            this.bt_editpatient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_editpatient.Location = new System.Drawing.Point(380, 78);
            this.bt_editpatient.Name = "bt_editpatient";
            this.bt_editpatient.Size = new System.Drawing.Size(75, 20);
            this.bt_editpatient.TabIndex = 31;
            this.bt_editpatient.Text = "Edit";
            this.bt_editpatient.UseVisualStyleBackColor = true;
            this.bt_editpatient.Click += new System.EventHandler(this.bt_editpatient_Click);
            // 
            // bt_deletepatient
            // 
            this.bt_deletepatient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_deletepatient.Location = new System.Drawing.Point(477, 78);
            this.bt_deletepatient.Name = "bt_deletepatient";
            this.bt_deletepatient.Size = new System.Drawing.Size(75, 20);
            this.bt_deletepatient.TabIndex = 30;
            this.bt_deletepatient.Text = "Delete";
            this.bt_deletepatient.UseVisualStyleBackColor = true;
            this.bt_deletepatient.Click += new System.EventHandler(this.bt_deletepatient_Click);
            // 
            // dg_patientlist
            // 
            this.dg_patientlist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dg_patientlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_patientlist.Location = new System.Drawing.Point(12, 122);
            this.dg_patientlist.Name = "dg_patientlist";
            this.dg_patientlist.Size = new System.Drawing.Size(540, 345);
            this.dg_patientlist.TabIndex = 34;
            // 
            // bt_refresh
            // 
            this.bt_refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_refresh.Location = new System.Drawing.Point(289, 78);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(75, 20);
            this.bt_refresh.TabIndex = 35;
            this.bt_refresh.Text = "Refresh";
            this.bt_refresh.UseVisualStyleBackColor = true;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // ViewPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 560);
            this.Controls.Add(this.bt_refresh);
            this.Controls.Add(this.dg_patientlist);
            this.Controls.Add(this.bt_editpatient);
            this.Controls.Add(this.bt_deletepatient);
            this.Controls.Add(this.tb_pat_search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ViewPatients";
            this.Text = "ViewPatients";
            this.Load += new System.EventHandler(this.ViewPatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_patientlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_pat_search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_editpatient;
        private System.Windows.Forms.Button bt_deletepatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dg_patientlist;
        private System.Windows.Forms.Button bt_refresh;
    }
}