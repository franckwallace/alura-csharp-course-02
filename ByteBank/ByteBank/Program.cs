using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            // chamando no método Main o Método Estático CalcularBonificacao
            // CalcularBonificacao();

            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor geovana = new Diretor("123.456.789-00");
            geovana.Nome = "Geovana";
            geovana.Senha = "123";

            GerenteDeConta larissa = new GerenteDeConta("410.110.263-00");
            larissa.Nome = "Larissa";
            larissa.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "xyz";

            sistemaInterno.Logar(larissa, "abc");
            sistemaInterno.Logar(geovana, "123");
            sistemaInterno.Logar(parceiro, "xyz");

            Console.ReadLine();
        }

        // criando um Método CalcularBonificacao
        public static void CalcularBonificacao()
        {
            // criando o GerenciadorBonificacao
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            // criando os funcionários
            Funcionario isabela = new Designer("111.222.333-44");
            isabela.Nome = "Isabela";

            Funcionario gabriela = new Auxiliar("098.765.432-10");
            gabriela.Nome = "Gabriela";


            Funcionario amanda = new Desenvolvedor("999.888.777-66");
            amanda.Nome = "Amanda";


            //Diretor geovana = new Diretor("123.456.789-00");
            //geovana.Nome = "Geovana";
            //geovana.Senha = "123";

            //GerenteDeConta larissa = new GerenteDeConta("410.110.263-00");
            //larissa.Nome = "Larissa";
            //larissa.Senha = "abc";




            // chamando o Método Registrar 
            // gerenciadorBonificacao.Registrar(geovana);
            gerenciadorBonificacao.Registrar(isabela);
            gerenciadorBonificacao.Registrar(gabriela);
            // gerenciadorBonificacao.Registrar(larissa);
            gerenciadorBonificacao.Registrar(amanda);

            Console.WriteLine("Total de bonificação: R$ " + gerenciadorBonificacao.GetTotalBonificacao());

        }
    }
}
