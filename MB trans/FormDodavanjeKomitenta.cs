using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Globalization;
using System.Data.SqlClient;
using System.Drawing.Printing;

using System.Runtime.InteropServices;

namespace MB_trans
{
    public partial class FormDodavanjeKomitenta : Form
    {
        string connection = "";
        public FormDodavanjeKomitenta()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-us", false);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us", false);

            TextReader tr = new StreamReader("c:\\Program files\\IT\\MB\\conn.txt");
            connection = tr.ReadLine();
            tr.Close();

            InitializeComponent();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    string queryUnesi = "INSERT INTO  primalac(primalac_naziv, primalac_mesto, primalac_ulica, primalac_broj, primalac_racun) " +
                                        " VALUES        (N'" + textBox1.Text + "',N'" + textBox2.Text + "',N'" + textBox3.Text + "',N'" + textBox4.Text + "',N'" + textBox5.Text + "')";

                    SqlCommand commUnosi = new SqlCommand();
                    commUnosi.CommandText = queryUnesi;
                    commUnosi.Connection = conn;
                    commUnosi.ExecuteNonQuery();

                    conn.Close();
                }
                MessageBox.Show("Uspešno unet komitent", "Uspešno");
            }
            catch
            {
                MessageBox.Show("Dosšlo je do greške", "Greška");
            }
        }
    }
}
