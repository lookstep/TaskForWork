using Contancts.LIB.Models.SetDataModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Contancts.LIB.Models.GetDataModels
{
    public class Participant
    {
        private const string XMLPath = @"C:\Users\Ярослав\Desktop\Новая папка (4)\participants.xml";
        private const string DocumentNumber = "Сервис №1";

        public string Name { get; init; }
        public string Surname { get; init; }
        public DateTime RegisterDate { get; init; }
        public List<Contact> GetDataXML()
        {
            var xmlFormater = new XmlSerializer(typeof(List<Participant>));
            using var file = new FileStream(XMLPath, FileMode.Open);                              
            var xmlData = xmlFormater.Deserialize(file) as List<Participant>;
            var contacts = new List<Contact>();
            foreach (var participant in xmlData)
            {
                contacts.Add(new ContactXML(participant.Name, participant.Surname, participant.RegisterDate));
            }
            return contacts;
        }
    }
}
