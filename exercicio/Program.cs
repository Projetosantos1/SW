namespace exercicio;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //Console.ReadKey();

        //Criar uma instancia (objeto) a partir de uma Classe
        Exemplo exe01 = new Exemplo();

        exe01.mostramsg();

        exe01.pegaNome("T.i acima de tudo.");

        Console.WriteLine(exe01.mensagem());
        
        Console.WriteLine("O resultado da some é: " + exe01.somar(77, 33));


    }
}
