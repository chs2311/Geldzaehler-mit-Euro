using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Geldzähler_mit_Euro
{
    [Serializable]
    internal class Login
    {
        public string username { get; set; }
        public string password { get; set; }

        public void Save(string path)
        {
            System.IO.FileStream FS = new System.IO.FileStream(path, System.IO.FileMode.Create);
            BinaryFormatter BF = new BinaryFormatter();
            BF.Serialize(FS, this);
            FS.Dispose();
            FS.Close();
        }

        public Login Load(string path)
        {
            Login lg = new Login();
            System.IO.FileStream FS = new System.IO.FileStream(path, System.IO.FileMode.Open);
            BinaryFormatter BF = new BinaryFormatter();
            lg = (Login)BF.Deserialize(FS);
            FS.Close();
            return lg;
        }
    }
}
