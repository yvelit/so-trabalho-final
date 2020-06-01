using System;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Threading;

namespace Especificacoes
{
    class Performance
    {
        private PerformanceCounter theCPUCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        private PerformanceCounter theMemCounter = new PerformanceCounter("Memory", "Available MBytes");

        public void getCpuTime()
        {
                Console.WriteLine("Tempo CPU: " + theCPUCounter.NextValue() + "%");   
        }
        public void getMemoryUsage()
        {  
                Console.WriteLine("RAM: " + theMemCounter.NextValue() + "MBytes");
        }

        public void getPerformance()
        {
            Console.WriteLine(System.Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER"));
            Thread.Sleep(4000);
            while (true)
            {
                getCpuTime();
                getMemoryUsage();
                Thread.Sleep(1000);
                Console.Clear();
            }
        }

        
    }
}

