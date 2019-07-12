using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaTriangulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            Triangulo objeto;
            Console.WriteLine("Verifica se 3 valores formam um triangulo");

            Console.Write("Lado A: ");
            entrada = Console.ReadLine();
            objeto = new Triangulo();
            objeto.ladoA = Convert.ToInt32(entrada);

            Console.Write("Lado B: ");
            entrada = Console.ReadLine();
            objeto.ladoB = Convert.ToInt32(entrada);

            Console.Write("Lado C: ");
            entrada = Console.ReadLine();
            objeto.ladoC = Convert.ToInt32(entrada);

            objeto.verificaTriangulo();
            Console.ReadKey();

        }
    }
}
