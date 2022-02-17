using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contancts.LIB.Models.SetDataModels
{
    public abstract class Contact
    {
        public abstract string FirstName { get; init; }
        public abstract string LastName { get; init; }
        public abstract DateTime RegisterDate { get; init; }
    }
}
