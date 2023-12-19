using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_2023
{
    class Doctor : Person
    {
        public string Specialization { get; set; }
        public override void the_role()
        {
            Console.WriteLine($"Dr/ {Name}, the {Specialization} doctor, is examining patients.");
        }
    }
}