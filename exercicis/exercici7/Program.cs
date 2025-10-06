namespace exercici7;

/* Defineix tres variables amb tres notes numèriques. 
Calcula la mitjana i mostra el resultat per pantalla. */ 

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Primera nota: ");
        var nota = Console.ReadLine();
        float nota_int = Convert.ToSingle(nota);
        Console.Write("Segona nota: ");
        var nota1 = Console.ReadLine();
        float nota_int1 = Convert.ToSingle(nota1);
        Console.Write("Tercera nota: ");
        var nota2 = Console.ReadLine();
        float nota_int2 = Convert.ToSingle(nota2);
        var resultat = (nota_int + nota_int1 + nota_int2) / 3;
        Console.WriteLine($"La mitjana es de: {resultat}");
    }
}