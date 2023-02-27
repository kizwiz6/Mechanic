using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanic
{
    /// <summary>
    /// The Tire class extends the Part abstract class and defines a Tire part
    /// </summary>
    class Tire : Part
    {
        /// <summary>
        /// The Tire constructor sets the Name and Price properties for the Tire
        /// </summary>
        public Tire()
        {
            Name = "Tire";
            Price = 200.0;
        }
    }
}
