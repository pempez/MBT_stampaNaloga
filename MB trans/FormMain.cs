using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MB_trans
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            FormNalog fNalog = new FormNalog();
            this.groupBox1.Controls.Clear();
            this.groupBox1.Controls.Add(fNalog);
            fNalog.Dock = DockStyle.Fill;
            fNalog.Show();
        }
    }
}
