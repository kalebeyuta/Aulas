using System;


class Programa{
        static void Main()
        {
        Int16 V1=0;
        Int16 V2=0;
        Int16 V3=0;
        Int16 Maior=0;
       



        Console.WriteLine("v1");
        V1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("v2");
        V2 =Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("v3");
        V3 =Convert.ToInt16(Console.ReadLine());

        if(V1 > V2 && V1 > V3){

           
            Maior = V1;
            V1 = V2;
            if(V1 > V3){
                V2 = V1;
                Console.Write(" O maior  "+ Maior +" o meio "+ V2 +" o menor "+ V3 +" ");
            }
           
        }
      
        if(V2>V1 && V2 >V3){
            Maior = V2;
            
            if(V2 > V3){
                
                Console.Write(" O maior "+ Maior +" o meio "+ V1 +" o menor "+ V3 +"  ");
            }
        }
        
        if(V3>V1 && V3>V2){
            Maior = V3;
            
                 Console.Write(" O maior "+ Maior +" o meio "+ V2 +" o menor "+ V1 +"  ");
            
            
            }

           
            
       

        }
    }
