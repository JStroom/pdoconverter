namespace PdoConverter
{
    partial class PdoForm
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
            this.recordsGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNummerWerkgever = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefoonContactpersoon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNaamContactPersoon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmailAdres = new System.Windows.Forms.TextBox();
            this.txtAdresGegevensLeverancier = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGegevensLeverancier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtVolgnummerBestand = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxDatumAanmaakBestand = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValuta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtControleGetal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportNaarPDOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbPeriodeMaand = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbPeriodeJaar = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblBuildVersion = new System.Windows.Forms.Label();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.recordsGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // recordsGridView
            // 
            this.recordsGridView.AllowUserToAddRows = false;
            this.recordsGridView.AllowUserToDeleteRows = false;
            this.recordsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recordsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.recordsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordsGridView.Location = new System.Drawing.Point(12, 211);
            this.recordsGridView.Name = "recordsGridView";
            this.recordsGridView.ReadOnly = true;
            this.recordsGridView.Size = new System.Drawing.Size(941, 276);
            this.recordsGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.txtNummerWerkgever);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTelefoonContactpersoon);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNaamContactPersoon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEmailAdres);
            this.groupBox1.Controls.Add(this.txtAdresGegevensLeverancier);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtGegevensLeverancier);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 178);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gegevens Enter & bestand";
            // 
            // txtNummerWerkgever
            // 
            this.txtNummerWerkgever.Location = new System.Drawing.Point(157, 149);
            this.txtNummerWerkgever.MaxLength = 8;
            this.txtNummerWerkgever.Name = "txtNummerWerkgever";
            this.txtNummerWerkgever.Size = new System.Drawing.Size(100, 20);
            this.txtNummerWerkgever.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Nummer Werkgever";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Telefoon contactpersoon";
            // 
            // txtTelefoonContactpersoon
            // 
            this.txtTelefoonContactpersoon.AccessibleDescription = "Adres gegevens";
            this.txtTelefoonContactpersoon.Location = new System.Drawing.Point(157, 122);
            this.txtTelefoonContactpersoon.MaxLength = 11;
            this.txtTelefoonContactpersoon.Name = "txtTelefoonContactpersoon";
            this.txtTelefoonContactpersoon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefoonContactpersoon.TabIndex = 18;
            this.txtTelefoonContactpersoon.Text = "12345678901";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Naam contactpersoon";
            // 
            // txtNaamContactPersoon
            // 
            this.txtNaamContactPersoon.AccessibleDescription = "Adres gegevens";
            this.txtNaamContactPersoon.Location = new System.Drawing.Point(157, 96);
            this.txtNaamContactPersoon.MaxLength = 40;
            this.txtNaamContactPersoon.Name = "txtNaamContactPersoon";
            this.txtNaamContactPersoon.Size = new System.Drawing.Size(312, 20);
            this.txtNaamContactPersoon.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Email adres";
            // 
            // txtEmailAdres
            // 
            this.txtEmailAdres.AccessibleDescription = "Adres gegevens";
            this.txtEmailAdres.Location = new System.Drawing.Point(157, 70);
            this.txtEmailAdres.MaxLength = 40;
            this.txtEmailAdres.Name = "txtEmailAdres";
            this.txtEmailAdres.Size = new System.Drawing.Size(312, 20);
            this.txtEmailAdres.TabIndex = 14;
            // 
            // txtAdresGegevensLeverancier
            // 
            this.txtAdresGegevensLeverancier.AccessibleDescription = "Adres gegevens";
            this.txtAdresGegevensLeverancier.Location = new System.Drawing.Point(157, 44);
            this.txtAdresGegevensLeverancier.MaxLength = 50;
            this.txtAdresGegevensLeverancier.Name = "txtAdresGegevensLeverancier";
            this.txtAdresGegevensLeverancier.Size = new System.Drawing.Size(312, 20);
            this.txtAdresGegevensLeverancier.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Adres GegevensLeverancier";
            // 
            // txtGegevensLeverancier
            // 
            this.txtGegevensLeverancier.Location = new System.Drawing.Point(157, 20);
            this.txtGegevensLeverancier.MaxLength = 42;
            this.txtGegevensLeverancier.Name = "txtGegevensLeverancier";
            this.txtGegevensLeverancier.Size = new System.Drawing.Size(312, 20);
            this.txtGegevensLeverancier.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "GegevensLeverancier";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(219, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Formaat: JJJJMMDD";
            // 
            // txtVolgnummerBestand
            // 
            this.txtVolgnummerBestand.Location = new System.Drawing.Point(150, 46);
            this.txtVolgnummerBestand.Mask = "00000";
            this.txtVolgnummerBestand.Name = "txtVolgnummerBestand";
            this.txtVolgnummerBestand.Size = new System.Drawing.Size(46, 20);
            this.txtVolgnummerBestand.TabIndex = 25;
            this.txtVolgnummerBestand.Text = "1";
            this.txtVolgnummerBestand.ValidatingType = typeof(int);
            // 
            // txtBoxDatumAanmaakBestand
            // 
            this.txtBoxDatumAanmaakBestand.Location = new System.Drawing.Point(150, 20);
            this.txtBoxDatumAanmaakBestand.Mask = "00000000";
            this.txtBoxDatumAanmaakBestand.Name = "txtBoxDatumAanmaakBestand";
            this.txtBoxDatumAanmaakBestand.Size = new System.Drawing.Size(63, 20);
            this.txtBoxDatumAanmaakBestand.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Valuta";
            // 
            // txtValuta
            // 
            this.txtValuta.AccessibleDescription = "";
            this.txtValuta.Location = new System.Drawing.Point(150, 98);
            this.txtValuta.MaxLength = 18;
            this.txtValuta.Name = "txtValuta";
            this.txtValuta.ReadOnly = true;
            this.txtValuta.Size = new System.Drawing.Size(34, 20);
            this.txtValuta.TabIndex = 22;
            this.txtValuta.Text = "EUR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Controle getal";
            // 
            // txtControleGetal
            // 
            this.txtControleGetal.AccessibleDescription = "";
            this.txtControleGetal.Location = new System.Drawing.Point(150, 72);
            this.txtControleGetal.MaxLength = 18;
            this.txtControleGetal.Name = "txtControleGetal";
            this.txtControleGetal.ReadOnly = true;
            this.txtControleGetal.Size = new System.Drawing.Size(129, 20);
            this.txtControleGetal.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Datum aanmaak bestand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Volgnummer Bestand";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(965, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportNaarPDOToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportNaarPDOToolStripMenuItem
            // 
            this.exportNaarPDOToolStripMenuItem.Name = "exportNaarPDOToolStripMenuItem";
            this.exportNaarPDOToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exportNaarPDOToolStripMenuItem.Text = "Export naar PDO";
            this.exportNaarPDOToolStripMenuItem.Click += new System.EventHandler(this.exportNaarPDOToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtControleGetal);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtVolgnummerBestand);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtValuta);
            this.groupBox2.Controls.Add(this.txtBoxDatumAanmaakBestand);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(504, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 125);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bestand gegevens";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(286, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(143, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "Som pens. loon en # records";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbPeriodeMaand);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.cmbPeriodeJaar);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(504, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(449, 46);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Periode";
            // 
            // cmbPeriodeMaand
            // 
            this.cmbPeriodeMaand.FormattingEnabled = true;
            this.cmbPeriodeMaand.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbPeriodeMaand.Location = new System.Drawing.Point(222, 16);
            this.cmbPeriodeMaand.Name = "cmbPeriodeMaand";
            this.cmbPeriodeMaand.Size = new System.Drawing.Size(57, 21);
            this.cmbPeriodeMaand.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(173, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Maand";
            // 
            // cmbPeriodeJaar
            // 
            this.cmbPeriodeJaar.FormattingEnabled = true;
            this.cmbPeriodeJaar.Items.AddRange(new object[] {
            "2012",
            "2013",
            "2014",
            "2015",
            "2016"});
            this.cmbPeriodeJaar.Location = new System.Drawing.Point(63, 15);
            this.cmbPeriodeJaar.Name = "cmbPeriodeJaar";
            this.cmbPeriodeJaar.Size = new System.Drawing.Size(88, 21);
            this.cmbPeriodeJaar.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Jaar: ";
            // 
            // lblBuildVersion
            // 
            this.lblBuildVersion.AutoSize = true;
            this.lblBuildVersion.Location = new System.Drawing.Point(720, 9);
            this.lblBuildVersion.Name = "lblBuildVersion";
            this.lblBuildVersion.Size = new System.Drawing.Size(108, 13);
            this.lblBuildVersion.TabIndex = 29;
            this.lblBuildVersion.Text = "Build: 8-4-2014 15:21";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // PdoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 519);
            this.Controls.Add(this.lblBuildVersion);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.recordsGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PdoForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.recordsGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView recordsGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGegevensLeverancier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdresGegevensLeverancier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmailAdres;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtValuta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefoonContactpersoon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNaamContactPersoon;
        private System.Windows.Forms.MaskedTextBox txtBoxDatumAanmaakBestand;
        private System.Windows.Forms.TextBox txtControleGetal;
        private System.Windows.Forms.MaskedTextBox txtVolgnummerBestand;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportNaarPDOToolStripMenuItem;
        private System.Windows.Forms.TextBox txtNummerWerkgever;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbPeriodeMaand;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbPeriodeJaar;
        private System.Windows.Forms.Label lblBuildVersion;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

