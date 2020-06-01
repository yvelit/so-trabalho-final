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
            Console.WriteLine("Atividade 10");
            Console.WriteLine("Alunos: Guilherme Henrique de Aguiar Diniz, Luiz Henrique Gomes Guimarães, Yuske Eduardo Velit Arruda.");
            Performance objPerformance = new Performance();
            Thread objThread           = new Thread(objPerformance.getPerformance);
            objThread.Start();
            Console.ReadKey();
        }
    }
}

