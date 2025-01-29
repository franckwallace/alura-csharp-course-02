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

            Funcionario geovana = new Funcionario();

            geovana.Nome = "Geovana";
            geovana.CPF = "123.456.789-00";
            geovana.Salario = 3500;

            Diretor larissa = new Diretor();

            larissa.Nome = "Larissa";
            larissa.CPF = "000.999.789-00";
            larissa.Salario = 6125;


            //
            gerenciador.Registar(geovana);
            gerenciador.Registar(larissa);


            Console.WriteLine("Nome: " + geovana.Nome);
            Console.WriteLine("CPF: " + geovana.CPF);
            Console.WriteLine("Salário: R$ " + geovana.Salario);
            Console.WriteLine("Bonificação: R$ " + geovana.GetBonificacao());

            Console.ReadLine();
        }
    }
}
