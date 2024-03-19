using System;
using System.IO;
namespace pruebaTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = "C:/Users/csi23-dmunnco/Desktop/doc.txt";
            Console.WriteLine("Ingresa el numero de la linea en la que desea colocar el texto");
            int linea = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa el texto que desea colocar en esa linea");
            string textoUsu = Console.ReadLine();

            try
            {
                string[] leer = File.ReadAllLines(ruta);

                if(linea > 0 && linea < leer.Length)
                {
                    leer[linea - 1] = textoUsu;

                    File.WriteAllLines(ruta, leer);

                    Console.WriteLine("El texto se ha escrito correctamente en la línea especificada.");
                }
                else
                {
                    Console.WriteLine("El número de línea especificado está fuera del rango del archivo.");
                }

            }catch (Exception ex)
            {
                Console.WriteLine("Error al leer/escribir el archivo: " + ex.Message);
            }
        }
    }
}

           