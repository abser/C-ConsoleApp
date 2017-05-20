using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Person = new Person();
            try
            {
                Console.WriteLine("Please entetr your name:");
                Person.Name = Console.ReadLine();
                if (!Person.validName())
                {
                    Console.WriteLine("Bad Name! tRY Again");
                }
                
                Console.WriteLine("Please entetr your Age:");
                Person.Age = Convert.ToInt16(Console.ReadLine());


                Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something Wrong!");
            }
        }
    }


    class Person
    {
        public string Name;
        public int Age;
        public bool validName()
        {
            if (Name.Length == 0)
            {
                return false;
            } 

            return true;
        }

        public bool validAge()
        {
            if (Age < 0 || Age >100)
            {
                return false;
            }

            return true;
        }

    }
}
 