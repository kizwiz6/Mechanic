using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanic
{
    /// <summary>
    /// The IPart interface defines the properties for a vehicle part
    /// </summary>
    public interface IPart
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
