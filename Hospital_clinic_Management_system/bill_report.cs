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
    public partial class bill_report : Form
    {
        public bill_report(string regID)
        {
            InitializeComponent();
            Connection db = new Connection();
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM bill_details WHERE Rgister_ID ='" + regID + "'";
                MySqlDataAdapter cmd2 = new MySqlDataAdapter(query, db.getConnection());
                DataTable dtable = new DataTable();
                cmd2.Fill(dtable);
                if (dtable.Rows.Count == 1)
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, db.getConnection()))
                    {
                        MySqlDataReader read = cmd.ExecuteReader();
                        if (read.Read())
                        {
                            name_lbl.Text = "Mr/Mrs." + read.GetString(read.GetOrdinal("Full_Name")).ToString();
                            name_lbl.Visible = true;
                            regid_lbl.Text = "Registation ID : " + read.GetString(read.GetOrdinal("Rgister_ID")).ToString();
                            regid_lbl.Visible = true;
                            cost_lbl.Text = "Cost : " + read.GetString(read.GetOrdinal("Cost")).ToString();
                            cost_lbl.Visible = true;
                            if (read.GetString(read.GetOrdinal("Type_of_doctor")).ToString().Equals("Psychologist"))
                            {
                                doc_lbl.Text = "Psychologist Doctor Cost : Rs.3000";
                                doc_lbl.Visible = true;
                            }
                            else if (read.GetString(read.GetOrdinal("Type_of_doctor")).ToString().Equals("Consulting doctor"))
                            {
                                doc_lbl.Text = "Consulting Doctor Cost : Rs.4000";
                                doc_lbl.Visible = true;
                            }
                            else if (read.GetString(read.GetOrdinal("Type_of_doctor")).ToString().Equals("Dentist"))
                            {
                                doc_lbl.Text = "Dentist Doctor Cost : Rs.5000";
                                doc_lbl.Visible = true;
                            }
                            date_lbl.Text = "Date :" + read.GetString(read.GetOrdinal("Date")).ToString();
                            date_lbl.Visible = true;
                            Bill_ID_lbl.Text = "Bill No :" + read.GetString(read.GetOrdinal("Bill_ID")).ToString();
                            Bill_ID_lbl.Visible = true;
                            if (!read.GetString(read.GetOrdinal("Pills_type")).ToString().Equals(" "))
                            {
                                pill_lbl.Text = "Rs.500 for One Types Of Pills , You got : " + read.GetString(read.GetOrdinal("Pills_type")).ToString();
                                pill_lbl.Visible = true;
                            }
                            days_lbl.Text = "hospital charge Rs 1000 ";
                            days_lbl.Visible = true;
                            int age = read.GetInt32(read.GetOrdinal("Age"));
                            if (age <= 15)
                            {
                                if (!age.Equals(""))
                                {
                                    dis_lbl.Text = "You Got 25% Discount";
                                    dis_lbl.Visible = true;
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
        private void exit_lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void printBillDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font1 = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            Font font2 = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            Font font = new Font("Microsoft Sans Serif", 10);

            Brush brush = Brushes.Black;
            Brush brush2 = Brushes.Red;

            e.Graphics.DrawLine(Pens.Black, new Point(100, 10), new Point(800, 10));
            e.Graphics.DrawLine(Pens.Black, new Point(100, 10), new Point(100, 520));
            e.Graphics.DrawLine(Pens.Black, new Point(800, 10), new Point(800, 520));
            e.Graphics.DrawString("LIFE HOSPITAL", font1, brush, new PointF(350, 50));
            e.Graphics.DrawLine(Pens.Black, new Point(150, 120), new Point(750, 120));

            e.Graphics.DrawString(name_lbl.Text, font2, brush, new PointF(150, 150));
            e.Graphics.DrawString(date_lbl.Text, font, brush, new PointF(635, 150));
            e.Graphics.DrawString(regid_lbl.Text, font, brush, new PointF(150, 180));
            e.Graphics.DrawString(Bill_ID_lbl.Text, font, brush, new PointF(630, 180));
            e.Graphics.DrawLine(Pens.Black, new Point(150, 210), new Point(750, 210));

            e.Graphics.DrawString(doc_lbl.Text, font, brush, new PointF(150, 240));
            e.Graphics.DrawString(pill_lbl.Text, font, brush, new PointF(150, 270));
            e.Graphics.DrawString(days_lbl.Text, font, brush, new PointF(150, 300));
            e.Graphics.DrawLine(Pens.Black, new Point(150, 340), new Point(750, 340));

            if (string.IsNullOrEmpty(dis_lbl.Text))
            {
                e.Graphics.DrawString(cost_lbl.Text, font, brush, new PointF(150, 370));
                e.Graphics.DrawLine(Pens.Black, new Point(150, 430), new Point(750, 430));
                e.Graphics.DrawString("Thank You , Come Again!", font1, brush2, new PointF(320, 460));
                e.Graphics.DrawString("Contact : 07i87211716 | 0112356744, website : LIFE Hospital.com", font2, brush, new PointF(200, 490));
                e.Graphics.DrawLine(Pens.Black, new Point(100, 520), new Point(800, 520));

            }
            else
            {
                e.Graphics.DrawString(dis_lbl.Text, font, brush, new PointF(150, 370));
                e.Graphics.DrawString(cost_lbl.Text, font, brush, new PointF(150, 400));
                e.Graphics.DrawLine(Pens.Black, new Point(100, 430), new Point(800, 430));
                e.Graphics.DrawString("Thank You , Come Again!", font1, brush2, new PointF(320, 460));
                e.Graphics.DrawString("Contact : 07i87211716 | 0112356744, website : LIFE Hospital.com", font2, brush, new PointF(200, 490));
                e.Graphics.DrawLine(Pens.Black, new Point(100, 520), new Point(800, 520));
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            PrintDialog printdialog = new PrintDialog();
            printdialog.Document = printBillDocument;
            DialogResult result = printdialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                printBillDocument.Print();
            }
        }
    }
}
