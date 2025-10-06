namespace exercici6;

/* Declara una variable per al costat d'un quadrat. Calcula el seu perímetre (suma dels quatre costats) 
i imprimeix-lo. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora del perimetre d'un quadrat");
        Console.Write("Longitud d'un costat del quadrat: ");
        var costat = Console.ReadLine();
        int costat1 = Convert.ToInt16(costat);
        int resultat = costat1 * 4;
        Console.WriteLine($"El perimetre del quadrat es de: {resultat}");
    }
}