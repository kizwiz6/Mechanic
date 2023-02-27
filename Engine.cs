using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanic
{
    /// <summary>
    /// The Engine class extends the Part abstract class and defines an Engine part
    /// </summary>
    class Engine : Part
    {
        public Engine()
        {
            Name = "Engine";
            Price = 3000.0;
        }
    }
}