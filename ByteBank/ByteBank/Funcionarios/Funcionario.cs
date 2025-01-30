using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    internal class Funcionario
    {
        // Criando o campo "_tipo" que será usado no Construtor "Funcionario"
        // 0 - Funcionario
        // 1 - Diretor
        // 2 - Designer
        // N - ...
        // private int _tipo;


        // Criando novas Propriedades para o funcionário
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        // Construtor "Funcionario" que indica qual tipo de funcionário o objeto criado faz parte
        //public Funcionario(int tipo) 
        //{
        //    _tipo = tipo;
        //}

        // Método que retorna a bonificação
        // a palavra reservada "virtual" indica que o Método "GetBonificacao" pode ser sobrescrito por um método de uma classe derivada, como Diretor, no caso
        public virtual double GetBonificacao() 
        {
            //if (_tipo == 1)
            //{
            //    return Salario * 1.0;
            //}

            //if (_tipo == 2)
            //{
            //    return Salario * 0.15;
            //}

            return Salario * 0.1;
        }


    }
}
