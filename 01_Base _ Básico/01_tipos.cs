using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Tipo int.
        Console.WriteLine("Int:");
        int num = 3;
        Console.WriteLine("Tipo: int");
        Console.WriteLine("Valor: " + num);

        //Tipo float.
        Console.WriteLine("\nFloat:");
        float numFloat = 3.5f;
        Console.WriteLine("Tipo: float");
        Console.WriteLine("Valor: " + numFloat);

        //Tipo complejo.
        Console.WriteLine("\nComplejo:");
        var numComplejo = new System.Numerics.Complex(3.5, 1.0);//Usando el tipo Complex de System.Numerics.
        Console.WriteLine("Tipo: complex<double>");
        Console.WriteLine("Valor: " + numComplejo);

        //Tipo booleano.
        Console.WriteLine("\nBooleano:");
        bool numBooleano = true;
        Console.WriteLine("Tipo: bool");
        Console.WriteLine("Valor: " + numBooleano);

        //Tipo string.
        Console.WriteLine("\nString:");
        string numStr = "3";
        Console.WriteLine("Tipo: string");
        Console.WriteLine("Valor: " + numStr);

        //Tipo lista.
        Console.WriteLine("\nLista:");
        List<int> numLista = new List<int> { 1, 2, 3 };
        Console.WriteLine("Tipo: List<int>");
        Console.Write("Valor: ");
        foreach (int n in numLista)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();

        //Tipo diccionario.
        Console.WriteLine("\nDiccionario:");
        var numDiccionario = new Dictionary<string, int> { { "uno", 1 }, { "dos", 2 }, { "tres", 3 } };
        Console.WriteLine("Tipo: Dictionary<string, int>");
        Console.Write("Valor: ");
        foreach (var pair in numDiccionario)
        {
            Console.Write("{" + pair.Key + ": " + pair.Value + "} ");
        }
        Console.WriteLine();

        //Tipo set.
        Console.WriteLine("\nSet:");
        var numSet = new HashSet<int> { 1, 2, 3 };
        Console.WriteLine("Tipo: HashSet<int>");
        Console.Write("Valor: ");
        foreach (int n in numSet)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();

        //Tipo tupla.
        Console.WriteLine("\nTupla:");
        var numTupla = Tuple.Create(1, 2.5f, "hola");
        Console.WriteLine("Tipo: Tuple<int, float, string>");
        Console.WriteLine("Valor: (" + numTupla.Item1 + ", " + numTupla.Item2 + ", " + numTupla.Item3 + ")");
    }
}
