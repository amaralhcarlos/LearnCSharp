using System;


class Program
{
    static void Main(String[] args)
    {

        double valorA = 47;
        double valorB = 3;

        double resultado = valorA + valorB;
        Console.WriteLine("Soma de " + valorA + " e " + valorB + " é " + resultado);

        resultado = valorA - valorB;
        Console.WriteLine("Subtração de " + valorB + " de " + valorA + " é " + resultado);

        resultado = valorA * valorB;
        Console.WriteLine("Multiplicação de " + valorA + " por " + valorB + " é " + resultado);

        resultado = valorA / valorB;
        Console.WriteLine("Divisão de " + valorA + " por " + valorB + " é " + resultado);

        resultado = valorA % valorB;
        Console.WriteLine("Resto da Divisão de " + valorA + " e " + valorB + " é " + resultado);

        resultado = Math.Pow(valorA,valorB);
        Console.WriteLine("BÔNUS: Potência de " + valorA + " elevado a " + valorB + " é " + resultado);
    }
}


