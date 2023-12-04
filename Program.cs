using System;
class Multiplicacion
{
    public static void Main()
    {
        Console.Write("Ingrese el multiplicando: ");
        if (int.TryParse(Console.ReadLine(), out int multiplicando))
        {
            Console.Write("Ingrese el multiplicador: ");
            if (int.TryParse(Console.ReadLine(), out int multiplicador))
            {
                int resultado = MultiplicacionRusa(multiplicando, multiplicador);
                Console.WriteLine($"El resultado de {multiplicando} * {multiplicador} es: {resultado}");
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un multiplicador válido.");
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un multiplicando válido.");
        }
    }

    public static int MultiplicacionRusa(int multiplicando, int multiplicador)
    {
        int resultado = 0;

        while (multiplicador > 0)
        {
            if (multiplicador % 2 != 0)
            {
                resultado += multiplicando;
            }

            multiplicando *= 2;
            multiplicador /= 2;
        }

        return resultado;
    }
}