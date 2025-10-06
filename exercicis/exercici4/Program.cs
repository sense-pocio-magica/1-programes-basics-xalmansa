namespace exercici4;

/* Un avi encara no sap quin és el valor de les coses perquè a tot arreu li parlen d’euros, 
però ell s’ha negat a canviar i encara té un pot ple de monedes de pesseta.
Necessita un programa amb el qual posi el valor de l'article que vol comprar en 
euros i li digui quin és el valor en les antigues pessetes
Nota: 1 euro = 166.386 pessetes i les pessetes no tenien cap decimal */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora de euros a pesetas ");
        var pesetas = 166.386;
        int pesetas1 = Convert.ToInt16(pesetas);

        Console.Write("Preu en euros? ");
        var euros = Console.ReadLine();
        double euros1 = Convert.ToDouble(euros);
        Console.WriteLine($"El preu en pesetas es de: {euros1 * pesetas1}");
    }
}
