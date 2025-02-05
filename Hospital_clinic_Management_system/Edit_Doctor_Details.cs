using MySql.Data.MySqlClient;
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
    public partial class Edit_Doctor_Details : Form
    {
        Connection db = new Connection();
        public Edit_Doctor_Details()
        {
            InitializeComponent();
        }
        private void Exit_lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Edit_Doctor_Details_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT NIC FROM doctor_details", db.getConnection());
            db.OpenConnection();
            MySqlDataReader dr = command.ExecuteReader();
            AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                mycollection.Add(dr.GetString(0));
            }
            NIC_txt.AutoCompleteCustomSource = mycollection;
            db.CloseConnection();
        }
        private void NIC_txt_Leave(object sender, EventArgs e)
        {
            db.OpenConnection();
            string query = "SELECT * FROM doctor_details WHERE NIC ='" + NIC_txt.Text + "'";
            MySqlDataAdapter cmd2 = new MySqlDataAdapter(query, db.getConnection());
            DataTable dtable = new DataTable();
            cmd2.Fill(dtable);
            if (dtable.Rows.Count == 0)
            {
                EditDocError.SetError(NIC_txt, "NIC is not valid");
                db.CloseConnection();
            }
            else
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM doctor_details WHERE NIC ='" + NIC_txt.Text + "'", db.getConnection()))
                {

                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {                      
                        Fname_txt.Text = dr.GetString(dr.GetOrdinal("Full_Name")).ToString();
                        dateTimePicker.Text = dr.GetString(dr.GetOrdinal("Date_of_birth")).ToString();
                        Email_txt.Text = dr.GetString(dr.GetOrdinal("Email")).ToString();
                        string gender = dr.GetString(dr.GetOrdinal("Gender")).ToString();
                        if (gender.Equals("Male"))
                        {
                            male_radioButton.Checked = true;
                        }
                        else
                        {
                            female_radioButton.Checked = true;
                        }
                        phoneNum_txt.Text = dr.GetString(dr.GetOrdinal("Phone_Number")).ToString();
                        Addres_richTextBox.Text = dr.GetString(dr.GetOrdinal("Address")).ToString();
                        doctor_comboBox.Text = dr.GetString(dr.GetOrdinal("doctor's_position")).ToString();
                        timeOfDay_comboBox.Text = dr.GetString(dr.GetOrdinal("TimeOfDay")).ToString();
                    }
                    db.CloseConnection();
                }
            }
        }
        private void update_btn_Click(object sender, EventArgs e)
        {
            string selectedValue = "";
            EditDocError.Clear();
            if (string.IsNullOrEmpty(Fname_txt.Text))
            {
                EditDocError.SetError(Fname_txt, "Fill Doctor's Full Name");
            }
            if (string.IsNullOrEmpty(Email_txt.Text))
            {
                EditDocError.SetError(Email_txt, "Fill Doctor's Emali");
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
                EditDocError.SetError(female_radioButton, "Select Doctor's Gender");
            }
            if (string.IsNullOrEmpty(phoneNum_txt.Text))
            {
                EditDocError.SetError(phoneNum_txt, "Fill Doctor's Phone Number");
            }
            if (string.IsNullOrEmpty(Addres_richTextBox.Text))
            {
                EditDocError.SetError(Addres_richTextBox, "Fill Doctor's Address");
            }
            if (string.IsNullOrEmpty(doctor_comboBox.Text))
            {
                EditDocError.SetError(doctor_comboBox, "Select Doctor's Position");
            }
            if (string.IsNullOrEmpty(timeOfDay_comboBox.Text))
            {
                EditDocError.SetError(timeOfDay_comboBox, "Select Time Period");
            }
            if (string.IsNullOrEmpty(EditDocError.GetError(Fname_txt)) && string.IsNullOrEmpty(EditDocError.GetError(Email_txt)) && string.IsNullOrEmpty(EditDocError.GetError(female_radioButton)) && string.IsNullOrEmpty(EditDocError.GetError(phoneNum_txt)) && string.IsNullOrEmpty(EditDocError.GetError(Addres_richTextBox)) && string.IsNullOrEmpty(EditDocError.GetError(doctor_comboBox)) && string.IsNullOrEmpty(EditDocError.GetError(timeOfDay_comboBox)))
            {
                db.OpenConnection();
                DialogResult error = MessageBox.Show("Are You Sure ? Want You To Change Details?", " Update Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (error.Equals(DialogResult.OK))
                {
                    MySqlCommand cmd2 = new MySqlCommand("UPDATE `doctor_details` SET `Full_Name` = '" + Fname_txt.Text + "' , `Date_of_birth` = '" + dateTimePicker.Text + "', `doctor's_position` = '" + doctor_comboBox.Text + "', `Phone_Number` = '" + phoneNum_txt.Text + "', `Address` = '" + Addres_richTextBox.Text + "', `Gender` = '" + selectedValue + "', `Email` = '" + Email_txt.Text + "', `TimeOfDay` = '" + timeOfDay_comboBox.Text + "' WHERE(`NIC` = '" + NIC_txt.Text + "')", db.getConnection());
                    cmd2.ExecuteNonQuery();
                    DialogResult error2 = MessageBox.Show("Dtails Successful Updated", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (error2.Equals(DialogResult.OK))
                    {
                        NIC_txt.Clear();
                        Fname_txt.Clear();
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
        }
        private void delete_btn_Click(object sender, EventArgs e)
        {
            string selectedValue = "";
            EditDocError.Clear();
            if (string.IsNullOrEmpty(Fname_txt.Text))
            {
                EditDocError.SetError(Fname_txt, "Fill Doctor's Full Name");
            }
            if (string.IsNullOrEmpty(Email_txt.Text))
            {
                EditDocError.SetError(Email_txt, "Fill Doctor's Emali");
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
                EditDocError.SetError(female_radioButton, "Select Doctor's Gender");
            }
            if (string.IsNullOrEmpty(phoneNum_txt.Text))
            {
                EditDocError.SetError(phoneNum_txt, "Fill Doctor's Phone Number");
            }
            if (string.IsNullOrEmpty(Addres_richTextBox.Text))
            {
                EditDocError.SetError(Addres_richTextBox, "Fill Doctor's Address");
            }
            if (string.IsNullOrEmpty(doctor_comboBox.Text))
            {
                EditDocError.SetError(doctor_comboBox, "Select Doctor's Position");
            }
            if (string.IsNullOrEmpty(timeOfDay_comboBox.Text))
            {
                EditDocError.SetError(timeOfDay_comboBox, "Select Time Period");
            }
            if (string.IsNullOrEmpty(EditDocError.GetError(Fname_txt)) && string.IsNullOrEmpty(EditDocError.GetError(Email_txt)) && string.IsNullOrEmpty(EditDocError.GetError(female_radioButton)) && string.IsNullOrEmpty(EditDocError.GetError(phoneNum_txt)) && string.IsNullOrEmpty(EditDocError.GetError(Addres_richTextBox)) && string.IsNullOrEmpty(EditDocError.GetError(doctor_comboBox)) && string.IsNullOrEmpty(EditDocError.GetError(timeOfDay_comboBox)))
            {
                db.OpenConnection();
                DialogResult error = MessageBox.Show("Are You Sure ? Want You To Delete the Details?", "Delete Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (error.Equals(DialogResult.OK))
                {
                    MySqlCommand cmd2 = new MySqlCommand(" DELETE  FROM doctor_details  WHERE `NIC` = '" + NIC_txt.Text + "'", db.getConnection());
                    cmd2.ExecuteNonQuery();
                    DialogResult error2 = MessageBox.Show("Details Successful Delete", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (error2.Equals(DialogResult.OK))
                    {
                        NIC_txt.Clear();
                        Fname_txt.Clear();
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
        }
    }
}
