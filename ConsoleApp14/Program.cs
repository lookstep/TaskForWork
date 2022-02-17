using System;
using Contancts.LIB.Controllers;
namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new ParticipantController();
            foreach (var el in test.AllContacts)
            {
                Console.WriteLine($"{el.FirstName} {el.LastName}, {el.RegisterDate}");
            }
        }
    }
}
