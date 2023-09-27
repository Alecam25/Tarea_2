using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //ingresar carnet, mobre quiz1,2,3 , tarea 1,2,3, examen1,2,3
            // Sumar los tres quices multiplicarlo por 25% y lo divido entre 100
            // Sumar las tres tareas multiplicarlo por 30% y lo divido entre 100
            // Sumar los tres examnes multiplicarlo por 45% y lo divido entre 100
            // mayor a 70 aprobado , igual a 50 o menor que 70 aplazado , menor que 50 reporbado 

            Console.WriteLine("Ingrese el numero de su carnet estudiantil");
            long carnet = long.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el porcentaje del primer quiz que tenia un valor del 10% ");
            float quiz1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el porcentaje del segundo quiz que tenia un valor de 10%");
            float quiz2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el porcentaje del tercer quiz que tenia un valor del 5%");
            float quiz3 = float.Parse(Console.ReadLine());


            float quicesS = quiz1 + quiz2 + quiz3;

            float quicesM = (float)(quicesS * 1.25);

            

            Console.WriteLine("Ingrese el porcentaje de la primera tarea de valor 10%");
            float tarea1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el porcentaje de la segunda tarea de valor 10%");
            float tarea2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el porcentaje de la tercera tarea de valor 10%");
            float tarea3 = float.Parse(Console.ReadLine());


            float tareaS = tarea1 + tarea2 + tarea3;

            float tareaM = (float)(tareaS * 1.30);



            Console.WriteLine("Ingrese el porcentaje del primer examen de valor 15%");
            float examen1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el porcentaje del segundo examen de valor 15%");
            float examen2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el porcentaje del tercer examen de valor 15%");
            float examen3 = float.Parse(Console.ReadLine());


            float examenS = examen1 + examen2 + examen3;

            float examenM = (float)(examenS * 1.45);

            

            float Nota = quicesM + tareaM + examenM;
       


            // mayor a 70 aprobado , igual a 50 o menor que 70 aplazado , menor que 50 reporbado 
            //reporte del carnet, porcentaje de quices , tareas, examenes , promedio final , condicion 
            if (Nota > 70)
            {
                Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.");
                Console.WriteLine(".-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.DESGOLSE FINAL DEL PROMEDIO.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.");
                Console.WriteLine("El numero del carnet es:" + carnet);
                Console.WriteLine("El nombre del estudiante es:" + nombre);
                Console.WriteLine("El porcentaje de los quices del curso es de:" + quicesM);
                Console.WriteLine("El porcentaje de las tareas del curso es de:" + tareaM);
                Console.WriteLine("El porcentaje de los examnes del curso es de:" + examenM);
                Console.WriteLine("El pormedio final es de:" + Nota);
                Console.WriteLine($"La condicion del estudiante {nombre},de numero de carnet {carnet}, es APROBADO");
                Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.");
                Console.WriteLine(".-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.DESGOLSE FINAL DEL PROMEDIO.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.");
                Console.ReadLine();

            }
            else if (Nota < 70 && Nota > 50)
            {
                Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.");
                Console.WriteLine(".-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.DESGOLSE FINAL DEL PROMEDIO.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.");
                Console.WriteLine("El numero del carnet es:" + carnet);
                Console.WriteLine("El nombre del estudiante es:" + nombre);
                Console.WriteLine("El porcentaje de los quices del curso es de:" + quicesM);
                Console.WriteLine("El porcentaje de las tareas del curso es de:" + tareaM);
                Console.WriteLine("El porcentaje de los examnes del curso es de:" + examenM);
                Console.WriteLine("El pormedio final es de:" + Nota);
                Console.WriteLine($"La condicion del estudiante {nombre},de numero de carnet {carnet}, es APLAZADO");
                Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.");
                Console.WriteLine(".-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.DESGOLSE FINAL DEL PROMEDIO.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.");
                Console.ReadLine();






            }
            else if (Nota < 50)
            {
                Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.");
                Console.WriteLine(".-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.DESGOLSE FINAL DEL PROMEDIO.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.");
                Console.WriteLine("El numero del carnet es:" + carnet);
                Console.WriteLine("El nombre del estudiante es:" + nombre);
                Console.WriteLine("El porcentaje de los quices del curso es de:" + quicesM);
                Console.WriteLine("El porcentaje de las tareas del curso es de:" + tareaM);
                Console.WriteLine("El porcentaje de los examnes del curso es de:" + examenM);
                Console.WriteLine("El pormedio final es de:" + Nota);
                Console.WriteLine($"La condicion del estudiante {nombre},de numero de carnet {carnet}, es REPROBADO ");
                Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.");
                Console.WriteLine(".-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.DESGOLSE FINAL DEL PROMEDIO.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.");
                Console.ReadLine();

            }


        }
    }
}
