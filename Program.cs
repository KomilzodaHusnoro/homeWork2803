using System;

namespace homeWork2803
{
    class Program
    {
        static void Main(string[] args)
        {
            // {// ex #2.1
            //     Console.WriteLine("Enter number: ");
            //     int firstNumber = int.Parse(Console.ReadLine());
            //     Console.WriteLine("Enter another number: ");
            //     int secondNumber = int.Parse(Console.ReadLine());
            //     int summa = 0;
            //     for (int i= firstNumber; i <= secondNumber; i++){
            //             summa += i;
                        
            //         }
            //         Console.WriteLine(summa);
            
            // }
            // {// ex #2.2
            //     Console.WriteLine("Enter number: ");
            //     int firstNumber = int.Parse(Console.ReadLine());
            //     Console.WriteLine("Enter another number: ");
            //     int secondNumber = int.Parse(Console.ReadLine());
            //     for (int i = 1 + firstNumber; i < secondNumber; i++){
            //          if (i % 2 == 1){ 
            //         Console.WriteLine(i);
            //         }

            //     }

            // }
            // {// ex #3.1
            //     Console.WriteLine("Enter rectangle length: ");
            //     int rectangleLength = int.Parse(Console.ReadLine());
            //     Console.WriteLine("Enter rectangle width: ");
            //     int rectangleWidth = int.Parse(Console.ReadLine());
            //     string length = "";

            //     for (int i = 0; i < rectangleLength; i++)
            //     {
            //         length += "* ";
            //     }
            //     Console.Write(length + "\n");

            //     for (int i = 0; i < rectangleWidth - 2; i++)
            //     {
            //         for (int u = 1; u <= rectangleLength; u++)
            //         {
            //             if ( u == 1 || u == rectangleLength) 
            //             {
            //                 Console.Write("* ");
            //             } else {
            //                 Console.Write("* ");
            //             }
            //         }
            //         Console.Write("\n");
            //     }
            //     Console.Write(length + "\n");
            // }

            // {// ex#3.2 прямоугольный 
            // Console.WriteLine("Enter katet: ");
            // int katet = int.Parse(Console.ReadLine());
            // int i = 0;
            // int j = 0;
            // while (i < katet)
            // {
            //    while (j < katet - i && j >= 0)
            //    {
            //        Console.Write("*");
            //        j++;
            //    }
            //   j = 0;
            //   i++;
            //   Console.WriteLine();
            // }

            // }
            
            // { // ex #3.3 равносторонний
            //     Console.WriteLine("Enter side: ");
            //     int storona = int.Parse(Console.ReadLine());
            //     int spaceCounter = storona - 1;
            //     for (int i = 0; i < storona; i++)
            //     { 
            //         for (int k = 0; k < spaceCounter; k++) {
            //             Console.Write(" ");
            //         }
            //         spaceCounter--;
            //         for (int j = 0; j <= i ; j++)
            //         {
            //             Console.Write("* ");
            //         }
            //         Console.WriteLine();
    
            //     }
            // }
            // { // ex #3.4 ромб
            //     Console.Write("Enter side of romb: ");
            //     int storona = int.Parse(Console.ReadLine());
            //     int spaceCounter = storona - 1;
            //     for (int i = 0; i < storona - 1; i++)
            //     { 
            //         for (int k = 0; k < spaceCounter; k++) {
            //             Console.Write(" ");
            //         }
            //         spaceCounter--;
            //         for (int j = 0; j <= i ; j++)
            //         {
            //             Console.Write("* ");
            //         }
            //         Console.WriteLine();   
            //     }
            //     spaceCounter = 0;
            //     for (int i = 0; i < storona; i++)
            //     { 
            //         for (int k = 0; k < spaceCounter; k++) {                        
            //             Console.Write(" ");
            //         }
            //         spaceCounter++;
            //         for (int j = storona ; j > i ; j--)
            //         {
            //             Console.Write("* ");
            //         }
            //         Console.WriteLine();    
            //     }
            // }
            { // ex #4 проще, чем выводить фигуры ... 
                Console.Write("Vvedite mesyachny prosent: ");
                decimal prosent = Convert.ToDecimal(Console.ReadLine());
                decimal nachVklad = 1000m; 
                int mesyac = 0;
                while ( nachVklad <= 1100)
                {
                    nachVklad = nachVklad + nachVklad * prosent/100;
                    mesyac++;
                }
                Console.WriteLine($"mesyac {mesyac}");
                Console.WriteLine($"Itogovy vklad {nachVklad}");
            }
        }
    }
}
