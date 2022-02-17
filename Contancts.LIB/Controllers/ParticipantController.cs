using System.Collections.Generic;
using Contancts.LIB.Models.GetDataModels;
using Contancts.LIB.Models.SetDataModels;

namespace Contancts.LIB.Controllers
{
    public class ParticipantController
    {
        public List<Contact> AllContacts { get; set; }
        public ParticipantController()
        {
            AllContacts = new List<Contact>();
            var xmlData = new Participant();
            var jsonData = new ParticipantJson();
            var csvData = new ParticipantCSV();
            AllContacts.AddRange(xmlData.GetDataXML());
            AllContacts.AddRange(jsonData.GetDataJSON().Result);
            AllContacts.AddRange(csvData.GetDataCSV());
        }
    }
}
