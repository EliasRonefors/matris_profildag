using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixVerifyer;

namespace Matrix
{
    partial class Program
    {
        static void Main(string[] args)
        {
            /*
             * Där finns tester tillgängliga genom att skriva
             * MatrixChecker.CheckAddition
             * MatrixChecker.CheckMultiplication
             * MatrixChecker.CheckRotationMatrix
             * 
             * Observera att testerna inte är noga testade.
             * 
             * De tar emot argument enligt följande standard:
             * CheckAddition tar emot alla Matris-värden 00, 01, 10, 11 för matris A
             * och alla Matris-värden 00, 01, 10, 11 för matris B, och den sista är
             * då det uträknade resultatet av A + B, som då är en matris 00, 01, 10, 11
             * 
             * CheckMultiplication liknar CheckAddition, den tar emot tre matriser,
             * A, B och sedan resultatet av A * B. Sen kommer den att jämföra och se
             * ifall matrisen har blivit rätt
             * 
             * CheckRotationMatrix tar emot antalet radianer du roterat en matris av,
             * och sedan en rotationsmatris som du har skapat. Den jämför sedan värden
             * för att se ifall matriserna stämmer överens.
             */

            /*
             * Där finns ett inbyggt verktyg för att rita ut matriser i två format.
             * Den första tar emot alla matrisvärden, 00, 01, 10, 11 och den andra
             * tar emot en float[,] (en float 2D-array) och skriver sedan ut matrisen
             * formaterat, och endast med 2 decimaler.
             */

            // De fyra första siffrorna = Matris A, de nästa fyra siffrorna = Matris B, de sista fyra siffrorna = resultatet av A + B
            // Exempel: MatrixChecker.CheckAddition(1, 2, 3, 4, 1, 2, 3, 4, 2, 4, 6, 8);

            // De fyra första siffrorna = Matris A, de nästa fyra siffrorna = Matris B, de sista fyra siffrorna = resultatet av A * B
            // Exempel: MatrixChecker.CheckMultiplication(1, 2, 3, 4, 1, 2, 3, 4, 7, 10, 15, 22);


            // Byt ut detta anropet med dina matrisvärden, så kommer programmet att rita ut dem istället :)




            // Värden
            float a00 = 1, a01 = 2, a10 = 3, a11 = 4;
            float b00 = 3, b01 = 4, b10 = 5, b11 = 6;
            float c00, c01, c10, c11;
            float radians = 3.14f;

            // Addition
            c00 = a00 + b00;
            c01 = a01 + b01;
            c10 = a10 + b10;
            c11 = a11 + b11;

            MatrixChecker.CheckAddition(a00, a01, a10, a11, b00, b01, b10, b11, c00, c01, c10, c11);
            Draw2x2Matrix(c00, c01, c10, c11);


            // Rotationsmatris? och ja jag vet att denna koden förmodligen suger, men den funkar(tror jag)!
            a00 = (float)Math.Cos(radians);
            a01 = (float)Math.Sin(radians);
            a10 = (float)Math.Sin(-radians);

            Console.Write("\n");
            MatrixChecker.CheckRotationMatrix(radians, a00, a01, a10, a00);
            Draw2x2Matrix(a00, a01, a10, a00);


            // Multiplikation
            //värden
            a00 = 1;
            a01 = 2;
            a10 = 3;
            a11 = 4;

            b00 = 5;
            b01 = 6;
            b10 = 7;
            b11 = 8;

            //matte
            c00 = a00 * b00 + a01 * b10;
            c01 = a00 * b01 + a01 * b11;
            c10 = a10 * b00 + a11 * b10;
            c11 = a10 * b01 + a11 * b11;

            Console.Write("\n");
            MatrixChecker.CheckMultiplication(a00, a01, a10, a11, b00, b01, b10, b11, c00, c01, c10, c11);
            Draw2x2Matrix(c00, c01, c10, c11);




            // Rotationsmatris 2.0 Electric Bogaloo
            
            Console.Write("\nTryck Enter för att fortsätta till extra uppgift.\n");
            Console.ReadKey();
            Console.Clear();

            float radians2;

            Console.Write("Vänligen skriv första radianen.\n");
            float.TryParse(Console.ReadLine(), out radians);


            Console.Write("\nVänligen skriv andra radianen.\n");
            float.TryParse(Console.ReadLine(), out radians2);

            Console.Clear();

            //Rotationsmatris-delen
            a00 = (float)Math.Cos(radians);
            a01 = (float)Math.Sin(radians);
            a10 = (float)Math.Sin(-radians);
            a11 = (float)Math.Cos(radians);

            b00 = (float)Math.Cos(radians2);
            b01 = (float)Math.Sin(radians2);
            b10 = (float)Math.Sin(-radians2);
            b11 = (float)Math.Cos(radians2);
            

            //Multiplikation
            c00 = a00 * b00 + a01 * b10;
            c01 = a00 * b01 + a01 * b11;
            c10 = a10 * b00 + a11 * b10;
            c11 = a10 * b01 + a11 * b11;

            //Rita matris
            Console.Write("\n");
            Draw2x2Matrix(c00, c01, c10, c11);



            Console.ReadKey();
        }
    }
}
