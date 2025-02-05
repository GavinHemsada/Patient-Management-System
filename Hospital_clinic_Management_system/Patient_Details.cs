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
    public partial class Patient_Details : Form
    {
        Connection db = new Connection();
        public Patient_Details()
        {
            InitializeComponent();
        }
        private void Patient_Details_Load(object sender, EventArgs e)
        {
            db.OpenConnection();            
            MySqlCommand command = new MySqlCommand("SELECT NIC FROM appointment_details", db.getConnection());
            MySqlDataReader dr = command.ExecuteReader();
            AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                mycollection.Add(dr.GetString(0));
            }
            NIC_txt.AutoCompleteCustomSource = mycollection;
            db.CloseConnection();
        }
        private void history_btn_Click(object sender, EventArgs e)
        {
            name_lbl.Visible = false;
            regid_lbl.Visible = false;
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM bill_details WHERE NIC ='" + NIC_txt.Text + "'";
                MySqlDataAdapter cmd = new MySqlDataAdapter(query, db.getConnection());
                DataTable dtable = new DataTable();
                cmd.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    dataGridView1.Rows.Clear();
                    using (MySqlCommand cmd2 = new MySqlCommand(query, db.getConnection()))
                    {
                        MySqlDataReader reader = cmd2.ExecuteReader();
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader.GetString(reader.GetOrdinal("Rgister_ID")).ToString(), reader.GetString(reader.GetOrdinal("Full_Name")).ToString(), reader.GetString(reader.GetOrdinal("Type_of_doctor")).ToString(), reader.GetString(reader.GetOrdinal("NIC")).ToString(), reader.GetString(reader.GetOrdinal("Date")).ToString(), reader.GetString(reader.GetOrdinal("Cost")).ToString());
                        }
                        dataGridView1.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Enter Correct NIC Number And Date", "Wrrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void findID_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM appointment_details WHERE NIC ='" + NIC_txt.Text + "'AND Date = '" + dateTimePicker.Text + "'";
                MySqlDataAdapter cmd = new MySqlDataAdapter(query, db.getConnection());
                DataTable dtable = new DataTable();
                cmd.Fill(dtable);
                if (dtable.Rows.Count == 1)
                {
                    dataGridView1.Rows.Clear();
                    using (MySqlCommand cmd2 = new MySqlCommand(query, db.getConnection()))
                    {
                        MySqlDataReader reader = cmd2.ExecuteReader();
                        if (reader.Read())
                        {
                            name_lbl.Text = " Mr/Mrs." + reader.GetString(reader.GetOrdinal("Full_Name")).ToString();
                            name_lbl.Visible = true;
                            regid_lbl.Text = " Registation ID : " + reader.GetString(reader.GetOrdinal("Rgister_ID")).ToString();
                            regid_lbl.Visible = true;
                            PrintDialog printdialog = new PrintDialog();
                            printdialog.Document = printDocument_findID;
                            DialogResult result2 = printdialog.ShowDialog();
                            if (result2 == DialogResult.OK)
                            {
                                printDocument_findID.Print();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Enter Correct NIC Number And Date", "Wrrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void findID_btn_MouseHover(object sender, EventArgs e)
        {
            dateTimePicker.Visible = true;
            date_lbl.Visible = true;
            text_lbl.Visible = true;
        }
        private void history_btn_MouseHover(object sender, EventArgs e)
        {
            dateTimePicker.Visible = false;
            date_lbl.Visible = false;
            text_lbl.Visible = false;
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            text_lbl.Visible = false;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            try
            {
                db.OpenConnection();
                DialogResult error = MessageBox.Show("Are You Sure ? Want You To Delete the Details?", "Delete Details", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (error.Equals(DialogResult.OK))
                {
                    string regid="";
                    string query = "SELECT * FROM appointment_details WHERE NIC ='" + NIC_txt.Text + "'AND Date = '" + dateTimePicker.Text + "'";
                    MySqlDataAdapter cmd = new MySqlDataAdapter(query, db.getConnection());
                    DataTable dtable = new DataTable();
                    cmd.Fill(dtable);
                    if (dtable.Rows.Count == 1)
                    {
                        using (MySqlCommand cmd2 = new MySqlCommand(query, db.getConnection()))
                        {
                            MySqlDataReader reader = cmd2.ExecuteReader();
                            if (reader.Read())
                            {  
                                regid = reader.GetString(reader.GetOrdinal("Rgister_ID")).ToString();
                                reader.Close();
                                string query2 = "SELECT * FROM bill_details WHERE Rgister_ID = '" + regid + "'";
                                MySqlDataAdapter cmd3 = new MySqlDataAdapter(query2, db.getConnection());
                                DataTable dtable2 = new DataTable();
                                cmd3.Fill(dtable2);
                                if (dtable2.Rows.Count == 0)
                                {
                                    MySqlCommand cmd1 = new MySqlCommand(" DELETE  FROM appointment_details  WHERE NIC = '" + NIC_txt.Text + "'AND Date = '" + dateTimePicker.Text + "'", db.getConnection());
                                    cmd1.ExecuteNonQuery();
                                    MessageBox.Show("Details Successful Delete", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Records are Used to Calculate Bill", "Can't Delete Records ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
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

        private void cancel(object sender, EventArgs e)
        {
            dateTimePicker.Visible = true;
            date_lbl.Visible = true;
            text_lbl.Visible = true;
        }

        private void printDocument_findID_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font1 = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            Brush brush = Brushes.Black;
            e.Graphics.DrawString(name_lbl.Text + " Youer Register ID is ", font1, brush, new PointF(100, 50));
            e.Graphics.DrawString(regid_lbl.Text, font1, brush, new PointF(150, 100));
        }
    }
}
