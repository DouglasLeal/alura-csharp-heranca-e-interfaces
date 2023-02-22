using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Adm.Models.Funcionarios
{
    public class Funcionario
    {
        public string? Nome { get; protected set; }
        public string? CPF { get; protected set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(string nome, string cpf, double salario)
        {
            Nome = nome;
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }

        public virtual double GetBonificacao()
        {
            return Salario * 0.1;
        }

        public virtual void AumentarSalario()
        {
            Salario *= 1.1;
        }
    }
}
