using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Adm.Models.Funcionarios
{
    public class Diretor : Funcionario
    {

        public Diretor(string nome, string cpf): base(nome, cpf, 5000)
        {

        }

        public override double GetBonificacao()
        {
            return Salario * 1.1;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
