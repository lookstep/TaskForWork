using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Contancts.LIB.Models
{
    public class ContactJson : Contact
    {
        private const string jsonPath = @"C:\Users\Ярослав\Desktop\Новая папка (4)\participants.json";

        public string FirstName { get; init; }
        public string LastName { get; init; }
        public DateTime RegistrationDate { get; init; }
        public int DocumentID { get; init; }

        public ContactJson()
        {
            
        }
        public ContactJson(string firstName, string lastName, DateTime registrationDate, int Id)
        {
            FirstName = firstName;
            LastName = lastName;
            RegistrationDate = registrationDate;
            DocumentID = Id;
        }

        public async Task<IEnumerable<ContactJson>> GetData()
        {
            using var fs = new FileStream(jsonPath, FileMode.Open);
            try
            {
                return await JsonSerializer.DeserializeAsync<IEnumerable<ContactJson>>(fs);
            }
            catch
            {
                return new List<ContactJson>();
            }
        }

    }
}
