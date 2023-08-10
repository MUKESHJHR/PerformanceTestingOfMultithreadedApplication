using System.Diagnostics;

namespace PerformanceTestingOfMultithreadedApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Example - 1 (Threading Performance Testing using a single thread)
            //Stopwatch stopwatch = Stopwatch.StartNew();
            //stopwatch = Stopwatch.StartNew();
            //EvenNumbersSum();
            //OddNumbersSum();
            //stopwatch.Stop();
            //Console.WriteLine($"Total time in milliseconds = { stopwatch.ElapsedMilliseconds}");
            #endregion

            #region Example - 2 (Threading Performance Testing Using Multiple Threads)
            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch = Stopwatch.StartNew();
            Thread t1 = new Thread(EvenNumbersSum);
            Thread t2 = new Thread(OddNumbersSum);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();
            
            stopwatch.Stop();
            Console.WriteLine($"Total time in milliseconds = {stopwatch.ElapsedMilliseconds}");
            #endregion

            Console.ReadKey();
        }
        #region Example - 1&2 (Threading Performance Testing using a single thread)
        public static void EvenNumbersSum()
        {
            double EvenSum = 0;
            for (int count = 0; count <= 50000000; count++)
            {
                if (count % 2 == 0)
                {
                    EvenSum = EvenSum + count;
                }
            }
            Console.WriteLine($"Sum of Even Numbers = {EvenSum}");
        }
        public static void OddNumbersSum()
        {
            double OddSum = 0;
            for (int count = 0; count <= 50000000; count++)
            {
                if (count % 2 == 1)
                {
                    OddSum = OddSum + count;
                }
            }
            Console.WriteLine($"Sum of Odd Numbers = {OddSum}");
        }
        #endregion

    }
}