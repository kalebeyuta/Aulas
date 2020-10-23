using System;


class Programa{
        static void Main()
        {
            Int64 Numero=0;
            Int64 resto=0;
        
            Console.WriteLine("Numero");
            Numero = Convert.ToInt64(Console.ReadLine());
            
            while (Numero > 0)
            {
                resto = Numero/2;
                if(resto/2 >= 0){
                    Console.WriteLine("1");
                    Numero = Numero/2;

                }
                if(resto/2 >= 1){
                    Console.WriteLine("0");
                    Numero = Numero/2;
                }
            }



        }
    }
