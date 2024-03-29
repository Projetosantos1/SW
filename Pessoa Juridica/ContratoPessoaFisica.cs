public class ContratoPessoaFisica : Contrato
{
    public string cpf;
    public int idade;

    public ContratoPessoaFisica(string descricao, double valor, string cpf, int idade)
        : base(descricao, valor)
    {
        this.cpf = cpf;
        this.idade = idade;
    }

    public override void ExibirDetalhes()
    {
        base.ExibirDetalhes();
        Console.WriteLine("CPF: " + cpf);
        Console.WriteLine("Idade: " + idade);
    }
}
