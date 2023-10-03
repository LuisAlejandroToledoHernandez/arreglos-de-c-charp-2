using System;

class Program
{
    static void Main()
    {
        int[] n = new int[] { 3, 4, 5 };

        Console.WriteLine("Elementoos del arreglo");
        foreach (int numero in n)
        {
            Console.WriteLine(numero);
        }
        int suma = 0;
        foreach (int numero in n)
        {
            suma += numero;
        }
        Console.WriteLine("suma de los elementos: " + suma);

        int maximo = n[0];

        foreach(int numero in n)
        {
            if(numero > maximo)
            {
                maximo = numero;
            }
        }

        Console.WriteLine("Numero maximo: " + maximo);

        Console.ReadLine();
    }

}
