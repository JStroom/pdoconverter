using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Data;


namespace PdoConverter
{
    class ExcelToPdo
    {
        private Dictionary<string, string> pdoDictionary = new Dictionary<string, string>();

        static CountryToCode countryToCode = new CountryToCode();

        public ExcelToPdo(Dictionary<string, string> excel)
        {
            fillPdoDictionary(excel);
        }

        private void fillPdoDictionary(Dictionary<string, string> excel)
        {
            pdoDictionary.Add(PdoForm.SOFINUMMER, getValue(excel, ExcelForm.SOFINUMMER));
            pdoDictionary.Add(PdoForm.NAAM, getValue(excel, ExcelForm.NAAM));
            pdoDictionary.Add(PdoForm.VOORLETTERS, getValue(excel, ExcelForm.VOORLETTERS).Replace(".", string.Empty));
            pdoDictionary.Add(PdoForm.VOORVOEGSELS, getValue(excel, ExcelForm.VOORVOEGSELS));
            pdoDictionary.Add(PdoForm.DUUR, getValue(excel, ExcelForm.UREN));
            pdoDictionary.Add(PdoForm.BEDRAG, getValue(excel, ExcelForm.PENSIOEN_GEVEND_LOON));
            pdoDictionary.Add(PdoForm.LAND_NAAM, getValue(excel, ExcelForm.LAND_NAAM));
            pdoDictionary.Add(PdoForm.CODE_LAND, countryToCode.GetCountryCode(getValue(excel, ExcelForm.LAND_NAAM)));

            TimeSpan datefromexcel = new TimeSpan(Convert.ToInt32(getValue(excel, ExcelForm.GEBOORTEDATUM)) - 2, 0, 0, 0);
            DateTime excelDate = new DateTime(1900, 1, 1).Add(datefromexcel);

            //DateTime datetime = DateTime.ParseExact(excelDate, "M-d-yyyy", CultureInfo.InvariantCulture);
            pdoDictionary.Add(PdoForm.GEBOORTEDATUM, excelDate.ToString("yyyyMMdd"));

            if (getValue(excel, ExcelForm.GESLACHT).Equals("Man"))
                pdoDictionary.Add(PdoForm.GESLACHT, "1");
            else
                pdoDictionary.Add(PdoForm.GESLACHT, "2");

            if (getValue(excel, ExcelForm.LAND_NAAM).Equals("Nederland"))
            {
                pdoDictionary.Add(PdoForm.POSTCODE, getValue(excel, ExcelForm.POSTCODE).Replace(" ", string.Empty));
                string adres = getValue(excel, ExcelForm.ADRES);
                Match match = Regex.Match(adres, @"[0-9]+", RegexOptions.IgnoreCase);
                pdoDictionary.Add(PdoForm.HUISNUMMER, match.Value);

                match = Regex.Match(adres, @"(?<=\d)[a-zA-Z ]+", RegexOptions.IgnoreCase);
                if (match.Success)
                    pdoDictionary.Add(PdoForm.TOEVOEGING, match.Value.Trim());
                else
                    pdoDictionary.Add(PdoForm.TOEVOEGING, "");
                pdoDictionary.Add(PdoForm.OMSCHRIJVING_POSTCODE_PLAATS, "");
                pdoDictionary.Add(PdoForm.ADRES_BUITENLAND, "");

            } else // buitenland
            {
                pdoDictionary.Add(PdoForm.OMSCHRIJVING_POSTCODE_PLAATS, getValue(excel, ExcelForm.POSTCODE) + " " + getValue(excel, ExcelForm.PLAATS));
                pdoDictionary.Add(PdoForm.ADRES_BUITENLAND, getValue(excel, ExcelForm.ADRES));

                pdoDictionary.Add(PdoForm.POSTCODE, "");
                pdoDictionary.Add(PdoForm.HUISNUMMER, "");
                pdoDictionary.Add(PdoForm.TOEVOEGING, "");
            }
        }

        private string getValue(Dictionary<string, string> excelDictionary, string key)
        {
            string value = "";
            excelDictionary.TryGetValue(key, out value);
            if (value == null)
                value = "";
            return value;
        }

        public Dictionary<string, string> getPdoDictionary()
        {
            return pdoDictionary;
        }

    }
}
