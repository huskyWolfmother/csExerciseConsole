using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testme1
{
    class Program
    {
        static void BankCounts(double vklad, int months)
        {
            double konsum = vklad + ((vklad * 0.07) * 12);
            Console.WriteLine(konsum);
        }
        static void Main(string[] args)
        {
            /*
             За каждый месяц банк начисляет к сумме вклада 7% от суммы. 
             Напишите консольную программу,
             в которую пользователь вводит сумму вклада и количество месяцев. 
             А банк вычисляет конечную сумму вклада с учетом начисления процентов за каждый месяц.
             
             */
            
            Console.WriteLine("сумма");
            double vklad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("месяца");
            int months = Convert.ToInt32(Console.ReadLine());
            BankCounts(vklad, months);
        }
    }
}
