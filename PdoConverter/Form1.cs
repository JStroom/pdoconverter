using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace PdoConverter
{
    public partial class PdoForm : Form
    {
        public static string CONTRACT = "Contract";
        public static string SOFINUMMER = "Sofinummer";
        public static string NAAM = "Naam";
        public static string VOORLETTERS = "Voorletters";
        public static string VOORVOEGSELS = "Voorvoegsels";
        public static string GEBOORTEDATUM = "Geboortedatum";
        public static string GESLACHT = "Geslacht";
        public static string HUISNUMMER = "Huisnummer";
        public static string TOEVOEGING = "Toevoeging";
        public static string POSTCODE = "Postcode";
        public static string ADRES_BUITENLAND = "Adres Buitenland";
        public static string OMSCHRIJVING_POSTCODE_PLAATS = "Postcode & Plaats Buitenland";
        public static string CODE_LAND = "Code Land";
        public static string LAND_NAAM = "Land";
        public static string DUUR = "Duur";
        public static string BEDRAG = "Bedrag Pensioengevend Loon";

        public static string[] pdoColumns = { CONTRACT, SOFINUMMER, NAAM, VOORLETTERS, VOORVOEGSELS, GEBOORTEDATUM, GESLACHT, HUISNUMMER, 
        TOEVOEGING, POSTCODE, ADRES_BUITENLAND, OMSCHRIJVING_POSTCODE_PLAATS, CODE_LAND, LAND_NAAM, DUUR, BEDRAG };

        DataSet recordsDataSet = new DataSet("RecordType2");
        DataTable recordsTable;
        Preferences prefs;

        public PdoForm()
        {
            InitializeComponent();
            DefineTableColumns();
            prefs = Preferences.read();

            lblBuildVersion.Text = "Build version" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            initRecord1();

        }

        public void initRecord1()
        {
            txtGegevensLeverancier.Text = prefs.Leverancier;
            txtAdresGegevensLeverancier.Text = prefs.AdresLeverancier;
            txtNaamContactPersoon.Text = prefs.NaamContactPersoon;
            txtTelefoonContactpersoon.Text = prefs.TelefoonContactPersoon;
            txtEmailAdres.Text = prefs.EmailContactPersoon;
            txtNummerWerkgever.Text = prefs.NummerWerkgever;

            DateTime thisDay = DateTime.Today;
            txtBoxDatumAanmaakBestand.Text = thisDay.ToString("yyyyMMdd");
            txtControleGetal.Text = "0";

            cmbPeriodeMaand.Text = thisDay.Month.ToString().PadLeft(2, '0');
            cmbPeriodeJaar.Text = thisDay.Year.ToString();
        }

        private void DefineTableColumns()
        {
            DataColumn contractColumn = new DataColumn(CONTRACT, typeof(int));
            DataColumn sofiNummerColumn = new DataColumn(SOFINUMMER, typeof(int));
            DataColumn naamColumn = new DataColumn(NAAM, typeof(string));
            naamColumn.MaxLength = 25;
            DataColumn voorlettersColumn = new DataColumn(VOORLETTERS, typeof(string));
            voorlettersColumn.MaxLength = 6;
            DataColumn voorvoegselsColumn = new DataColumn(VOORVOEGSELS, typeof(string));
            voorvoegselsColumn.MaxLength = 10;
            DataColumn geboortedatumColumn = new DataColumn(GEBOORTEDATUM, typeof(int));
            DataColumn codeGeslachtColumn = new DataColumn(GESLACHT, typeof(int));
            DataColumn huisnummerColumn = new DataColumn(HUISNUMMER, typeof(int));
            DataColumn nadereAanduidingHuisnummerColumn = new DataColumn(TOEVOEGING, typeof(string));
            nadereAanduidingHuisnummerColumn.MaxLength = 4;
            DataColumn postcodeColumn = new DataColumn(POSTCODE, typeof(string));
            postcodeColumn.MaxLength = 6;
            DataColumn omschrijvingAdresColumn = new DataColumn(ADRES_BUITENLAND, typeof(string));
            omschrijvingAdresColumn.MaxLength = 35;
            DataColumn omschrijvingPostcodePlaatsColumn = new DataColumn(OMSCHRIJVING_POSTCODE_PLAATS, typeof(string));
            omschrijvingPostcodePlaatsColumn.MaxLength = 35;
            DataColumn codeLandColumn = new DataColumn(CODE_LAND, typeof(string));
            codeLandColumn.MaxLength = 4;
            DataColumn naamLandColumn = new DataColumn(LAND_NAAM, typeof(string));
            naamLandColumn.MaxLength = 40;
            DataColumn duurColumn = new DataColumn(DUUR, typeof(int));
            DataColumn pensioengevendLoon = new DataColumn(BEDRAG, typeof(string));
            pensioengevendLoon.MaxLength = 19;

            recordsTable = recordsDataSet.Tables.Add("records");

            recordsTable.Columns.AddRange(new DataColumn[] {
                contractColumn,
                sofiNummerColumn, 
                naamColumn, 
                voorlettersColumn, 
                voorvoegselsColumn, 
                geboortedatumColumn, 
                codeGeslachtColumn, 
                huisnummerColumn, 
                nadereAanduidingHuisnummerColumn, 
                postcodeColumn, 
                omschrijvingAdresColumn, 
                omschrijvingPostcodePlaatsColumn, 
                codeLandColumn, 
                naamLandColumn, 
                duurColumn, 
                pensioengevendLoon});

            recordsGridView.DataSource = recordsTable;
        }

        private void exportNaarPDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ("".Equals(txtNummerWerkgever.Text))
            {
                MessageBox.Show("Het nummer werkgever mag niet leeg zijn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "PDO" + txtVolgnummerBestand.Text.PadLeft(5, '0').ToString() + ".txt";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                prefs.exportFileLocation = dialog.FileName;
            }
            else
            {
                return;
            }

            if (File.Exists(dialog.FileName))
            {
                File.Delete(dialog.FileName);
            }

            FileStream fs = new FileStream(dialog.FileName, FileMode.CreateNew);

            StreamWriter writer = new StreamWriter(fs, Encoding.GetEncoding("iso-8859-1"));
            writer.Write("1");
            writer.Write(AlphaNumeric(txtGegevensLeverancier.Text, 42));
            writer.Write(UnsignedNumeric(txtVolgnummerBestand.Text, 5));
            writer.Write(txtBoxDatumAanmaakBestand.Text); // check if filled in
            writer.Write(AlphaNumeric(txtAdresGegevensLeverancier.Text, 50));
            writer.Write(AlphaNumeric(txtEmailAdres.Text, 40));
            writer.Write(AlphaNumeric(txtNaamContactPersoon.Text, 40));
            writer.Write(AlphaNumeric(txtTelefoonContactpersoon.Text, 11));
            writer.Write(UnsignedNumeric(txtControleGetal.Text, 18));
            writer.Write(txtValuta.Text);
            writer.Write(" ".PadLeft(13));
            writer.Write('\n');

            foreach (DataRow row in recordsTable.Rows)
            {
                writer.Write("2");
                writer.Write("950");

                writer.Write(UnsignedNumeric(txtNummerWerkgever.Text, 8));
                writer.Write(UnsignedNumeric(row[CONTRACT], 2));
                writer.Write(UnsignedNumeric(cmbPeriodeMaand.Text, 2));
                writer.Write(UnsignedNumeric(cmbPeriodeJaar.Text, 4));
                writer.Write(UnsignedNumeric(row[SOFINUMMER], 9));
                writer.Write(AlphaNumericUpperCase(row[NAAM], 25));
                writer.Write(AlphaNumericUpperCase(row[VOORLETTERS], 6));
                writer.Write(AlphaNumericUpperCase(row[VOORVOEGSELS], 10));
                writer.Write(UnsignedNumeric(row[GEBOORTEDATUM], 8));
                writer.Write(row[GESLACHT].ToString());
                writer.Write(UnsignedNumeric(row[HUISNUMMER], 5));
                writer.Write(AlphaNumeric(row[TOEVOEGING], 4));
                writer.Write(AlphaNumeric(row[POSTCODE], 6));
                writer.Write(AlphaNumeric(row[ADRES_BUITENLAND], 35));
                writer.Write(AlphaNumeric(row[OMSCHRIJVING_POSTCODE_PLAATS], 35));
                writer.Write(AlphaNumeric(row[CODE_LAND], 4));
                writer.Write(AlphaNumeric(row[LAND_NAAM], 40));
                writer.Write(SignedNumeric(row[DUUR], 4));
                writer.Write(SignedNumeric(row[BEDRAG], 19));
                writer.Write('\n');
            }

            writer.Close();
            fs.Close();
        }

        private string ascii(string Message)
        {
            Encoding iso = Encoding.GetEncoding("ISO-8859-1");
            Encoding utf8 = Encoding.UTF8;
            byte[] utfBytes = utf8.GetBytes(Message);
            byte[] isoBytes = Encoding.Convert(utf8, iso, utfBytes);
            return iso.GetString(isoBytes);
        }

        private string UnsignedNumeric(Object input, int maxLength)
        {
            if (input is System.DBNull)
            {
                return " ".PadRight(5);
            }
            return UnsignedNumeric((int)input, maxLength);
        }

        private string UnsignedNumeric(String input, int maxLength)
        {
            int integer = int.Parse(input);
            return UnsignedNumeric(integer, maxLength);
        }


        private string UnsignedNumeric(int integer, int maxLength)
        {
            if (integer < 0)
                throw new ApplicationException("Error occured: " + integer + " contains a negative value");

            if (integer.ToString().Length > maxLength)
                throw new ApplicationException("Error occured: " + integer + " is longer than maximum length: " + maxLength);

            return integer.ToString().PadLeft(maxLength, '0');
        }

        private string SignedNumeric(Object input, int maxLength)
        {
            int integer = 0;

            if (input is string)
                integer = int.Parse((string)input);
            else
                integer = (int)input;

            return SignedNumeric(integer, maxLength);
        }

        private string SignedNumeric(String input, int maxLength)
        {
            int integer = int.Parse(input);
            return SignedNumeric(integer, maxLength);
        }


        private string SignedNumeric(int integer, int maxLength)
        {
            if (integer.ToString().Length > maxLength)
            {
                throw new ApplicationException("Error occured: " + integer + " is longer than maximum length: " + maxLength);
            }
            char pad = ' '; // default whitespace, for positive numbers

            if (integer < 0) // negative number, change pad to -
            {
                pad = '-';
                integer = Math.Abs(integer);
            }

            return pad + integer.ToString().PadLeft(maxLength - 1, '0');
        }

        private string AlphaNumericUpperCase(Object input, int maxLength)
        {
            string upper = ((string)input).ToUpper();
            return AlphaNumeric(upper, maxLength);

        }

        private string AlphaNumeric(Object input, int maxLength)
        {
            if (input.ToString().Length > maxLength)
            {
                throw new ApplicationException("Error occured: " + input + " is longer than maximum length: " + maxLength);
            }
            return input.ToString().PadRight(maxLength);
        }

        private int controlegetal()
        {
            int getal = 0;
            foreach (DataRow row in recordsTable.Rows)
            {
                int bedrag = int.Parse((string)row[BEDRAG]);
                getal += Math.Abs(bedrag);
            }
            getal += recordsTable.Rows.Count;
            return getal;
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            prefs.Leverancier = txtGegevensLeverancier.Text;
            prefs.AdresLeverancier = txtAdresGegevensLeverancier.Text;
            prefs.NaamContactPersoon = txtNaamContactPersoon.Text;
            prefs.TelefoonContactPersoon = txtTelefoonContactpersoon.Text;
            prefs.EmailContactPersoon = txtEmailAdres.Text;
            prefs.NummerWerkgever = txtNummerWerkgever.Text;

            prefs.save();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelForm excel = new ExcelForm(prefs);
            try
            {
                excel.ShowDialog();

                ArrayList pdoList = excel.getConvertedArrayList();

                if (pdoList.Count > 0)
                {
                    recordsTable.Clear();
                }

                foreach (Dictionary<string, string> pdoDictionary in pdoList)
                {
                    DataRow row = recordsTable.NewRow();
                    foreach (string pdoColumn in PdoForm.pdoColumns)
                    {
                        string value;
                        pdoDictionary.TryGetValue(pdoColumn, out value);
                        if (value == "" && recordsTable.Columns[pdoColumn].DataType == typeof(Int32))
                            continue;
                        row[pdoColumn] = value;
                    }
                    recordsTable.Rows.Add(row);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                recordsTable.Clear();
                return;
            }

            txtControleGetal.Text = controlegetal().ToString();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.ShowDialog();
        }
    }
}
