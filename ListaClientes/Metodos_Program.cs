using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ListaClientes
{
    //Program com os metodos à utilizar.
    partial class Program
    {
        //Opção A, metódo de cadastrar clientes novos.
        static void CadastrarClientes(string NomeCliente, string Telefone, string CPF, string logradouro)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("*           Cadastrar Cliente          *");
            Console.WriteLine("****************************************\n");

            //Atribuição dos valores aos campos.

            Console.Write("Nome: ");
            NomeCliente = Console.ReadLine();
            while (NomeCliente == "")
            {
                Console.Write("Telefone invalido, discrimine novamente:");
                NomeCliente = Console.ReadLine();
            }

            Console.Write("Telefone: ");
            Telefone = Console.ReadLine();
            while (Telefone == "")
            {
                Console.Write("Telefone invalido, discrimine novamente:");
                Telefone = Console.ReadLine();
            }
            Console.Write("CPF: ");
            CPF = Console.ReadLine();
            while (CPF == "")
            {
                Console.Write("CPF invalido, discrimine novamente:");
                CPF = Console.ReadLine();
            }
            Console.Write("Logradouro: ");
            logradouro = Console.ReadLine();
            while (logradouro == "")
            {
                Console.Write("Logradouro invalido, discrimine novamente:");
                logradouro = Console.ReadLine();
            }

            Console.WriteLine();

            //Escreve no arquivo TXT 
            var BD = "Clientes.txt";
            using (var Arquivo = new FileStream(BD, FileMode.Append))
            using (var escritor = new StreamWriter(Arquivo, Encoding.Default))
            {
                escritor.WriteLine($"Cliente: {NomeCliente}; Telefone: {Telefone}; CPF: {CPF}");
                escritor.WriteLine($"Logradouro: {logradouro}");
                escritor.WriteLine();

                Console.WriteLine();

                escritor.Flush();
                escritor.Close();
            }
        }

        //Opção B, Relatorio com os dados dos clientes.
        static void RelatorioClientes()
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("*   Relatorio de clientes cadastrados  *");
            Console.WriteLine("****************************************\n");


            //Lê todo o arquivo TXT e mostra em tela.
            var Leitor = new StreamReader("Clientes.txt", Encoding.Default);
            string[] linhas = Leitor.ReadToEnd().Split('\n');

            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }
        }

        //Opção C, Cadastrar Funcionario.
        static void CadastrarFuncionario(string Nome, string Cargo, double Salario)
        {
            var func = new Funcionario();

            Console.WriteLine("****************************************");
            Console.WriteLine("*      Cadastrar Funcionario novo      *");
            Console.WriteLine("****************************************\n");

            Console.Write("Nome Funcionario: ");
            Nome = Console.ReadLine();

            while (Nome == "")
            {
                Console.Write("Nome invalido, discrimine novamente:");
                Nome = Console.ReadLine();
            }

            Console.Write("Cargo Funcionario: ");
            Cargo = Console.ReadLine();

            while (Cargo == "")
            {
                Console.Write("cargo invalido, discrimine novamente:");
                Cargo = Console.ReadLine();
            }



            try
            {
                Console.Write("Salario Funcionario: ");
                Salario = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.Write("formato invalido, informe um valor numerico:");
                Salario = double.Parse(Console.ReadLine());
            }

            while (Salario == 0)
            {
                Console.Write("cargo invalido, discrimine novamente:");
                Salario = double.Parse(Console.ReadLine());
            }

            //escritor do cadastrar Funcionario
            var BD2 = "Funcionario.TXT";
            using (var arquivoF = new FileStream(BD2, FileMode.Append))
            using (var escritorF = new StreamWriter(arquivoF, Encoding.Default))
            {
                escritorF.WriteLine($"Funcionario: {Nome}; Cargo: {Cargo}; Salario: {Salario}");
                escritorF.WriteLine();

                escritorF.Flush();
                escritorF.Close();
            }
        }

        static void RelatorioFuncionarios()
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("* Relatorio de Funcionaios cadastrados *");
            Console.WriteLine("****************************************\n");

            Console.WriteLine();

            //Lê todo o arquivo TXT e mostra em tela.
            var Leitor = new StreamReader("Funcionario.TXT", Encoding.Default);
            string[] linhas = Leitor.ReadToEnd().Split('\n');

            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }
        }
    }
}
