namespace exercici19;

// Assigna una paraula a una variable de text. Utilitza una funció per a obtenir la seva longitud i 
// imprimeix la paraula i el seu nombre de caràcters.
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digues una paraula: ");
        var paraula = Console.ReadLine();

        var longitud = paraula.Length;

        Console.WriteLine($"La paraula es: {paraula} i la seva longitud es: {longitud}");
    }
}
