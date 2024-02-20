namespace To_do_List
{
    // Classe para representar uma tarefa
    public class Task
    {
        public string Description { get; set; } // Descrição da tarefa
        public bool IsCompleted { get; set; } // Indica se a tarefa foi concluída

        public Task(string description)
        {
            Description = description; // Inicializa a descrição da tarefa
            IsCompleted = false; // Inicializa a tarefa como não concluída
        }

        // Sobrescreve o método ToString() para formatar a exibição da tarefa
        public override string ToString()
        {
            return $"{(IsCompleted ? "[X]" : "[ ]")} {Description}";
        }
    }
}