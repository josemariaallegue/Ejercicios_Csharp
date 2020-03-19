using System;
using System.Threading;

namespace threads
{
    class Program
    {
        static void Main(string[] args)
        {
            #region threads declaracion basica y .isBackground
            //Thread t1 = new Thread(HolaMundo);
            //Thread t2 = new Thread(AdiosMundo);

            ////isBackground hace que aplicacion termine incluso si sigue corriendo el thread
            //t1.IsBackground = true;
            //t2.IsBackground = true;

            //t1.Start();
            //t2.Start();

            #endregion

            #region lock




            #endregion

        }

        public static void HolaMundo()
        {
            for(int i = 0;i <100; i++)
            {
                Console.WriteLine($"i: {i}");
            }
        }

        public static void AdiosMundo()
        {
            for (int j = 0; j < 100; j++)
            {
                Console.WriteLine($"j: {j}");
            }
        }

}
