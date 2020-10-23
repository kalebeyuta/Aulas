    using System;

class Aula04{   
     static public Boolean Schizo  (int Analise)
    {
        Boolean retorno = false;
        if (Analise > 0)
        {
            retorno = true;
            Analise = Analise-1 ;
            Console.WriteLine("AAAA");
            Console.WriteLine(Analise);
        }
        
        return retorno;
    }
    static void Main(){
      
      int Analise=100;
      Boolean Caralho=false;
      Caralho = Schizo(Analise);
      if (Caralho == true){
        Console.WriteLine("Schizo");
        Console.WriteLine(Caralho);
      }
      
    }
      
}