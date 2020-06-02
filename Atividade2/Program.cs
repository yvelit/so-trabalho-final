using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    class Program
    {
		public static void Main(String[] args)
		{


			Barbeiro barbeiro = new Barbeiro(2, 10); // Construtor recebe por parametro
														// a quantidade de cadeiras de espera
														// e a quantidade de clientes que podem chegar
														// na barbearia
			Thread threadBarbeiro = new Thread(barbeiro.run);
			threadBarbeiro.Start();

		}
	}
    
}
