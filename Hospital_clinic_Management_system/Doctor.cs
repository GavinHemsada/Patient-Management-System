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
    public partial class Doctor : Form
    {
        Connection db = new Connection();
        public Doctor()
        {
            InitializeComponent();
        }
        private void register_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DoctorError.Clear();
                string selectedValue = "";
                if (string.IsNullOrEmpty(Fname_txt.Text))
                {
                    DoctorError.SetError(Fname_txt,"Fill Doctor's Full Name");
                }
                if (string.IsNullOrEmpty(NIC_txt.Text))
                {
                    DoctorError.SetError(NIC_txt, "Fill Doctor's NIC Number");
                }
                else if(NIC_txt.Text.Length <12 || NIC_txt.Text.Length > 12)
                {
                    DoctorError.SetError(NIC_txt, "InValid NIC Number");
                }
                else
                {
                    db.OpenConnection();
                    string query = "SELECT * FROM doctor_details WHERE NIC ='" + NIC_txt.Text + "'";
                    MySqlDataAdapter cmd = new MySqlDataAdapter(query, db.getConnection());
                    DataTable dtable = new DataTable();
                    cmd.Fill(dtable);
                    if (dtable.Rows.Count > 0)
                    {
                        DoctorError.SetError(NIC_txt, "Already Registered");
                        db.CloseConnection();
                    }

                }
                if (string.IsNullOrEmpty(Email_txt.Text))
                {
                    DoctorError.SetError(Email_txt, "Fill Doctor's Email Address");
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
                        DoctorError.SetError(Email_txt, "Email is not valid");
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
                    DoctorError.SetError(female_radioButton, "Selecte Doctor's Gender");
                }
                if (string.IsNullOrEmpty(phoneNum_txt.Text))
                {
                    DoctorError.SetError(phoneNum_txt, "Fill Doctor's Phone Number");
                }else if(phoneNum_txt.Text.Length < 10 || phoneNum_txt.Text.Length > 10)
                {
                    DoctorError.SetError(phoneNum_txt, "InValid Phone Number");
                }
                if (string.IsNullOrEmpty(Addres_richTextBox.Text))
                {
                    DoctorError.SetError(Addres_richTextBox, "Fill Doctor's Address");
                }
                if (string.IsNullOrEmpty(doctor_comboBox.Text))
                {
                    DoctorError.SetError(doctor_comboBox, "Selecte Doctor's Position");
                }
                if (string.IsNullOrEmpty(timeOfDay_comboBox.Text))
                {
                    DoctorError.SetError(timeOfDay_comboBox, "Selecte Time Period");
                }
                if (string.IsNullOrEmpty(DoctorError.GetError(Fname_txt)) && string.IsNullOrEmpty(DoctorError.GetError(NIC_txt)) &&string.IsNullOrEmpty(DoctorError.GetError(Email_txt)) && string.IsNullOrEmpty(DoctorError.GetError(Addres_richTextBox)) && string.IsNullOrEmpty(DoctorError.GetError(female_radioButton)) && string.IsNullOrEmpty(DoctorError.GetError(phoneNum_txt)) && string.IsNullOrEmpty(DoctorError.GetError(doctor_comboBox)) && string.IsNullOrEmpty(DoctorError.GetError(timeOfDay_comboBox)))
                {
                    string queir = "INSERT INTO `doctor_details`(`NIC`,`Full_Name`, `Date_of_birth`,`doctor's_position`, `Phone_Number`, `Address`, `Gender`, `Email`, `TimeOfDay`) VALUES ('" + NIC_txt.Text + "','" + "Dr."+Fname_txt.Text + "','" + dateTimePicker.Text + "','" + doctor_comboBox.Text + "','" + phoneNum_txt.Text + "','" + Addres_richTextBox.Text + "','" + selectedValue + "','" + Email_txt.Text + "','" + timeOfDay_comboBox.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(queir, db.getConnection());
                    cmd.ExecuteNonQuery();
                    DialogResult error = MessageBox.Show("Registaion successful", " Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (error.Equals(DialogResult.OK))
                    {
                        Fname_txt.Clear();
                        NIC_txt.Clear();
                        Email_txt.Clear();
                        doctor_comboBox.SelectedItem = null;
                        male_radioButton.Checked = false;
                        female_radioButton.Checked = false;
                        phoneNum_txt.Clear();
                        Addres_richTextBox.Clear();
                        timeOfDay_comboBox.SelectedItem = null;
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
        private void edit_btn_Click(object sender, EventArgs e)
        {
            Edit_Doctor_Details editD = new Edit_Doctor_Details();
            editD.TopLevel = false;
            Doc_Content_panal.Controls.Add(editD);
            editD.BringToFront();
            editD.Show();
        }
    }
}
