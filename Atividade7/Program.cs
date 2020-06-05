using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atividade 7");
            Console.WriteLine("Alunos: Guilherme Henrique de Aguiar Diniz, Luiz Henrique Gomes Guimarães, Yuske Eduardo Velit Arruda.");

            Console.WriteLine($"Arquivo de entrada: {args[0]}");

            try
            {
                File.Delete(args[0]);
                Console.WriteLine("Arquivo de entrada apagado com sucesso.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Sem autorização para apagar o arquivo de entrada.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Arquivo de entrada não existe.");
            }
            finally
            {
                Console.WriteLine("Pressione alguma tecla para sair...");
                Console.ReadKey();
            }

        }
    }
}
