using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csExerciseConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a myCar object
            Car myCar = new Car();

            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();
            Vehicle myVehicle = new Vehicle();
            Console.WriteLine(myVehicle.brand);
            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName);

            string zhopa = "top";
            string ruchka = " kek";
            zhopa += ruchka;
            Console.WriteLine(Math.Max(5, 10));

            int a = Convert.ToInt32(Console.ReadLine());
        }
    }
}
