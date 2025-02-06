using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            // adicionando o CPF como argumento
            Funcionario geovana = new Funcionario(2000, "123.456.789-00");

            geovana.Nome = "Geovana";
            // geovana.CPF = "123.456.789-00";
            // geovana.Salario = 2000;

            geovana.AumentarSalario();

            // imprimindo o resultado do método AumentarSalario
            Console.WriteLine("Novo salário da Geovana: " + geovana.Salario + "\n");

            // imprimindo o resultado do construtor Total de Funcionário
            Console.WriteLine(Funcionario.TotalDeFuncionario);

            Diretor larissa = new Diretor(5000, "000.999.789-00");

            larissa.Nome = "Larissa";
            // larissa.CPF = "000.999.789-00";
            // larissa.Salario = 5000;

            larissa.AumentarSalario();

            // imprimindo o resultado do método AumentarSalario
            Console.WriteLine("Novo salário da Larissa: " + larissa.Salario + "\n");

            Console.WriteLine("Bonificação de uma referência de Diretor: " + geovana.GetBonificacao());

            // imprimindo o resultado do construtor Total de Funcionário
            Console.WriteLine(Funcionario.TotalDeFuncionario);

            //atribuindo dentro da variável Funcionário um tipo mais derivado, de uma classe filha (no caso, Diretor, que é também um funcionário)
            // colocar em uma variável do tipo base um objeto especializado se chama "Polimorfismo"
            Funcionario larissaTeste = larissa;


            // teste para mostrar como o Método GetBonificação do tipo Diretor não está sendo sobrescrevendo o do Funcionário, mas que só funciona quando se trabalha explicitamente com o Diretor 
            Console.WriteLine("Bonificação de uma referência de Diretor: " + larissa.GetBonificacao());
            Console.WriteLine("Bonificação de uma referência de Funcionário: " + larissaTeste.GetBonificacao() + "\n");


            //
            gerenciador.Registrar(geovana);
            gerenciador.Registrar(larissa);


            Console.WriteLine("Nome: " + geovana.Nome);
            Console.WriteLine("CPF: " + geovana.CPF);
            Console.WriteLine("Salário: R$ " + geovana.Salario);
            Console.WriteLine("Bonificação: R$ " + geovana.GetBonificacao() + "\n");

            Console.WriteLine("Nome: " + larissa.Nome);
            Console.WriteLine("CPF: " + larissa.CPF);
            Console.WriteLine("Salário: R$ " + larissa.Salario);
            Console.WriteLine("Bonificação: R$ " + larissa.GetBonificacao() + "\n");

            Console.WriteLine("Total de Bonificações: R$ " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
