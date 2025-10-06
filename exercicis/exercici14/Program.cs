namespace exercici14;

// Declara una paraula i fes que el programa imprimeixi només la primera lletra, l'última lletra i la lletra del mig 
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Escriue la paraula: ");
        var paraula = Console.ReadLine();
        var primera = paraula[0];
        var mitj = paraula[paraula.Length / 2];
        var ultima = paraula[paraula.Length - 1];

        Console.WriteLine($"La primer lletra es: {primera}, la lletra del mitj {mitj} i la ultima lletra es: {ultima}");
    }
}