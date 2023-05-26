using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num; 
            Console.WriteLine("please enter your num");
            string number = Console.ReadLine();
            Num = int.Parse(number);
            Num *= 3;
            Console.WriteLine(Num);
            Console.WriteLine("enter any key to exit");
            Console.ReadKey();
        }
    }
}
