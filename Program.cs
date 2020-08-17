using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace VendasConsole
{

    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            string Nome;
            string Cpf;

            bool flag = false;

            List<Cliente> clientes = new List<Cliente>();

            do
            {
                Console.Clear();
                Console.WriteLine("---- APLICAÇÃO DE VENDAS ----\n");
                Console.WriteLine("1 - Cadastrar cliente");
                Console.WriteLine("2 - Listar clientes");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("\nDigite a opção desejada: ");

                opcao = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (opcao)
                {
                    case 1:

                        Console.Clear();
                        Console.WriteLine("---- CADASTRAR CLIENTE ----\n");

                        Console.WriteLine("Digite o Nome do cliente:");
                        Nome = Console.ReadLine();

                        Console.WriteLine("Digite o CPF do cliente:");
                        Cpf = Console.ReadLine();

                        if (clientes.Count > 0)
                        {
                            foreach (Cliente cli in clientes)
                            {
                                if (Cpf.Equals(cli.getCpf()))
                                {
                                    flag = false;
                                    Console.Clear();
                                    Console.WriteLine("###### CPF já cadastrado, informe outro.######\n");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    flag = true;
                                }
                            }
                        }
                        else
                        {
                            flag = true;
                        }

                        if (flag)
                        {
                            clientes.Add(new Cliente(Nome, Cpf));
                            Console.Clear();
                            Console.WriteLine("###### Cliente cadastrado com sucesso! ######\n");
                        }

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("---- LISTAR CLIENTES ----\n");

                        foreach (Cliente cli in clientes)
                            Console.WriteLine(cli.ToString());

                        break;
                    case 0:
                        Console.WriteLine("Saindo...\n");
                        break;
                    default:
                        Console.WriteLine("---- OPÇÃO INVÁLIDA! ----\n");
                        break;
                }

                Console.WriteLine("\n Pressione uma tecla para continuar...");
                Console.ReadKey();

            } while (opcao != 0);
        }

        private static bool ValidarCpf(string cpf)
        {
            return false;
        }
    }
}
