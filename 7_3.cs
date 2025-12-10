using System;
using System.Collections.Generic;

class TodoManager
{
    public List<string> tasks = new List<string>();

    public void AddTask(string taskName)
    {
        tasks.Add(taskName);
        Console.WriteLine("Dodano zadanie: " + taskName);
    }

    public void RemoveTask(int index)
    {
        if (index >= 0 && index < tasks.Count)
        {
            Console.WriteLine("Usunięto: " + tasks[index]);
            tasks.RemoveAt(index);
        }
    }

    public void ListTasks()
    {
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + tasks[i]);
        }
    }

    public void CompleteTask(int index)
    {
        if (index >= 0 && index < tasks.Count)
        {
            Console.WriteLine("Zakończono: " + tasks[index]);
            tasks[index] = tasks[index] + " (done)";
        }
    }
}

class Program
{
    static void Main()
    {
        TodoManager todo = new TodoManager();

        todo.AddTask("Zrobić zaległości");
        todo.AddTask("Pójść na lekcje");
        todo.AddTask("Zgarnąć uwagę");

        todo.CompleteTask(1);
        todo.RemoveTask(0);

        todo.ListTasks();
    }
}
