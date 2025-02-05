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
    public partial class Bill_Calculater : Form
    {
        Connection db = new Connection();
        public Bill_Calculater()
        {
            InitializeComponent();  
        }
        private void Bill_Calculater_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT Rgister_ID FROM appointment_details", db.getConnection());
            db.OpenConnection();
            MySqlDataReader dr = command.ExecuteReader();
            AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                mycollection.Add(dr.GetString(0));
            }
            RegID_txt.AutoCompleteCustomSource = mycollection;
            db.CloseConnection();
        }
        private void RegID_txt_Leave(object sender, EventArgs e)
        {
            db.OpenConnection();
            string query = "SELECT * FROM appointment_details WHERE Rgister_ID ='" + RegID_txt.Text + "'";
            MySqlDataAdapter cmd2 = new MySqlDataAdapter(query, db.getConnection());
            DataTable dtable = new DataTable();
            cmd2.Fill(dtable);
            if (dtable.Rows.Count == 0)
            {
                Billerror.SetError(RegID_txt, "Registation ID is not valid");
                db.CloseConnection();
            }
            else
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM appointment_details WHERE Rgister_ID ='" + RegID_txt.Text + "'", db.getConnection()))
                {

                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        NIC_txt.Text = dr.GetString(dr.GetOrdinal("NIC")).ToString();
                        Fname_txt.Text = dr.GetString(dr.GetOrdinal("Full_Name")).ToString();
                        Doctor_comBox.Text = dr.GetString(dr.GetOrdinal("Type_of_doctor")).ToString();
                        age_txt.Text = dr.GetString(dr.GetOrdinal("Age")).ToString();
                    }
                    db.CloseConnection();
                }
            }
        }
        private void Submite_btn_Click(object sender, EventArgs e)
        {           
            try
            {
                Billerror.Clear();
                if (string.IsNullOrEmpty(RegID_txt.Text))
                {
                    Billerror.SetError(RegID_txt, "Enter register id");
                }
                else
                {
                    db.OpenConnection();
                    string query = "SELECT * FROM appointment_details WHERE Rgister_ID ='" + RegID_txt.Text + "'";
                    MySqlDataAdapter cmd = new MySqlDataAdapter(query, db.getConnection());
                    DataTable dtable = new DataTable();
                    cmd.Fill(dtable);
                    if (dtable.Rows.Count == 0)
                    {
                        Billerror.SetError(RegID_txt, "Registation ID is not valid");
                        db.CloseConnection();
                    }
                    else
                    {
                        db.OpenConnection();
                        MySqlDataAdapter cmd2 = new MySqlDataAdapter("SELECT * FROM bill_details WHERE Rgister_ID ='" + RegID_txt.Text + "'", db.getConnection());
                        DataTable dtable2 = new DataTable();
                        cmd2.Fill(dtable2);
                        if (dtable2.Rows.Count > 0)
                        {
                            Billerror.SetError(RegID_txt, "Registation ID is already used");
                            db.CloseConnection();
                        }
                    }
                }
                if (string.IsNullOrEmpty(Pills_type_comboBox.Text))
                {
                    Billerror.SetError(Pills_type_comboBox, "Enter Number of Pills types");
                }             
                if (string.IsNullOrEmpty(Billerror.GetError(Pills_type_comboBox)) &&  string.IsNullOrEmpty(Billerror.GetError(RegID_txt)))
                {
                    int hospital_charges_onlymedicnine = 1000;
                    int AGE = Convert.ToInt32(age_txt.Text);
                    int one_PillsType = 500;
                    double cost = 0;
                    int[] DocPriceArray = { 3000, 4000, 5000 };
                    string[] DocArray = { "Psychologist", "Consulting doctor", "Dentist" };
                    string[] numPillsArray = { "no Medicine", "1 Pills type", "2 Pills type", "3 Pills type" };
                 
                        for (int x = 0; x < 3; x++)
                        {
                            if (Doctor_comBox.SelectedItem.ToString().Equals(DocArray[x]))
                            {
                                for (int y = 0; y < 4; y++)
                                {
                                    if (Pills_type_comboBox.SelectedItem.ToString().Equals(numPillsArray[y]))
                                    {
                                        cost = hospital_charges_onlymedicnine + DocPriceArray[x] + (one_PillsType * y);
                                        if (AGE <= 15)
                                        {
                                            cost = cost - (cost * 0.25);
                                        }

                                    }
                                }
                            }
                        }
                    db.OpenConnection();
                    string StartID = "2023LHB";
                    MySqlCommand cdm = new MySqlCommand("SELECT COUNT(Bill_ID) FROM bill_details", db.getConnection());
                    int readID = Convert.ToInt32(cdm.ExecuteScalar());
                    readID++;
                    string billIdBuilder = StartID + readID;

                    string queir = "INSERT INTO `bill_details`(`Bill_ID`,`Cost`, `Full_Name`,`Type_of_doctor`, `Date`, `Pills_type` , `Age`,`NIC`,`Rgister_ID`) VALUES ('" + billIdBuilder + "','" + cost + "','" + Fname_txt.Text + "','" + Doctor_comBox.Text + "','" + dateTimePicker.Text + "','" + Pills_type_comboBox.Text + "','" + age_txt.Text + "','" + NIC_txt.Text + "','" + RegID_txt.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(queir, db.getConnection());
                    cmd.ExecuteNonQuery();
                    DialogResult error = MessageBox.Show("Cost is :" + cost, " Patient Total amount", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (error.Equals(DialogResult.OK))
                    {
                        RegID_txt.Clear();
                        Fname_txt.Clear();
                        Doctor_comBox.SelectedItem = null;
                        age_txt.Clear();
                        NIC_txt.Clear();
                        Pills_type_comboBox.SelectedItem = null;                      
                        dateTimePicker.Value = DateTime.Now;
                    }
                }
            }
            catch(Exception ex)
            {
               //MessageBox.Show(ex.Message);
               MessageBox.Show(" Server not respond", " 502 Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);             
            }
            finally
            {
                db.CloseConnection();
            }
        }
        private void report_btn_Click(object sender, EventArgs e)
        {
            Billerror.Clear();
            if (string.IsNullOrEmpty(RegID_txt.Text))
            {
                Billerror.SetError(RegID_txt,"Fill Registation Number");
            }
            if (string.IsNullOrEmpty(Billerror.GetError(RegID_txt)))
            {
                bill_report bill = new bill_report(RegID_txt.Text);
                bill.TopLevel = false;
                Content_panel.Controls.Add(bill);
                bill.BringToFront();
                bill.Show();
                RegID_txt.Clear();
                Fname_txt.Clear();
                Doctor_comBox.SelectedItem = null;
                age_txt.Clear();
                NIC_txt.Clear();
                Pills_type_comboBox.SelectedItem = null;
            }
        }
    }
}
