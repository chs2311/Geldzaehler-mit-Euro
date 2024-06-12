using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Geldzähler_mit_Euro
{
    [Serializable]
    internal class Userdaten
    {
        public string gesamt { get; set; }
        public string ausgaben { get; set; }
        public string mykonto { get; set; }
        public string cent1 { get; set; }
        public string cent2 { get; set; }
        public string cent5 { get; set; }
        public string cent10 { get; set; }
        public string cent20 { get; set; }
        public string cent50 { get; set; }
        public string euro1 { get; set; }
        public string euro2 { get; set; }
        public string euro5 { get; set; }
        public string euro10 { get; set; }
        public string euro20 { get; set; }
        public string euro50 { get; set; }
        public string euro100 { get; set; }
        public string euro200 { get; set; }
	   public string FARBE { get; set; }
	   public string color { get; set; }

        /* <save, load> this string, entered string*/

        public void Save(string path)
        {
            System.IO.FileStream FS = new System.IO.FileStream(path, System.IO.FileMode.Create);
            BinaryFormatter BF = new BinaryFormatter();
            BF.Serialize(FS, this);
            FS.Dispose();
            FS.Close();
        }

        public Userdaten Load(string path)
        {
            Userdaten US = new Userdaten();
            System.IO.FileStream FS = new System.IO.FileStream(path, System.IO.FileMode.Open);
            BinaryFormatter BF = new BinaryFormatter();
            US = (Userdaten)BF.Deserialize(FS);
            FS.Close();
            return US;
            
        }
    }
}
