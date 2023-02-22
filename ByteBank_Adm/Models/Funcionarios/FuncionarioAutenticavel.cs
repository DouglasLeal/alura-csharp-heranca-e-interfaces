using ByteBank_Adm.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Adm.Models.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }

        protected FuncionarioAutenticavel(string nome, string cpf, double salario, string senha) : base(nome, cpf, salario)
        {
            Senha = senha;
        }
       
        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
