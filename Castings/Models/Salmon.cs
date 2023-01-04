using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castings.Models
{
    public class Salmon:Fish
    {
        public Salmon()
        {
            Console.WriteLine("Salmon constructor");
        }
        public string Color { get; set; }
        public override void Sound()
        {
            Console.WriteLine("Salmon sound");
        }
    }
}
