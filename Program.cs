using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono t1 = new Telefono("4dfgs33", "Samsung");
            Console.WriteLine("ingrese el nnumero:");
            t1.NumTel = Console.ReadLine();
            Console.WriteLine("Ingrese el codigp de operador:");
            t1.CodOper = int.Parse(Console.ReadLine());

            Console.WriteLine(t1.Marca);
            Console.WriteLine(t1.Modelo);
            Console.WriteLine(t1.NumTel);
            Console.WriteLine(t1.CodOper);
            Console.WriteLine(t1.llamar());
            Console.WriteLine("Ingrese el contacto");
            string contacto = Console.ReadLine();

            Console.WriteLine(t1.llamar(contacto));

            Console.ReadKey();
        }
    }
}
