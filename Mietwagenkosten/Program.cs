using System;

public class Program()
{
    public static void Main()
    {
        //Deklarationsblock
        double preis;
        int eingabe;


        //Menu
        Console.Write("Geben sie die Mietwagenkategorie ein:\n" +
            "\n" +
            "A: Bei Fahrten unter 300km\n" +
            "B: Bei Fahrten bis 100km\n" +
            "C: Pauschalangebot - 150€\n\n");

        //Auswahl/Berechnung
        switch (Console.ReadLine())
        {
            //A
            case "A":
                Console.Write("Wie viele Kilometer wirst du schätzungsweise fahren?\n\n");

                //Eingabe - Schätz KM und Berechnung von preis
                eingabe = Convert.ToInt32(Console.ReadLine());


                if (eingabe <= 299.0)
                {
                    preis = eingabe * 0.42 + 90.0;
                }
                else
                {
                    preis = eingabe * 0.24 + 114.0;
                }

                Console.WriteLine("Der Preis liegt bei {0} Euro.", preis);
                break;
            case "a":
                Console.Write("Wie viele Kilometer wirst du schätzungsweise fahren?\n\n");

                //Eingabe - Schätz KM und Berechnung von preis
                eingabe = Convert.ToInt32(Console.ReadLine());


                if (eingabe <= 299.0)
                {
                    preis = eingabe * 0.42 + 90.0;
                }
                else
                {
                    preis = eingabe * 0.24 + 114.0;
                }

                Console.WriteLine("Der Preis liegt bei {0} Euro.", preis);
            break;
            //B
            case "B":
                Console.Write("Wie viele Kilometer wirst du schätzungsweise fahren?\n\n");

                //Eingabe - Schätz KM und Berechnung von preis
                eingabe = Convert.ToInt32(Console.ReadLine());


                if (eingabe <= 99.0)
                {
                    preis = 99.0;
                }
                else
                {
                    preis = eingabe * 0.17 + 99.0;
                }

                Console.WriteLine("Der Preis liegt bei {0} Euro.", preis);
            break;
            case "b":
                Console.Write("Wie viele Kilometer wirst du schätzungsweise fahren?\n\n");

                //Eingabe - Schätz KM und Berechnung von preis
                eingabe = Convert.ToInt32(Console.ReadLine());


                if (eingabe <= 99.0)
                {
                    preis = 99.0;
                }
                else
                {
                    preis = eingabe * 0.17 + 99.0;
                }

                Console.WriteLine("Der Preis liegt bei {0} Euro.", preis);
            break;
            //C
            case "C":
                Console.Write("Der Preis lautet pauschal 149 Euro\n");
            break;
            case "c":
                Console.Write("Der Preis lautet pauschal 149 Euro\n");
            break;

            default:
                Console.WriteLine("Falche Eingabe...");
            break;
        }
    }
}