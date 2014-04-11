using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PdoConverter
{
    [Serializable]
    public class Preferences
    {

        public string Leverancier { get; set; }
        public string AdresLeverancier { get; set; }
        public string NaamContactPersoon { get; set; }
        public string EmailContactPersoon { get; set; }
        public string TelefoonContactPersoon { get; set; }
        public string NummerWerkgever { get; set; }
        public string NummerContract { get; set; }
        public string excelFileLocation { get; set; }
        public string exportFileLocation { get; set; }

        [NonSerialized]
        private const string FILENAME = "preferences.xml";

        public static Preferences read()
        {
            IsolatedStorageFile isoStore = IsolatedStorageFile.GetUserStoreForDomain();

            if (!isoStore.FileExists(FILENAME))
            {
                return new Preferences();
            }

            IsolatedStorageFileStream isoStream =
                new IsolatedStorageFileStream(FILENAME, FileMode.OpenOrCreate, isoStore);
            StreamReader reader = new StreamReader(isoStream);
            XmlSerializer xmlFormat = new XmlSerializer(typeof(Preferences));
            Preferences pref = (Preferences)xmlFormat.Deserialize(reader);

            reader.Close();
            isoStream.Close();
            return pref;
        }

        public void save()
        {
            IsolatedStorageFile isoStore = IsolatedStorageFile.GetUserStoreForDomain();
            if (isoStore.FileExists(FILENAME))
            {
                isoStore.DeleteFile(FILENAME);
            }

            IsolatedStorageFileStream isoStream =
                new IsolatedStorageFileStream(FILENAME, FileMode.OpenOrCreate, isoStore);
            StreamWriter writer = new StreamWriter(isoStream);

            XmlSerializer xmlFormat = new XmlSerializer(typeof(Preferences));
            xmlFormat.Serialize(writer, this);
        }
    }
}

