using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 
/// </summary>
namespace ubozhestvo111
{

    /// <summary>
    /// 
    /// </summary>
    

    class Car

    {
        string model;
        string color;
        int year;

        static int BruhMethod(int x, int y)
        {
            Console.WriteLine(x + y);
            return x + y;
        }
        static int BruhMethod(int x)
        {
            return 0;
        }
        /// <summary>
        /// 
        /// </summary>
        static void MyMethod(string fname = "bruh", int lel = 1)
        {
            Console.WriteLine("Привет, " + fname + "." + lel);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // я лох убейт е меня пжлста
            string fname = "loh";
            MyMethod("ultraloh", 12);
            int bruh = 0;
            while (bruh<10)
            {
                BruhMethod(3);
                BruhMethod(3, 2);
                MyMethod(fname, bruh);
                MyMethod(fname, bruh);
                bruh++;
            }
            
            Console.WriteLine("убейте емня");
            Console.WriteLine("hach");
            Console.Write("hach");
            Console.WriteLine(3 + 3);
            
            int Lohblya = 5;
            Console.WriteLine(Lohblya);
            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);

            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);   // Outputs True
            Console.WriteLine(isFishTasty);   // Outputs False

            char myGrade = '1';
            Console.WriteLine(myGrade);

            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double

            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);   // Outputs 9

             myDouble = 9.99;
             myInt = (int)myDouble;    // Manual casting: double to int

            Console.WriteLine(myDouble);   // Outputs 9.78
            Console.WriteLine(myInt);      // Outputs 9

             myInt = 10;
             myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

            
            Console.WriteLine();

            Console.WriteLine("Enter your age:");
            int age;
            string lel = "45";
            age = Convert.ToInt32(lel);
            Console.WriteLine("Your age is: " + age);
            Console.WriteLine(Math.Round(-4.5));

            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length);

             txt = "Hello World";
            Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txt.ToLower());   // Outputs "hello world"

            string firstName = "John ";
            string lastName = "Doe";
            string name = firstName + lastName;
            Console.WriteLine(name);


             firstName = "John ";
             lastName = "Doe";
            name = string.Concat(firstName, lastName);
            Console.WriteLine(name);

            int x = 10;
            int y = 20;
            int z = x + y;  // z will be 30 (an integer/number)

            string xx = "10";
            string yy = "20";
            string zz = xx + yy;  // z will be 1020 (a string)

            int xxx = 10;
            string yyy = "10";
            int zzz = xxx + Convert.ToInt32(yyy);
            string zzzz;
            zzzz = Convert.ToString(xxx) + Convert.ToString(yyy);


            

             firstName = "John";
             lastName = "Doe";
             name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);

            string myString = "Hello";
            Console.WriteLine(myString[0]);  // Outputs "H"
            char myChar = myString[0];
            Console.WriteLine(myChar);

            myString = "Hello";
            Console.WriteLine(myString.IndexOf("o"));  // Outputs "1"

            // Full name
             name = "John Doe";

            // Location of the letter D
            int charPos = name.IndexOf("D");

            // Get last name
             lastName = name.Substring(charPos);

            // Print the result
            Console.WriteLine(lastName);

            txt = "We are the so-called \\   \'\'\'\'\'\"\"\"\"\" \"Vikings\" from the north. It\'s alright.";
            Console.WriteLine(txt);

            x = 10;
            y = 9;
            Console.WriteLine(x != y); // returns True, because 10 is higher than 9

             x = 20;
             y = 18;
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }

            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            // Outputs "Good evening."

            time = 20;
            string result = (time == 18) ? "18" : (result = (time == 19) ? "19" : (result = (time == 20) ? "20" : "hachahchahch"));
            Console.WriteLine(result);

            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            // Outputs "Thursday" (day 4)
            int i = 0;
            while (i < 9)
            {
                Console.WriteLine(i);
                i++;
            }

            for (i = 0; i <= 10; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Convert.ToString(i);
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars.Length);
            Array.Sort(cars);

            foreach (string ii in cars)
            {
                Console.WriteLine(ii);
            }

            for (int ii = 0; ii < cars.Length; ii++)
            {
                Console.WriteLine(cars[ii]);
            }

            for ( i = 0; i < 10; i++)
            {
                if (i > 4)
                {
                    continue;

                }
                Console.WriteLine(i);
            }

            Car myObj1 = new Car();
            Car myObj2 = new Car();
            Console.WriteLine(myObj1.color);
            Console.WriteLine(myObj2.color);
            Class1 notbruh = new Class1();
            Console.WriteLine(notbruh.bruh);


            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 1969;

            Car Opel = new Car();
            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);

            Console.ReadKey();
        }
    }

}
