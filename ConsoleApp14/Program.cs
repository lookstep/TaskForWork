using System;
using System.Diagnostics;
using System.IO;
using Contancts.LIB.Models;
namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new ContactJson();
            var y = new Participant();
            var z = new ContactCSV();
            var cheak = new Stopwatch();
            cheak.Start();
            foreach (var el in z.GetData().Result)
            {
                Console.WriteLine(el.Date);
            }
            foreach (var el in x.GetData().Result)
            {
                Console.WriteLine(el.RegistrationDate);
            }
            foreach (var el in y.GetData().Result)
            {
                Console.WriteLine(el.RegisterDate);
            }
            cheak.Stop();
            Console.WriteLine($"\n\nMS: {cheak.ElapsedMilliseconds}");
        }
    }
}
