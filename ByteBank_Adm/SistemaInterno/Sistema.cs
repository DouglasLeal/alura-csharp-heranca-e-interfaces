using ByteBank_Adm.Interfaces;
using ByteBank_Adm.Models.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Adm.SistemaInterno
{
    public class Sistema
    {
        public bool Logar(IAutenticavel autenticavel, string senha)
        {
            if (autenticavel.Autenticar(senha))
            {
                Console.WriteLine("Acesso ao sistema liberado.");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta.");
                return false;
            }
        }
    }
}
