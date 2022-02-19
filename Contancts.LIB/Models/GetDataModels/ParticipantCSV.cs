using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Contancts.LIB.Models.SetDataModels;
using CsvHelper;
using CsvHelper.Configuration.Attributes;

namespace Contancts.LIB.Models.GetDataModels
{
    public class ParticipantCSV
    {
        private const string CSVPath = @"C:\Users\Ярослав\Desktop\Новая папка (4)\participants.csv";
        private const string DocumentNumber = "Сервис №2";

        [Index(0)]
        public string Name { get; init; }
        [Index(1)]
        public string SecondName { get; init; }
        [Index(2)]
        public DateTime Date { get; init; }

        internal List<Contact> GetDataCSV()
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
