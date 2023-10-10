using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Non_PrimitiveTypes_Classes.Math;

namespace Non_PrimitiveTypes_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPerson = new Person();
            firstPerson.FirstName = "Naren";
            firstPerson.LastName = "Bagavathy";
            firstPerson.Introduce();

            var calculator = new Calculator();
            var addResult = calculator.Add(6, 2);
            Console.WriteLine(addResult);
        }
    }
}
