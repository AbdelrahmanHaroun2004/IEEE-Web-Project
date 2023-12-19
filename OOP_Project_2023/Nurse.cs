using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_2023
{
    class Nurse : Person
    {
        public override void the_role()
        {
            Console.WriteLine($"{Name}, the nurse, is assisting patients.");
        }
    }
}