using System;

namespace ejercicios_numericos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            double resultado;


            Console.WriteLine("introducir el primer numero.");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introdusca el segundo numero.");
            numero2 = Convert.ToInt32(Console.ReadLine());
            //suma
            resultado = numero1 + numero2;
            Console.WriteLine("El resultado de la suma de " + numero1 +" y " + numero2 + " es: = " + resultado);
            //resta
            resultado = numero1 - numero2;
            Console.WriteLine("El resultado de la resta de " + numero1 + " y " + numero2 + " es: = " + resultado);
            //multiplicacion
            resultado = numero1 * numero2;
            Console.WriteLine("El resultado de la multiplicacion de " + numero1 + " y " + numero2 + " es: = " + resultado);
            // divicion
            resultado = numero1 / numero2;
            Console.WriteLine("El resultado de la divicion de " + numero1 + " y " + numero2 + " es: = " + resultado);

            Console.ReadKey();
        }
    }
}
