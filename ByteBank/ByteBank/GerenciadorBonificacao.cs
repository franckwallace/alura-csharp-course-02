﻿using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class GerenciadorBonificacao
    {
        private double _totalBonificacao;
        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        // Aqui tem-se um Método "Registrar" com o mesmo nome. Isso é válido para lista de argumentos diferentes (diretor e funcionário), chamado de sobrecarga

        //public void Registrar(Diretor diretor)
        //{
        //    _totalBonificacao += diretor.GetBonificacao();
        //}

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
