using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Euro_Geldzähler__Grafic_
{[Serializable]
    internal class Userdaten
    {
        public int centOne { get; set; }
        public int centTwo { get; set; }
        public int centFive { get; set; }
        public int centTen { get; set; }
        public int centTwenty { get; set; }
        public int centFifty { get; set; }
        public int euroOne { get; set; }
        public int euroTwo { get; set; }
        public int euroFive { get; set; }
        public int euroTen { get; set; }
        public int euroTwenty { get; set; }
        public int euroFifty { get; set; }
        public int eurohundred { get; set; }
        public int euroTwoHundred { get; set; }

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
