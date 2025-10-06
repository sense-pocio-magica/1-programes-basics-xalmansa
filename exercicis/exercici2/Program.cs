namespace exercici2;

/* Declara variables per emmagatzemar l’adreça d’una persona: 
carrer, número, codi postal i població. Imprimeix el resultat 
en una sola línia */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Escriu el teu carrer: ");
        var carrer = Console.ReadLine();
        Console.Write("Escriu el teu numero del carrer: ");
        var numero = Console.ReadLine();
        int numerocarrer = Convert.ToInt16(numero);
        Console.Write("Escriu el teu Codi postal: ");
        var codi = Console.ReadLine();
        int codiposta = Convert.ToInt16(codi);
        Console.Write("Escriu la teva poblacio: ");
        var poblacio = Console.ReadLine();

        Console.WriteLine($"Vius al carrer {carrer}, el teu numero es {numero}, el teu codi postal es {codi} i la teva poblacio es {poblacio}");
    }
}
