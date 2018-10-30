using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.IO;
using System.Threading;
using System.Globalization;

namespace MB_trans
{
    public partial class FormFirma : Form
    {
        string connection = "";
        public FormFirma()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-us", false);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us", false);

            TextReader tr = new StreamReader("c:\\Program files\\IT\\MB\\conn.txt");
            connection = tr.ReadLine();
            tr.Close();


            InitializeComponent();
            ucitaj_firmu();
        }

        private void ucitaj_firmu()
        {
            string query1 = "SELECT        id, naziv, mesto, adresa, PIB FROM            firma";

            SqlDataAdapter myAdapter1 = new SqlDataAdapter(query1, connection);
            DataTable idData1 = new DataTable();

            myAdapter1.Fill(idData1);
            comboBox1.DataSource = idData1;
            comboBox1.DisplayMember = "naziv";
            comboBox1.ValueMember = "id";
          

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {

                string query1 = "SELECT        TOP (200) id, duznik_naziv as [Naziv], duznik_racun as [Ziro racun], duznik_model as Model, duznik_poziv as [Poziv na broj] FROM  duznik " +
                                " WHERE        (firma_id = " + comboBox1.SelectedValue + ")";

                SqlDataAdapter myAdapter1 = new SqlDataAdapter(query1, connection);
                DataTable idData1 = new DataTable();

                myAdapter1.Fill(idData1);
                dataGridView1.DataSource = idData1;
                //dataGridView1.AutoSize = true;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dataGridView1.Columns["id"].Visible = false;
            }
            catch { }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            string naziv = (dataGridView1.CurrentRow.Cells["Naziv"].Value.ToString());
            
            string racun = (dataGridView1.CurrentRow.Cells["Ziro racun"].Value.ToString());
            string model = (dataGridView1.CurrentRow.Cells["Model"].Value.ToString());
            string poziv = (dataGridView1.CurrentRow.Cells["Poziv na broj"].Value.ToString());
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                string query = "UPDATE duznik set duznik_naziv = N'" + naziv + "', duznik_racun = N'" + racun + "', duznik_model = N'" + model + "', duznik_poziv = N'" + poziv + "' " +
                               " WHERE        (id = " + id + ")";
                SqlCommand commUp = new SqlCommand();
                commUp.Connection = conn;
                commUp.CommandText = query;
                commUp.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
