using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace Atividade3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Atividade 3");
            Console.WriteLine("Alunos: Guilherme Henrique de Aguiar Diniz, Luiz Henrique Gomes Guimarães, Yuske Eduardo Velit Arruda.");
            RecuperaMemoria();
            EsperarParaContinuar();
            RecuperaCPU();
            EsperarParaContinuar();
            RecuperaDisco();
            EsperarParaContinuar();
            RecuperaProcessos();
            EsperarParaContinuar();
            RecuperaThreads();
            EsperarParaContinuar();
        }

        private static void RecuperaThreads()
        {
            Console.WriteLine("THREADS:");
            Console.WriteLine();
            var processes = Process.GetProcesses();

            foreach (var process in processes.OrderBy(x => x.Id))
            {
                foreach (ProcessThread thread in process.Threads)
                {
                    try
                    {
                        Console.WriteLine($"Thread ID: {thread.Id} - Prioridade: {thread.PriorityLevel}");
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }

        private static void RecuperaDisco()
        {
            Console.WriteLine("DISCO:");
            Console.WriteLine();
            var performance = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total", true);
            performance.NextValue();
            Thread.Sleep(1000);
            var memory = performance.NextValue();
            Console.WriteLine($"Disponível: {100 - memory:00} %");
            Console.WriteLine($"Em uso: {memory:00} %");
        }

        private static void RecuperaCPU()
        {
            Console.WriteLine("CPU:");
            Console.WriteLine();
            var performance = new PerformanceCounter("Processor", "% Processor Time", "_Total", true);
            performance.NextValue();
            Thread.Sleep(1000);
            var memory = performance.NextValue();
            Console.WriteLine($"Disponível: {100 - memory:00} %");
            Console.WriteLine($"Em uso: {memory:00} %");
        }

        private static void EsperarParaContinuar()
        {
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar.");
            Console.ReadKey();
            Console.WriteLine();
        }

        private static void RecuperaMemoria()
        {
            Console.WriteLine("MEMÓRIA:");
            Console.WriteLine();
            var performance = new PerformanceCounter("Memory", "% Committed Bytes In Use", true);
            var memory = performance.NextValue();
            Console.WriteLine($"Disponível: {100 - memory:00} %");
            Console.WriteLine($"Em uso: {memory:00} %");
        }

        private static void RecuperaProcessos()
        {
            Console.WriteLine("PROCESSOS:");
            Console.WriteLine();
            var processes = Process.GetProcesses();

            foreach (var process in processes.OrderBy(x => x.Id))
            {
                Console.WriteLine($"PID: {process.Id} - Nome: {process.ProcessName}");
            }
        }
    }
}
