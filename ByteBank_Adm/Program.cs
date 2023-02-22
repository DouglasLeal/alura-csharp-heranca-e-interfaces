using ByteBank_Adm.Models.Funcionarios;

var f = new Funcionario();
f.Salario = 1500;

Console.WriteLine(f.GetBonificacao());
