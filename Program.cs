using System;

public class Program
{
    public static void Main()
    {
        Fila<int> fila = new Fila<int>();
        fila.Enfileira(1);
        fila.Enfileira(2);
        fila.Enfileira(3);
        fila.Enfileira(4);
        fila.Enfileira(5);
        
        int[] array = fila.paraArray();

        foreach (int item in array) {
            Console.WriteLine(item);
        }
    }
}