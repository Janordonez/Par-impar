// See https://aka.ms/new-console-template for more information
using System;

namespace paroimpar
{
    class ParesoImpares
    {
        int numeros;
        int contPos;
        int contNeg;
        int contCer;
        int contPar;
        int contImp;



        double numTotal = 0;
        double ParTotal = 0;
        float impTotal = 0;
        double sqPar;
        double sevenImp = 0;

        char opc;

        static void Main(string[] args)
        {
            ParesoImpares paresoImpares = new ParesoImpares();
            do {

                Console.WriteLine("\nDigite numeros enteros:");
                paresoImpares.numeros = int.Parse(Console.ReadLine());

                paresoImpares.numTotal += paresoImpares.numeros;

                if (paresoImpares.numeros > 0)
                {
                    paresoImpares.contPos++;
                }

                if (paresoImpares.numeros < 0)
                {
                    paresoImpares.contNeg++;
                }

                if (paresoImpares.numeros == 0)
                {
                    paresoImpares.contCer++;
                }

                if (paresoImpares.numeros % 2 == 0)
                {
                    paresoImpares.contPar++;
                    paresoImpares.ParTotal += paresoImpares.numeros;
                }

                if (paresoImpares.numeros % 2 != 0)
                {
                    paresoImpares.contImp++;
                    paresoImpares.impTotal += paresoImpares.numeros;
                }

                Console.WriteLine("\nDesea ingresar otro numero?: ");
                paresoImpares.opc = Console.ReadKey().KeyChar;

            } while (paresoImpares.opc == 'S'|| paresoImpares.opc == 's');

            paresoImpares.sqPar = Math.Sqrt(paresoImpares.ParTotal);
            paresoImpares.sevenImp = paresoImpares.impTotal % 7;

            Console.WriteLine($"La suma total es : {paresoImpares.numTotal}");
            Console.WriteLine($"La suma total de los pares es : {paresoImpares.ParTotal}");
            Console.WriteLine($"La suma total de los impares es : {paresoImpares.impTotal}");
            Console.WriteLine($"La suma total de los pares con raiz cuadrada : {paresoImpares.sqPar}");
            Console.WriteLine($"La suma total de los impares del residuo dividido entre 7 es : {paresoImpares.sevenImp}");
        }
    }
}
