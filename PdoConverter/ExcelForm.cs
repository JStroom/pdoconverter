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
using Excel = Microsoft.Office.Interop.Excel;
using System.Collections;
using Microsoft.Office.Interop.Excel;


namespace PdoConverter
{
    public partial class ExcelForm : Form
    {
        public static string VOORLETTERS = "Voorletters";
        public static string VOORVOEGSELS = "Voorvoegsel";
        public static string NAAM = "Achternaam";
        public static string GEBOORTEDATUM = "Geboortedatum";
        public static string SOFINUMMER = "BSN";
        public static string ADRES = "Adres";
        public static string POSTCODE = "Postcode";
        public static string PLAATS = "Plaats";
        public static string LAND_NAAM = "Land";
        public static string GESLACHT = "Geslacht";
        public static string UREN = "Uren";
        public static string PENSIOEN_GEVEND_LOON = "pensioengev. Sal";
        public static string BASIS = "basisregeling";
        public static string PLUS = "Plusregeling";


        public static string[] mandatoryExcelColumns = { GEBOORTEDATUM, VOORLETTERS, VOORVOEGSELS, NAAM, SOFINUMMER, LAND_NAAM, ADRES, 
                                                           POSTCODE, GESLACHT, PENSIOEN_GEVEND_LOON, UREN, BASIS, PLUS };
        public static string[] nonNullExcelColumns = { GEBOORTEDATUM, VOORLETTERS, NAAM, SOFINUMMER, LAND_NAAM, ADRES, 
                                                           POSTCODE, GESLACHT, PENSIOEN_GEVEND_LOON, UREN };
        string[] availableExcelColumns;
        private ArrayList convertedDictionaryList = new ArrayList();

        Excel.Application excelApp = new Excel.Application();
        Excel.Workbook excelWorkbook;
        Preferences prefs;

        public ExcelForm(Preferences prefs)
        {
            InitializeComponent();
            this.prefs = prefs;
            txtImportFile.Text = prefs.excelFileLocation;
            pBarImport.Minimum = 1;
            pBarImport.Maximum = 1000;
            pBarImport.Visible = false;
           
        }

        public ArrayList getConvertedArrayList()
        {
            return convertedDictionaryList;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            String path = Path.GetDirectoryName(prefs.excelFileLocation);
            dialog.InitialDirectory = path;
            dialog.FilterIndex = 2;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    prefs.excelFileLocation = dialog.FileName;
                    txtImportFile.Text = dialog.FileName;
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show(ex.Message, "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if(!File.Exists(txtImportFile.Text)){
                MessageBox.Show("De opgegeven file bestaat niet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Excel.Worksheet excelWorksheet = getExcelSheet();
            if (excelWorksheet == null)
                return; // we are finished here.
            pBarImport.Visible = true;
            pBarImport.Value = 1;
            pBarImport.Step = 1;

            try
            {
                validateColumns(excelWorksheet);
                extractDataRows(excelWorksheet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            excelWorkbook.Close(0);
            excelApp.Quit();
            this.Close();
        }

        private void validateColumns(Excel.Worksheet sheet)
        {
            Excel.Range range = (Excel.Range)sheet.get_Range("A1", "Z1"); // first row only
            System.Array rangeValues = (System.Array)range.Cells.Value;
            availableExcelColumns = new string[rangeValues.Length];

            int i = 0;
            foreach (string column in rangeValues)
            {
                availableExcelColumns[i] = column;
                i++;
            }

            ArrayList missing = new ArrayList();

            foreach (string column in mandatoryExcelColumns)
            {
                if (!availableExcelColumns.Contains(column))
                {
                    missing.Add(column);
                }
            }

            if (missing.Count > 0)
            {
                String errorText = "";
                foreach (string miss in missing)
                {
                    errorText += miss + " ";
                }

                throw new ApplicationException("De volgende kolommen missen in de excel sheet: " + errorText);
            }
        }

        private void extractDataRows(Excel.Worksheet sheet)
        {
            Excel.Range usedRange = (Excel.Range)sheet.get_Range("A2", "Z1000");

            foreach (Excel.Range row in usedRange.Rows)
            {
                pBarImport.PerformStep();
                Dictionary<string, string> excelDictionary = new Dictionary<string, string>();

                Range cell1 = row.Cells[1, 1];
                if (cell1.Value2 == null)
                {
                    continue; // this is to skip empty rows
                }

                foreach (string excelColumn in mandatoryExcelColumns)
                {
                    int index = System.Array.IndexOf(availableExcelColumns, excelColumn) + 1; //+1 because arrays start at 0 and excel at 1
                    Range cell = row.Cells[1, index];

                    if (cell.Value2 == null)
                    {
                        continue;
                    }

                    excelDictionary.Add(excelColumn, cell.Value2.ToString());
                }
                validateExtractedRow(excelDictionary, row);

                ExcelToPdo excelPdo = new ExcelToPdo(excelDictionary);
                convertedDictionaryList.Add(excelPdo.getPdoDictionary());
            }
        }

        private void validateExtractedRow(Dictionary<string, string> excelDictionary, Range row)
        {
            string missing = "";
            string value;
            if (!excelDictionary.TryGetValue(GEBOORTEDATUM, out value))
                missing = GEBOORTEDATUM + " ";

            if (!excelDictionary.TryGetValue(VOORLETTERS, out value))
                missing += VOORLETTERS + " ";

            if (!excelDictionary.TryGetValue(NAAM, out value))
                missing += NAAM + " ";

            if (!excelDictionary.TryGetValue(SOFINUMMER, out value))
                missing += SOFINUMMER + " ";
            else
            {
                try
                {
                    int integer = int.Parse(value);
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Het sofinummer in rij [" + row.Row + "] is geen nummer " + ex.Message);
                }
            }


            if (!excelDictionary.TryGetValue(LAND_NAAM, out value))
                missing += LAND_NAAM + " ";

            if (!excelDictionary.TryGetValue(ADRES, out value))
                missing += ADRES + " ";

            if (!excelDictionary.TryGetValue(POSTCODE, out value))
                missing += POSTCODE + " ";

            if (!excelDictionary.TryGetValue(GESLACHT, out value))
            {
                missing += GESLACHT + " ";
            }
            else
            {
                if (!(value.Equals("Man") || value.Equals("Vrouw")))
                    throw new ApplicationException("Het geslacht in rij [" + row.Row + "] is geen geen Man of Vrouw");
            }

            if (!excelDictionary.TryGetValue(PENSIOEN_GEVEND_LOON, out value)){
                missing += PENSIOEN_GEVEND_LOON + " ";
            }

            if (!excelDictionary.TryGetValue(UREN, out value))
                missing += UREN + " ";
            else
            {
                try
                {
                    int integer = int.Parse(value);
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("De uren in rij[" + row.Row + "] zijn geen heel getal: " + value +
                        "\n" + ex.Message);
                }
            }


            if (!missing.Equals(""))
                throw new ApplicationException("De volgende velden zijn niet aanwezig in rij [" + row.Row + "]: " + missing);
        }


        private Excel.Worksheet getExcelSheet()
        {
            excelWorkbook = excelApp.Workbooks.Open(txtImportFile.Text,
                0, false, 5, "", "", false, Excel.XlPlatform.xlWindows, "",
                true, false, 0, true, false, false);
            Excel.Sheets sheets = excelWorkbook.Worksheets;
            Excel.Worksheet excelWorksheet = null;
            try
            {
                excelWorksheet = (Excel.Worksheet)sheets.get_Item("pensioen_gegevens");
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Kan de sheet pensioen_gegevens niet vinden");
            }

            return excelWorksheet;
        }

    }
}
