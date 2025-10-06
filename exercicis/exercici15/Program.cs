namespace exercici15;

// Assigna un nom i un cognom en variables. Imprimeix el nom complet, 
// assegurant-te que la primera lletra de cada paraula estigui en majúscula
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Escriu el teu nom: ");
        var nom = Console.ReadLine();
        string primeraLetraMayuscula = Char.ToUpper(nom[0]).ToString();
        string laresta = nom.Substring(1).ToLower();
        Console.Write("Escriu el teu cognom ");
        var cognom = Console.ReadLine();
        string primeraLetraMayuscula2 = Char.ToUpper(cognom[0]).ToString();
        string laresta1 = cognom.Substring(1).ToLower();
        
        var resultat = primeraLetraMayuscula + laresta;
        var resultat1 = primeraLetraMayuscula2 + laresta1;
        
        Console.WriteLine($"El teu nom i cognom es: {resultat} {resultat1}.");
    }
}
