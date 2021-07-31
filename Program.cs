using ExercicioHeranca.Entities;
using System;
using System.Collections.Generic;

namespace ExercicioHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int numEmp = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numEmp; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced? (y/n) - ");
                string opt = Console.ReadLine().ToLower();

                if (opt == "y" || opt == "n")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePerhour = double.Parse(Console.ReadLine());
                    if (opt == "n")
                    {
                        employees.Add(new Employee(name, hours, valuePerhour));
                    }
                    else
                    {
                        Console.Write("Additional charge: ");
                        double additionalCharge = double.Parse(Console.ReadLine());
                        employees.Add(new OutsourcedEmployee(name, hours, valuePerhour, additionalCharge));
                    }
                }
                else
                {
                    Console.WriteLine("Opção Inválida!");
                    i--;
                    continue;
                }

            }

            Console.WriteLine("PAYMENTS:");
            foreach (Employee e in employees)
            {
                Console.WriteLine($"{e.Name} - $ {e.Payment()}");
            }

        }
    }
}
