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

        int CantNum;

        char opc;

        static void Main(string[] args)
        {
            ParesoImpares paresoImpares = new ParesoImpares();

            Console.WriteLine("Digite la cantidad de numeros que desea digitar:");
            paresoImpares.CantNum = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < paresoImpares.CantNum; i++) { 
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
            }



            paresoImpares.sqPar = Math.Sqrt(paresoImpares.ParTotal); //Calcular raiz 
            paresoImpares.sevenImp = paresoImpares.impTotal % 7;

            Console.WriteLine($"La cantidad de positivos son: {paresoImpares.contPos}");
            Console.WriteLine($"La cantidad de negativos son : {paresoImpares.contNeg}");
            Console.WriteLine($"La cantidad de ceros son: {paresoImpares.contCer}");
            Console.WriteLine($"La cantidad de los pares son: {paresoImpares.contPar}");
            Console.WriteLine($"La cantidad de impares son: {paresoImpares.contImp}");

            Console.WriteLine($"\nLa suma total es : {paresoImpares.numTotal}");
            Console.WriteLine($"La suma total de los pares es : {paresoImpares.ParTotal}");
            Console.WriteLine($"La suma total de los impares es : {paresoImpares.impTotal}");
            Console.WriteLine($"La suma total de los pares con raiz cuadrada : {paresoImpares.sqPar}");
            Console.WriteLine($"La suma total de los impares del residuo dividido entre 7 es : {paresoImpares.sevenImp}");
        }
    }
}
