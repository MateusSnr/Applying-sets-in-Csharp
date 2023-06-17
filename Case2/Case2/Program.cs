using System;
using Case2.Entities;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Registration> registrations = new HashSet<Registration>();

            Console.Write("How many students for course A: ");
            int a = int.Parse(Console.ReadLine());

            for(int i = 0; i < a; i++)
            {
                int registration = int.Parse(Console.ReadLine());
                registrations.Add(new Registration { RegistrationNumber = registration });
            }

            Console.Write("How many students for course B: ");
            int b = int.Parse(Console.ReadLine());

            for (int i = 0; i < b; i++)
            {
                int registration = int.Parse(Console.ReadLine());
                registrations.Add(new Registration { RegistrationNumber = registration });
            }

            Console.Write("How many students for course C: ");
            int c = int.Parse(Console.ReadLine());

            for (int i = 0; i < c; i++)
            {
                int registration = int.Parse(Console.ReadLine());
                registrations.Add(new Registration { RegistrationNumber = registration });
            }

            Console.WriteLine("Total students: " + registrations.Count);
        }
    }
}
