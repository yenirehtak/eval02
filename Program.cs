using System;
using Numeros;
namespace eval02
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "Hola!";
            Numero obNum = new Numero();
            Console.WriteLine(cadena);
            obNum.CargarTabla();
            obNum.ImprimirTabla();

        }
    }
}
