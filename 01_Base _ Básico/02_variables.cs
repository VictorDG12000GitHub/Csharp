using System;

class Program
{
    static void Main()
    {
        //Camel case.
        string miVariableStringCamelCase = "String"; 
        Console.WriteLine(miVariableStringCamelCase);

        //Concatenación.
        Console.WriteLine(miVariableString + " " + 5 + " hola");

        //ToString, conversión de entero a string.
        int num = 5;
        string intToStr = num.ToString();
        Console.WriteLine("Tipo: string (resultado de ToString)");
        Console.WriteLine("Valor: " + intToStr);

        //Declaración múltiple.
        int a = 1, b = 2, c = 3;
        string d = "d";
        Console.WriteLine("Valores de variables múltiples: a=" + a + ", b=" + b + ", c=" + c + ", d=" + d);
    }
}
