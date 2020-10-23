using System;

class Aula04{   
     static public Boolean Schizo  (int Analise)
    {
        Boolean retorno = false;
        if (Analise == 0)
        {
            retorno = true;
        }
        
        return retorno;
    }
    static void Main(){
      
      int Analise=0;
      Boolean Caralho=false;
      Caralho = Schizo(Analise);
      if (Caralho == true){
        Console.WriteLine("Schizo");
        Console.WriteLine(Caralho);
      }
      
    }
      
}