namespace exercici9;

/* Demana un valor en metres. Converteix el valor a peus (1 metre = 3,28084 metres) 
i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Calculadora de metros a peus ");
        var metros = Console.ReadLine();
        float metros1 = Convert.ToSingle(metros);

        var pies = (metros1 * 3.28084);
        Console.WriteLine($"El resultat es: {pies}");
    }
}
