namespace exercici20;

/* Ens cal un programa que quan li entrem un número de tres xifres i ens retorni 
el número amb els dígits invertits. 

Ex. 245 -> 542
Entra el número a invertir: 347
El número invertit és: 743
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Entra el número a invertir: ");
        var numero = Console.ReadLine();
        char numero1 = numero[0];
        char numero2 = numero[1];
        char numero3 = numero[2];

        Console.WriteLine($"El número invertit és: {numero3}{numero2}{numero1}");
    }
}
