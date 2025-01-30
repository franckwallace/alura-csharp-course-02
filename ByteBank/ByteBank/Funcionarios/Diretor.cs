using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    // Ao inserir dois pontos (:), diz-se que o Diretor é uma classe derivada do Funcionário, herdando seus parâmetros
    internal class Diretor : Funcionario
    {
        //public string Nome { get; set; }
        //public string CPF { get; set; }
        //public double Salario { get; set; }

        // a palavra reservada "override" indica que o Método dessa classe derivada está sobrepondo/sobrescrevendo o Método "GetBonificacao" da sua classe mãe (no caso, Funcionario)
        public override double GetBonificacao()
        { 
            // a palavra reservada "base." evita um looping do Método GetBonificacao nessa classe derivada, chamando o Método contido na classe de origem (Funcionario)

            return (Salario * 1.0) + (base.GetBonificacao()); 
        }
    }
}
