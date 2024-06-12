using System;

public class Program
{
    private static string enter;

    public static void Main()
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(" - Geldrechner mit Euro - ");
        Console.WriteLine(" Programmed by Christian. ");
        Console.WriteLine("          ");
        Console.WriteLine(" *A*  Nach Anzahl         ");
        Console.WriteLine(" *B*  Nach Gewicht        ");
        enter = Console.ReadLine();
        if (enter == "A")
        {
            Console.Clear();
            Console.WriteLine(" Geldzähler 1.0 (2022) ");
            Console.WriteLine(" Nun gibst du die Anzahl der genannten Münzen/Scheinen an:");


            Console.WriteLine(" Anzahl der 1-Cent-Münzen: ");
            string cent1 = Console.ReadLine();
            Int64 result1 = Convert.ToInt64(cent1) * Convert.ToInt64(1);


            Console.WriteLine(" Anzahl der 2-Cent-Münzen: ");
            string cent2 = Console.ReadLine();
            Int64 result2 = Convert.ToInt64(cent2) * Convert.ToInt64(2);


            Console.WriteLine(" Anzahl der 5-Cent-Münzen: ");
            string cent5 = Console.ReadLine();
            Int64 result3 = Convert.ToInt64(cent5) * Convert.ToInt64(5);


            Console.WriteLine(" Anzahl der 10-Cent-Münzen: ");
            string cent10 = Console.ReadLine();
            Int64 result4 = Convert.ToInt64(cent10) * Convert.ToInt64(10);


            Console.WriteLine(" Anzahl der 20-Cent-Münzen: ");
            string cent20 = Console.ReadLine();
            Int64 result5 = Convert.ToInt64(cent20) * Convert.ToInt64(20);


            Console.WriteLine(" Anzahl der 50-Cent-Münzen: ");
            string cent50 = Console.ReadLine();
            Int64 result6 = Convert.ToInt64(cent50) * Convert.ToInt64(50);


            Console.WriteLine(" Anzahl der 1-Euro-Münzen: ");
            string cent100 = Console.ReadLine();
            Int64 result7 = Convert.ToInt64(cent100) * Convert.ToInt64(100);


            Console.WriteLine(" Anzahl der 2-Euro-Münzen: ");
            string cent200 = Console.ReadLine();
            Int64 result8 = Convert.ToInt64(cent200) * Convert.ToInt64(200);


            Console.WriteLine(" Anzahl der 5-Euro-Schein: ");
            string euro5 = Console.ReadLine();
            Int64 result9 = Convert.ToInt64(euro5) * Convert.ToInt64(500);


            Console.WriteLine(" Anzahl der 10-Euro-Schein: ");
            string euro10 = Console.ReadLine();
            Int64 result10 = Convert.ToInt64(euro10) * Convert.ToInt64(1000);


            Console.WriteLine(" Anzahl der 20-Euro-Schein: ");
            string euro20 = Console.ReadLine();
            Int64 result11 = Convert.ToInt64(euro20) * Convert.ToInt64(2000);


            Console.WriteLine(" Anzahl der 50-Euro-Schein: ");
            string euro50 = Console.ReadLine();
            Int64 result12 = Convert.ToInt64(euro50) * Convert.ToInt64(5000);


            Console.WriteLine(" Anzahl der 100-Euro-Schein: ");
            string euro100 = Console.ReadLine();
            Int64 result14 = Convert.ToInt64(euro100) * Convert.ToInt64(10000);


            Int64 resultct = Convert.ToInt64(result1) + Convert.ToInt64(result2) + Convert.ToInt64(result3) + Convert.ToInt64(result4) + Convert.ToInt64(result5) + Convert.ToInt64(result6) + Convert.ToInt64(result7) + Convert.ToInt64(result8) + Convert.ToInt64(result9) + Convert.ToInt64(result10) + Convert.ToInt64(result11) + Convert.ToInt64(result12) + Convert.ToInt64(result14);
            Int64 resulteu = Convert.ToInt64(resultct) / Convert.ToInt64(100);
            Console.WriteLine(" Es ergeben sich " + resultct + "Cent. ");
            Console.WriteLine("          ");
            Console.WriteLine(" Drücke eine beliebige Taste zum beenden. ");
            Console.ReadKey();
        }

        else if (enter == "B")
        {
            Console.Clear();
            Console.WriteLine(" Gebe das Gesamtgewicht (in Gramm, ohne g) der genannten Münzen an: ");

            Console.WriteLine(" Gebe das Gewicht der 1-Cent-Münzen an: ");
            string gewicht1 = Console.ReadLine();
            Int64 anzahl1 = Convert.ToInt64(gewicht1) / Convert.ToInt64("2");
            Int64 cash1 = Convert.ToInt64(anzahl1) * Convert.ToInt64("1");

            Console.WriteLine(" Gebe das Gewicht der 2-Cent-Münzen an: ");
            string gewicht2 = Console.ReadLine();
            Int64 anzahl2 = Convert.ToInt64(gewicht2) / Convert.ToInt64("3");
            Int64 cash2 = Convert.ToInt64(anzahl2) * Convert.ToInt64("2");

            Console.WriteLine(" Gebe das Gewicht der 5-Cent-Münzen an: ");
            string gewicht3 = Console.ReadLine();
            Int64 anzahl3 = Convert.ToInt64(gewicht3) / Convert.ToInt64("4");
            Int64 cash3 = Convert.ToInt64(anzahl3) * Convert.ToInt64("5");

            Console.WriteLine(" Gebe das Gewicht der 10-Cent-Münzen an: ");
            string gewicht4 = Console.ReadLine();
            Int64 anzahl4 = Convert.ToInt64(gewicht4) / Convert.ToInt64("4");
            Int64 cash4 = Convert.ToInt64(anzahl4) * Convert.ToInt64("10");

            Console.WriteLine(" Gebe das Gewicht der 20-Cent-Münzen an: ");
            string gewicht5 = Console.ReadLine();
            Int64 anzahl5 = Convert.ToInt64(gewicht5) / Convert.ToInt64("5");
            Int64 cash5 = Convert.ToInt64(anzahl5) * Convert.ToInt64("20");

            Console.WriteLine(" Gebe das Gewicht der 50-Cent-Münzen an: ");
            string gewicht6 = Console.ReadLine();
            Int64 anzahl6 = Convert.ToInt64(gewicht6) / Convert.ToInt64("8");
            Int64 cash6 = Convert.ToInt64(anzahl6) * Convert.ToInt64("50");

            Console.WriteLine(" Gebe das Gewicht der 1-Euro-Münzen an: ");
            string gewicht7 = Console.ReadLine();
            Int64 anzahl7 = Convert.ToInt64(gewicht7) / Convert.ToInt64("7");
            Int64 cash7 = Convert.ToInt64(anzahl7) * Convert.ToInt64("100");

            Console.WriteLine(" Gebe das Gewicht der 2-Euro-Münzen an: ");
            string gewicht8 = Console.ReadLine();
            Int64 anzahl8 = Convert.ToInt64(gewicht8) / Convert.ToInt64("8");
            Int64 cash8 = Convert.ToInt64(anzahl8) * Convert.ToInt64("200");

            Int64 cash = Convert.ToInt64(cash1) + Convert.ToInt64(cash2) + Convert.ToInt64(cash3) + Convert.ToInt64(cash4) + Convert.ToInt64(cash5) + Convert.ToInt64(cash6) + Convert.ToInt64(cash7) + Convert.ToInt64(cash8);
            Console.WriteLine(" Es sind ca. " + cash + " Cent. ");
            Console.ReadKey();
        }

    }
}
