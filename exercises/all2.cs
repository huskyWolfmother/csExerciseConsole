using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Level
    {
        Low=99,
        Medium,
        High,
        topkek
    }
    interface IAnimal
    {
         void animalSound();
         void sleep();
        
    }
    class Pig : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("hru-hru");
        }
        public void sleep()
        {

        }
    }
    class Vehicle
    {
        public string brand = "Ford";
        public virtual void honk()
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Car : Vehicle
    {
        public string modelName = "Mustang";
        public override void honk()
        {
            Console.WriteLine("DOOT, DOOT!");
        }
    }

    interface IFirstInterface
    {
        void myMethod(); // interface method
    }

    interface ISecondInterface
    {
        void myOtherMethod(); // interface method
    }

    // Implement multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Some text..");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int myNum = (int)Level.topkek;
            Console.WriteLine(myNum);
            DemoClass myObj = new DemoClass();
            myObj.myMethod();
            myObj.myOtherMethod();
            Pig myPig = new Pig();
            myPig.animalSound();
            myPig.sleep();
            Vehicle myVehicle = new Vehicle();
            Car myCar = new Car();
            myVehicle.honk();
            myCar.honk();
            Console.WriteLine(myCar.brand + ' ' + myCar.modelName);
            string writeText = "Hello World!";  // Create a text string
            File.WriteAllText("filename.txt", writeText);  // Create a file and write the content of writeText to it
            File.Copy(filename.txt);

            string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
            Console.WriteLine(readText);  // Output the content
        }
    }
}

