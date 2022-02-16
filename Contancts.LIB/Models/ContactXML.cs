using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Contancts.LIB.Models
{
    public class Participant : Contact
    {
        private const string XMLPath = @"C:\Users\Ярослав\Desktop\Новая папка (4)\participants.xml";
        public string Name { get; init; }
        public string Surname { get; init; }
        public DateTime RegisterDate { get; init; }
        public int DocumentID { get; init; }
        public async Task<List<Participant>> GetData()
        {
            var xmlData = new List<Participant>();
            var xmlFormater = new XmlSerializer(typeof(List<Participant>));
            using (var file = new FileStream(XMLPath, FileMode.Open))
            {
                await Task.Run(() => {xmlData = xmlFormater.Deserialize(file) as List<Participant>; });
            }
            return xmlData;
        }
    }
}
