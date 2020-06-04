using System;
using System.IO;

namespace Atividade4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Atividade 4");
            Console.WriteLine("Alunos: Guilherme Henrique de Aguiar Diniz, Luiz Henrique Gomes Guimarães, Yuske Eduardo Velit Arruda.");

            Console.WriteLine($"Arquivo de entrada: {args[0]}");
            Console.WriteLine($"Arquivo de saída: {args[1]}");

            var value = string.Empty;
            Console.WriteLine("Entre com os caracteres:");
            var response = Console.ReadLine();

            foreach (var r in response)
            {
                if (r == '*')
                {
                    break;
                }

                value += r;
            }


            using (var stream = File.Open(args[0],FileMode.Create))
            {
                var sWriter = new StreamWriter(stream);

                sWriter.WriteLine(value);

                sWriter.Close();
                stream.Close();
            }

            string content = string.Empty;
            using (var stream = File.Open(args[0],FileMode.Open,FileAccess.Read))
            {
                var sReader = new StreamReader(stream);

                content = sReader.ReadLine();

                Console.WriteLine($"Caracteres digitados: {content}");

                sReader.Close();
                stream.Close();
            }

            using (var stream = File.Open(args[1],FileMode.Create))
            {
                var sWriter = new StreamWriter(stream);

                sWriter.Write(content.ToUpperInvariant());

                sWriter.Close();
                stream.Close();
            }

            using (var stream = File.Open(args[1], FileMode.Open, FileAccess.Read))
            {
                var sReader = new StreamReader(stream);

                content = sReader.ReadLine();

                Console.WriteLine($"Caracteres convertidos: {content}");

                sReader.Close();
                stream.Close();
            }


            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
