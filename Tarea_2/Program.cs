using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2
{
    internal class Program
    {
        public static void Aguinaldo(double salario, string empleado)
        {
 
            Console.WriteLine($"{empleado}: Salario = ${salario}, Aguinaldo = ${salario*12}");

        }
        static void Main(string[] args)
        {
            string[] empleados = { "Juan", "Filomena", "Pedro", "Sara" , "Enrique", "Fede", "Ronaldo", "Tercio" };
            double[] salario = { 562.12, 653.96, 785.32, 559.23, 965.25, 962.56, 563.25, 457.25};
            int i = 0;
            foreach (double numero in salario)
            {
                if (salario.Length == empleados.Length)
                {
                    Aguinaldo(numero, empleados[i++]);
                }
                if (salario.Length != empleados.Length)
                {
                    Console.WriteLine("Hay una cantidad desigual de empleados y salarios, por favor revisar los datos."); break;

                }
            }
            int j = 0;
            i = 0;
            int[] letras = new int[empleados.Length];
            if (empleados.Length == salario.Length)
            {
                foreach (string nombre in empleados)
                {
                    j = 0;
                    foreach (char letra in nombre)
                    {
                        j++;
                    }
                    letras[i] = j;
                    i++;
                }
                i = 0;
                j = 0;
                int mayor = 1;
                foreach (int cantidad in letras)
                {
                    mayor = 1;
                    i = 0;
                    while (i < letras.Length - 1)
                    {
                        if (cantidad >= letras[i])
                        {
                            mayor = mayor + 1;
                            i++;
                            if (mayor == letras.Length)
                            {
                                Console.WriteLine($"\nEl nombre con mayor cantidad de letras es {empleados[j]}");
                                i++;
                            }
                        }
                        else { i++; }

                    }
                    j++;


                }
            }
            
            Console.Read();

        }
        
    }
}
