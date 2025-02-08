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
            // chamando no método Main o Método Estático CalcularBonificacao
            CalcularBonificacao();

            Console.ReadLine();
        }

        // criando um Método CalcularBonificacao
        public static void CalcularBonificacao()
        {
            // criando o GerenciadorBonificacao
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            // criando os funcionários
            Funcionario geovana = new Diretor("123.456.789-00");
            geovana.Nome = "Geovana";

            Funcionario isabela = new Designer("111.222.333-44");
            isabela.Nome = "Isabela";

            Funcionario gabriela = new Auxiliar("098.765.432-10");
            gabriela.Nome = "Gabriela";

            Funcionario larissa = new GerenteDeConta("410.110.263-00");
            larissa.Nome = "Larissa";

            Funcionario amanda = new Desenvolvedor("999.888.777-66");
            amanda.Nome = "Amanda";

            // chamando o Método Registrar 
            gerenciadorBonificacao.Registrar(geovana);
            gerenciadorBonificacao.Registrar(isabela);
            gerenciadorBonificacao.Registrar(gabriela);
            gerenciadorBonificacao.Registrar(larissa);
            gerenciadorBonificacao.Registrar(amanda);

            Console.WriteLine("Total de bonificação: R$ " + gerenciadorBonificacao.GetTotalBonificacao());

        }
    }
}
