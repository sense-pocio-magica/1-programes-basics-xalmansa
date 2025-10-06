namespace exercici10;

/* Declara dues variables: una per al nom i una altra per l’any de naixement. 
Combina-les per crear una contrasenya bàsica (per exemple, Pere i 1982 -> Pere1982). 
Imprimeix la contrasenya generada (i sobretot no la facis servir mai que és molt dolenta) */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("El teu nom: ");
        var nom = Console.ReadLine();

        Console.Write("El teu any de naixement: ");
        var any = Console.ReadLine();
        int any1 = Convert.ToInt16(any);

        Console.WriteLine($"La teva contrasenya super segura es: {nom}{any1}");
    }
}