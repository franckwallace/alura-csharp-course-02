// adicionando 
using ByteBank.Funcionarios;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    // 
    // public abstract class IAutenticavel : Funcionario

    //    {
    //        //public string Senha { get; set; }

    //        //// criando um construtor
    //        //public IAutenticavel(double salario, string cpf) : base(salario, cpf)
    //        //{
    //        //}

    //        public bool Autenticar(string senha)
    //    {
    //        return Senha == senha;
    //    }

    //    bool Autenticar(string senha) { }
    //}

    // Interfaces não possuem implementações
    // Interfaces não possuem modificador de acesso em seus membros, pois, todas as implementações de interfaces devem expõem seus membros publicamente;
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
