using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();
            Doctor doctor = new Doctor();
            Nurse nurse = new Nurse();
            Patient patient = new Patient();

            bool running = true;
            while (running)
            {
                Console.WriteLine("1- Add Doctor");
                Console.WriteLine("2- Add Nurse");
                Console.WriteLine("3- Add Patient");
                Console.WriteLine("4- Exit Program");

                Console.WriteLine();

                Console.Write("Choose Action: ");

                int action = int.Parse(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        Console.Write("Doctor Name: ");
                        doctor.Name = Console.ReadLine();
                        Console.Write("Doctor Age: ");
                        doctor.Age = int.Parse(Console.ReadLine());
                        Console.Write("Doctor Gender: ");
                        doctor.Gender = Console.ReadLine();
                        Console.Write("Doctor Specialization: ");
                        doctor.Specialization = Console.ReadLine();
                        Console.WriteLine();
                        hospital.admit_person(doctor);
                        doctor.the_role();
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.Write("Nurse Name: ");
                        nurse.Name = Console.ReadLine();
                        Console.Write("Nurse Age: ");
                        nurse.Age = int.Parse(Console.ReadLine());
                        Console.Write("Nurse Gender: ");
                        nurse.Gender = Console.ReadLine();
                        Console.WriteLine();
                        hospital.admit_person(nurse);
                        nurse.the_role();
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.Write("Patient Name: ");
                        patient.Name = Console.ReadLine();
                        Console.Write("Patient Age: ");
                        patient.Age = int.Parse(Console.ReadLine());
                        Console.Write("Patient Gender: ");
                        patient.Gender = Console.ReadLine();
                        Console.Write("Patient ID: ");
                        patient.Patient_id = int.Parse(Console.ReadLine());
                        Console.Write("Patient Condition: ");
                        patient.Condition = Console.ReadLine();
                        Console.WriteLine();
                        hospital.admit_person(patient);
                        patient.the_role();
                        Console.WriteLine();
                        break;

                    case 4:
                        running = false;
                        break;
                }
            }
        }
    }
}