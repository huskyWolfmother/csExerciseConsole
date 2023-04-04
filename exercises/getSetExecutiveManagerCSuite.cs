using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ne_slishkom_ubozhestvo3
{
    public class Manager
    {
        public string Name
        {
            get;
            set;
        }
        public string Designation
        {
            get;
            set;
        }
        public int KPI
        {
            get;
            set;
        }
        public Executive EvaluateSubordinate(Executive executive)
        {
            Random random = new Random();
            executive.KPI = random.Next(40, 100);
            return executive;
        }

    }
    public class CSuite
    {
        public string Name
        {
            get;
            set;
        }
        public string Designation
        {
            get;
            set;
        }
        public Manager EvaluateSubordinate(Manager manager)
        {
            Random random = new Random();
            manager.KPI = random.Next(60, 100);
            return manager;
        }
        public void TerminateExecutive(Executive executive)
        {
            Console.WriteLine($"Employee {executive.Name} with KPI {executive.KPI} has been terminated because of KPI below 70");
        }
        public void TerminateManager(Manager manager)
        {
            Console.WriteLine($"Employee {manager.Name} with KPI {manager.KPI} has been terminated because of KPI below 70");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            double c, f, k;
            Console.Write("c: ");
            c = Convert.ToDouble(Console.ReadLine());
            f = (9 * c + (32 * 5)) / 5;
            k = c + 273;
            Console.WriteLine("{0}, {1}", f, k);
            {
                Console.WriteLine(first_last("w3resource"));
                Console.WriteLine(first_last("The quick brown fox jumps over the lazy dog."));
                Console.WriteLine(first_last("жмых"));
            }
            string first_last(string ustr)
            {
                // code that I don't understand
                return ustr.Length > 1
                ? ustr.Substring(0, 1) + ustr.Substring(0) + ustr.Substring(0, 1) : ustr;
            }
        }
        }
}