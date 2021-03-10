// Ali Abu-Alizz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    // Interface that will be used by all the classes that are going to have different print formatting for the ToString method
    // This allows for abstraction and extension.
    public interface IFormat
    {
        string ToString(Person aPerson);

    }
}
