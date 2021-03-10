// Ali Abu-Alizz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    // This class is responsible for injection.
    // It implements the interface IFormat and then the method ToString in this class will call the ToString method that other classes  
    // that are going to be injected into this class have.
    public class Formatter : IFormat
    {
        private IFormat aFormat;

        public Formatter(IFormat aFormat)
        {
            this.aFormat = aFormat;
        }

        public string ToString(Person aPerson)
        {
            return aFormat.ToString(aPerson);
        }

    }
}
