using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_clinic_Management_system
{
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
        }
        Connection db = new Connection();
        string registrationIdBuilder;
        private void Fname_txt_Enter(object sender, EventArgs e)
        {
            if (Fname_txt.Text.Trim().Equals("Ga@in He@@anda"))
            {
                Fname_txt.Clear();
                Fname_txt.ForeColor = Color.Black;
                NumOfAppo_lbl.Visible = false;
            }
        }
        private void Fname_txt_Leave(object sender, EventArgs e)
        {
            if (Fname_txt.Text.Equals(""))
            {
                Fname_txt.Text = "         Ga@in He@@anda";
                Fname_txt.ForeColor = Color.Silver;
                NumOfAppo_lbl.Visible = true; ;
            }
        }
        private void NIC_txt_Enter(object sender, EventArgs e)
        {
            if (NIC_txt.Text.Trim().Equals("434545xxx567"))
            {
                NIC_txt.Clear();
                NIC_txt.ForeColor = Color.Black;
                nic_lbl.Visible = false;
            }
        }
        private void NIC_txt_Leave(object sender, EventArgs e)
        {
            if (NIC_txt.Text.Equals(""))
            {
                NIC_txt.Text = "         434545xxx567";
                NIC_txt.ForeColor = Color.Silver;
                nic_lbl.Visible = true;
            }
        }
        private void Age_txt_Enter(object sender, EventArgs e)
        {
            if (Age_txt.Text.Trim().Equals("2X"))
            {
                Age_txt.Clear();
                Age_txt.ForeColor = Color.Black;
            }
        }
        private void Age_txt_Leave(object sender, EventArgs e)
        {
            if (Age_txt.Text.Equals(""))
            {
                Age_txt.Text = "         2X";
                Age_txt.ForeColor = Color.Silver;
            }
        }
        private void Email_txt_Enter(object sender, EventArgs e)
        {
            if (Email_txt.Text.Trim().Equals("exsampel@gmail.com"))
            {
                Email_txt.Clear();
                Email_txt.ForeColor = Color.Black;
            }
        }

        private void Email_txt_Leave(object sender, EventArgs e)
        {
            if (Email_txt.Text.Equals(""))
            {
                Email_txt.Text = "          exsampel@gmail.com";
                Email_txt.ForeColor = Color.Silver;
            }
        }

        private void phoneNum_txt_Enter(object sender, EventArgs e)
        {
            if (phoneNum_txt.Text.Trim().Equals("072xxx656"))
            {
                phoneNum_txt.Clear();
                phoneNum_txt.ForeColor = Color.Black;
            }
        }
        private void phoneNum_txt_Leave(object sender, EventArgs e)
        {
            if (phoneNum_txt.Text.Equals(""))
            {
                phoneNum_txt.Text = "          072xxx656";
                phoneNum_txt.ForeColor = Color.Silver;
            }
        }

        private void Addres_richTextBox_Enter(object sender, EventArgs e)
        {
            if (Addres_richTextBox.Text.Trim().Equals("no12,Pili@@@ala,Mada@@@a"))
            {
                Addres_richTextBox.Clear();
                Addres_richTextBox.ForeColor = Color.Black;
            }
        }
        private void Addres_richTextBox_Leave(object sender, EventArgs e)
        {
            if (Addres_richTextBox.Text.Equals(""))
            {
                Addres_richTextBox.Text = "          no12,Pili@@@ala,Mada@@@a";
                Addres_richTextBox.ForeColor = Color.Silver;
            }
        }
       
        private void Submite_btn_Click(object sender, EventArgs e)
        {
                    
            string selectedValue = "";
            try
            {
                Appointmenterror.Clear();
                if (Fname_txt.Text.Trim().Equals("Ga@in He@@anda"))
                {
                    Appointmenterror.SetError(Fname_txt, "Fill patient Full Name");
                }
                if (NIC_txt.Text.Trim().Equals("434545xxx567"))
                {
                    Appointmenterror.SetError(NIC_txt, "Fill patient NIC Number");
                }
                else if(NIC_txt.Text.Length < 12 || NIC_txt.Text.Length >12)
                {
                    Appointmenterror.SetError(NIC_txt, "Invalid NIC Number");
                }
                else
                {
                    db.OpenConnection();
                    string query = "SELECT * FROM appointment_details WHERE NIC = '" + NIC_txt.Text + "' AND Date = '" + dateTimePicker.Text + "'";
                    MySqlDataAdapter cmd = new MySqlDataAdapter(query, db.getConnection());
                    DataTable dtable = new DataTable();
                    cmd.Fill(dtable);
                    if (dtable.Rows.Count > 0)
                    {
                        Appointmenterror.SetError(Fname_txt, "You have an Appointment");
                        Appointmenterror.SetError(NIC_txt, "You have an Appointment");
                        NumOfAppo_lbl.Visible = true;
                    }
                    db.CloseConnection();
                }
                if (Age_txt.Text.Trim().Equals("2X"))
                {
                    Appointmenterror.SetError(Age_txt, "Fill patient Age");
                }
                else
                {
                    string Age = Age_txt.Text.Trim();
                    bool IsValidLname(string aGe)
                    {
                        string pattern = @"^([0-9][0-9]|[0-9][0-9])$";
                        return Regex.IsMatch(aGe, pattern);
                    }
                    if (!IsValidLname(Age))
                    {
                        Appointmenterror.SetError(Age_txt, "Age is not valid");
                    }
                }
                if (Email_txt.Text.Trim().Equals("exsampel@gmail.com"))
                {
                    Appointmenterror.SetError(Email_txt, "Fill patient Email address");
                }
                else
                {
                    string email = Email_txt.Text.Trim();
                    bool IsValidEmail(string mail)
                    {
                        string pattern = @"^[a-zA-Z]+@[a-zA-Z]+\.[a-zA-Z]{2,}$";
                        return Regex.IsMatch(mail, pattern);
                    }
                    if (!IsValidEmail(email))
                    {
                        Appointmenterror.SetError(Email_txt, "Email is not valid");
                    }
                }
                if (male_radioButton.Checked || female_radioButton.Checked)
                {  
                    if (male_radioButton.Checked)
                    {
                        selectedValue = male_radioButton.Text;
                    }
                    else if (female_radioButton.Checked)
                    {
                        selectedValue = female_radioButton.Text;
                    }
                }
                else
                {
                    Appointmenterror.SetError(female_radioButton, "Select patient gender");
                }
                if (phoneNum_txt.Text.Trim().Equals("072xxx656"))
                {
                    Appointmenterror.SetError(phoneNum_txt, "Fill patient Phone Number");
                }
                else if(phoneNum_txt.Text.Length < 10 || phoneNum_txt.Text.Length > 10)
                {
                    Appointmenterror.SetError(phoneNum_txt, "InValid Phone Number");
                }
                if (Addres_richTextBox.Text.Trim().Equals("no12,Pili@@@ala,Mada@@@a"))
                {
                    Appointmenterror.SetError(Addres_richTextBox, "Fill patient Address");
                }
                if (string.IsNullOrEmpty(doctor_comboBox.Text))
                {
                    Appointmenterror.SetError(doctor_comboBox, "Select Doctor");
                }
                if (string.IsNullOrEmpty(DoctorName_comboBox.Text)) 
                {
                    Appointmenterror.SetError(DoctorName_comboBox, "Select Doctor's Name");
                }
                if (string.IsNullOrEmpty(timeOfDay_comboBox.Text))
                {
                    Appointmenterror.SetError(timeOfDay_comboBox, "Select Time Period");
                }
                if (string.IsNullOrEmpty(Appointmenterror.GetError(Fname_txt)) && string.IsNullOrEmpty(Appointmenterror.GetError(NIC_txt)) && string.IsNullOrEmpty(Appointmenterror.GetError(Age_txt)) && string.IsNullOrEmpty(Appointmenterror.GetError(Email_txt)) && string.IsNullOrEmpty(Appointmenterror.GetError(Addres_richTextBox)) && string.IsNullOrEmpty(Appointmenterror.GetError(female_radioButton)) && string.IsNullOrEmpty(Appointmenterror.GetError(phoneNum_txt)) && string.IsNullOrEmpty(Appointmenterror.GetError(doctor_comboBox)) && string.IsNullOrEmpty(Appointmenterror.GetError(DoctorName_comboBox)) && string.IsNullOrEmpty(Appointmenterror.GetError(timeOfDay_comboBox)))
                {
                    db.OpenConnection();
                    string StartID = "2023LH";                     
                    string query = "SELECT MAX(Rgister_ID) FROM appointment_details";
                    MySqlCommand cmd2 = new MySqlCommand(query, db.getConnection());
                    string result = cmd2.ExecuteScalar().ToString();
                    if (string.IsNullOrEmpty(result))
                    {
                        registrationIdBuilder = "2023LH1";
                    }
                    else 
                    { 
                        Char[] devided = { 'H' };
                        string[] numarray = result.Split(devided);
                        registrationIdBuilder = StartID + (1 + Convert.ToInt32(numarray[1]));
                    }

                    string queir = "INSERT INTO `appointment_details`(`Rgister_ID`,`NIC`, `Full_Name`,`Age`, `Phone_Number`, `Email`, `Address`, `Gender`, `Type_of_doctor`, `Date`, `Doctor_Name`, `Time`) VALUES ('" + registrationIdBuilder + "','" + NIC_txt.Text + "','" + Fname_txt.Text + "','" + Age_txt.Text + "','" + phoneNum_txt.Text + "','" + Email_txt.Text + "','" + Addres_richTextBox.Text + "','" + selectedValue + "','" + doctor_comboBox.Text + "','" + dateTimePicker.Text + "','" + DoctorName_comboBox.Text + "','" + timeOfDay_comboBox.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(queir, db.getConnection());
                    cmd.ExecuteNonQuery();
                    DialogResult error = MessageBox.Show("Registaion ID is :" + registrationIdBuilder, " Registaion successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (error.Equals(DialogResult.OK))
                    {
                        PrintDialog printdialog = new PrintDialog();
                        printdialog.Document = printDocument_appointment;
                        DialogResult result2 = printdialog.ShowDialog();
                        if (result2 == DialogResult.OK)
                        {
                            printDocument_appointment.Print();
                        }
                        Fname_txt.Text = "         Ga@in He@@anda";
                        Fname_txt.ForeColor = Color.Silver;
                        doctor_comboBox.SelectedItem = null;
                        DoctorName_comboBox.SelectedItem = null;
                        timeOfDay_comboBox.SelectedItem = null;
                        NIC_txt.Text = "         434545xxx567";
                        NIC_txt.ForeColor = Color.Silver;
                        Age_txt.Text = "         2X";
                        Age_txt.ForeColor = Color.Silver;
                        male_radioButton.Checked = false;
                        female_radioButton.Checked = false;
                        phoneNum_txt.Text = "          072xxx656";
                        phoneNum_txt.ForeColor = Color.Silver;
                        Email_txt.Text = "          exsampel@gmail.com";
                        Email_txt.ForeColor = Color.Silver;
                        Addres_richTextBox.Text = "          no12,Pili@@@ala,Mada@@@a";
                        Addres_richTextBox.ForeColor = Color.Silver;
                        dateTimePicker.Value = DateTime.Now;
                    }
                }
            }
            catch
            {
                MessageBox.Show(" Server not respond", " 502 Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                db.CloseConnection();
            }
        }
        private void timeOfDay_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.OpenConnection();
            DoctorName_comboBox.Items.Clear();
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM doctor_details WHERE `doctor's_position` = '" + doctor_comboBox.Text + "' AND `TimeOfDay` = '" + timeOfDay_comboBox.Text + "' ", db.getConnection()))
            {
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DoctorName_comboBox.Items.Add(dr.GetString(dr.GetOrdinal("Full_Name")).ToString());
                }
            }
            db.CloseConnection();
        }

        private void printDocument_appointment_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font1 = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            Brush brush = Brushes.Black;
            e.Graphics.DrawString("Mr/Mrs."+Fname_txt.Text+" Youer Register ID is ", font1, brush, new PointF(100, 50));
            e.Graphics.DrawString(registrationIdBuilder, font1, brush, new PointF(150, 100));
        }
    }
}
