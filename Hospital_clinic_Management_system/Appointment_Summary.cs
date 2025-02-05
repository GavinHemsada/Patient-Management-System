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
    public partial class Appointment_Summary : Form
    {
        Connection db = new Connection();
        public Appointment_Summary()
        {
            InitializeComponent();
        }
        private void Submite_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                string query = "SELECT * FROM bill_details";
                if (Month_checkBox.Checked && year_checkBox.Checked && doctor_checkBox.Checked)
                {
                    if (string.IsNullOrEmpty(month_comboBox.Text))
                    {
                        summaryError.SetError(month_comboBox, "Select month Number");
                    }
                    if (string.IsNullOrEmpty(Year_text.Text))
                    {
                        summaryError.SetError(Year_text, "Enter Year");
                    }
                    if (string.IsNullOrEmpty(doctor_comboBox.Text))
                    {
                        summaryError.SetError(doctor_comboBox, "Select Doctor Type");
                    }
                    if (string.IsNullOrEmpty(summaryError.GetError(month_comboBox)) && string.IsNullOrEmpty(summaryError.GetError(Year_text)) && string.IsNullOrEmpty(summaryError.GetError(doctor_comboBox)))
                    {
                        db.OpenConnection();
                        using (MySqlCommand cmd = new MySqlCommand(query, db.getConnection()))
                        {
                            MySqlDataReader reader = cmd.ExecuteReader();
                            string date;
                            int total = 0;
                            while (reader.Read())
                            {
                                date = reader.GetString("Date");
                                Char[] devided = { '/' };
                                string[] datearray = date.Split(devided);
                                if (reader.GetString("Type_of_doctor").Equals(doctor_comboBox.Text) && datearray[2].Equals(Year_text.Text) && datearray[0].Equals(month_comboBox.Text))
                                {
                                    total = total + reader.GetInt32(reader.GetOrdinal("Cost"));
                                    dataGridView1.Rows.Add(reader.GetString(reader.GetOrdinal("Rgister_ID")).ToString(), reader.GetString(reader.GetOrdinal("Cost")).ToString(), reader.GetString(reader.GetOrdinal("Type_of_doctor")).ToString(), reader.GetString(reader.GetOrdinal("Date")).ToString());
                                    dataGridView1.Visible = true;
                                }
                            }
                            if (total.Equals(0))
                            {
                                MessageBox.Show("Don't have a Records", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                cost_lbl.Text = "Total Cost is : "+ total.ToString();
                                cost_lbl.Visible = true;
                            }
                        }
                        db.CloseConnection();
                    }
                }
                else if (Month_checkBox.Checked && year_checkBox.Checked)
                {
                    if (string.IsNullOrEmpty(month_comboBox.Text))
                    {
                        summaryError.SetError(month_comboBox, "Select month Number");
                    }
                    if (string.IsNullOrEmpty(Year_text.Text))
                    {
                        summaryError.SetError(Year_text, "Enter Year");
                    }
                    if (string.IsNullOrEmpty(summaryError.GetError(month_comboBox)) && string.IsNullOrEmpty(summaryError.GetError(Year_text)))
                    {
                        db.OpenConnection();
                        using (MySqlCommand cmd = new MySqlCommand(query, db.getConnection()))
                        {
                            MySqlDataReader reader = cmd.ExecuteReader();
                            string date;
                            int total = 0;
                            while (reader.Read())
                            {
                                date = reader.GetString("Date");
                                Char[] devided = { '/' };
                                string[] datearray = date.Split(devided);
                                if (datearray[0].Equals(month_comboBox.Text) && datearray[2].Equals(Year_text.Text))
                                {
                                    total = total + reader.GetInt32(reader.GetOrdinal("Cost"));
                                    dataGridView1.Rows.Add(reader.GetString(reader.GetOrdinal("Rgister_ID")).ToString(), reader.GetString(reader.GetOrdinal("Cost")).ToString(), reader.GetString(reader.GetOrdinal("Type_of_doctor")).ToString(), reader.GetString(reader.GetOrdinal("Date")).ToString());
                                    dataGridView1.Visible = true;
                                }
                            }
                            if (total.Equals(0))
                            {
                                MessageBox.Show("Don't have a Records", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                cost_lbl.Text = "Total Cost is : " + total.ToString();
                                cost_lbl.Visible = true;
                            }
                        }
                        db.CloseConnection();
                    }
                }
                else if (doctor_checkBox.Checked && year_checkBox.Checked)
                {
                    if (string.IsNullOrEmpty(Year_text.Text))
                    {
                        summaryError.SetError(Year_text, "Enter Year");
                    }
                    if (string.IsNullOrEmpty(doctor_comboBox.Text))
                    {
                        summaryError.SetError(doctor_comboBox, "Select Doctor Type");
                    }
                    if (string.IsNullOrEmpty(summaryError.GetError(Year_text)) && string.IsNullOrEmpty(summaryError.GetError(doctor_comboBox)))
                    {
                        db.OpenConnection();
                        using (MySqlCommand cmd = new MySqlCommand(query, db.getConnection()))
                        {
                            MySqlDataReader reader = cmd.ExecuteReader();
                            string date;
                            int total = 0;
                            while (reader.Read())
                            {
                                date = reader.GetString("Date");
                                Char[] devided = { '/' };
                                string[] datearray = date.Split(devided);
                                if (reader.GetString("Type_of_doctor").Equals(doctor_comboBox.Text) && datearray[2].Equals(Year_text.Text))
                                {
                                    total = total + reader.GetInt32(reader.GetOrdinal("Cost"));
                                    dataGridView1.Rows.Add(reader.GetString(reader.GetOrdinal("Rgister_ID")).ToString(), reader.GetString(reader.GetOrdinal("Cost")).ToString(), reader.GetString(reader.GetOrdinal("Type_of_doctor")).ToString(), reader.GetString(reader.GetOrdinal("Date")).ToString());
                                    dataGridView1.Visible = true;
                                }
                            }
                            if (total.Equals(0))
                            {
                                MessageBox.Show("Don't have a Records", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                cost_lbl.Text = "Total Cost is : " + total.ToString();
                                cost_lbl.Visible = true;
                            }
                        }
                        db.CloseConnection();
                    }
                }
                else if (Month_checkBox.Checked && doctor_checkBox.Checked)
                {
                    if (string.IsNullOrEmpty(month_comboBox.Text))
                    {
                        summaryError.SetError(month_comboBox, "Select month Number");
                    }
                    if (string.IsNullOrEmpty(doctor_comboBox.Text))
                    {
                        summaryError.SetError(doctor_comboBox, "Select Doctor Type");
                    }
                    if (string.IsNullOrEmpty(summaryError.GetError(month_comboBox)) && string.IsNullOrEmpty(summaryError.GetError(doctor_comboBox)))
                    {
                        db.OpenConnection();
                        using (MySqlCommand cmd = new MySqlCommand(query, db.getConnection()))
                        {
                            MySqlDataReader reader = cmd.ExecuteReader();
                            string date;
                            int total = 0;
                            while (reader.Read())
                            {
                                date = reader.GetString("Date");
                                Char[] devided = { '/' };
                                string[] datearray = date.Split(devided);
                                if (datearray[0].Equals(month_comboBox.Text) && reader.GetString("Type_of_doctor").Equals(doctor_comboBox.Text))
                                {
                                    total = total + reader.GetInt32(reader.GetOrdinal("Cost"));
                                    dataGridView1.Rows.Add(reader.GetString(reader.GetOrdinal("Rgister_ID")).ToString(), reader.GetString(reader.GetOrdinal("Cost")).ToString(), reader.GetString(reader.GetOrdinal("Type_of_doctor")).ToString(), reader.GetString(reader.GetOrdinal("Date")).ToString());
                                    dataGridView1.Visible = true;
                                }
                            }
                            if (total.Equals(0))
                            {
                                MessageBox.Show("Don't have a Records", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                cost_lbl.Text = "Total Cost is : " + total.ToString();
                                cost_lbl.Visible = true;
                            }
                        }
                        db.CloseConnection();
                    }
                }
                else if (Month_checkBox.Checked)
                {
                    if (string.IsNullOrEmpty(month_comboBox.Text))
                    {
                        summaryError.SetError(month_comboBox, "Select month Number");
                    }
                    if (string.IsNullOrEmpty(summaryError.GetError(month_comboBox)))
                    {
                        db.OpenConnection();
                        using (MySqlCommand cmd = new MySqlCommand(query, db.getConnection()))
                        {
                            MySqlDataReader reader = cmd.ExecuteReader();
                            string date;
                            int total = 0;
                            while (reader.Read())
                            {
                                date = reader.GetString("Date");
                                Char[] devided = { '/' };
                                string[] datearray = date.Split(devided);
                                if (datearray[0].Equals(month_comboBox.Text))
                                {
                                    total = total + reader.GetInt32(reader.GetOrdinal("Cost"));
                                    dataGridView1.Rows.Add(reader.GetString(reader.GetOrdinal("Rgister_ID")).ToString(), reader.GetString(reader.GetOrdinal("Cost")).ToString(), reader.GetString(reader.GetOrdinal("Type_of_doctor")).ToString(), reader.GetString(reader.GetOrdinal("Date")).ToString());
                                    dataGridView1.Visible = true;
                                }
                            }
                            if (total.Equals(0))
                            {
                                MessageBox.Show("Don't have a Records", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                cost_lbl.Text = "Total Cost is : " + total.ToString();
                                cost_lbl.Visible = true;
                            }
                        }
                        db.CloseConnection();
                    }
                }
                else if (year_checkBox.Checked)
                {
                    if (string.IsNullOrEmpty(Year_text.Text))
                    {
                        summaryError.SetError(Year_text, "Enter Year");
                    }
                    if (string.IsNullOrEmpty(summaryError.GetError(Year_text)))
                    {
                        db.OpenConnection();
                        using (MySqlCommand cmd = new MySqlCommand(query, db.getConnection()))
                        {
                            MySqlDataReader reader = cmd.ExecuteReader();
                            string date;
                            int total = 0;
                            while (reader.Read())
                            {
                                date = reader.GetString("Date");
                                Char[] devided = { '/' };
                                string[] datearray = date.Split(devided);
                                if (datearray[2].Equals(Year_text.Text))
                                {
                                    total = total + reader.GetInt32(reader.GetOrdinal("Cost"));
                                    dataGridView1.Rows.Add(reader.GetString(reader.GetOrdinal("Rgister_ID")).ToString(), reader.GetString(reader.GetOrdinal("Cost")).ToString(), reader.GetString(reader.GetOrdinal("Type_of_doctor")).ToString(), reader.GetString(reader.GetOrdinal("Date")).ToString());
                                    dataGridView1.Visible = true;
                                }
                            }
                            if (total.Equals(0))
                            {
                                MessageBox.Show("Don't have a Records", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                cost_lbl.Text = "Total Cost is : " + total.ToString();
                                cost_lbl.Visible = true;
                            }
                        }
                        db.CloseConnection();
                    }
                }
                else if (doctor_checkBox.Checked)
                {
                    if (string.IsNullOrEmpty(doctor_comboBox.Text))
                    {
                        summaryError.SetError(doctor_comboBox, "Select Doctor Type");
                    }
                    if (string.IsNullOrEmpty(summaryError.GetError(doctor_comboBox)))
                    {
                        db.OpenConnection();
                        using (MySqlCommand cmd = new MySqlCommand(query, db.getConnection()))
                        {
                            MySqlDataReader reader = cmd.ExecuteReader();
                            int total = 0;
                            while (reader.Read())
                            {
                                if (reader.GetString("Type_of_doctor").Equals(doctor_comboBox.Text))
                                {
                                    total = total + reader.GetInt32(reader.GetOrdinal("Cost"));
                                    dataGridView1.Rows.Add(reader.GetString(reader.GetOrdinal("Rgister_ID")).ToString(), reader.GetString(reader.GetOrdinal("Cost")).ToString(), reader.GetString(reader.GetOrdinal("Type_of_doctor")).ToString(), reader.GetString(reader.GetOrdinal("Date")).ToString());
                                    dataGridView1.Visible = true;
                                }
                            }
                            if (total.Equals(0))
                            {
                                MessageBox.Show("Don't have a Records", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                cost_lbl.Text = "Total Cost is : " + total.ToString();
                                cost_lbl.Visible = true;
                            }
                        }
                        db.CloseConnection();
                    }
                }
                else
                {
                    db.OpenConnection();
                    using (MySqlCommand cmd = new MySqlCommand(query, db.getConnection()))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        int total = 0;
                        while (reader.Read())
                        {
                            total = total + reader.GetInt32(reader.GetOrdinal("Cost"));
                            dataGridView1.Rows.Add(reader.GetString(reader.GetOrdinal("Rgister_ID")).ToString(), reader.GetString(reader.GetOrdinal("Cost")).ToString(), reader.GetString(reader.GetOrdinal("Type_of_doctor")).ToString(), reader.GetString(reader.GetOrdinal("Date")).ToString());
                            dataGridView1.Visible = true;
                        }
                        cost_lbl.Text = "Total Cost is : " + total.ToString();
                        cost_lbl.Visible = true;
                    }
                    db.CloseConnection();
                }
            }
            catch
            {
                MessageBox.Show(" Server not respond", " 502 Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Month_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Month_checkBox.Checked)
            {
                month_comboBox.Visible = true;
                month_lbl.Visible = true;
            }
            else
            {
                month_comboBox.Visible = false;
                month_lbl.Visible = false;
            }
        }
        private void year_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (year_checkBox.Checked)
            {
                Year_text.Visible = true;
                year_lbl.Visible = true;
            }
            else
            {
                Year_text.Visible = false;
                year_lbl.Visible = false;
            }
        }
        private void doctor_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (doctor_checkBox.Checked)
            {
                doctor_comboBox.Visible = true;
                doctor_lbl.Visible = true;
            }
            else
            {
                doctor_comboBox.Visible = false;
                doctor_lbl.Visible = false;
            }
        }
    }
}
