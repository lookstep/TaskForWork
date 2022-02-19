using System;
using System.Text.RegularExpressions;
using Contancts.LIB.Controllers;
namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandList = new string[] {"search", "get-page"};
            var participantController = new ParticipantController();

            var command = Console.ReadLine();
            var commandSplit = command.Split($" ");
            if(Regex.IsMatch(commandSplit[0], commandList[0]) && Regex.IsMatch(commandSplit[1], @"[""]"))
            {
                Console.Clear();
                foreach (var particiant in participantController.GetCurrentContact(commandSplit[1].Trim().Trim('"')))
                {
                    Console.WriteLine(particiant);
                } 
            }
            else if (Regex.IsMatch(commandSplit[0], commandList[1]) && int.TryParse(commandSplit[1], out int pageNumber))
            {
                Console.Clear();
                if(participantController.GetPage(pageNumber) is null)
                    Console.WriteLine("Такой страницы нет");
                foreach (var particiant in participantController.GetPage(pageNumber))
                {
                    Console.WriteLine(particiant);
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Такой команды нет");
            }
            

        }
    }
}
