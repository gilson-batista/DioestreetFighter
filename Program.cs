using DioestreetFighter.Scr.Entities;

class Program 
{
 static void  Main (string[] args)
 {
    Ryu lutador = new Ryu("RYU");
    
    Console.WriteLine(lutador.GolpeChuteForte());
    Console.WriteLine(lutador.GolpeSocoForte());
    Console.WriteLine(lutador.Hadouken());
    Console.WriteLine(lutador.HurricaneKick());
    Console.WriteLine(lutador.Shoryuken());
    Console.WriteLine(lutador.GolpeChuteMedio());
    Console.WriteLine(lutador.GolpeSocoFraco());
    Console.WriteLine(lutador);


 }
}