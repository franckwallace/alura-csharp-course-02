﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    internal class GerenteDeConta : Funcionario
    {
        // Chamando o construtor da classe base, passando-se adiante o argumento "cpf"
        // Chamando o construtor da classe base, passando-se adiante o argumento "salario"
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {
        }

        // Com o "virtual" na classe base, pode-se sobrescrever (override) o método AumentarSalario
        public override void AumentarSalario()
        {
            Salario *= 1.05;

        }

        public override double GetBonificacao()
        {
            return Salario *= 0.25;
        }
    }
}
