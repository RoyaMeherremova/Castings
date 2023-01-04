﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castings.Models
{
    public class Eagle:Bird
    {
        public int Speed { get; set; }
        public override void Sound()
        {
            Console.WriteLine("Eagle sound");
        }
    }
}
