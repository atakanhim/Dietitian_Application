using diyetisyenproje.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diyetisyenproje
{
    public class JsonParser
    {
        public void JsonCevir()
        {
            string strResultJson = JsonConvert.SerializeObject(Singleton.Instance.secilenHastabilgileri);
            File.WriteAllText(@"deneme.json", strResultJson.ToString());
         
            strResultJson = String.Empty;
            strResultJson = File.ReadAllText(@"deneme.json");
            SecilenHastabilgileri resultStudent = JsonConvert.DeserializeObject<SecilenHastabilgileri>(strResultJson);
            MessageBox.Show("stroed");


        }
    }
}
