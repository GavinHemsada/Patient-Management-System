
namespace Hospital_clinic_Management_system
{
    partial class Appointment_Summary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.doctor_lbl = new System.Windows.Forms.Label();
            this.year_lbl = new System.Windows.Forms.Label();
            this.month_lbl = new System.Windows.Forms.Label();
            this.Year_text = new System.Windows.Forms.TextBox();
            this.doctor_comboBox = new System.Windows.Forms.ComboBox();
            this.doctor_checkBox = new System.Windows.Forms.CheckBox();
            this.month_comboBox = new System.Windows.Forms.ComboBox();
            this.year_checkBox = new System.Windows.Forms.CheckBox();
            this.Month_checkBox = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Submite_btn = new System.Windows.Forms.Button();
            this.cost_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.summaryError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.summaryError)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 66);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(192, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(410, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Summary of APPOINTMENTS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel2.Controls.Add(this.doctor_lbl);
            this.panel2.Controls.Add(this.year_lbl);
            this.panel2.Controls.Add(this.month_lbl);
            this.panel2.Controls.Add(this.Year_text);
            this.panel2.Controls.Add(this.doctor_comboBox);
            this.panel2.Controls.Add(this.doctor_checkBox);
            this.panel2.Controls.Add(this.month_comboBox);
            this.panel2.Controls.Add(this.year_checkBox);
            this.panel2.Controls.Add(this.Month_checkBox);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.Submite_btn);
            this.panel2.Controls.Add(this.cost_lbl);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 588);
            this.panel2.TabIndex = 4;
            // 
            // doctor_lbl
            // 
            this.doctor_lbl.AutoSize = true;
            this.doctor_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctor_lbl.ForeColor = System.Drawing.Color.Purple;
            this.doctor_lbl.Location = new System.Drawing.Point(393, 121);
            this.doctor_lbl.Name = "doctor_lbl";
            this.doctor_lbl.Size = new System.Drawing.Size(123, 18);
            this.doctor_lbl.TabIndex = 36;
            this.doctor_lbl.Text = "Select the Doctor";
            this.doctor_lbl.Visible = false;
            // 
            // year_lbl
            // 
            this.year_lbl.AutoSize = true;
            this.year_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_lbl.ForeColor = System.Drawing.Color.Purple;
            this.year_lbl.Location = new System.Drawing.Point(393, 84);
            this.year_lbl.Name = "year_lbl";
            this.year_lbl.Size = new System.Drawing.Size(107, 18);
            this.year_lbl.TabIndex = 35;
            this.year_lbl.Text = "Select the Year";
            this.year_lbl.Visible = false;
            // 
            // month_lbl
            // 
            this.month_lbl.AutoSize = true;
            this.month_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month_lbl.ForeColor = System.Drawing.Color.Purple;
            this.month_lbl.Location = new System.Drawing.Point(393, 50);
            this.month_lbl.Name = "month_lbl";
            this.month_lbl.Size = new System.Drawing.Size(182, 18);
            this.month_lbl.TabIndex = 34;
            this.month_lbl.Text = "Select the Month(Number)";
            this.month_lbl.Visible = false;
            // 
            // Year_text
            // 
            this.Year_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year_text.Location = new System.Drawing.Point(581, 84);
            this.Year_text.Name = "Year_text";
            this.Year_text.Size = new System.Drawing.Size(121, 24);
            this.Year_text.TabIndex = 33;
            this.Year_text.Visible = false;
            // 
            // doctor_comboBox
            // 
            this.doctor_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctor_comboBox.FormattingEnabled = true;
            this.doctor_comboBox.Items.AddRange(new object[] {
            "Psychologist",
            "Consulting doctor",
            "Dentist"});
            this.doctor_comboBox.Location = new System.Drawing.Point(581, 118);
            this.doctor_comboBox.Name = "doctor_comboBox";
            this.doctor_comboBox.Size = new System.Drawing.Size(121, 26);
            this.doctor_comboBox.TabIndex = 32;
            this.doctor_comboBox.Visible = false;
            // 
            // doctor_checkBox
            // 
            this.doctor_checkBox.AutoSize = true;
            this.doctor_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctor_checkBox.Location = new System.Drawing.Point(275, 117);
            this.doctor_checkBox.Name = "doctor_checkBox";
            this.doctor_checkBox.Size = new System.Drawing.Size(109, 22);
            this.doctor_checkBox.TabIndex = 31;
            this.doctor_checkBox.Text = "Doctor Type";
            this.doctor_checkBox.UseVisualStyleBackColor = true;
            this.doctor_checkBox.CheckedChanged += new System.EventHandler(this.doctor_checkBox_CheckedChanged);
            // 
            // month_comboBox
            // 
            this.month_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month_comboBox.FormattingEnabled = true;
            this.month_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.month_comboBox.Location = new System.Drawing.Point(581, 47);
            this.month_comboBox.Name = "month_comboBox";
            this.month_comboBox.Size = new System.Drawing.Size(121, 26);
            this.month_comboBox.TabIndex = 30;
            this.month_comboBox.Visible = false;
            // 
            // year_checkBox
            // 
            this.year_checkBox.AutoSize = true;
            this.year_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_checkBox.Location = new System.Drawing.Point(275, 83);
            this.year_checkBox.Name = "year_checkBox";
            this.year_checkBox.Size = new System.Drawing.Size(70, 22);
            this.year_checkBox.TabIndex = 28;
            this.year_checkBox.Text = "Anualy";
            this.year_checkBox.UseVisualStyleBackColor = true;
            this.year_checkBox.CheckedChanged += new System.EventHandler(this.year_checkBox_CheckedChanged);
            // 
            // Month_checkBox
            // 
            this.Month_checkBox.AutoSize = true;
            this.Month_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Month_checkBox.Location = new System.Drawing.Point(275, 49);
            this.Month_checkBox.Name = "Month_checkBox";
            this.Month_checkBox.Size = new System.Drawing.Size(79, 22);
            this.Month_checkBox.TabIndex = 27;
            this.Month_checkBox.Text = "Monthly";
            this.Month_checkBox.UseVisualStyleBackColor = true;
            this.Month_checkBox.CheckedChanged += new System.EventHandler(this.Month_checkBox_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LemonChiffon;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.LemonChiffon;
            this.dataGridView1.Location = new System.Drawing.Point(239, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.LemonChiffon;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(404, 256);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Register ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cost";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Doctor";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Date";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Submite_btn
            // 
            this.Submite_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Submite_btn.FlatAppearance.BorderSize = 0;
            this.Submite_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submite_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submite_btn.ForeColor = System.Drawing.Color.White;
            this.Submite_btn.Location = new System.Drawing.Point(342, 511);
            this.Submite_btn.Name = "Submite_btn";
            this.Submite_btn.Size = new System.Drawing.Size(185, 37);
            this.Submite_btn.TabIndex = 24;
            this.Submite_btn.Text = "View Summary";
            this.Submite_btn.UseVisualStyleBackColor = false;
            this.Submite_btn.Click += new System.EventHandler(this.Submite_btn_Click);
            // 
            // cost_lbl
            // 
            this.cost_lbl.AutoSize = true;
            this.cost_lbl.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_lbl.ForeColor = System.Drawing.Color.Red;
            this.cost_lbl.Location = new System.Drawing.Point(340, 460);
            this.cost_lbl.Name = "cost_lbl";
            this.cost_lbl.Size = new System.Drawing.Size(44, 21);
            this.cost_lbl.TabIndex = 17;
            this.cost_lbl.Text = "Cost";
            this.cost_lbl.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Summary Type";
            // 
            // summaryError
            // 
            this.summaryError.ContainerControl = this;
            // 
            // Appointment_Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 654);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Appointment_Summary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment_Summary";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.summaryError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Submite_btn;
        private System.Windows.Forms.Label cost_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox year_checkBox;
        private System.Windows.Forms.CheckBox Month_checkBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox month_comboBox;
        private System.Windows.Forms.ComboBox doctor_comboBox;
        private System.Windows.Forms.CheckBox doctor_checkBox;
        private System.Windows.Forms.TextBox Year_text;
        private System.Windows.Forms.ErrorProvider summaryError;
        private System.Windows.Forms.Label doctor_lbl;
        private System.Windows.Forms.Label year_lbl;
        private System.Windows.Forms.Label month_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}