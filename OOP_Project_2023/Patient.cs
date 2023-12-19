using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_2023
{
    class Patient : Person
    {
        public int Patient_id { get; set; }
        public string Condition { get; set; }
        public override void the_role()
        {
            Console.WriteLine($"{Name}, the patient, is receiving treatment for {Condition}.");
        }
    }
}