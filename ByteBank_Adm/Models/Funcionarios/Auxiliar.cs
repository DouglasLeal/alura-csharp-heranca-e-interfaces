﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Adm.Models.Funcionarios
{
    public class Auxiliar : Funcionario
    {

        public Auxiliar(string nome, string cpf): base(nome, cpf, 2000)
        {

        }

        public override double GetBonificacao()
        {
            return Salario * 0.2;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }
    }
}