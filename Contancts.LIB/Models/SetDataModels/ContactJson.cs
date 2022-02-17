using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contancts.LIB.Models.SetDataModels
{
    public class ContactJson : Contact
    {
        public override string FirstName { get; init; }
        public override string LastName { get; init; }
        public override DateTime RegisterDate { get; init; }
        public override string DocumentId { get; init; }
        public ContactJson(string firstName, string lastName, DateTime registerDate, string documentId)
        {
            FirstName = firstName;
            LastName = lastName;
            RegisterDate = registerDate;
            DocumentId = documentId;
        }
    }
}
