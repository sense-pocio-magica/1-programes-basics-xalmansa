namespace exercici5;

/* Feu un programa que demani un nom i l’any de naixement i imprimeixi per pantalla 
“Hola [nom]!  Ja tens [edat] anys? 
nom i edat seran el nom introduït i l'edat la resta de l’any actual i l’any de naixement. */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("El teu nom? ");
        var nom = Console.ReadLine();
        Console.Write("Any naixement? ");
        var any = Console.ReadLine();
        int any_naixement = Convert.ToInt16(any);
        var any1 = 2025;
        int resultat = any1 - any_naixement;
        Console.WriteLine($"Hola {nom}! Ja tens {resultat}");
    }
}
