using Revisao;

Funcionario fun = new Funcionario("PJX9594");
Dependente den = new Dependente();
Automovel aut = new Automovel();

if (fun.VerificarVeiculo(aut))
{
    Console.WriteLine("A placa contém 7 caracteres!");
}
else
{
    Console.WriteLine("A placa não contém 7 caracteres!");
}

if (fun.Contatar())
{
    Console.WriteLine("Contato Realizado");
}

int MatriculaFuncionario = fun.MatriculaFuncionario();
Console.WriteLine(MatriculaFuncionario);