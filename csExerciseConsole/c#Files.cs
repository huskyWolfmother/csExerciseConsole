using System;
using System.IO;
using System.Text;

namespace csExerciseConsole
{
    public class File
    {
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }

        public static void Main()
        {
            checkAge(20);
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]); // error!
            }
            catch (Exception bruh)
            {
                Console.WriteLine(bruh.Source);
                Console.WriteLine("ÎØÈÁÊÀ:(POSHEL_NAHUI)");
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
        }
    }
}