using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csExerciseConsole
{
    class Vehicle  // base class (parent) 
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }
    class Car : Vehicle  // derived class (child)
    {
        new public string brand = "Opel";
        public string modelName = "Mustang";  // Car field
    }
}
