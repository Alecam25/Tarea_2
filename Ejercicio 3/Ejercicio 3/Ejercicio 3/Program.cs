using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10 productos o menos el precio es de 20 
            // mas de 10 el precio es de 15 
            //multiplicar la cantidad de productos por el precio 
            //Ingresar la cantidad de articulos y dar como resultado el precio el total 

            Console.WriteLine("Digite la cantidad de articulos a comprar");
            int articulos = int.Parse(Console.ReadLine());


            if (articulos <= 10)
            {
                float precio = articulos * 20;
                                        Console.WriteLine(".-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.DESGLOSE.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.");
                                        Console.WriteLine($"Por la compra de {articulos} articulos el precio es de 20$ por producto");
                                        Console.WriteLine($"El total a pagar es de {precio} $ ");
                                        Console.WriteLine(".-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.DESGLOSE.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.");
                                        Console.ReadLine();





            }
            else if (articulos > 10 )
            {
                float precio = articulos * 15;
                                    Console.WriteLine(".-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.DESGLOSE.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.");
                                    Console.WriteLine($"Por la compra de {articulos} articulos el precio es de 15$ por producto");
                                    Console.WriteLine($"El total a pagar es de {precio} $");
                                    Console.WriteLine(".-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.DESGLOSE.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.");
                                    Console.ReadLine();



            }
            Console.ReadLine();













        }
    }
}
