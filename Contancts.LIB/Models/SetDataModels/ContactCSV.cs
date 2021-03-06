using System;

namespace Contancts.LIB.Models.SetDataModels
{
    internal class ContactCSV : Contact
    {
        public override string FirstName { get; init; }
        public override string LastName { get; init; }
        public override DateTime RegisterDate { get; init; }
        public override string DocumentId { get; init; }

        public ContactCSV(string firstName, string lastName, DateTime registerDate, string documentId)
        {
            FirstName = firstName;
            LastName = lastName;
            RegisterDate = registerDate;
            DocumentId = documentId;
        }
    }
}
