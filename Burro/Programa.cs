using System;


class Programa{
        static void Main()
        {
            Int64 Numero=0;
            Int64 Maior=0;
            Int64 Menor=0;
            Int64 I=0;
            Int64 Range=0;
        
            Console.WriteLine("Range");
            Range = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("PRIMEIRO");
            Numero = Convert.ToInt64(Console.ReadLine());
            Maior = Numero;
            Menor = Numero;

            for (I=0; I<Range; I++)
            {
              Console.WriteLine("Manda");
            Numero = Convert.ToInt64(Console.ReadLine());
            if (Numero>Maior){
                Maior = Numero;
            }
            if(Numero<Menor){
                  Menor = Numero;
              }

            }
            Console.WriteLine(""+Maior);
            Console.WriteLine(""+Menor);



        }
    }
