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

using System.Drawing.Printing;

using System.Runtime.InteropServices;

namespace MB_trans
{
    public partial class FormNalog : Form
    {
        string connection = "";

        public FormNalog()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-us", false);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us", false);

            TextReader tr = new StreamReader("c:\\Program files\\IT\\MB\\conn.txt");
            connection = tr.ReadLine();
            tr.Close();

            InitializeComponent();
            OnStart();
        }

        private void OnStart()
        {
            //dateTimePicker1.Value = new DateTime(int.Parse(godina.ToString().Substring(0, 4)), DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            txtSvrhaPlacanja.Text = "";
            txtIznos.Text = "0.00";
            textBox1.Text = "";
            textBox9.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            //platilac
            string query1 = "SELECT id, naziv, mesto, adresa, PIB, naziv + ', ' + mesto + ',' + adresa AS dis FROM   firma";
            SqlDataAdapter myAdapter1 = new SqlDataAdapter(query1, connection);
            DataTable idData1 = new DataTable();


            myAdapter1.Fill(idData1);
            cbPlatilac.DataSource = idData1;
            cbPlatilac.DisplayMember = "dis";
            cbPlatilac.ValueMember = "id";
            cbPlatilac.SelectedIndex = -1;

            //primalac
            string query2 = " SELECT   id, primalac_naziv, primalac_mesto, primalac_ulica, primalac_broj, primalac_racun, " +
                " prmalac_model, primalac_poziv,primalac_naziv + ',' + primalac_mesto + ',' + primalac_ulica + ',' + primalac_broj AS dis FROM primalac";
            SqlDataAdapter myAdapter2 = new SqlDataAdapter(query2, connection);
            DataTable idData2 = new DataTable();


            myAdapter2.Fill(idData2);
            cbPrimalac.DataSource = idData2;
            cbPrimalac.DisplayMember = "dis";
            cbPrimalac.ValueMember = "id";
            cbPrimalac.SelectedIndex = -1;

            //ziro platilac
            string query3 = " SELECT id, duznik_naziv, duznik_racun, duznik_model, duznik_poziv, firma_id FROM  duznik";
            SqlDataAdapter myAdapter3 = new SqlDataAdapter(query3, connection);
            DataTable idData3 = new DataTable();


            myAdapter3.Fill(idData3);
            cbPlatilacRacun.DataSource = idData3;
            cbPlatilacRacun.DisplayMember = "duznik_racun";
            cbPlatilacRacun.ValueMember = "firma_id";
            cbPlatilacRacun.SelectedIndex = -1;

            //ziro primalac
            string query4 = "SELEct id, primalac_naziv, primalac_mesto, primalac_ulica, primalac_broj, primalac_racun, prmalac_model, primalac_poziv FROM            primalac";
            SqlDataAdapter myAdapter4 = new SqlDataAdapter(query4, connection);
            DataTable idData4 = new DataTable();


            myAdapter4.Fill(idData4);
            cbPrimaocRacun.DataSource = idData4;
            cbPrimaocRacun.DisplayMember = "primalac_racun";
            cbPrimaocRacun.ValueMember = "id";
            cbPrimaocRacun.SelectedIndex = -1;

            //stampaci
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cbStampac.Items.Add(printer);
            }
            cbStampac.SelectedIndex = 0;
        }

        private void cbPlatilac_Leave(object sender, EventArgs e)
        {
            //platilac
            try
            {
                string query1 = "SELECT        TOP (200) id, duznik_naziv, duznik_racun, duznik_model, duznik_poziv, firma_id,duznik_naziv +': '+ duznik_racun as dis " +
                                " FROM            duznik " +
                                " WHERE        (firma_id = " + cbPlatilac.SelectedValue + ")";
                SqlDataAdapter myAdapter1 = new SqlDataAdapter(query1, connection);
                DataTable idData1 = new DataTable();

                myAdapter1.Fill(idData1);
                cbPlatilacRacun.DataSource = idData1;
                cbPlatilacRacun.DisplayMember = "duznik_racun";
                cbPlatilacRacun.ValueMember = "id";
                cbPlatilacRacun.SelectedIndex = 0;

            }
            catch
            {
                string query1 = "SELECT        TOP (200) id, duznik_naziv, duznik_racun, duznik_model, duznik_poziv, firma_id,duznik_naziv +': '+ duznik_racun as dis " +
                                    " FROM            duznik ";

                SqlDataAdapter myAdapter1 = new SqlDataAdapter(query1, connection);
                DataTable idData1 = new DataTable();

                myAdapter1.Fill(idData1);
                cbPlatilacRacun.DataSource = idData1;
                cbPlatilacRacun.DisplayMember = "duznik_racun";
                cbPlatilacRacun.ValueMember = "firma_id";
                cbPlatilacRacun.SelectedIndex = -1;
            }
            //catch { }
        }

        private void cbPrimalac_Leave(object sender, EventArgs e)
        {
            try
            {
                string query1 = "SELECT        TOP (200) id, primalac_naziv, primalac_mesto, primalac_ulica, primalac_broj, primalac_racun, prmalac_model, primalac_poziv " +
                               " FROM  primalac where id = " + cbPrimalac.SelectedValue + "";
                SqlDataAdapter myAdapter1 = new SqlDataAdapter(query1, connection);
                DataTable idData1 = new DataTable();

                myAdapter1.Fill(idData1);

                txtPrimaocRacun.Text = idData1.Rows[0]["primalac_racun"].ToString();
                cbPrimaocRacun.Text = idData1.Rows[0]["primalac_racun"].ToString();
                // cbPrimaocRacun.SelectedValue = idData1.Rows[0]["primalac_racun"].ToString();
                textBox3.Text = idData1.Rows[0]["prmalac_model"].ToString();
                textBox5.Text = idData1.Rows[0]["primalac_poziv"].ToString();
            }
            catch { }
        }



        private void btnStampa_Click(object sender, EventArgs e)
        {
            string uplatnica = napravi_uplatnicu();
            string d = "C:\\blankoUPLATNICE\\" + uplatnica + ".txt";

            string stampac = this.cbStampac.GetItemText(this.cbStampac.SelectedItem);
            RawPrinterHelper.SendFileToPrinter(stampac, d, int.Parse(tbBrKopija.Text));
            unesi(int.Parse(cbPlatilacRacun.SelectedValue.ToString()), int.Parse(cbPrimalac.SelectedValue.ToString()),
                DateTime.Now, double.Parse(txtIznos.Text));
        }

        private string napravi_uplatnicu()
        {
            if (!Directory.Exists("C://blankoUPLATNICE/"))
            {
                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory("C://blankoUPLATNICE/");
            }

            string b = DateTime.Now.ToString("ddMMyyyy_HHmmss");

            string primalac_naziv = "";
            string primalac_mesto = "";
            string primalac_adresa = "";
            TextWriter upisi = new StreamWriter("C://blankoUPLATNICE/" + b + ".txt", false, System.Text.Encoding.UTF8);

            string nalogodavac = cbPlatilac.Text;
            char[] separatingChars = { ',' };
            char[] separatingCharsDT = { ':' };
            char[] separatingCharsSvrha = { '\n' };
            string[] nalogodavacSve = nalogodavac.Split(separatingChars, System.StringSplitOptions.RemoveEmptyEntries);

            //nalogodavac
            string nalogodavac_naziv = nalogodavacSve[0].Trim();
            string nalogodavac_mesto = nalogodavacSve[1].Trim();
            string nalogodavac_adresa = nalogodavacSve[2].Trim() + " " + nalogodavacSve[3].Trim();


            //lice
            string primalac = cbPrimalac.Text;
            string[] primalacSve = primalac.Split(separatingChars, System.StringSplitOptions.RemoveEmptyEntries);



            primalac_naziv = primalacSve[0].Trim();
            primalac_naziv = primalac_naziv.PadRight(49);
            try
            {
                primalac_mesto = primalacSve[1].Trim();
            }
            catch { }
            try
            {
                primalac_adresa = primalacSve[2].Trim() + " " + primalacSve[3].Trim();
            }
            catch { }

            string[] platilacRacun = cbPlatilacRacun.Text.Split(separatingCharsDT, System.StringSplitOptions.RemoveEmptyEntries);
            string neto = txtIznos.Text;
            double neto_pom = double.Parse(neto);


            string lice_ziro = cbPrimaocRacun.Text;
            // string svrha = txtSvrhaPlacanja.Text.Replace("/n"," ");
            string[] svrha = txtSvrhaPlacanja.Text.Split(separatingCharsSvrha, System.StringSplitOptions.RemoveEmptyEntries);
            DateTime dan = DateTime.Now;
            //char c = ' ';
            //if (checkBox1.Checked)
            //{
            //   c = '√';
            //}
             upisi.Write("");
            //upisi.WriteLine();
            //upisi.WriteLine();
            //upisi.WriteLine();
            //upisi.WriteLine();
            //upisi.WriteLine();
            upisi.WriteLine();
            upisi.Write("   " + nalogodavac_naziv + "");
            upisi.WriteLine();
            upisi.Write("   " + nalogodavac_mesto.PadRight(41) + "" + textBox1.Text + "     " + textBox9.Text + "      =" + neto_pom.ToString("N2") + "");
            upisi.WriteLine();
            upisi.Write("   " + nalogodavac_adresa + "");
            upisi.WriteLine();
            upisi.WriteLine();
            upisi.Write("                                                    " + platilacRacun[0] + "");
            upisi.WriteLine();
            upisi.Write("   " + svrha[0] + "");
            upisi.WriteLine();
            try
            {
                upisi.Write("   " + svrha[1] + "");
            }
            catch { }
            upisi.WriteLine();
            try
            {
                upisi.Write("   " + svrha[2].PadRight(41) + "" + textBox2.Text + "       " + textBox4.Text + "");
            }
            catch
            {
                upisi.Write("                                            " + textBox2.Text + "       " + textBox4.Text + "");
            }
            upisi.WriteLine();
            upisi.WriteLine();
            upisi.WriteLine();
            upisi.Write("   " + primalac_naziv + "" + lice_ziro + " ");
            upisi.WriteLine();
            upisi.WriteLine("   " + primalac_mesto + "");
            upisi.WriteLine("   " + primalac_adresa + "");
            upisi.Write("                                            " + textBox3.Text + "       " + textBox5.Text + "");
            upisi.WriteLine();
            upisi.WriteLine();
            upisi.WriteLine();
            //upisi.Write("             Novi Slankamen," + dan.Day + "." + dan.Month + "." + dan.Year + "       ");
            upisi.Write("             "+ textBox6.Text+"");
            upisi.WriteLine();
           // upisi.Write("                                                                   "+c+"     ");
            upisi.WriteLine();

            upisi.WriteLine();
            upisi.WriteLine();
            upisi.WriteLine();
            upisi.WriteLine();
            upisi.WriteLine();


            upisi.Close();
            return b;
        }
        private void unesi(int duznik, int primalac, DateTime datum, double iznos)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                for (int i = 0; i < int.Parse(tbBrKopija.Text); i++)
                {
                    string queryUnesi = "INSERT INTO preneto  ( duznik, primalac, datum, iznos) " +
                                        " VALUES        (" + duznik + "," + primalac + ",'" + datum + "',N'" + iznos + "')";

                    SqlCommand commUnosi = new SqlCommand();
                    commUnosi.CommandText = queryUnesi;
                    commUnosi.Connection = conn;
                    commUnosi.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public class RawPrinterHelper
        {
            // Structure and API declarions:
            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
            public class DOCINFOA
            {
                [MarshalAs(UnmanagedType.LPStr)]
                public string pDocName;
                [MarshalAs(UnmanagedType.LPStr)]
                public string pOutputFile;
                [MarshalAs(UnmanagedType.LPStr)]
                public string pDataType;
            }
            [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

            [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool ClosePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

            [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool EndDocPrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool StartPagePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool EndPagePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

            // SendBytesToPrinter()
            // When the function is given a printer name and an unmanaged array
            // of bytes, the function sends those bytes to the print queue.
            // Returns true on success, false on failure.
            public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount, int broj)
            {
                Int32 dwError = 0, dwWritten = 0;
                IntPtr hPrinter = new IntPtr(0);
                DOCINFOA di = new DOCINFOA();
                bool bSuccess = false; // Assume failure unless you specifically succeed.


                di.pDocName = "My C#.NET RAW Document";
                di.pDataType = "RAW";



                // Open the printer.
                if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
                {
                    for (int q = 1; q <= broj; q++)
                    {
                        // Start a document.
                        if (StartDocPrinter(hPrinter, 1, di))
                        {
                            // Start a page.
                            if (StartPagePrinter(hPrinter))
                            {
                                // Write your bytes.
                                bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                                EndPagePrinter(hPrinter);
                            }

                            EndDocPrinter(hPrinter);
                        }
                    }
                    ClosePrinter(hPrinter);
                }
                // If you did not succeed, GetLastError may give more information
                // about why not.
                if (bSuccess == false)
                {
                    dwError = Marshal.GetLastWin32Error();
                }
                return bSuccess;
            }

            public static bool SendFileToPrinter(string szPrinterName, string szFileName, int brojKopija)
            {

                // Open the file.
                FileStream fs = new FileStream(szFileName, FileMode.Open);
                // Create a BinaryReader on the file.
                BinaryReader br = new BinaryReader(fs);
                // Dim an array of bytes big enough to hold the file's contents.
                Byte[] bytes = new Byte[fs.Length];
                bool bSuccess = false;
                // Your unmanaged pointer.
                IntPtr pUnmanagedBytes = new IntPtr(0);
                int nLength;

                nLength = Convert.ToInt32(fs.Length);
                // Read the contents of the file into the array.
                bytes = br.ReadBytes(nLength);
                // Allocate some unmanaged memory for those bytes.
                pUnmanagedBytes = Marshal.AllocCoTaskMem(nLength);
                // Copy the managed byte array into the unmanaged array.
                Marshal.Copy(bytes, 0, pUnmanagedBytes, nLength);
                // Send the unmanaged bytes to the printer.
                bSuccess = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, nLength, brojKopija);
                // Free the unmanaged memory that you allocated earlier.
                Marshal.FreeCoTaskMem(pUnmanagedBytes);
                fs.Close();
                return bSuccess;
            }
            public static bool SendStringToPrinter(string szPrinterName, string szString, int broj)
            {
                IntPtr pBytes;
                Int32 dwCount;
                // How many characters are in the string?
                dwCount = szString.Length;
                // Assume that the printer is expecting ANSI text, and then convert
                // the string to ANSI text.
                pBytes = Marshal.StringToCoTaskMemAnsi(szString);
                // Send the converted ANSI string to the printer.
                SendBytesToPrinter(szPrinterName, pBytes, dwCount, broj);
                Marshal.FreeCoTaskMem(pBytes);
                return true;
            }

        }

        private void cbPlatilacRacun_Leave(object sender, EventArgs e)
        {
            try
            {
                string query12 = "SELECT         id, naziv, mesto, adresa, PIB, naziv + ', ' + mesto + ',' + adresa AS dis " +
                                " FROM            firma " +
                                " WHERE        (id = " + cbPlatilacRacun.SelectedValue + ")";
                string query1 = "SELECT        dbo.firma.id, dbo.firma.naziv, dbo.firma.mesto, dbo.firma.adresa, dbo.firma.PIB, dbo.firma.naziv + ', ' + dbo.firma.mesto + ',' + dbo.firma.adresa AS dis "+
                                " FROM            dbo.firma INNER JOIN       dbo.duznik ON dbo.firma.id = dbo.duznik.firma_id "+
                                " WHERE        (dbo.duznik.id = " + cbPlatilacRacun.SelectedValue + ")";
                SqlDataAdapter myAdapter1 = new SqlDataAdapter(query1, connection);
                DataTable idData1 = new DataTable();


                myAdapter1.Fill(idData1);
                //cbPlatilac.DataSource = idData1;
                //cbPlatilac.DisplayMember = "dis";
                cbPlatilac.ValueMember = "id";
                cbPlatilac.Text = idData1.Rows[0]["dis"].ToString();
            }
            catch { }

        }

        private void cbPrimaocRacun_Leave(object sender, EventArgs e)
        {
            try
            {
                string query1 = " SELECT   id, primalac_naziv, primalac_mesto, primalac_ulica, primalac_broj, primalac_racun, " +
                " prmalac_model, primalac_poziv,primalac_naziv + ',' + primalac_mesto + ',' + primalac_ulica + ',' + primalac_broj AS dis FROM primalac" +
                                " WHERE        (id = " + cbPrimaocRacun.SelectedValue + ")";
                SqlDataAdapter myAdapter1 = new SqlDataAdapter(query1, connection);
                DataTable idData1 = new DataTable();


                myAdapter1.Fill(idData1);
                //cbPrimalac.DataSource = idData1;
                //cbPrimalac.DisplayMember = "dis";
                cbPrimalac.ValueMember = "id";
                cbPrimalac.Text = idData1.Rows[0]["dis"].ToString();
                textBox3.Text = idData1.Rows[0]["prmalac_model"].ToString();
                textBox5.Text = idData1.Rows[0]["primalac_poziv"].ToString();
            }
            catch { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormKomitenti km = new FormKomitenti();
            km.Show();

        }

        private void pregledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKomitenti kom = new FormKomitenti();
            kom.ShowDialog();
            //this.groupBox2.Controls.Clear();
            //this.groupBox2.Controls.Add(kom.GetGroupBox());
            //kom.GetGroupBox().Dock = DockStyle.Fill;
            //kom.GetGroupBox().Show();
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            OnStart();
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFirma fr = new FormFirma();
            fr.ShowDialog();
        }






    }
}