using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name;
            Console.WriteLine("please enter your name");
          Name= Console.ReadLine();
            Console.WriteLine("hello" + Name);
            Console.ReadKey();
        }
    }
}
