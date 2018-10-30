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
    public partial class FormKomitenti : Form
    {
        string connection = "";

        public FormKomitenti()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-us", false);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us", false);

            TextReader tr = new StreamReader("c:\\Program files\\IT\\MB\\conn.txt");
            connection = tr.ReadLine();
            tr.Close();

            InitializeComponent();

            ucitaj_komitente();
        }
        private void ucitaj_komitente()
        {
            string query1 = "SELECT        id, primalac_naziv as [Naziv], primalac_mesto as [Mesto], primalac_ulica as [Ulica], primalac_broj as [Broj], primalac_racun as [Ziro racun], prmalac_model as [Model], primalac_poziv as [Poziv na broj] " +
                            " FROM            primalac";

            SqlDataAdapter myAdapter1 = new SqlDataAdapter(query1, connection);
            DataTable idData1 = new DataTable();

            myAdapter1.Fill(idData1);
            dataGridView1.DataSource = idData1;
            //dataGridView1.AutoSize = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView1.Columns["id"].Visible = false;


        }
        private void ucitaj_komitente(string naziv)
        {
            string query1 = "SELECT        id, primalac_naziv as [Naziv], primalac_mesto as [Mesto], primalac_ulica as [Ulica], primalac_broj as [Broj], primalac_racun as [Ziro racun], prmalac_model as [Model], primalac_poziv as [Poziv na broj] " +
                            " FROM            primalac" +
                            " WHERE        (primalac_naziv LIKE N'%" + naziv + "%')";

            SqlDataAdapter myAdapter1 = new SqlDataAdapter(query1, connection);
            DataTable idData1 = new DataTable();

            myAdapter1.Fill(idData1);
            dataGridView1.DataSource = idData1;
            //dataGridView1.AutoSize = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView1.Columns["id"].Visible = false;


        }
        public GroupBox GetGroupBox()
        {
            return groupBox1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucitaj_komitente(txtNaziv.Text);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                string querydelete = "delete from primalac where id = " + dataGridView1.CurrentRow.Cells["id"].Value.ToString() + "";
                SqlCommand commUp = new SqlCommand();
                commUp.Connection = conn;
                commUp.CommandText = querydelete;
                commUp.ExecuteNonQuery();
                conn.Close();
            }
            ucitaj_komitente();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            string naziv = (dataGridView1.CurrentRow.Cells["naziv"].Value.ToString());
            string mesto = (dataGridView1.CurrentRow.Cells["mesto"].Value.ToString());
            string ulica = (dataGridView1.CurrentRow.Cells["ulica"].Value.ToString());
            string broj = (dataGridView1.CurrentRow.Cells["broj"].Value.ToString());
            string racun = (dataGridView1.CurrentRow.Cells["Ziro racun"].Value.ToString());
            string model = (dataGridView1.CurrentRow.Cells["model"].Value.ToString());
            string poziv = (dataGridView1.CurrentRow.Cells["Poziv na broj"].Value.ToString());
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                string query = "UPDATE primalac set primalac_naziv = N'" + naziv + "', primalac_mesto = N'" + mesto + "', primalac_ulica = N'" + ulica + "', primalac_broj = N'" + broj + "', primalac_racun = N'" + racun + "', prmalac_model = N'" + model + "', primalac_poziv = N'" + poziv + "' " +
                               " WHERE        (id = " + id + ")";
                SqlCommand commUp = new SqlCommand();
                commUp.Connection = conn;
                commUp.CommandText = query;
                commUp.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FormDodavanjeKomitenta dk = new FormDodavanjeKomitenta();
            dk.ShowDialog();
        }




    }
}
