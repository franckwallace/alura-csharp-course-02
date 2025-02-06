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

        // Chamando o construtor da classe base, passando-se adiante o argumento "cpf"
        // Chamando o construtor da classe base, passando-se adiante o argumento "salario"
        public Diretor(double salario, string cpf) : base(salario, cpf)
        {
            Console.WriteLine("Criando DIRETOR");

        }

        // Com o "virtual" na classe base, pode-se sobrescrever (override) o método AumentarSalario
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        // a palavra reservada "override" indica que o Método dessa classe derivada está sobrepondo/sobrescrevendo o Método "GetBonificacao" da sua classe mãe (no caso, Funcionario)
        public override double GetBonificacao()
        { 
            // a palavra reservada "base." evita um looping do Método GetBonificacao nessa classe derivada, chamando o Método contido na classe de origem (Funcionario)

            return (base.Salario * 1.0) + (base.GetBonificacao()); 
        }
    }
}
