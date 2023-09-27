using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // de 2 a 5 camisas descuento del 15 
            // mas de 5 camisas DESCUENTO DEL 20 
            // solicitar cantidad de camiasa y el precio 
            // se multiplica primero y despues de resta 



         Console.WriteLine("Digite la cantidad de camisas a comprar");
         int Camisas = int.Parse(Console.ReadLine());

          
         Console.WriteLine("Digite el precio de las camisas");
         float Precio1 = float.Parse(Console.ReadLine());

            float Precio = Precio1 * Camisas;



                if (Camisas > 2 && Camisas <= 5)
                {

                    double Rebajo = Precio * 0.15;
                    double Descuento = Precio - Rebajo;

                    Console.WriteLine("___________DESGLOSE DE LA COMPRA___________");
                    Console.WriteLine("El precio original de las camisas es de: " + Precio);
                    Console.WriteLine($"El monto final a pagar es de {Descuento} , con un descuento del 15% en la compra");
                    Console.WriteLine($"El rebajo en su compra es de:" + Rebajo);
                    Console.WriteLine("______________________________________________________________________________________");
                    Console.ReadLine();

                }
                else if (Camisas > 5)
                {
                    double Rebajo = Precio * 0.20;
                    double Descuento = Precio - Rebajo;


                    Console.WriteLine("___________DESGLOSE DE LA COMPRA___________");
                    Console.WriteLine("El precio original de las camisas es de: " + Precio);
                    Console.WriteLine($"El monto final a pagar es de {Descuento} , con un descuento del 15% en la compra");
                    Console.WriteLine($"El rebajo en su compra es de: " + Rebajo);
                    Console.WriteLine("______________________________________________________________________________________");
                    Console.ReadLine();



                }
            Console.ReadLine();
        }
    }
}
