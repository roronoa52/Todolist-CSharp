using Todolist.Repository;
using Todolist.Service;
using Todolist.View;

namespace Todolist
{
    public class Program
    {
        static void Main(string[] args)
        {

            TodolistRepositoryImpl todolistRepository = new TodolistRepositoryImpl("localhost", "todolist_c_sharp", "postgres", "12345678");
            TodolistServiceImpl todolistServiceImpl = new TodolistServiceImpl(todolistRepository);
             TodolistView todolistView = new TodolistView(todolistServiceImpl);

             todolistView.ViewTodolist();
        }
    }
}