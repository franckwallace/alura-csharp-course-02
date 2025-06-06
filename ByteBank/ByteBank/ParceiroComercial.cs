﻿using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    // implementação da interface 'IAutenticavel', respeitando o contrato
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha {  get; set; }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
