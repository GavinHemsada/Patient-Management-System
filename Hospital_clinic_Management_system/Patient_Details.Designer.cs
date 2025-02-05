
namespace Hospital_clinic_Management_system
{
    partial class Patient_Details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.patin_details_panel = new System.Windows.Forms.Panel();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.text_lbl = new System.Windows.Forms.Label();
            this.regid_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findID_btn = new System.Windows.Forms.Button();
            this.history_btn = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.date_lbl = new System.Windows.Forms.Label();
            this.NIC_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.printDialog_findID = new System.Windows.Forms.PrintDialog();
            this.printDocument_findID = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.patin_details_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 66);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(291, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Patient Details";
            // 
            // patin_details_panel
            // 
            this.patin_details_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patin_details_panel.AutoSize = true;
            this.patin_details_panel.BackColor = System.Drawing.Color.LemonChiffon;
            this.patin_details_panel.Controls.Add(this.cancel_btn);
            this.patin_details_panel.Controls.Add(this.text_lbl);
            this.patin_details_panel.Controls.Add(this.regid_lbl);
            this.patin_details_panel.Controls.Add(this.name_lbl);
            this.patin_details_panel.Controls.Add(this.dataGridView1);
            this.patin_details_panel.Controls.Add(this.findID_btn);
            this.patin_details_panel.Controls.Add(this.history_btn);
            this.patin_details_panel.Controls.Add(this.dateTimePicker);
            this.patin_details_panel.Controls.Add(this.date_lbl);
            this.patin_details_panel.Controls.Add(this.NIC_txt);
            this.patin_details_panel.Controls.Add(this.label2);
            this.patin_details_panel.Location = new System.Drawing.Point(0, 66);
            this.patin_details_panel.Name = "patin_details_panel";
            this.patin_details_panel.Size = new System.Drawing.Size(835, 588);
            this.patin_details_panel.TabIndex = 4;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_btn.AutoSize = true;
            this.cancel_btn.BackColor = System.Drawing.Color.Navy;
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_btn.Location = new System.Drawing.Point(564, 496);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(193, 37);
            this.cancel_btn.TabIndex = 33;
            this.cancel_btn.Text = "Cancel Appointment";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            this.cancel_btn.MouseHover += new System.EventHandler(this.cancel);
            // 
            // text_lbl
            // 
            this.text_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_lbl.AutoSize = true;
            this.text_lbl.ForeColor = System.Drawing.Color.Red;
            this.text_lbl.Location = new System.Drawing.Point(224, 113);
            this.text_lbl.Name = "text_lbl";
            this.text_lbl.Size = new System.Drawing.Size(273, 13);
            this.text_lbl.TabIndex = 32;
            this.text_lbl.Text = "(Set Date If you Find Register ID or Cancel Appointment)";
            this.text_lbl.Visible = false;
            // 
            // regid_lbl
            // 
            this.regid_lbl.AutoSize = true;
            this.regid_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regid_lbl.Location = new System.Drawing.Point(221, 295);
            this.regid_lbl.Name = "regid_lbl";
            this.regid_lbl.Size = new System.Drawing.Size(79, 31);
            this.regid_lbl.TabIndex = 30;
            this.regid_lbl.Text = "regid";
            this.regid_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.regid_lbl.Visible = false;
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.Location = new System.Drawing.Point(322, 237);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(48, 18);
            this.name_lbl.TabIndex = 29;
            this.name_lbl.Text = "Name";
            this.name_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.name_lbl.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.GridColor = System.Drawing.Color.LemonChiffon;
            this.dataGridView1.Location = new System.Drawing.Point(216, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(541, 314);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Registation ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 91;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Full Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 73;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Doctor";
            this.Column3.Name = "Column3";
            this.Column3.Width = 64;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "NIC Number";
            this.Column4.Name = "Column4";
            this.Column4.Width = 83;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date";
            this.Column5.Name = "Column5";
            this.Column5.Width = 55;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Cost";
            this.Column6.Name = "Column6";
            this.Column6.Width = 53;
            // 
            // findID_btn
            // 
            this.findID_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.findID_btn.AutoSize = true;
            this.findID_btn.BackColor = System.Drawing.Color.Purple;
            this.findID_btn.FlatAppearance.BorderSize = 0;
            this.findID_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findID_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findID_btn.ForeColor = System.Drawing.Color.White;
            this.findID_btn.Location = new System.Drawing.Point(297, 496);
            this.findID_btn.Name = "findID_btn";
            this.findID_btn.Size = new System.Drawing.Size(233, 37);
            this.findID_btn.TabIndex = 27;
            this.findID_btn.Text = "Can\'t Remember Register ID";
            this.findID_btn.UseVisualStyleBackColor = false;
            this.findID_btn.Click += new System.EventHandler(this.findID_btn_Click);
            this.findID_btn.MouseHover += new System.EventHandler(this.findID_btn_MouseHover);
            // 
            // history_btn
            // 
            this.history_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.history_btn.AutoSize = true;
            this.history_btn.BackColor = System.Drawing.Color.Navy;
            this.history_btn.FlatAppearance.BorderSize = 0;
            this.history_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.history_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_btn.ForeColor = System.Drawing.Color.White;
            this.history_btn.Location = new System.Drawing.Point(61, 496);
            this.history_btn.Name = "history_btn";
            this.history_btn.Size = new System.Drawing.Size(205, 37);
            this.history_btn.TabIndex = 26;
            this.history_btn.Text = "View Patient History";
            this.history_btn.UseVisualStyleBackColor = false;
            this.history_btn.Click += new System.EventHandler(this.history_btn_Click);
            this.history_btn.MouseHover += new System.EventHandler(this.history_btn_MouseHover);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(216, 84);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(541, 26);
            this.dateTimePicker.TabIndex = 22;
            this.dateTimePicker.Visible = false;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lbl.Location = new System.Drawing.Point(48, 90);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(162, 19);
            this.date_lbl.TabIndex = 13;
            this.date_lbl.Text = "Appointment Date";
            this.date_lbl.Visible = false;
            // 
            // NIC_txt
            // 
            this.NIC_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NIC_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NIC_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.NIC_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NIC_txt.Location = new System.Drawing.Point(216, 35);
            this.NIC_txt.Name = "NIC_txt";
            this.NIC_txt.Size = new System.Drawing.Size(541, 26);
            this.NIC_txt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "NIC Number";
            // 
            // printDialog_findID
            // 
            this.printDialog_findID.UseEXDialog = true;
            // 
            // printDocument_findID
            // 
            this.printDocument_findID.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_findID_PrintPage);
            // 
            // Patient_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(835, 654);
            this.Controls.Add(this.patin_details_panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patient_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient_Details";
            this.Load += new System.EventHandler(this.Patient_Details_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.patin_details_panel.ResumeLayout(false);
            this.patin_details_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel patin_details_panel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.TextBox NIC_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button findID_btn;
        private System.Windows.Forms.Button history_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label regid_lbl;
        private System.Windows.Forms.Label text_lbl;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.PrintDialog printDialog_findID;
        private System.Drawing.Printing.PrintDocument printDocument_findID;
    }
}