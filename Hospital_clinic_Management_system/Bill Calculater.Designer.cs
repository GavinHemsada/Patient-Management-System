
namespace Hospital_clinic_Management_system
{
    partial class Bill_Calculater
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Content_panel = new System.Windows.Forms.Panel();
            this.report_btn = new System.Windows.Forms.Button();
            this.age_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Pills_type_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Submite_btn = new System.Windows.Forms.Button();
            this.Doctor_comBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RegID_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NIC_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Fname_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Billerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.Content_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Billerror)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 66);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(235, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculate Patient Bill";
            // 
            // Content_panel
            // 
            this.Content_panel.BackColor = System.Drawing.Color.LemonChiffon;
            this.Content_panel.Controls.Add(this.report_btn);
            this.Content_panel.Controls.Add(this.age_txt);
            this.Content_panel.Controls.Add(this.label5);
            this.Content_panel.Controls.Add(this.Pills_type_comboBox);
            this.Content_panel.Controls.Add(this.label3);
            this.Content_panel.Controls.Add(this.Submite_btn);
            this.Content_panel.Controls.Add(this.Doctor_comBox);
            this.Content_panel.Controls.Add(this.dateTimePicker);
            this.Content_panel.Controls.Add(this.label10);
            this.Content_panel.Controls.Add(this.label8);
            this.Content_panel.Controls.Add(this.RegID_txt);
            this.Content_panel.Controls.Add(this.label4);
            this.Content_panel.Controls.Add(this.NIC_txt);
            this.Content_panel.Controls.Add(this.label2);
            this.Content_panel.Controls.Add(this.Fname_txt);
            this.Content_panel.Controls.Add(this.label11);
            this.Content_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content_panel.Location = new System.Drawing.Point(0, 66);
            this.Content_panel.Name = "Content_panel";
            this.Content_panel.Size = new System.Drawing.Size(835, 588);
            this.Content_panel.TabIndex = 5;
            // 
            // report_btn
            // 
            this.report_btn.BackColor = System.Drawing.Color.Purple;
            this.report_btn.FlatAppearance.BorderSize = 0;
            this.report_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.report_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_btn.ForeColor = System.Drawing.Color.White;
            this.report_btn.Location = new System.Drawing.Point(496, 496);
            this.report_btn.Name = "report_btn";
            this.report_btn.Size = new System.Drawing.Size(231, 37);
            this.report_btn.TabIndex = 32;
            this.report_btn.Text = "Bill Report";
            this.report_btn.UseVisualStyleBackColor = false;
            this.report_btn.Click += new System.EventHandler(this.report_btn_Click);
            // 
            // age_txt
            // 
            this.age_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.age_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_txt.ForeColor = System.Drawing.Color.Black;
            this.age_txt.Location = new System.Drawing.Point(278, 357);
            this.age_txt.Name = "age_txt";
            this.age_txt.Size = new System.Drawing.Size(447, 26);
            this.age_txt.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(96, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "Age";
            // 
            // Pills_type_comboBox
            // 
            this.Pills_type_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pills_type_comboBox.FormattingEnabled = true;
            this.Pills_type_comboBox.Items.AddRange(new object[] {
            "no Medicine",
            "1 Pills type",
            "2 Pills type",
            "3 Pills type"});
            this.Pills_type_comboBox.Location = new System.Drawing.Point(278, 422);
            this.Pills_type_comboBox.Name = "Pills_type_comboBox";
            this.Pills_type_comboBox.Size = new System.Drawing.Size(447, 28);
            this.Pills_type_comboBox.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Type Of Pills";
            // 
            // Submite_btn
            // 
            this.Submite_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Submite_btn.FlatAppearance.BorderSize = 0;
            this.Submite_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submite_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submite_btn.ForeColor = System.Drawing.Color.White;
            this.Submite_btn.Location = new System.Drawing.Point(278, 496);
            this.Submite_btn.Name = "Submite_btn";
            this.Submite_btn.Size = new System.Drawing.Size(212, 37);
            this.Submite_btn.TabIndex = 24;
            this.Submite_btn.Text = "Submite Details";
            this.Submite_btn.UseVisualStyleBackColor = false;
            this.Submite_btn.Click += new System.EventHandler(this.Submite_btn_Click);
            // 
            // Doctor_comBox
            // 
            this.Doctor_comBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doctor_comBox.FormattingEnabled = true;
            this.Doctor_comBox.Items.AddRange(new object[] {
            "Psychologist",
            "Consulting doctor",
            "Dentist"});
            this.Doctor_comBox.Location = new System.Drawing.Point(278, 291);
            this.Doctor_comBox.Name = "Doctor_comBox";
            this.Doctor_comBox.Size = new System.Drawing.Size(447, 28);
            this.Doctor_comBox.TabIndex = 23;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(278, 230);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(447, 26);
            this.dateTimePicker.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(94, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 19);
            this.label10.TabIndex = 17;
            this.label10.Text = "Type Of Doctor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(96, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Date";
            // 
            // RegID_txt
            // 
            this.RegID_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.RegID_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.RegID_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegID_txt.ForeColor = System.Drawing.Color.Black;
            this.RegID_txt.Location = new System.Drawing.Point(278, 32);
            this.RegID_txt.Name = "RegID_txt";
            this.RegID_txt.Size = new System.Drawing.Size(447, 26);
            this.RegID_txt.TabIndex = 6;
            this.RegID_txt.Leave += new System.EventHandler(this.RegID_txt_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Register ID";
            // 
            // NIC_txt
            // 
            this.NIC_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NIC_txt.ForeColor = System.Drawing.Color.Black;
            this.NIC_txt.Location = new System.Drawing.Point(278, 97);
            this.NIC_txt.Name = "NIC_txt";
            this.NIC_txt.Size = new System.Drawing.Size(447, 26);
            this.NIC_txt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "NIC Number";
            // 
            // Fname_txt
            // 
            this.Fname_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Fname_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname_txt.ForeColor = System.Drawing.Color.Black;
            this.Fname_txt.Location = new System.Drawing.Point(278, 163);
            this.Fname_txt.Name = "Fname_txt";
            this.Fname_txt.Size = new System.Drawing.Size(447, 26);
            this.Fname_txt.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(96, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 19);
            this.label11.TabIndex = 1;
            this.label11.Text = "Full Name";
            // 
            // Billerror
            // 
            this.Billerror.ContainerControl = this;
            // 
            // Bill_Calculater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 654);
            this.Controls.Add(this.Content_panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bill_Calculater";
            this.Text = "Bill_Calculater";
            this.Load += new System.EventHandler(this.Bill_Calculater_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Content_panel.ResumeLayout(false);
            this.Content_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Billerror)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Content_panel;
        private System.Windows.Forms.Button Submite_btn;
        private System.Windows.Forms.ComboBox Doctor_comBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox RegID_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NIC_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Fname_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Pills_type_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider Billerror;
        private System.Windows.Forms.TextBox age_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button report_btn;
    }
}