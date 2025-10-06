namespace exercici18;

/* Un rellotger està perdent la memòria i necessita un programa que a partir de l'hora actual li puguem dir
 quina hora serà d’aquí un nombre determinat d’hores.

Hora actual: 9
Hores a incrementar: 3
D'aquí a 3 hores seran les 12


Hora actual: 11
Hores a incrementar: 3
D'aquí a 3 hores seran les 2
*/ 

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hora actual: ");
        int actual = Convert.ToInt16(Console.ReadLine());
        Console.Write("Hores a incrementar: ");
        int increment = Convert.ToInt16(Console.ReadLine());
        var resultat = actual + increment;

        if (resultat > 12)
        {
            var resultat1 = resultat - 12;
            Console.WriteLine($"D'aquí a {increment} hores seran les {resultat1}");
        }
        else
        {
            Console.WriteLine($"D'aquí a {increment} hores seran les {resultat}");
        }
    }
}
