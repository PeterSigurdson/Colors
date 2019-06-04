using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    { static void Main(string[] args) {
            //new Colors().TestProgramA(); }
            new Numbers().Run();
    }

    class Colors
    {
        public void TestProgramA()
        {
            for (   ; Green();  )
            {
                while (Blue())
                {
                    if (Orange())
                    {
                        Console.WriteLine(ProgramRun++);
                    }
                    else { Console.WriteLine(ProgramRun);}
                }
            }
        }
        static int ProgramCounter1 = 0;
        Random rand1;
        int GreenVariable, BlueVariable, ProgramRun = 0;
        
        public Colors() { rand1 = new Random(); }
        bool Green()
        {   GreenVariable = rand1.Next(100);
            Console.WriteLine("the GreenVariable is {0} ", GreenVariable);
            if (GreenVariable > 50)  { return true; }
            return false;
        }
        bool Blue()  {
            BlueVariable += 2;
            Console.WriteLine("the GreenVariable is {0} ", GreenVariable);
            return Green(); }

        bool Orange()
        {
            if (GreenVariable > BlueVariable)  { return true; }
            return false;
        }
    }

        //// class Numbers
        //{
        //    int a = 0;
        //    public void Run()
        //    {
        //        for (int i = 0; i < 10; i++)
        //        {
        //            a++;
        //        }
        //    }
        //}
}
