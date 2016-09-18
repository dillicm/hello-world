using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class Student
    {
        static void Main(string[] args)

        {
            System.Console.WriteLine("First Name:");
           string Name = Console.ReadLine();
            System.Console.WriteLine("Last Name:");
            string LastName = Console.ReadLine();
            System.Console.WriteLine("Address:");
            string Adress = Console.ReadLine();
            System.Console.WriteLine("State:");
            string State = Console.ReadLine();
            Console.WriteLine("Zip:");
            string Zip = Console.ReadLine();

            Student1 one = new Student1(Name, LastName, Adress,State,Zip);

            System.Console.WriteLine(one.getInfo());
            System.Console.ReadLine();



        }
    }
}
