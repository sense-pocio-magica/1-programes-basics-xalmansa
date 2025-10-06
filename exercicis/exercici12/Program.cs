﻿namespace exercici12;

/* Fes un programa que a partir de dos números imprimeixi per pantalla la seva suma, la seva resta, 
la seva multiplicació i la seva divisió

Entra el primer número: 3
Entra el segon número: 4

4 + 3 = 7
4 - 3 = 1
4 * 5 = 12
4 / 3 = 1  i en sobra 1


Entra el primer número: 25
Entra el segon número: 5

25 + 5 = 30
25 - 5 = 20
25 * 5 = 125
25 / 5 = 5  i en sobra 0
*/



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora completa");
        Console.Write("Primer numero: ");
        var numero = Convert.ToInt16(Console.ReadLine());

        Console.Write("Segon numero: ");
        var numero2 = Convert.ToInt16(Console.ReadLine());

        var suma = numero + numero2;
        var resta = numero2 - numero;
        var multiplicació = numero * numero2;
        var divisio = numero2 / numero;

        var sobradivisio = divisio % numero;
        
        Console.WriteLine($"La suma es: {suma}, la resta es: {resta}, la multiplicacio: {multiplicació}, la divisio {divisio} i el que sobra: {sobradivisio}");
    }
}
