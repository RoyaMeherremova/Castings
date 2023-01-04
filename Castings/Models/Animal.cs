using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castings.Models
{
    public class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal constructor");
        }
        public string Name { get; set; }
        public virtual void Sound()
        {
            Console.WriteLine("Animal sound");
        }

    }
}
