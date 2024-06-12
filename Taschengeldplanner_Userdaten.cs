using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Geldzähler_mit_Euro
{
    [Serializable]
    internal class Taschengeldplanner_Userdaten
    {
        #region Einnahmen
        public string jan { get; set; }
        public string feb { get; set; }
        public string mar { get; set; }
        public string apr { get; set; }
        public string may { get; set; }
        public string jun { get; set; }
        public string jul { get; set; }
        public string aug { get; set; }
        public string sep { get; set; }
        public string okt { get; set; }
        public string nov { get; set; }
        public string dez { get; set; }

        #endregion

        #region Ausstehende Ausgaben

        public string name1 { get; set; }
        public string name2 { get; set; }
        public string name3 { get; set; }
        public string name4 { get; set; }
        public string name5 { get; set; }
        public string name6 { get; set; }
        public string name7 { get; set; }
        public string name8 { get; set; }
        public string name9 { get; set; }
        public string name10 { get; set; }
        public string name11 { get; set; }
        public string name12 { get; set; }

        public string price1 { get; set; }
        public string price2 { get; set; }
        public string price3 { get; set; }
        public string price4 { get; set; }
        public string price5 { get; set; }
        public string price6 { get; set; }
        public string price7 { get; set; }
        public string price8 { get; set; }
        public string price9 { get; set; }
        public string price10 { get; set; }
        public string price11 { get; set; }
        public string price12 { get; set; }

        public int anzahl1 { get; set; }
        public int anzahl2 { get; set; }
        public int anzahl3 { get; set; }
        public int anzahl4 { get; set; }
        public int anzahl5 { get; set; }
        public int anzahl6 { get; set; }
        public int anzahl7 { get; set; }
        public int anzahl8 { get; set; }
        public int anzahl9 { get; set; }
        public int anzahl10 { get; set; }
        public int anzahl11 { get; set; }
        public int anzahl12 { get; set; }

        #endregion

        #region Meine Ausgaben

        public string name1a { get; set; }
        public string name2a { get; set; }
        public string name3a { get; set; }
        public string name4a { get; set; }
        public string name5a { get; set; }
        public string name6a { get; set; }
        public string name7a { get; set; }
        public string name8a { get; set; }
        public string name9a { get; set; }
        public string name10a { get; set; }
        public string name11a { get; set; }
        public string name12a { get; set; }

        public string price1a { get; set; }
        public string price2a { get; set; }
        public string price3a { get; set; }
        public string price4a { get; set; }
        public string price5a { get; set; }
        public string price6a { get; set; }
        public string price7a { get; set; }
        public string price8a { get; set; }
        public string price9a { get; set; }
        public string price10a { get; set; }
        public string price11a { get; set; }
        public string price12a { get; set; }

        public int anzahl1a { get; set; }
        public int anzahl2a { get; set; }
        public int anzahl3a { get; set; }
        public int anzahl4a { get; set; }
        public int anzahl5a { get; set; }
        public int anzahl6a { get; set; }
        public int anzahl7a { get; set; }
        public int anzahl8a { get; set; }
        public int anzahl9a { get; set; }
        public int anzahl10a { get; set; }
        public int anzahl11a { get; set; }
        public int anzahl12a { get; set; }

        #endregion


        public void Save(string path)
        {
            System.IO.FileStream FS = new System.IO.FileStream(path, System.IO.FileMode.Create);
            BinaryFormatter BF = new BinaryFormatter();
            BF.Serialize(FS, this);
            FS.Dispose();
            FS.Close();
        }

        public Taschengeldplanner_Userdaten Load(string path)
        {
            Taschengeldplanner_Userdaten US = new Taschengeldplanner_Userdaten();
            System.IO.FileStream FS = new System.IO.FileStream(path, System.IO.FileMode.Open);
            BinaryFormatter BF = new BinaryFormatter();
            US = (Taschengeldplanner_Userdaten)BF.Deserialize(FS);
            FS.Close();
            return US;
        }

    }
}
