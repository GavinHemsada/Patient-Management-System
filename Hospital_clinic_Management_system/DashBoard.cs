using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_clinic_Management_system
{
    public partial class DashBoard : Form
    {
        public DashBoard(int num)
        {
            InitializeComponent();
            if (num.Equals(1))
            {
                Doctor_Details.Visible = false;
                AppSummary_btn.Visible = false;
            }
            else if (num.Equals(2))
            {
                Doctor_Details.Visible = true;
                AppSummary_btn.Visible = true;
            }
        }
        private void DashBoard_Load(object sender, EventArgs e)
        {
            vision_btn.BackColor = Color.Navy;
            vision_pictureBox.Visible = true;
        }
        private void ButtonColorChange(Button btn1,Button btn2, Button btn3, Button btn4, Button btn5, Button btn6)
        {
            btn1.BackColor = Color.Navy;
            btn2.BackColor = Color.Blue;
            btn3.BackColor = Color.Blue;
            btn4.BackColor = Color.Blue;
            btn5.BackColor = Color.Blue;
            btn6.BackColor = Color.Blue;
        }
        private void Appoin_btn_Click(object sender, EventArgs e)
        {
            ButtonColorChange(Appoin_btn, paDeatils_btn, bill_btn, Doctor_Details, AppSummary_btn, vision_btn);
            vision_pictureBox.Visible = false;
            Appointment appoin = new Appointment();
            appoin.TopLevel = false;
            content_panel.Controls.Add(appoin);
            appoin.BringToFront();
            appoin.Show();
            exit_lbl.BringToFront();
        }

        private void paDeatils_btn_Click(object sender, EventArgs e)
        {
            ButtonColorChange( paDeatils_btn, bill_btn, Doctor_Details, AppSummary_btn, vision_btn, Appoin_btn);
            vision_pictureBox.Visible = false;
            Patient_Details pDetails = new Patient_Details();
            pDetails.TopLevel = false;
            content_panel.Controls.Add(pDetails);
            pDetails.BringToFront();
            pDetails.Show();
            exit_lbl.BringToFront();
        }

        private void bill_btn_Click(object sender, EventArgs e)
        {
            ButtonColorChange( bill_btn, Doctor_Details, AppSummary_btn, vision_btn, Appoin_btn, paDeatils_btn);
            vision_pictureBox.Visible = false;
            Bill_Calculater BillCal = new Bill_Calculater();
            BillCal.TopLevel = false;
            content_panel.Controls.Add(BillCal);
            BillCal.BringToFront();
            BillCal.Show();
            exit_lbl.BringToFront();
        }

        private void Doctor_Details_Click(object sender, EventArgs e)
        {
            ButtonColorChange( Doctor_Details, AppSummary_btn, vision_btn, Appoin_btn, paDeatils_btn, bill_btn);
            Doctor doc = new Doctor();
            doc.TopLevel = false;
            content_panel.Controls.Add(doc);
            doc.BringToFront();
            doc.Show();
            exit_lbl.BringToFront();
        }

        private void AppSummary_btn_Click(object sender, EventArgs e)
        {
            ButtonColorChange( AppSummary_btn, vision_btn, Appoin_btn, paDeatils_btn, bill_btn, Doctor_Details);
            vision_pictureBox.Visible = false;
            Appointment_Summary summary = new Appointment_Summary();
            summary.TopLevel = false;
            content_panel.Controls.Add(summary);
            summary.BringToFront();
            summary.Show();
            exit_lbl.BringToFront();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {   
            this.Hide();
            Admin_login alog = new Admin_login();
            alog.Show();
        }

        private void exit_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void vision_btn_Click(object sender, EventArgs e)
        {
            ButtonColorChange(vision_btn, paDeatils_btn, bill_btn, Doctor_Details, AppSummary_btn, Appoin_btn);
            vision_pictureBox.BringToFront();
            vision_pictureBox.Visible = true;
            exit_lbl.BringToFront();
        }
    }
}
