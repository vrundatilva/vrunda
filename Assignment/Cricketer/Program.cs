using System;

namespace Cricketer
{
  public  class cricketer
    {
     public  int averageRuns(int runs, int matches, int notout)
        {
            {

                // Calculate number of
                // dismissals
                int out1;
                out1 = matches - notout;

                // Check for 0 times out
                if (out1 == 0)
                    return -1;

                // Calculate batting average
                int avg = (runs) / out1;

                return avg;
                throw new NotImplementedException();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            cricketer c = new cricketer();
            int runs = 10000;
            int matches = 250;
            int notout = 50;

            int avg =c.averageRuns(runs, matches,
                                        notout);
            Console.Write($"Total Run : {runs}");
            Console.Write($"Total Matches : {matches}");
            Console.Write($"Total Notout : {notout}");
            if (avg == -1)
                Console.Write("NA");
            else
            Console.Write($"Average  : {avg}");

            Console.ReadLine();
        }
    }
}

