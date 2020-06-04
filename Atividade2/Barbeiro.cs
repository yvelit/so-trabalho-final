using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
	public class Barbeiro
	{
		private int cadeiraDeEspera;
		bool cadeiraOcupada = false; // true = ocupada 
		private int clientesNovos;
		int numeroDeClientes = 0;

		public Barbeiro(int numeroCadeirasDeEspera, int maxClientes)
		{
			clientesNovos = maxClientes; // definindo quantidade maxima de novos clientes
			this.cadeiraDeEspera = numeroCadeirasDeEspera;

			Console.WriteLine("Barbearia aberta! Possui " + cadeiraDeEspera + " cadeiras de espera.");
		}

		public void criaClientes()
		{
			Random rand = new Random();
			numeroDeClientes = rand.Next(clientesNovos);
		}

		public void BarbeiroDormindo()
		{
			Console.WriteLine("Nenhum cliente...");
			Console.WriteLine("Barbeiro dormindo...\n");
			Thread.Sleep(2250);
			Console.WriteLine("Cadeira livre\n");

			criaClientes();
		}

		public void BarbeiroAtendendo()
		{
				if (numeroDeClientes > 1 && cadeiraOcupada == false)
				{
					if (numeroDeClientes >= cadeiraDeEspera + 1)
					{

						Console.WriteLine(numeroDeClientes + " chegaram no salão e " + (numeroDeClientes - (cadeiraDeEspera + 1)) + " foram embora.");
						numeroDeClientes = cadeiraDeEspera + 1;
					}
					else if (numeroDeClientes < cadeiraDeEspera + 1)
					{
						Console.WriteLine(numeroDeClientes + " cliente(s) chegaram no salão.");
					}
				}

				Console.WriteLine("\n1 Cliente sentou na cadeira para ser atendido.");
				numeroDeClientes = numeroDeClientes - 1;
				Console.WriteLine((numeroDeClientes) + " esperando...");
				Console.WriteLine("Cliente sendo atendido...\n");
				Thread.Sleep(4000);
				Console.WriteLine("Cliente atendido!\n");
		}

		public void run()
		{
			while (true)
			{
				if (numeroDeClientes <= 0)
				{
					try
					{
						BarbeiroDormindo();
					}
					catch (ThreadInterruptedException ex)
					{
						Console.WriteLine(ex);
					}
				}
				else
				{
					try
					{
						BarbeiroAtendendo();
					}
					catch (ThreadInterruptedException ex)
					{
						Console.WriteLine(ex);
					}

				}
			}

		}
	}
}

