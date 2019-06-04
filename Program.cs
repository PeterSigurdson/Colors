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
        static int ProgramCounter1 = 0;
        Random rand1;
        int GreenVariable, BlueVariable, OrangeVariable = 0;
        static void Main(string[] args)
        {
            
        }

        public void TestProgramA()
        {
            for (   ; Green();  )
            {
                while (Blue())
                {
                    if (Orange())
                    {

                    }
                }
            }
        }

        bool Green()
        {   GreenVariable = rand1.Next(100);
            if (GreenVariable > 50)
            {
                return true;
            }
            return false;
        }
       
    }
}
