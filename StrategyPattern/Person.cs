// Ali Abu-Alizz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{

    // Person class that has three variables with gets and sets and a method that returns a formatted string
    public class Person
    {
        private string firstName = "n/a";
        private string lastName = "n/a";
        private string middleName = "n/a";

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set { this.middleName = value; }
        }

        // Basic format without the strategy pattern being used.
        public string ToString(string fname, string mname, string lname)
        {
            return "First Name: " + fname + " \nMiddle Name: " + mname + " \nLast Name: " + lname + " \n";

        }

    }
}
