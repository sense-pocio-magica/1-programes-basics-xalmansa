namespace exercici16;

/* Ningú entén res del nou sistema d’avaluació. Necessitem un programa que calculi la part que és més senzilla: 
a partir de la mitjana de les notes les pràctiques i la nota de l’examen ens calculi la nota final

Nota de pràctiques: 8
Nota de l’examen: 9
La nota final és 8.7 o sigui un 8

Nota de pràctiques: 10
Nota de l’examen: 5
La nota final és 6.5 o sigui un 7 
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nota de pràctiques: ");
        var practiques = Console.ReadLine();
        float nota = Convert.ToSingle(practiques);
        Console.Write("Nota de l’examen: ");
        var examen = Console.ReadLine();
        float nota1 = Convert.ToSingle(examen);
        float resultat = (nota * 0.3f) + (nota1 * 0.7f);
        int resultat1 = (int)Math.Truncate(resultat);
        Console.WriteLine($"La nota final és {resultat} o sigui un {resultat1}");
    }
}
