using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanic
{
    /// <summary>
    /// The Part abstract class defines common properties for all vehicle parts
    /// </summary>
    abstract class Part : IPart
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
