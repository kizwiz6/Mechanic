using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanic
{
    /// <summary>
    /// The Car class extends the Vehicle abstract class and implements the IRepairable and IMaintenance interfaces
    /// </summary>
    internal class Car : Vehicle, IRepairable, IMaintenance
    {
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
            Parts = new List<IPart>();
        }

        // The ListParts method overrides the parent Vehicle's method to list the car's parts
        public override void ListParts()
        {
            Console.WriteLine($"Parts for {Make} {Model} ({Year}):");
            foreach (var part in Parts)
            {
                Console.WriteLine($"{part.Name}: ${part.Price}");
            }
        }

        /// <summary>
        /// The Repair method implements the IRepairable interface to repair the car
        /// </summary>
        public void Repair()
        {
            Console.WriteLine($"Repairing {Make} {Model} ({Year})...");
        }

        /// <summary>
        /// The Replace method implements the IMaintenance interface to replace the car's parts
        /// </summary>
        public void Replace()
        {
            Console.WriteLine($"Replacing parts for {Make} {Model} ({Year})...");
        }
    }
}
