
namespace Hospital_clinic_Management_system
{
    partial class Edit_Doctor_Details
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
            this.Doc_Content_panal = new System.Windows.Forms.Panel();
            this.timeOfDay_comboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            this.Exit_lbl = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.update_btn = new System.Windows.Forms.Button();
            this.doctor_comboBox = new System.Windows.Forms.ComboBox();
            this.female_radioButton = new System.Windows.Forms.RadioButton();
            this.male_radioButton = new System.Windows.Forms.RadioButton();
            this.Addres_richTextBox = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.phoneNum_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NIC_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Fname_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.EditDocError = new System.Windows.Forms.ErrorProvider(this.components);
            this.Doc_Content_panal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditDocError)).BeginInit();
            this.SuspendLayout();
            // 
            // Doc_Content_panal
            // 
            this.Doc_Content_panal.BackColor = System.Drawing.Color.LemonChiffon;
            this.Doc_Content_panal.Controls.Add(this.timeOfDay_comboBox);
            this.Doc_Content_panal.Controls.Add(this.label8);
            this.Doc_Content_panal.Controls.Add(this.delete_btn);
            this.Doc_Content_panal.Controls.Add(this.Exit_lbl);
            this.Doc_Content_panal.Controls.Add(this.dateTimePicker);
            this.Doc_Content_panal.Controls.Add(this.update_btn);
            this.Doc_Content_panal.Controls.Add(this.doctor_comboBox);
            this.Doc_Content_panal.Controls.Add(this.female_radioButton);
            this.Doc_Content_panal.Controls.Add(this.male_radioButton);
            this.Doc_Content_panal.Controls.Add(this.Addres_richTextBox);
            this.Doc_Content_panal.Controls.Add(this.label10);
            this.Doc_Content_panal.Controls.Add(this.label9);
            this.Doc_Content_panal.Controls.Add(this.phoneNum_txt);
            this.Doc_Content_panal.Controls.Add(this.label7);
            this.Doc_Content_panal.Controls.Add(this.label6);
            this.Doc_Content_panal.Controls.Add(this.Email_txt);
            this.Doc_Content_panal.Controls.Add(this.label5);
            this.Doc_Content_panal.Controls.Add(this.label4);
            this.Doc_Content_panal.Controls.Add(this.NIC_txt);
            this.Doc_Content_panal.Controls.Add(this.label2);
            this.Doc_Content_panal.Controls.Add(this.Fname_txt);
            this.Doc_Content_panal.Controls.Add(this.label11);
            this.Doc_Content_panal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Doc_Content_panal.Location = new System.Drawing.Point(0, 0);
            this.Doc_Content_panal.Name = "Doc_Content_panal";
            this.Doc_Content_panal.Size = new System.Drawing.Size(835, 588);
            this.Doc_Content_panal.TabIndex = 6;
            // 
            // timeOfDay_comboBox
            // 
            this.timeOfDay_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeOfDay_comboBox.FormattingEnabled = true;
            this.timeOfDay_comboBox.Items.AddRange(new object[] {
            "Morning( 5 am to 12 pm)",
            "Afternoon(12pm to 5pm)",
            "Evening(5 pm to 9 pm)"});
            this.timeOfDay_comboBox.Location = new System.Drawing.Point(282, 465);
            this.timeOfDay_comboBox.Name = "timeOfDay_comboBox";
            this.timeOfDay_comboBox.Size = new System.Drawing.Size(462, 28);
            this.timeOfDay_comboBox.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(73, 469);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 19);
            this.label8.TabIndex = 30;
            this.label8.Text = "Time of Day";
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.White;
            this.delete_btn.Location = new System.Drawing.Point(534, 522);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(210, 37);
            this.delete_btn.TabIndex = 29;
            this.delete_btn.Text = "Delete Details";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // Exit_lbl
            // 
            this.Exit_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_lbl.AutoSize = true;
            this.Exit_lbl.BackColor = System.Drawing.Color.Red;
            this.Exit_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_lbl.ForeColor = System.Drawing.Color.White;
            this.Exit_lbl.Location = new System.Drawing.Point(818, 0);
            this.Exit_lbl.Name = "Exit_lbl";
            this.Exit_lbl.Size = new System.Drawing.Size(17, 16);
            this.Exit_lbl.TabIndex = 28;
            this.Exit_lbl.Text = "X";
            this.Exit_lbl.Click += new System.EventHandler(this.Exit_lbl_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(282, 133);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(460, 26);
            this.dateTimePicker.TabIndex = 27;
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.Purple;
            this.update_btn.FlatAppearance.BorderSize = 0;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.Location = new System.Drawing.Point(282, 522);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(219, 37);
            this.update_btn.TabIndex = 24;
            this.update_btn.Text = "Update Details";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // doctor_comboBox
            // 
            this.doctor_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctor_comboBox.FormattingEnabled = true;
            this.doctor_comboBox.Items.AddRange(new object[] {
            "Psychologist",
            "Consulting doctor",
            "Dentist"});
            this.doctor_comboBox.Location = new System.Drawing.Point(282, 412);
            this.doctor_comboBox.Name = "doctor_comboBox";
            this.doctor_comboBox.Size = new System.Drawing.Size(462, 28);
            this.doctor_comboBox.TabIndex = 23;
            // 
            // female_radioButton
            // 
            this.female_radioButton.AutoSize = true;
            this.female_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female_radioButton.Location = new System.Drawing.Point(431, 240);
            this.female_radioButton.Name = "female_radioButton";
            this.female_radioButton.Size = new System.Drawing.Size(80, 24);
            this.female_radioButton.TabIndex = 21;
            this.female_radioButton.TabStop = true;
            this.female_radioButton.Text = "Female";
            this.female_radioButton.UseVisualStyleBackColor = true;
            // 
            // male_radioButton
            // 
            this.male_radioButton.AutoSize = true;
            this.male_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male_radioButton.Location = new System.Drawing.Point(300, 240);
            this.male_radioButton.Name = "male_radioButton";
            this.male_radioButton.Size = new System.Drawing.Size(61, 24);
            this.male_radioButton.TabIndex = 20;
            this.male_radioButton.TabStop = true;
            this.male_radioButton.Text = "Male";
            this.male_radioButton.UseVisualStyleBackColor = true;
            // 
            // Addres_richTextBox
            // 
            this.Addres_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addres_richTextBox.Location = new System.Drawing.Point(282, 339);
            this.Addres_richTextBox.Name = "Addres_richTextBox";
            this.Addres_richTextBox.Size = new System.Drawing.Size(462, 47);
            this.Addres_richTextBox.TabIndex = 19;
            this.Addres_richTextBox.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(73, 412);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 19);
            this.label10.TabIndex = 17;
            this.label10.Text = "Doctor\'s Position";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(73, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Address";
            // 
            // phoneNum_txt
            // 
            this.phoneNum_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNum_txt.Location = new System.Drawing.Point(282, 288);
            this.phoneNum_txt.Name = "phoneNum_txt";
            this.phoneNum_txt.Size = new System.Drawing.Size(460, 26);
            this.phoneNum_txt.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(71, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Gender";
            // 
            // Email_txt
            // 
            this.Email_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_txt.Location = new System.Drawing.Point(282, 185);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(460, 26);
            this.Email_txt.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date Of Birth";
            // 
            // NIC_txt
            // 
            this.NIC_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NIC_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.NIC_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NIC_txt.Location = new System.Drawing.Point(282, 34);
            this.NIC_txt.Name = "NIC_txt";
            this.NIC_txt.Size = new System.Drawing.Size(460, 26);
            this.NIC_txt.TabIndex = 4;
            this.NIC_txt.Leave += new System.EventHandler(this.NIC_txt_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "NIC Number";
            // 
            // Fname_txt
            // 
            this.Fname_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Fname_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname_txt.Location = new System.Drawing.Point(282, 81);
            this.Fname_txt.Name = "Fname_txt";
            this.Fname_txt.Size = new System.Drawing.Size(460, 26);
            this.Fname_txt.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(71, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 19);
            this.label11.TabIndex = 1;
            this.label11.Text = "Full Name";
            // 
            // EditDocError
            // 
            this.EditDocError.ContainerControl = this;
            // 
            // Edit_Doctor_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 588);
            this.Controls.Add(this.Doc_Content_panal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edit_Doctor_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit_Doctor_Details";
            this.Load += new System.EventHandler(this.Edit_Doctor_Details_Load);
            this.Doc_Content_panal.ResumeLayout(false);
            this.Doc_Content_panal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditDocError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Doc_Content_panal;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.ComboBox doctor_comboBox;
        private System.Windows.Forms.RadioButton female_radioButton;
        private System.Windows.Forms.RadioButton male_radioButton;
        private System.Windows.Forms.RichTextBox Addres_richTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox phoneNum_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NIC_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Fname_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label Exit_lbl;
        private System.Windows.Forms.ErrorProvider EditDocError;
        private System.Windows.Forms.ComboBox timeOfDay_comboBox;
        private System.Windows.Forms.Label label8;
    }
}