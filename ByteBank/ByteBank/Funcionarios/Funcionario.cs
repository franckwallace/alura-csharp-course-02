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

        // Criando um campo estático (é uma propriedade da classe) para obter o total de funcionários
        // o "set" é private porque não pode ser alterado de fora
        public static int TotalDeFuncionario { get; private set; }

        public string Nome { get; set; }
        // privando o CPF para ele não ser usado lá fora
        public string CPF { get; private set; }
        public double Salario { get; set; }

        // Construtor "Funcionario" que indica qual tipo de funcionário o objeto criado faz parte
        //public Funcionario(int tipo) 
        //{
        //    _tipo = tipo;
        //}

        // Criando um Construtor para calcular o total de funcionário
        // Colocando uma obrigação no Construtor de ser informado o "cpf"
        public Funcionario(string cpf)
        {
            // imprimindo para função de testes
            Console.WriteLine("Criando FUNCIONARIO");
            TotalDeFuncionario++;

            CPF = cpf;
        }

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
