using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Välkommen till enkelt C#-projekt!");

        // Ta emot input från användaren
        Console.Write("Ange det första talet: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ange det andra talet: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Beräkna summan
        int sum = Addera(num1, num2);

        // Visa resultatet
        Console.WriteLine($"Summan av {num1} och {num2} är: {sum}");

        Console.ReadLine(); // Vänta på användarens input innan programmet avslutas
    }

    // Funktion för att addera två tal
    static int Addera(int a, int b)
    {
        return a + b;
    }
}
