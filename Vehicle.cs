using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanic
{
    /// <summary>
    /// The Vehicle abstract class defines common properties and methods for all vehicles
    /// </summary>
    abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public List<IPart> Parts { get; set; }

        /// <summary>
        ///  The virtual ListParts method is overridden by the Car class to list its parts
        /// </summary>
        public virtual void ListParts()
        {
            Console.WriteLine($"Parts for {Make} {Model} ({Year}):");
            foreach (var part in Parts)
            {
                Console.WriteLine($"{part.Name}: ${part.Price}");
            }
        }
    }
}
