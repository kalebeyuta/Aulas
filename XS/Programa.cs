using System;

class Aula03{
    static double Diametro(double Raio){
        double diametroC=0;
        diametroCU = Raio*2;
        return diametroC;
    }

    static double Area(double Raio){
        double areaC=0;
        areaCU = 3.14 * (Raio*Raio);
        return areaC;
    }
    static double Circuferencia(double Raio){
        double circuloC=0;
        double p=0;
        p = 3.14*Raio;
        circuloC = 2* p;
        return circuloC;
    }
    static void Main(){
      double Raio=0;
      Console.WriteLine("Raio");
      Raio = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine(Diametro(Raio));
      Console.WriteLine(Area(Raio));
      Console.WriteLine(Circuferencia(Raio));
    }
}   