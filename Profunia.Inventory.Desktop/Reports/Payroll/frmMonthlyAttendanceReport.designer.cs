﻿namespace Profunia.Inventory.Desktop.Reports
{
    partial class frmMonthlyAttendanceReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonthlyAttendanceReport));
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnDetailed = new System.Windows.Forms.RadioButton();
            this.rbtnCondensed = new System.Windows.Forms.RadioButton();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgvMonthlyAttendance = new System.Windows.Forms.DataGridView();
            this.rbtnActive = new System.Windows.Forms.RadioButton();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.rbtnInActive = new System.Windows.Forms.RadioButton();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.cmbDesigantion = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyAttendance)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Profunia.Inventory.Desktop.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(569, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Profunia.Inventory.Desktop.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(660, 39);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(461, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 1202;
            this.label4.Text = "Month";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1201;
            this.label1.Text = "Designation";
            // 
            // rbtnDetailed
            // 
            this.rbtnDetailed.AutoSize = true;
            this.rbtnDetailed.ForeColor = System.Drawing.Color.White;
            this.rbtnDetailed.Location = new System.Drawing.Point(106, 79);
            this.rbtnDetailed.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.rbtnDetailed.Name = "rbtnDetailed";
            this.rbtnDetailed.Size = new System.Drawing.Size(64, 17);
            this.rbtnDetailed.TabIndex = 3;
            this.rbtnDetailed.TabStop = true;
            this.rbtnDetailed.Text = "Detailed";
            this.rbtnDetailed.UseVisualStyleBackColor = true;
            this.rbtnDetailed.CheckedChanged += new System.EventHandler(this.rbtnDetailed_CheckedChanged);
            // 
            // rbtnCondensed
            // 
            this.rbtnCondensed.AutoSize = true;
            this.rbtnCondensed.ForeColor = System.Drawing.Color.White;
            this.rbtnCondensed.Location = new System.Drawing.Point(21, 79);
            this.rbtnCondensed.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.rbtnCondensed.Name = "rbtnCondensed";
            this.rbtnCondensed.Size = new System.Drawing.Size(79, 17);
            this.rbtnCondensed.TabIndex = 2;
            this.rbtnCondensed.TabStop = true;
            this.rbtnCondensed.Text = "Condensed";
            this.rbtnCondensed.UseVisualStyleBackColor = true;
            this.rbtnCondensed.CheckedChanged += new System.EventHandler(this.rbtnCondensed_CheckedChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Profunia.Inventory.Desktop.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(615, 560);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgvMonthlyAttendance
            // 
            this.dgvMonthlyAttendance.AllowUserToAddRows = false;
            this.dgvMonthlyAttendance.AllowUserToDeleteRows = false;
            this.dgvMonthlyAttendance.BackgroundColor = System.Drawing.Color.White;
            this.dgvMonthlyAttendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonthlyAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMonthlyAttendance.ColumnHeadersHeight = 25;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonthlyAttendance.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMonthlyAttendance.EnableHeadersVisualStyles = false;
            this.dgvMonthlyAttendance.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvMonthlyAttendance.Location = new System.Drawing.Point(18, 104);
            this.dgvMonthlyAttendance.Name = "dgvMonthlyAttendance";
            this.dgvMonthlyAttendance.ReadOnly = true;
            this.dgvMonthlyAttendance.RowHeadersVisible = false;
            this.dgvMonthlyAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonthlyAttendance.Size = new System.Drawing.Size(764, 438);
            this.dgvMonthlyAttendance.TabIndex = 1214;
            // 
            // rbtnActive
            // 
            this.rbtnActive.AutoSize = true;
            this.rbtnActive.ForeColor = System.Drawing.Color.White;
            this.rbtnActive.Location = new System.Drawing.Point(50, 4);
            this.rbtnActive.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.rbtnActive.Name = "rbtnActive";
            this.rbtnActive.Size = new System.Drawing.Size(55, 17);
            this.rbtnActive.TabIndex = 1;
            this.rbtnActive.TabStop = true;
            this.rbtnActive.Text = "Active";
            this.rbtnActive.UseVisualStyleBackColor = true;
            this.rbtnActive.CheckedChanged += new System.EventHandler(this.rbtnActive_CheckedChanged);
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.ForeColor = System.Drawing.Color.White;
            this.rbtnAll.Location = new System.Drawing.Point(11, 4);
            this.rbtnAll.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(36, 17);
            this.rbtnAll.TabIndex = 0;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "All";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.CheckedChanged += new System.EventHandler(this.rbtnAll_CheckedChanged);
            // 
            // rbtnInActive
            // 
            this.rbtnInActive.AutoSize = true;
            this.rbtnInActive.ForeColor = System.Drawing.Color.White;
            this.rbtnInActive.Location = new System.Drawing.Point(108, 4);
            this.rbtnInActive.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.rbtnInActive.Name = "rbtnInActive";
            this.rbtnInActive.Size = new System.Drawing.Size(63, 17);
            this.rbtnInActive.TabIndex = 2;
            this.rbtnInActive.TabStop = true;
            this.rbtnInActive.Text = "Inactive";
            this.rbtnInActive.UseVisualStyleBackColor = true;
            this.rbtnInActive.CheckedChanged += new System.EventHandler(this.rbtnInActive_CheckedChanged);
            // 
            // dtpMonth
            // 
            this.dtpMonth.CustomFormat = "MMM-yyyy";
            this.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonth.Location = new System.Drawing.Point(569, 13);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.Size = new System.Drawing.Size(213, 20);
            this.dtpMonth.TabIndex = 1;
            this.dtpMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpMonth_KeyDown);
            // 
            // cmbDesigantion
            // 
            this.cmbDesigantion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesigantion.FormattingEnabled = true;
            this.cmbDesigantion.Location = new System.Drawing.Point(126, 13);
            this.cmbDesigantion.Name = "cmbDesigantion";
            this.cmbDesigantion.Size = new System.Drawing.Size(213, 21);
            this.cmbDesigantion.TabIndex = 0;
            this.cmbDesigantion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDesigantion_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtnActive);
            this.panel2.Controls.Add(this.rbtnAll);
            this.panel2.Controls.Add(this.rbtnInActive);
            this.panel2.Location = new System.Drawing.Point(18, 548);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 31);
            this.panel2.TabIndex = 6;
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Profunia.Inventory.Desktop.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(703, 561);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmMonthlyAttendanceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbDesigantion);
            this.Controls.Add(this.dtpMonth);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvMonthlyAttendance);
            this.Controls.Add(this.rbtnDetailed);
            this.Controls.Add(this.rbtnCondensed);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMonthlyAttendanceReport";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monthly Attendance Report";
            this.Load += new System.EventHandler(this.frmMonthlyAttendanceReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMonthlyAttendanceReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyAttendance)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnDetailed;
        private System.Windows.Forms.RadioButton rbtnCondensed;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgvMonthlyAttendance;
        private System.Windows.Forms.RadioButton rbtnActive;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.RadioButton rbtnInActive;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.ComboBox cmbDesigantion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExport;
    }
}