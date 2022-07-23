using System;
using System.Threading;

namespace app1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for(int i=0; i<=10;i++)
            {
                Thread.Sleep(1000);
                ProgressBar(i,10);
            }
        }

        static void ProgressBar(int count, int total)
        {
            var barLength=60;
            var filledLength=(int)(Math.Round(barLength*count/(float)total));
            var percent=Math.Round(100.0*count/(float)total,1);
            string bar="";
            bar=bar.PadRight(filledLength,'█')+percent+'%'+bar.PadRight((barLength-filledLength),' ');
            Console.Clear();
            Console.WriteLine($"[{bar}]");
            Console.Out.Flush();
        }

    }
}
