namespace Exemplo_Heranca;

class FuncionarioN1:Funcionario
{

    public int Idade {get;set;}

    public override double Lucro(){
        return base.Lucro()*0.01;
    }
}