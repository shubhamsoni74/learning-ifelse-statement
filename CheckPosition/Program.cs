using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int marks;
            Console.WriteLine("Enter your marks");
            marks = int.Parse(Console.ReadLine());
            if (marks>=80)
            {
                Console.WriteLine("First Position");
            }
            else if (marks>=70&marks<80)
            {
                Console.WriteLine("Second position");
            }
            else if (marks >= 40 & marks < 70)
            {
                Console.WriteLine("Third position");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            Console.ReadLine();
        }
    }
}
