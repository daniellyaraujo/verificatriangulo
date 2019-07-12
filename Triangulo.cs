using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaTriangulo2
{
    class Triangulo
    {
        public int ladoA;
        public int ladoB;
        public int ladoC;

        public void verificaTriangulo()
        {
            if ((ladoA<ladoB+ladoC)&&(ladoB<ladoA+ladoC)&&(ladoC<ladoA+ladoB))
            {
                Console.WriteLine("Forma um Triangulo!");
            }
            else
            {
                Console.WriteLine("Não forma um triangulo");
            }
        }
    }
}
