using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threadpool
{
    class Program
    {
        static void Main(string[] args)
        {
            int nWorkThreads;
            int nComletionThreads;

            ThreadPool.GetMaxThreads(out nWorkThreads, out nComletionThreads);
            Console.WriteLine(nWorkThreads + " " + nComletionThreads);
        }
    }
}
