using Npgsql;
using Todolist.Entity;
using Todolist.Repository;

namespace Todolist.Service
{
    public class TodolistServiceImpl : TodolistService
    {

        private TodolistRepository repository;

        public TodolistServiceImpl(TodolistRepository repository)
        {
            this.repository = repository;
        }

        public void addTodolist(string todolist)
        {
            Todo todo = new Todo();
            todo.todo = todolist;
            repository.save(todo);
        }

        public void removeTodolist(string todo)
        {
            repository.remove(todo);
        }

        public void showTodolist()
        {
            var todos = repository.getAll();

            Console.WriteLine("==========================================================");
            Console.WriteLine();


            todos.Select((todo, index) => new { Index = index, Todo = todo })
                 .ToList()
                 .ForEach(item => Console.WriteLine($"{item.Index + 1}. {item.Todo.todo}"));

            Console.WriteLine();
            Console.WriteLine("==========================================================");
        }
    }
}