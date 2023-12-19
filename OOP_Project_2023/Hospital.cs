using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_2023
{
    class Hospital
    {
        public List<Person> Persons { get; set; }
        public Hospital()
        {
            Persons = new List<Person>();
        }
        public void admit_person(Person person)
        {
            Persons.Add(person);
            Console.WriteLine($"{person.Name}, has been admitted to the hospital.");
        }
    }
}