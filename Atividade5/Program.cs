using System;

namespace Calculadora
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Atividade 5");
                Console.WriteLine("Alunos: Guilherme Henrique de Aguiar Diniz, Luiz Henrique Gomes Guimarães, Yuske Eduardo Velit Arruda.");
                Console.WriteLine("CALCULADORA");
                Console.WriteLine();

                var argumentos = new Argumentos(args);

                decimal resultado;

                switch (argumentos.Operacao)
                {
                    case Operacao.Soma:
                        resultado = Calculadora.Soma(argumentos.X, argumentos.Y);
                        break;

                    case Operacao.Subtracao:
                        resultado = Calculadora.Subtrai(argumentos.X, argumentos.Y);
                        break;

                    case Operacao.Multiplicacao:
                        resultado = Calculadora.Multiplica(argumentos.X, argumentos.Y);

                        break;

                    case Operacao.Divisao:
                        resultado = Calculadora.Divide(argumentos.X, argumentos.Y);

                        break;

                    default:
                        resultado = 0;
                        break;
                }

                Console.WriteLine("Resultado: " + args[0] + " " + args[1] + " " + args[2] + " = " + resultado);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para fechar a calculadora");
                Console.ReadKey();
            }
        }

        public enum Operacao
        {
            Soma,
            Subtracao,
            Multiplicacao,
            Divisao,
        }

        public static class Calculadora
        {
            public static decimal Soma(decimal x, decimal y)
            {
                return x + y;
            }

            public static decimal Subtrai(decimal x, decimal y)
            {
                return x - y;
            }

            public static decimal Multiplica(decimal x, decimal y)
            {
                return x * y;
            }

            public static decimal Divide(decimal x, decimal y)
            {
                if (y == 0)
                {
                    throw new InvalidOperationException("Não é possível fazer divisão por zero");
                }
                return x / y;
            }
        }

        public class Argumentos
        {
            private decimal _x;

            public decimal X
            {
                get
                {
                    return _x;
                }
                set
                {
                    _x = value;
                }
            }

            private decimal _y;

            public decimal Y
            {
                get
                {
                    return _y;
                }
                set
                {
                    _y = value;
                }
            }

            private Operacao _operacao;

            public Operacao Operacao
            {
                get
                {
                    return _operacao;
                }
                set
                {
                    _operacao = value;
                }
            }

            public Argumentos(string[] args)
            {
                if (args == null || args.Length < 3)
                {
                    throw new ArgumentException("A calculadora precisa de 3 argumentos");
                }

                decimal x;

                try
                {
                    X = decimal.Parse(args[0]);
                }
                catch (Exception)
                {
                    throw new ArgumentException("Argumento 1 deve ser um número.");
                }
                var ehDecimal = decimal.TryParse(args[0], out x);

                switch (args[1])
                {
                    case "+":
                        Operacao = Operacao.Soma;
                        break;

                    case "-":
                        Operacao = Operacao.Subtracao;
                        break;

                    case "x":
                        Operacao = Operacao.Multiplicacao;
                        break;

                    case "/":
                        Operacao = Operacao.Divisao;
                        break;

                    default:
                        throw new ArgumentException("Argumento 2 deve ser + ou - ou x ou /.");
                }

                try
                {
                    Y = decimal.Parse(args[2]);
                }
                catch (Exception)
                {
                    throw new ArgumentException("Argumento 3 deve ser um número.");
                }

                decimal y;
                ehDecimal = decimal.TryParse(args[2], out y);

                if (!ehDecimal)
                {
                }

                Y = y;
            }
        }
    }
}
