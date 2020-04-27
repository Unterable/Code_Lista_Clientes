using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;


namespace ListaClientes
{
    partial class Program
    {
        //Program principal
        static void Main(string[] args)
        {
            //Inicio da aplicação
            Console.WriteLine("****************************************");
            Console.WriteLine("*            Seja bem vindo            *");
            Console.WriteLine("****************************************\n");

            Console.WriteLine("> Digite uma das opções da lista abaixo <\n");

            Console.WriteLine("a - Cadastrar Clientes");
            Console.WriteLine("b - Lista de Clientes\n");
            Console.WriteLine("c - Cadastrar Funcionários");
            Console.WriteLine("d - Lista de Funcionários\n");

            Console.Write("Opção desejada: ");

            //instancia da classe Cliente com os dados dos clientes.
            var cliente = new Cliente();
            //instancia da classe Funcionario com os dados dos Funcionarios.
            var funcionario = new Funcionario();

            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "a":
                        Console.Clear();
                        CadastrarClientes(cliente.Nome, cliente.Telefone, cliente.CPF, cliente.logradouro);
                        Console.WriteLine("\nCliente cadastrado!\n Aperte Enter.");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("****************************************");
                        Console.WriteLine("*            Seja bem vindo            *");
                        Console.WriteLine("****************************************\n");
                        Console.WriteLine(
                        "(a) cadastrar Cliente (b) relatorio de clientes \n " +
                            "(c) cadastrar funcionario (d) Lista de Funcionarios");
                        break;

                    case "b":
                        Console.Clear();
                        RelatorioClientes();
                        Console.WriteLine("\n Aperte qualquer tecla para selecionar outra opção.");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("****************************************");
                        Console.WriteLine("*            Seja bem vindo            *");
                        Console.WriteLine("****************************************\n");
                        Console.WriteLine(
                        "(a) cadastrar Cliente (b) relatorio de clientes \n " +
                            "(c) cadastrar funcionario (d) Lista de Funcionarios");
                        break;

                    case "c":
                        Console.Clear();
                        CadastrarFuncionario(funcionario.Nome, funcionario.Cargo, funcionario.Salario);
                        Console.WriteLine("\nFuncionario cadastrado!\n"
                        + "\nAperte qualquer tecla para selecionar outra opção.\n");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("****************************************");
                        Console.WriteLine("*            Seja bem vindo            *");
                        Console.WriteLine("****************************************\n");
                        Console.WriteLine(
                        "(a) cadastrar Cliente (b) relatorio de clientes \n " +
                            "(c) cadastrar funcionario (d) Lista de Funcionarios");
                        break;

                    case "d":
                        Console.Clear();
                        RelatorioFuncionarios();
                        Console.WriteLine("\n Aperte qualquer tecla para selecionar outra opção.");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("****************************************");
                        Console.WriteLine("*            Seja bem vindo            *");
                        Console.WriteLine("****************************************\n");
                        Console.WriteLine(
                        "(a) cadastrar Cliente (b) relatorio de clientes \n " +
                            "(c) cadastrar funcionario (d) Lista de Funcionarios");
                        break;

                    default:
                        //Console.Write("Opção invalida tecle 1x Enter e selecione uma das opções acima ");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
