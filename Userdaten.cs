using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Geldzähler_mit_Euro_3._0
{
    [Serializable]
    internal class Userdaten
    {
        public string cash1 { get; set; }
        public string cash2 { get; set; }
        public string cash3 { get; set; }
        public string cash4 { get; set; }
        public string cash5 { get; set; }
        public string cash6 { get; set; }
        public string cash7 { get; set; }
        public string cash8 { get; set; }
        public string cash9 { get; set; }
        public string cash10 { get; set; }
        public string cash11 { get; set; }
        public string cash12 { get; set; }
        public string cash13 { get; set; }
        public string cash14 { get; set; }
        public string Geldstand { get; set; }

        public void Save(string path)
        {
            System.IO.FileStream FS = new System.IO.FileStream(path, System.IO.FileMode.Create);
            BinaryFormatter BF = new BinaryFormatter();
            BF.Serialize(FS, this);
            FS.Dispose();
        }

        public Userdaten Load(string path)
        {
            Userdaten US = new Userdaten();
            System.IO.FileStream FS = new System.IO.FileStream(path, System.IO.FileMode.Open);
            BinaryFormatter BF = new BinaryFormatter();
            US = (Userdaten)BF.Deserialize(FS);
            return US;
        }

    }
}
