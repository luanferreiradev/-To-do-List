using System;
using System.Collections.Generic;

namespace To_do_List
{
    // Classe principal do programa
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>(); // Lista para armazenar as tarefas

            while (true)
            {
                // Exibe o menu de opções
                Console.WriteLine("=== To-Do List ===");
                Console.WriteLine("1. Adicionar Tarefa");
                Console.WriteLine("2. Visualizar Lista de Tarefas");
                Console.WriteLine("3. Marcar Tarefa como Concluída");
                Console.WriteLine("4. Sair");
                Console.WriteLine("==================");
                Console.Write("Escolha uma opção: ");

                // Lê a opção escolhida pelo usuário
                int option;
                if (int.TryParse(Console.ReadLine(), out option))
                {
                    switch (option)
                    {
                        case 1:
                            // Adiciona uma nova tarefa à lista
                            Console.Write("Digite a descrição da tarefa: ");
                            string description = Console.ReadLine();
                            tasks.Add(new Task(description));
                            Console.WriteLine("Tarefa adicionada com sucesso!");
                            break;
                        case 2:
                            // Exibe a lista de tarefas
                            Console.WriteLine("=== Lista de Tarefas ===");
                            for (int i = 0; i < tasks.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {tasks[i]}");
                            }
                            Console.WriteLine("========================");
                            break;
                        case 3:
                            // Marca uma tarefa como concluída
                            Console.Write("Digite o número da tarefa concluída: ");
                            if (int.TryParse(Console.ReadLine(), out int taskIndex) && taskIndex > 0 && taskIndex <= tasks.Count)
                            {
                                tasks[taskIndex - 1].IsCompleted = true;
                                Console.WriteLine("Tarefa marcada como concluída!");
                            }
                            else
                            {
                                Console.WriteLine("Número de tarefa inválido!");
                            }
                            break;
                        case 4:
                            // Sai do programa
                            Console.WriteLine("Saindo do programa...");
                            return;
                        default:
                            // Exibe mensagem de opção inválida
                            Console.WriteLine("Opção inválida! Tente novamente.");
                            break;
                    }
                }
                else
                {
                    // Exibe mensagem de opção inválida
                    Console.WriteLine("Opção inválida! Tente novamente.");
                }

                Console.WriteLine(); // Adiciona uma linha em branco para melhorar a legibilidade
            }
        }
    }
}
