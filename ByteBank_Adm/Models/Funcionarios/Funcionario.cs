using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Adm.Models.Funcionarios
{
    public class Funcionario
    {
        public string? Nome { get; set; }
        public string? CPF { get; protected set; }
        public double Salario { get; set; }
        public static int TotalDeFuncionarios { get; private set; }

        public virtual double GetBonificacao()
        {
            return Salario * 0.1;
        }

        public Funcionario(string cpf)
        {
            CPF = cpf;
            TotalDeFuncionarios++;
        }
    }
}
