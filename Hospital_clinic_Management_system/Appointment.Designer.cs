
namespace Hospital_clinic_Management_system
{
    partial class Appointment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timeOfDay_comboBox = new System.Windows.Forms.ComboBox();
            this.DoctorName_comboBox = new System.Windows.Forms.ComboBox();
            this.NumOfAppo_lbl = new System.Windows.Forms.Label();
            this.nic_lbl = new System.Windows.Forms.Label();
            this.Submite_btn = new System.Windows.Forms.Button();
            this.doctor_comboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.female_radioButton = new System.Windows.Forms.RadioButton();
            this.male_radioButton = new System.Windows.Forms.RadioButton();
            this.Addres_richTextBox = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.phoneNum_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Age_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NIC_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Fname_txt = new System.Windows.Forms.TextBox();
            this.Appointmenterror = new System.Windows.Forms.ErrorProvider(this.components);
            this.printDocument_appointment = new System.Drawing.Printing.PrintDocument();
            this.printDialog_appointmen = new System.Windows.Forms.PrintDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Appointmenterror)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(291, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEW APPOINTMENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 66);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel2.Controls.Add(this.timeOfDay_comboBox);
            this.panel2.Controls.Add(this.DoctorName_comboBox);
            this.panel2.Controls.Add(this.NumOfAppo_lbl);
            this.panel2.Controls.Add(this.nic_lbl);
            this.panel2.Controls.Add(this.Submite_btn);
            this.panel2.Controls.Add(this.doctor_comboBox);
            this.panel2.Controls.Add(this.dateTimePicker);
            this.panel2.Controls.Add(this.female_radioButton);
            this.panel2.Controls.Add(this.male_radioButton);
            this.panel2.Controls.Add(this.Addres_richTextBox);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.phoneNum_txt);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Email_txt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Age_txt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.NIC_txt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Fname_txt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 588);
            this.panel2.TabIndex = 3;
            // 
            // timeOfDay_comboBox
            // 
            this.timeOfDay_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeOfDay_comboBox.FormattingEnabled = true;
            this.timeOfDay_comboBox.Items.AddRange(new object[] {
            "Morning( 5 am to 12 pm)",
            "Afternoon(12pm to 5pm)",
            "Evening(5 pm to 9 pm)"});
            this.timeOfDay_comboBox.Location = new System.Drawing.Point(416, 464);
            this.timeOfDay_comboBox.Name = "timeOfDay_comboBox";
            this.timeOfDay_comboBox.Size = new System.Drawing.Size(176, 28);
            this.timeOfDay_comboBox.TabIndex = 34;
            this.timeOfDay_comboBox.SelectedIndexChanged += new System.EventHandler(this.timeOfDay_comboBox_SelectedIndexChanged);
            // 
            // DoctorName_comboBox
            // 
            this.DoctorName_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorName_comboBox.FormattingEnabled = true;
            this.DoctorName_comboBox.Location = new System.Drawing.Point(598, 464);
            this.DoctorName_comboBox.Name = "DoctorName_comboBox";
            this.DoctorName_comboBox.Size = new System.Drawing.Size(131, 28);
            this.DoctorName_comboBox.TabIndex = 27;
            // 
            // NumOfAppo_lbl
            // 
            this.NumOfAppo_lbl.AutoSize = true;
            this.NumOfAppo_lbl.ForeColor = System.Drawing.Color.Red;
            this.NumOfAppo_lbl.Location = new System.Drawing.Point(280, 54);
            this.NumOfAppo_lbl.Name = "NumOfAppo_lbl";
            this.NumOfAppo_lbl.Size = new System.Drawing.Size(257, 13);
            this.NumOfAppo_lbl.TabIndex = 26;
            this.NumOfAppo_lbl.Text = "(Only one appointment per day is valid for the patient)";
            // 
            // nic_lbl
            // 
            this.nic_lbl.AutoSize = true;
            this.nic_lbl.ForeColor = System.Drawing.Color.Red;
            this.nic_lbl.Location = new System.Drawing.Point(280, 109);
            this.nic_lbl.Name = "nic_lbl";
            this.nic_lbl.Size = new System.Drawing.Size(162, 13);
            this.nic_lbl.TabIndex = 25;
            this.nic_lbl.Text = "(Parent\'s NIC also valid for child )";
            // 
            // Submite_btn
            // 
            this.Submite_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Submite_btn.FlatAppearance.BorderSize = 0;
            this.Submite_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submite_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submite_btn.ForeColor = System.Drawing.Color.White;
            this.Submite_btn.Location = new System.Drawing.Point(274, 518);
            this.Submite_btn.Name = "Submite_btn";
            this.Submite_btn.Size = new System.Drawing.Size(455, 37);
            this.Submite_btn.TabIndex = 24;
            this.Submite_btn.Text = "Submite Details";
            this.Submite_btn.UseVisualStyleBackColor = false;
            this.Submite_btn.Click += new System.EventHandler(this.Submite_btn_Click);
            // 
            // doctor_comboBox
            // 
            this.doctor_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctor_comboBox.FormattingEnabled = true;
            this.doctor_comboBox.Items.AddRange(new object[] {
            "Psychologist",
            "Consulting doctor",
            "Dentist"});
            this.doctor_comboBox.Location = new System.Drawing.Point(271, 464);
            this.doctor_comboBox.Name = "doctor_comboBox";
            this.doctor_comboBox.Size = new System.Drawing.Size(139, 28);
            this.doctor_comboBox.TabIndex = 23;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(274, 335);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(455, 26);
            this.dateTimePicker.TabIndex = 22;
            // 
            // female_radioButton
            // 
            this.female_radioButton.AutoSize = true;
            this.female_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female_radioButton.Location = new System.Drawing.Point(377, 232);
            this.female_radioButton.Name = "female_radioButton";
            this.female_radioButton.Size = new System.Drawing.Size(75, 22);
            this.female_radioButton.TabIndex = 21;
            this.female_radioButton.TabStop = true;
            this.female_radioButton.Text = "Female";
            this.female_radioButton.UseVisualStyleBackColor = true;
            // 
            // male_radioButton
            // 
            this.male_radioButton.AutoSize = true;
            this.male_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male_radioButton.Location = new System.Drawing.Point(274, 232);
            this.male_radioButton.Name = "male_radioButton";
            this.male_radioButton.Size = new System.Drawing.Size(58, 22);
            this.male_radioButton.TabIndex = 20;
            this.male_radioButton.TabStop = true;
            this.male_radioButton.Text = "Male";
            this.male_radioButton.UseVisualStyleBackColor = true;
            // 
            // Addres_richTextBox
            // 
            this.Addres_richTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Addres_richTextBox.Location = new System.Drawing.Point(271, 390);
            this.Addres_richTextBox.Name = "Addres_richTextBox";
            this.Addres_richTextBox.Size = new System.Drawing.Size(458, 47);
            this.Addres_richTextBox.TabIndex = 19;
            this.Addres_richTextBox.Text = "         no12,Pili@@@ala,Mada@@@a";
            this.Addres_richTextBox.Enter += new System.EventHandler(this.Addres_richTextBox_Enter);
            this.Addres_richTextBox.Leave += new System.EventHandler(this.Addres_richTextBox_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(86, 467);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 19);
            this.label10.TabIndex = 17;
            this.label10.Text = "Doctor and time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(86, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(86, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Date";
            // 
            // phoneNum_txt
            // 
            this.phoneNum_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNum_txt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.phoneNum_txt.Location = new System.Drawing.Point(274, 280);
            this.phoneNum_txt.Name = "phoneNum_txt";
            this.phoneNum_txt.Size = new System.Drawing.Size(455, 26);
            this.phoneNum_txt.TabIndex = 12;
            this.phoneNum_txt.Text = "         072xxx656";
            this.phoneNum_txt.Enter += new System.EventHandler(this.phoneNum_txt_Enter);
            this.phoneNum_txt.Leave += new System.EventHandler(this.phoneNum_txt_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(86, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(86, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Gender";
            // 
            // Email_txt
            // 
            this.Email_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_txt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Email_txt.Location = new System.Drawing.Point(274, 185);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(455, 26);
            this.Email_txt.TabIndex = 8;
            this.Email_txt.Text = "         exsampel@gmail.com";
            this.Email_txt.Enter += new System.EventHandler(this.Email_txt_Enter);
            this.Email_txt.Leave += new System.EventHandler(this.Email_txt_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email";
            // 
            // Age_txt
            // 
            this.Age_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age_txt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Age_txt.Location = new System.Drawing.Point(274, 136);
            this.Age_txt.Name = "Age_txt";
            this.Age_txt.Size = new System.Drawing.Size(455, 26);
            this.Age_txt.TabIndex = 6;
            this.Age_txt.Text = "         2X";
            this.Age_txt.Enter += new System.EventHandler(this.Age_txt_Enter);
            this.Age_txt.Leave += new System.EventHandler(this.Age_txt_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Age";
            // 
            // NIC_txt
            // 
            this.NIC_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NIC_txt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.NIC_txt.Location = new System.Drawing.Point(274, 81);
            this.NIC_txt.Name = "NIC_txt";
            this.NIC_txt.Size = new System.Drawing.Size(455, 26);
            this.NIC_txt.TabIndex = 4;
            this.NIC_txt.Text = "         434545xxx567";
            this.NIC_txt.Enter += new System.EventHandler(this.NIC_txt_Enter);
            this.NIC_txt.Leave += new System.EventHandler(this.NIC_txt_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "NIC Number";
            // 
            // Fname_txt
            // 
            this.Fname_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Fname_txt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Fname_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname_txt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Fname_txt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Fname_txt.Location = new System.Drawing.Point(274, 26);
            this.Fname_txt.MaximumSize = new System.Drawing.Size(1000, 100);
            this.Fname_txt.Multiline = true;
            this.Fname_txt.Name = "Fname_txt";
            this.Fname_txt.Size = new System.Drawing.Size(455, 25);
            this.Fname_txt.TabIndex = 2;
            this.Fname_txt.Text = "         Ga@in He@@anda";
            this.Fname_txt.WordWrap = false;
            this.Fname_txt.Enter += new System.EventHandler(this.Fname_txt_Enter);
            this.Fname_txt.Leave += new System.EventHandler(this.Fname_txt_Leave);
            // 
            // Appointmenterror
            // 
            this.Appointmenterror.ContainerControl = this;
            // 
            // printDocument_appointment
            // 
            this.printDocument_appointment.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_appointment_PrintPage);
            // 
            // printDialog_appointmen
            // 
            this.printDialog_appointmen.UseEXDialog = true;
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 654);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Appointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Appointmenterror)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Submite_btn;
        private System.Windows.Forms.ComboBox doctor_comboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.RadioButton female_radioButton;
        private System.Windows.Forms.RadioButton male_radioButton;
        private System.Windows.Forms.RichTextBox Addres_richTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox phoneNum_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Age_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NIC_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Fname_txt;
        private System.Windows.Forms.ErrorProvider Appointmenterror;
        private System.Windows.Forms.Label nic_lbl;
        private System.Windows.Forms.Label NumOfAppo_lbl;
        private System.Windows.Forms.ComboBox DoctorName_comboBox;
        private System.Windows.Forms.ComboBox timeOfDay_comboBox;
        private System.Drawing.Printing.PrintDocument printDocument_appointment;
        private System.Windows.Forms.PrintDialog printDialog_appointmen;
    }
}