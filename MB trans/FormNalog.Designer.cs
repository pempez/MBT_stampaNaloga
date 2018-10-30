namespace MB_trans
{
    partial class FormNalog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbBrKopija = new System.Windows.Forms.TextBox();
            this.btnStampa = new System.Windows.Forms.Button();
            this.cbStampac = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.primaociToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.firmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.cbPrimaocRacun = new System.Windows.Forms.ComboBox();
            this.cbPlatilacRacun = new System.Windows.Forms.ComboBox();
            this.cbPlatilac = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.txtPrimaocRacun = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbPrimalac = new System.Windows.Forms.ComboBox();
            this.txtSvrhaPlacanja = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tbBrKopija);
            this.groupBox1.Controls.Add(this.btnStampa);
            this.groupBox1.Controls.Add(this.cbStampac);
            this.groupBox1.Location = new System.Drawing.Point(699, 474);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 110);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Štampa";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Štampac";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Broj kopija";
            // 
            // tbBrKopija
            // 
            this.tbBrKopija.Location = new System.Drawing.Point(9, 84);
            this.tbBrKopija.Name = "tbBrKopija";
            this.tbBrKopija.Size = new System.Drawing.Size(51, 20);
            this.tbBrKopija.TabIndex = 2;
            this.tbBrKopija.Text = "1";
            // 
            // btnStampa
            // 
            this.btnStampa.Location = new System.Drawing.Point(220, 81);
            this.btnStampa.Name = "btnStampa";
            this.btnStampa.Size = new System.Drawing.Size(75, 23);
            this.btnStampa.TabIndex = 1;
            this.btnStampa.Text = "Štampaj";
            this.btnStampa.UseVisualStyleBackColor = true;
            this.btnStampa.Click += new System.EventHandler(this.btnStampa_Click);
            // 
            // cbStampac
            // 
            this.cbStampac.FormattingEnabled = true;
            this.cbStampac.Location = new System.Drawing.Point(7, 40);
            this.cbStampac.Name = "cbStampac";
            this.cbStampac.Size = new System.Drawing.Size(288, 21);
            this.cbStampac.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.primaociToolStripMenuItem,
            this.firmaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // primaociToolStripMenuItem
            // 
            this.primaociToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledToolStripMenuItem});
            this.primaociToolStripMenuItem.Name = "primaociToolStripMenuItem";
            this.primaociToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.primaociToolStripMenuItem.Text = "Komitenti";
            // 
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.pregledToolStripMenuItem.Text = "Pregled";
            this.pregledToolStripMenuItem.Click += new System.EventHandler(this.pregledToolStripMenuItem_Click);
            // 
            // btnPonisti
            // 
            this.btnPonisti.Location = new System.Drawing.Point(12, 485);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(75, 23);
            this.btnPonisti.TabIndex = 27;
            this.btnPonisti.Text = "Poništi";
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // firmaToolStripMenuItem
            // 
            this.firmaToolStripMenuItem.Name = "firmaToolStripMenuItem";
            this.firmaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.firmaToolStripMenuItem.Text = "Firma";
            this.firmaToolStripMenuItem.Click += new System.EventHandler(this.firmaToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::MB_trans.Properties.Resources.nalog_3;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.cbPrimaocRacun);
            this.groupBox2.Controls.Add(this.cbPlatilacRacun);
            this.groupBox2.Controls.Add(this.cbPlatilac);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.txtIznos);
            this.groupBox2.Controls.Add(this.txtPrimaocRacun);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.cbPrimalac);
            this.groupBox2.Controls.Add(this.txtSvrhaPlacanja);
            this.groupBox2.Location = new System.Drawing.Point(0, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1012, 441);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(241, 367);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(220, 21);
            this.textBox6.TabIndex = 40;
            this.textBox6.Text = "Novi Slankamen";
            // 
            // cbPrimaocRacun
            // 
            this.cbPrimaocRacun.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbPrimaocRacun.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPrimaocRacun.FormattingEnabled = true;
            this.cbPrimaocRacun.Location = new System.Drawing.Point(555, 249);
            this.cbPrimaocRacun.Name = "cbPrimaocRacun";
            this.cbPrimaocRacun.Size = new System.Drawing.Size(414, 21);
            this.cbPrimaocRacun.TabIndex = 39;
            this.cbPrimaocRacun.Leave += new System.EventHandler(this.cbPrimaocRacun_Leave);
            // 
            // cbPlatilacRacun
            // 
            this.cbPlatilacRacun.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbPlatilacRacun.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPlatilacRacun.FormattingEnabled = true;
            this.cbPlatilacRacun.Location = new System.Drawing.Point(555, 135);
            this.cbPlatilacRacun.Name = "cbPlatilacRacun";
            this.cbPlatilacRacun.Size = new System.Drawing.Size(414, 21);
            this.cbPlatilacRacun.TabIndex = 32;
            this.cbPlatilacRacun.Leave += new System.EventHandler(this.cbPlatilacRacun_Leave);
            // 
            // cbPlatilac
            // 
            this.cbPlatilac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbPlatilac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPlatilac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlatilac.FormattingEnabled = true;
            this.cbPlatilac.ItemHeight = 13;
            this.cbPlatilac.Location = new System.Drawing.Point(31, 60);
            this.cbPlatilac.Name = "cbPlatilac";
            this.cbPlatilac.Size = new System.Drawing.Size(430, 21);
            this.cbPlatilac.TabIndex = 26;
            this.cbPlatilac.Leave += new System.EventHandler(this.cbPlatilac_Leave);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox1.Location = new System.Drawing.Point(857, 373);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 38;
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(646, 76);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(43, 20);
            this.textBox9.TabIndex = 30;
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(740, 76);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(232, 20);
            this.txtIznos.TabIndex = 31;
            // 
            // txtPrimaocRacun
            // 
            this.txtPrimaocRacun.Location = new System.Drawing.Point(498, 349);
            this.txtPrimaocRacun.Name = "txtPrimaocRacun";
            this.txtPrimaocRacun.Size = new System.Drawing.Size(259, 20);
            this.txtPrimaocRacun.TabIndex = 35;
            this.txtPrimaocRacun.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(643, 309);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(326, 20);
            this.textBox5.TabIndex = 37;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(646, 194);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(326, 20);
            this.textBox4.TabIndex = 34;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(556, 309);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(40, 20);
            this.textBox3.TabIndex = 36;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(557, 194);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(40, 20);
            this.textBox2.TabIndex = 33;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(556, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 20);
            this.textBox1.TabIndex = 29;
            // 
            // cbPrimalac
            // 
            this.cbPrimalac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbPrimalac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPrimalac.FormattingEnabled = true;
            this.cbPrimalac.Location = new System.Drawing.Point(31, 249);
            this.cbPrimalac.Name = "cbPrimalac";
            this.cbPrimalac.Size = new System.Drawing.Size(433, 21);
            this.cbPrimalac.TabIndex = 28;
            this.cbPrimalac.Leave += new System.EventHandler(this.cbPrimalac_Leave);
            // 
            // txtSvrhaPlacanja
            // 
            this.txtSvrhaPlacanja.Location = new System.Drawing.Point(31, 153);
            this.txtSvrhaPlacanja.Name = "txtSvrhaPlacanja";
            this.txtSvrhaPlacanja.Size = new System.Drawing.Size(433, 61);
            this.txtSvrhaPlacanja.TabIndex = 27;
            this.txtSvrhaPlacanja.Text = "";
            // 
            // FormNalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1012, 597);
            this.Controls.Add(this.btnPonisti);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormNalog";
            this.Text = "Nalog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStampa;
        private System.Windows.Forms.ComboBox cbStampac;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbBrKopija;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbPrimaocRacun;
        private System.Windows.Forms.ComboBox cbPlatilacRacun;
        private System.Windows.Forms.ComboBox cbPlatilac;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.TextBox txtPrimaocRacun;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbPrimalac;
        private System.Windows.Forms.RichTextBox txtSvrhaPlacanja;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem primaociToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ToolStripMenuItem firmaToolStripMenuItem;
    }
}

