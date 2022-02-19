using Contancts.LIB.Models.SetDataModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Contancts.LIB.Models.GetDataModels
{
    public class ParticipantJson
    {
        private const string jsonPath = @"C:\Users\Ярослав\Desktop\Новая папка (4)\participants.json";
        private const string DocumentNumber = "Сервис №3";

        public string FirstName { get; init; }
        public string LastName { get; init; }
        public DateTime RegistrationDate { get; init; }
        internal async Task<List<Contact>> GetDataJSON()
        {
            using var fs = new FileStream(jsonPath, FileMode.Open);
            var contacts = new List<Contact>();
            try
            {
                var jsonData = await JsonSerializer.DeserializeAsync<IEnumerable<ParticipantJson>>(fs);
                foreach (var patricipant in jsonData)
                {
                    contacts.Add(new ContactJson(patricipant.FirstName, patricipant.LastName, patricipant.RegistrationDate, DocumentNumber));
                }
                return contacts;
            }
            catch
            {
                return new List<Contact>();
            }
        }

    }
}
