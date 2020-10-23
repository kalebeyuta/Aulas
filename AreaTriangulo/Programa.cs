using System;


class Programa{
        static void Main()
        {
        Double Altura=0;
        Double Base=0;
        Double Resultado;


        Console.WriteLine("Altura");
        Altura = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Base");
        Base =Convert.ToDouble(Console.ReadLine());


        Resultado = Base*Altura;
        Resultado = Resultado/2;
        Console.WriteLine(Resultado);
        Console.ReadKey();



        }
    }
