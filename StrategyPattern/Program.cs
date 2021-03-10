// Ali Abu-Alizz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    // This program uses the strategy design pattern to utilize various different formats
    // of printing a person's name as a string using injection through an abstract format interface.
    class Program
    {
        static void Main(string[] args)
        {
            Person aPerson = new Person();
            aPerson.FirstName = "Jane";
            aPerson.MiddleName = "Elizabeth";
            aPerson.LastName = "Brown";
            IFormat formatB = new FormatD();    // new object of a certain type of format implementing the interface IFormat
                                                // this can be FormatB or FormatC or FormatD etc...


            Formatter aFormatter = new Formatter(formatB); // Injection of the strategy pattern happens here
            Console.WriteLine(aFormatter.ToString(aPerson));
            Console.ReadLine();
        }
    }
}
