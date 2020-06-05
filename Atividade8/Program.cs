using System;
using System.IO;

namespace Atividade8
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Atividade 8");
            Console.WriteLine("Alunos: Guilherme Henrique de Aguiar Diniz, Luiz Henrique Gomes Guimarães, Yuske Eduardo Velit Arruda.");

            try
            {
                var drives = DriveInfo.GetDrives();
                foreach (var drive in drives)
                {
                    Console.WriteLine($"Disco: {drive.Name}");
                    Console.WriteLine($"Tipo de disco: {drive.DriveType}");
                    if (drive.IsReady)
                    {
                        Console.WriteLine($"Rótulo do volume: {drive.VolumeLabel}");
                        Console.WriteLine($"Sistema de arquivo: {drive.DriveFormat}");
                        Console.WriteLine($"Espaço disponível para o usuário: {drive.AvailableFreeSpace/ 1048576} mb");
                        Console.WriteLine($"Espaço total disponível: {drive.TotalFreeSpace/ 1048576} mb");
                        Console.WriteLine($"Espaço total do disco: {drive.TotalSize/ 1048576} mb");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("O processo falhou: {0}", e.ToString());
            }

            Console.WriteLine("Pressione alguma tecla para sair...");
            Console.ReadKey();
        }
    }
}
