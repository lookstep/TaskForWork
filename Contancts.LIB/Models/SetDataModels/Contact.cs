using System;

namespace Contancts.LIB.Models.SetDataModels
{
    public abstract class Contact
    {
        public abstract string FirstName { get; init; }
        public abstract string LastName { get; init; }
        public abstract DateTime RegisterDate { get; init; }
        public abstract string DocumentId { get; init; }
        public override string ToString()
        {
            return $"{FirstName} {LastName} {RegisterDate.ToString("g")} {DocumentId}";
        }
    }
}
