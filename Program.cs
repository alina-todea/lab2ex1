using System;

namespace Lab2ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Scrieti o functie care citeşte de la tastatură un şir de n numere naturale şi determină media aritmetică a celor pare, n fiind citit de la tastatra
            */

            Console.WriteLine("Introduceti un numar intreg");
            int numar = int.Parse(Console.ReadLine());

            double media = MediaAritmetica(numar);
            Console.WriteLine("media aritmetica este " + media);

        }

        static double MediaAritmetica(int numar)
        {

            int total = 0;
            int contorNumerePare = 0;
            
            for (var i = 1; i < numar+1; i++)
            {
         
                Console.WriteLine("Introduceti al " + i + "lea numar");
                int numarCurent = int.Parse(Console.ReadLine());
                if (numarCurent % 2 == 0)
                {
                    total = total + numarCurent;
                    contorNumerePare = contorNumerePare + 1;
                }
            }
            double result = total / contorNumerePare;
            return result;
        }


    }
}
