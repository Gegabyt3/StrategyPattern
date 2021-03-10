// Ali Abu-Alizz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    // This class implements the interface IFormat and provides its own format for the ToString method 
    // that will later be injected into the Formatter class.
    public class FormatB : IFormat
    {
        public string ToString(Person aPerson)
        {
            return "First Name: " + aPerson.FirstName + " <br />Middle Name: " + aPerson.MiddleName + " <br />Last Name: " + aPerson.LastName + " <br />";
        }




    }
}
