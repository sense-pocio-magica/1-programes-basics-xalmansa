namespace exercici11;

// A partir de dues variables (nom d'usuari i domini), crea i imprimeix una adreça de correu electrònic completa.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("La teva adreça de correu");
        Console.Write("Nom d'usuari: ");
        var nomusuari = Console.ReadLine();

        var domini = ("cendrassos.net");

        Console.WriteLine($"La teva adreça de correu es: {nomusuari}@{domini}");
    }
}
