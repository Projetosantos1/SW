namespace exemplo_acessor;
class Program
{
    static void Main(string[] args)
    {
        Produto p1 = new Produto();
        //p1.Preco = 20;
        p1.AlterarPreco(-50);
        p1.AlterarNome("PARAFUSO");
        p1.MostraDados();
    


        //Console.WriteLine("GAveta: " + p1.Preco);
    }
}
 
