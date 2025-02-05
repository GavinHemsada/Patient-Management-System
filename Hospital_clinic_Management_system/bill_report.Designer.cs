
namespace Hospital_clinic_Management_system
{
    partial class bill_report
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.print_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Bill_ID_lbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date_lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dis_lbl = new System.Windows.Forms.Label();
            this.days_lbl = new System.Windows.Forms.Label();
            this.cost_lbl = new System.Windows.Forms.Label();
            this.pill_lbl = new System.Windows.Forms.Label();
            this.regid_lbl = new System.Windows.Forms.Label();
            this.doc_lbl = new System.Windows.Forms.Label();
            this.exit_lbl = new System.Windows.Forms.Label();
            this.printBillDialog = new System.Windows.Forms.PrintDialog();
            this.printBillDocument = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.print_btn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.exit_lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 588);
            this.panel1.TabIndex = 0;
            // 
            // print_btn
            // 
            this.print_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.print_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_btn.ForeColor = System.Drawing.Color.White;
            this.print_btn.Location = new System.Drawing.Point(694, 534);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(89, 32);
            this.print_btn.TabIndex = 14;
            this.print_btn.Text = "Print";
            this.print_btn.UseVisualStyleBackColor = false;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Bill_ID_lbl);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.date_lbl);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.name_lbl);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dis_lbl);
            this.panel2.Controls.Add(this.days_lbl);
            this.panel2.Controls.Add(this.cost_lbl);
            this.panel2.Controls.Add(this.pill_lbl);
            this.panel2.Controls.Add(this.regid_lbl);
            this.panel2.Controls.Add(this.doc_lbl);
            this.panel2.Location = new System.Drawing.Point(145, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 546);
            this.panel2.TabIndex = 13;
            // 
            // Bill_ID_lbl
            // 
            this.Bill_ID_lbl.AutoSize = true;
            this.Bill_ID_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Bill_ID_lbl.Location = new System.Drawing.Point(74, 87);
            this.Bill_ID_lbl.Name = "Bill_ID_lbl";
            this.Bill_ID_lbl.Size = new System.Drawing.Size(38, 18);
            this.Bill_ID_lbl.TabIndex = 19;
            this.Bill_ID_lbl.Text = "Billid";
            this.Bill_ID_lbl.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 504);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(429, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Contact : 07i87211716 | 0112356744, website : LIFE Hospital.com";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(119, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Thank You , Come Again!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(388, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------------";
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lbl.Location = new System.Drawing.Point(316, 87);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(36, 18);
            this.date_lbl.TabIndex = 7;
            this.date_lbl.Text = "date";
            this.date_lbl.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(388, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------------";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.Location = new System.Drawing.Point(73, 110);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(62, 24);
            this.name_lbl.TabIndex = 0;
            this.name_lbl.Text = "name";
            this.name_lbl.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "LIFE HOSPITAL";
            // 
            // dis_lbl
            // 
            this.dis_lbl.AutoSize = true;
            this.dis_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dis_lbl.Location = new System.Drawing.Point(74, 348);
            this.dis_lbl.Name = "dis_lbl";
            this.dis_lbl.Size = new System.Drawing.Size(0, 18);
            this.dis_lbl.TabIndex = 6;
            this.dis_lbl.Visible = false;
            // 
            // days_lbl
            // 
            this.days_lbl.AutoSize = true;
            this.days_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.days_lbl.Location = new System.Drawing.Point(74, 279);
            this.days_lbl.Name = "days_lbl";
            this.days_lbl.Size = new System.Drawing.Size(39, 18);
            this.days_lbl.TabIndex = 5;
            this.days_lbl.Text = "days";
            this.days_lbl.Visible = false;
            // 
            // cost_lbl
            // 
            this.cost_lbl.AutoSize = true;
            this.cost_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_lbl.Location = new System.Drawing.Point(74, 388);
            this.cost_lbl.Name = "cost_lbl";
            this.cost_lbl.Size = new System.Drawing.Size(37, 18);
            this.cost_lbl.TabIndex = 2;
            this.cost_lbl.Text = "cost";
            this.cost_lbl.Visible = false;
            // 
            // pill_lbl
            // 
            this.pill_lbl.AutoSize = true;
            this.pill_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pill_lbl.Location = new System.Drawing.Point(74, 238);
            this.pill_lbl.Name = "pill_lbl";
            this.pill_lbl.Size = new System.Drawing.Size(25, 18);
            this.pill_lbl.TabIndex = 4;
            this.pill_lbl.Text = "pill";
            this.pill_lbl.Visible = false;
            // 
            // regid_lbl
            // 
            this.regid_lbl.AutoSize = true;
            this.regid_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regid_lbl.Location = new System.Drawing.Point(74, 157);
            this.regid_lbl.Name = "regid_lbl";
            this.regid_lbl.Size = new System.Drawing.Size(40, 18);
            this.regid_lbl.TabIndex = 1;
            this.regid_lbl.Text = "regid";
            this.regid_lbl.Visible = false;
            // 
            // doc_lbl
            // 
            this.doc_lbl.AutoSize = true;
            this.doc_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc_lbl.Location = new System.Drawing.Point(74, 197);
            this.doc_lbl.Name = "doc_lbl";
            this.doc_lbl.Size = new System.Drawing.Size(33, 18);
            this.doc_lbl.TabIndex = 3;
            this.doc_lbl.Text = "doc";
            this.doc_lbl.Visible = false;
            // 
            // exit_lbl
            // 
            this.exit_lbl.AutoSize = true;
            this.exit_lbl.BackColor = System.Drawing.Color.Red;
            this.exit_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_lbl.ForeColor = System.Drawing.Color.White;
            this.exit_lbl.Location = new System.Drawing.Point(818, 0);
            this.exit_lbl.Name = "exit_lbl";
            this.exit_lbl.Size = new System.Drawing.Size(17, 16);
            this.exit_lbl.TabIndex = 8;
            this.exit_lbl.Text = "X";
            this.exit_lbl.Click += new System.EventHandler(this.exit_lbl_Click);
            // 
            // printBillDialog
            // 
            this.printBillDialog.UseEXDialog = true;
            // 
            // printBillDocument
            // 
            this.printBillDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printBillDocument_PrintPage);
            // 
            // bill_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 588);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bill_report";
            this.Text = "bill_report";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.Label dis_lbl;
        private System.Windows.Forms.Label pill_lbl;
        private System.Windows.Forms.Label doc_lbl;
        private System.Windows.Forms.Label cost_lbl;
        private System.Windows.Forms.Label regid_lbl;
        private System.Windows.Forms.Label exit_lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.PrintDialog printBillDialog;
        private System.Drawing.Printing.PrintDocument printBillDocument;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Bill_ID_lbl;
        private System.Windows.Forms.Label days_lbl;
    }
}