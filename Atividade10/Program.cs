using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Especificacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Performance objPerformance = new Performance();
            Thread objThread           = new Thread(objPerformance.getPerformance);
            objThread.Start();
            Console.ReadKey();
        }
    }
}

