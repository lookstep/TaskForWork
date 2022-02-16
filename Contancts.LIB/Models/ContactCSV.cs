using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace Contancts.LIB.Models
{
    public class ContactCSV
    {   
        [Index(0)]
        public string Name { get; set; }
        [Index(1)]
        public string SecondName { get; set; }
        [Index(2)]
        public DateTime Date { get; set; }

        public async Task<List<ContactCSV>> GetData()
        {
            using var Sr = new StreamReader(@"C:\Users\Ярослав\Desktop\Новая папка (4)\participants.csv");
            using var csvReader = new CsvReader(Sr, System.Globalization.CultureInfo.InvariantCulture);              
            return await csvReader.GetRecordsAsync<ContactCSV>().ToListAsync();
        }
    }
}
