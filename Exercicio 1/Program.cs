namespace exercicio1;
class Program
{
    static void Main(string[] args)
    {
    Homem Vitor = new Homem();
    Cao Caramelo = new Cao();
    Gato Pitoco = new Gato();

    Console.WriteLine(Vitor.Fala());
    Console.WriteLine(Caramelo.Fala());
    Console.WriteLine(Pitoco.Fala());
    }   
        
}
