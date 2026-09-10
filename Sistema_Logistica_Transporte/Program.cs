using System;
using System.Collections.Generic;

namespace Sistema_Logistica_Transporte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<FuncionarioTransporte> funcionarios = new List<FuncionarioTransporte>();
            bool executando = true;

            while (executando)
            {
                Console.Clear();
                Console.WriteLine("=============================================");
                Console.WriteLine("       SISTEMA DE LOGÍSTICA E TRANSPORTE     ");
                Console.WriteLine("=============================================");
                Console.WriteLine("1 - Cadastrar motorista de carreta");
                Console.WriteLine("2 - Cadastrar entregador de moto");
                Console.WriteLine("3 - Listar todos os funcionários");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("=============================================");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CadastrarMotoristaCarreta(funcionarios);
                        break;
                    case "2":
                        CadastrarEntregadorMoto(funcionarios);
                        break;
                    case "3":
                        ListarFuncionarios(funcionarios);
                        break;
                    case "0":
                        executando = false;
                        Console.WriteLine("\nEncerrando o sistema...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida! Pressione qualquer tecla para tentar novamente.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void CadastrarMotoristaCarreta(List<FuncionarioTransporte> funcionarios)
        {
            Console.Clear();
            Console.WriteLine("--- CADASTRO DE MOTORISTA DE CARRETA ---");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Registro: ");
            string registro = Console.ReadLine();

            Console.Write("Categoria da CNH: ");
            string categoriaCNH = Console.ReadLine();

            Console.Write("Placa do Veículo: ");
            string placa = Console.ReadLine();

            double capacidade;
            Console.Write("Capacidade de carga (em toneladas): ");
            while (!double.TryParse(Console.ReadLine(), out capacidade) || capacidade <= 0)
            {
                Console.Write("Valor inválido. Digite um número positivo para a capacidade (toneladas): ");
            }

            MotoristaCarreta motorista = new MotoristaCarreta(nome, registro, categoriaCNH, placa, capacidade);
            funcionarios.Add(motorista);

            Console.WriteLine("\nMotorista de carreta cadastrado com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        static void CadastrarEntregadorMoto(List<FuncionarioTransporte> funcionarios)
        {
            Console.Clear();
            Console.WriteLine("--- CADASTRO DE ENTREGADOR DE MOTO ---");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Registro: ");
            string registro = Console.ReadLine();

            Console.Write("Categoria da CNH: ");
            string categoriaCNH = Console.ReadLine();

            Console.Write("Placa da moto: ");
            string placa = Console.ReadLine();

            EntregadorMoto entregador = new EntregadorMoto(nome, registro, categoriaCNH, placa);
            funcionarios.Add(entregador);

            Console.WriteLine("\nEntregador de Moto cadastrado com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        static void ListarFuncionarios(List<FuncionarioTransporte> funcionarios)
        {
            Console.Clear();
            Console.WriteLine("--- RELATÓRIO DE FUNCIONÁRIOS CADASTRADOS ---\n");

            if (funcionarios.Count == 0)
            {
                Console.WriteLine("Nenhum funcionário cadastrado até o momento.");
            }
            else
            {
                foreach (var funcionario in funcionarios)
                {
                    funcionario.MostrarDetalhes();
                }
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
}