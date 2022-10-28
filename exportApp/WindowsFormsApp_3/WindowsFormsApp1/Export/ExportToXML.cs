using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    class ExportToXML: Export
    {
        public void ExportToFile(User user, List<User> ListUsers)
        {
            string file = @"usersX.xml";
            FileInfo fileInf = new FileInfo(file);
            if (fileInf.Exists)
            {
                fileInf.Delete();
            }

            XmlSerializer formatter = new XmlSerializer(typeof(User));
            using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
            {
                foreach (var u in ListUsers)
                {
                    formatter.Serialize(fs, u);
                }

            }
        }
    }
}
