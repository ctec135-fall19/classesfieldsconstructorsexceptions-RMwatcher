using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region region 1
            // or cond1 = 0;
            for (int printerPrintsCondition = 0; printerPrintsCondition <= 1; printerPrintsCondition++)
            {
                // cond2 = red light is flashing
                for (int cond2 = 0; cond2 <= 1; cond2++)
                {
                    for (int cond3 = 0; cond3 <= 1; cond3++)
                    {
                        if (printerPrintsCondition == 0 && cond2 == 0 && cond3 == 0)
                        {
                            // print out conditions
                            Console.WriteLine("Print prints condition: NO");
                            Console.WriteLine("A red light is flashing: NO");
                            Console.WriteLine("Printer is recognized by computer: NO");
                            // call action methods
                        }

                        if (printerPrintsCondition == 0 && cond2 == 0 && cond3 == 1)
                        {
                            // call action methods
                        }
                    }
                }
            }
            #endregion

            #region region 2
            for (int i = 0; i <= 7; i++)
            {
                switch (i)
                {
                    case 0:
                        // print conditions
                        // call actions methods for No, No, No
                        Console.WriteLine("");
                        break;

                    case 1:
                        // call actions methods for NO, No, Yes
                        Console.WriteLine("");
                        break;

                    case 2:
                        // call actions methods for No, Yes, no
                        Console.WriteLine("");
                        break;

                }
            }

            #endregion
        }

        public void CheckInk()
        {
            Console.WriteLine("Check ink and replace if empty");
        }

        public void CheckPaperJam()
        {
            Console.WriteLine("Check printer for a paper jam");
        }
    }
}
