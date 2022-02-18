using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contancts.LIB.Models.SetDataModels;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace Contancts.LIB.Models.GetDataModels
{
    public class ParticipantCSV
    {
        private const string CSVPath = @"C:\Users\Ярослав\Desktop\Новая папка (4)\participants.csv";
        private const string DocumentNumber = "Сервис №2";

        [Index(0)]
        public string Name { get; set; }
        [Index(1)]
        public string SecondName { get; set; }
        [Index(2)]
        public DateTime Date { get; set; }

        public List<Contact> GetDataCSV()
        {
            var contacts = new List<Contact>();
            
            using var Sr = new StreamReader(CSVPath);
            using var csvReader = new CsvReader(Sr, System.Globalization.CultureInfo.InvariantCulture);              
            var dataCsv = csvReader.GetRecords<ParticipantCSV>().ToList();
            foreach (var participant in dataCsv)
            {
                contacts.Add(new ContactCSV(participant.Name, participant.SecondName, participant.Date, DocumentNumber)); ;
            }
            return contacts;
        }
    }
}
