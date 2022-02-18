using System.Collections.Generic;
using System.Linq;
using Contancts.LIB.Models.GetDataModels;
using Contancts.LIB.Models.SetDataModels;

namespace Contancts.LIB.Controllers
{
    public class ParticipantController
    {
        public List<Contact> AllContacts { get; set; }
        public Contact CurrentContact { get; set; }
         
        public ParticipantController()
        {
            AllContacts = new List<Contact>();
            var xmlData = new Participant();
            var jsonData = new ParticipantJson();
            var csvData = new ParticipantCSV();
            AllContacts.AddRange(xmlData.GetDataXML());
            AllContacts.AddRange(jsonData.GetDataJSON().Result);
            AllContacts.AddRange(csvData.GetDataCSV());

            var duplicates = AllContacts
                .Where(x => AllContacts
                .Except(new List<Contact> { x }).Any(y => y.FirstName == x.FirstName && y.LastName == x.LastName && y.RegisterDate < x.RegisterDate || y.RegisterDate == x.RegisterDate))
                .OrderBy(x => x.RegisterDate)
                .ToList();
            foreach (var latersData in duplicates)
            {
                AllContacts.Remove(latersData);
            }
            AllContacts = AllContacts.OrderBy(x => x.RegisterDate).ToList();
        }
        public string GetCurrentContact(string name)
        {
            var contact = AllContacts.FirstOrDefault(x => x.FirstName == name);
            if (contact is null)
                return "Контакт не найден.";
            else return contact.ToString();
        }
        public IEnumerable<Contact> GetPage(int pageNumber)
        {
            List<Contact> viewContact = new List<Contact>();
            switch (pageNumber)
            {
                case 1:
                    for (int i = 0; i < 5; i++)
                    {
                        viewContact.Add(AllContacts[i]);
                    }
                    break;
                case 2:
                    for (int i = 5; i < 10; i++)
                    {
                        viewContact.Add(AllContacts[i]);
                    }
                    break;
                case 3:
                    for (int i = 10; i < 15; i++)
                    {
                        viewContact.Add(AllContacts[i]);
                    }
                    break;
                case 4:
                    for (int i = 15; i < 20; i++)
                    {
                        viewContact.Add(AllContacts[i]);
                    }
                    break;
                case 5:
                    viewContact.Add(AllContacts.LastOrDefault());
                    break;
                default:
                    viewContact = null;
                    break;
            }
            return viewContact;
        }

        
    }
}
