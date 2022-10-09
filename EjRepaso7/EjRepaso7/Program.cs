using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjRepaso7
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Ejercicio VII
            //Crear una aplicación que, cuando el usuario ingrese cinco números, indique cuál es
            //mayor, cuál es valor intermedio y cuál el menor.

            int mayor=0;
            int menor=0;
            int intermedio=0;
            string valor;
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            int n4 = 0;
            int n5 = 0;
            int[] lista = new int[5];


            Console.WriteLine("Ingrese el primer número");
            valor = Console.ReadLine();
            if (PasarAInt(valor))
                {
                try
                {
                    n1 = int.Parse(valor);
                 }
                catch (Exception)
                {
                    Console.WriteLine("El valor ingresado no es un número válido, se define 0 por defecto");
                }
            }
            else
            {
                Console.WriteLine("El valor ingresado no es un número válido"); 
            }
            
            Console.WriteLine("Ingrese el segundo número");
            valor = Console.ReadLine();
            if (PasarAInt(valor))
            {
                try
                {
                    n2 = int.Parse(valor);
            }
                catch (Exception)
                {
                    Console.WriteLine("El valor ingresado no es un número válido, se define 0 por defecto");
                }
            }
            else
            {
                Console.WriteLine("El valor ingresado no es un número válido");
            }

            Console.WriteLine("Ingrese el tercer número");
            valor = Console.ReadLine();
            if (PasarAInt(valor))
            {
                try
                {
                    n3 = int.Parse(valor);
                }
                catch (Exception)
                {
                    Console.WriteLine("El valor ingresado no es un número válido, se define 0 por defecto");
                }
            }
            else
            {
                Console.WriteLine("El valor ingresado no es un número válido");
            }

            Console.WriteLine("Ingrese el cuarto número");
            valor = Console.ReadLine();
            if (PasarAInt(valor))
            {
                try
                {
                    n4 = int.Parse(valor);
                }
                catch (Exception)
                {
                    Console.WriteLine("El valor ingresado no es un número válido, se define 0 por defecto");
                }
            }
            else
            {
                Console.WriteLine("El valor ingresado no es un número válido");
            }

            Console.WriteLine("Ingrese el quinto número");
            valor = Console.ReadLine();
            if (PasarAInt(valor))
            {
                try
                {
                    n5 = int.Parse(valor);
                }
                catch (Exception)
                {
                    Console.WriteLine("El valor ingresado no es un número válido, se define 0 por defecto");
                }
            }
            else
            {
                Console.WriteLine("El valor ingresado no es un número válido");
            }

            lista[0] = n1;
            lista[1] = n2;
            lista[2] = n3;
            lista[3] = n4;
            lista[4] = n5;
            Array.Sort(lista);
            menor = lista[0];
            mayor = lista[4];
            intermedio = lista[2];
            Console.WriteLine("El mayor es " + mayor + ", el menor es " + menor + " y el intermedio es " + intermedio);
            Console.ReadKey();
        }

        public static bool PasarAInt(string num)
        {
            int valorParseado;
            bool sePuede = false;
            sePuede = Int32.TryParse(num, out valorParseado);
            return sePuede;
        }
    }
}
