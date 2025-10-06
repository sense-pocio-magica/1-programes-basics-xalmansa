namespace exercici3;

/* Defineix quatre variables per al nom d’un producte, el seu preu 
i si està en estoc o no. Imprimeix la informació de forma clara. */
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Quin producte vols? ");
        var producte = Console.ReadLine();
        Console.Write("Quin preu te? ");
        var preu = Console.ReadLine();
        Console.Write("Té estoc? ");
        var estoc = Console.ReadLine();
        bool ok;

        if (estoc == "si")
        {
            ok = true;
        }
        else
        {
            ok = false;
        }
        if (ok == true)
        {
            Console.WriteLine($"El producte que has seleccionat es: {producte}, el seu preu es de: {preu} i si hi ha estoc");
        }
        else
        {
            Console.WriteLine($"El producte que has seleccionat es: {producte}, el seu preu es de: {preu} i no hi ha estoc");
        }
    }
}
