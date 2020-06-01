using System;
using System.ServiceProcess;
using System.Threading.Tasks;

namespace ServicosEmExecucao
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceController[] servicos;
            servicos = ServiceController.GetServices();

            Console.WriteLine("Serviços em execução: ");
            foreach (ServiceController servico in servicos)
            {
                if (servico.Status == ServiceControllerStatus.Running)
                {
                    Console.WriteLine();
                    Console.WriteLine("Serviço: " + servico.ServiceName);
                    Console.WriteLine("  Nome de exibição: " + servico.DisplayName);
                }
            }
            Console.ReadKey();
        }
    }
}
