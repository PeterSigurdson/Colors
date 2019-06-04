using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Colors().TestProgramA(); }
            new Numbers2().Run();
        }
 }
        class Colors
        {
            public void TestProgramA()
            {
                for (; Green();)
                {
                    while (Blue())
                    {
                        if (Orange())
                        {
                            Console.WriteLine(ProgramRun++);
                        }
                        else { Console.WriteLine(ProgramRun); }
                    }
                }
            }
            static int ProgramCounter1 = 0;
            Random rand1;
            int GreenVariable, BlueVariable, ProgramRun = 0;

            public Colors() { rand1 = new Random(); }
            bool Green()
            {
                GreenVariable = rand1.Next(100);
                Console.WriteLine("the GreenVariable is {0} ", GreenVariable);
                if (GreenVariable > 50) { return true; }
                return false;
            }
            bool Blue()
            {
                BlueVariable += 2;
                Console.WriteLine("the GreenVariable is {0} ", GreenVariable);
                return Green();
            }

            bool Orange()
            {
                if (GreenVariable > BlueVariable) { return true; }
                return false;
            }
        }

        class Numbers
        {
            int a = 0;
            public void Run()
            {
                for (; true;)
                {
                    a++;
                    Console.WriteLine("Point A {0} ", a);
                    if (a > 5)
                    {
                        a -= 3;
                        Console.WriteLine("Point B {0} ", a);
                    }
                }
            }
        }

        class Numbers2
        {
        int a  = 2 , b = 3, c = 2;
            public void Run()
            {

                while (true)
                {
                Console.WriteLine(a);
                    a *= 2;

                if (a > 10) a -= 11;
                }

            }

            public void ArrayPlay(int []a, int b)
        {
            int GeorgeTheLion = 0;
            a = new int[b];
            for (int i =0; i<a.Length; i++)
            {
                a[i] = GeorgeTheLion++;
            }

        }

        public void ArrayPlay2()
        {

        }

        }
   
}
