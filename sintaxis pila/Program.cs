using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comentario prueba
            int op;

            Stack Pila = new Stack();

            Pila.Push(Console.ReadLine());

            Pila.Push(Console.ReadLine());
            Pila.Push(Console.ReadLine());
            Pila.Push(Console.ReadLine());
            Pila.Push(Console.ReadLine());
            //--
            Array arreglo = Pila.ToArray();

            foreach (string valor in arreglo)
            {
                Console.WriteLine(valor);
            }

            Console.ReadKey();

            Pila.Pop();

            Console.ReadKey();

            Pila.Pop();

            Console.ReadKey();

            Pila.Pop();

            Console.ReadKey();

            Pila.Pop();

            Console.ReadKey();

            //elimina el último valor introducido
            Pila.Pop();


            //Muestra el ´8ltimo valor introducido
            Pila.Peek();

        }

       




    }
}
