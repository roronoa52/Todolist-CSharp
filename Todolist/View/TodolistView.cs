using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todolist.Service;

namespace Todolist.View
{
    public class TodolistView
    {
        private TodolistService todolistService;

        public TodolistView(TodolistService todolistService)
        {
            this.todolistService = todolistService;
        }

        public void ViewTodolist()
        {
            while (true)
            {
                todolistService.showTodolist();

                Console.WriteLine("1. Membuat Todolist");
                Console.WriteLine("2. Menghapus Todolist");
                Console.WriteLine("x. Keluar aplikasi");
                Console.Write("Masukan pilihan: ");
                var choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Masukan Todolist: ");
                    var todo = Console.ReadLine();

                    todolistService.addTodolist(todo);
                } else if (choice == "2")
                {
                    Console.Write("Masukan todolist: ");
                    var todo = Console.ReadLine();

                    todolistService.removeTodolist(todo);
                }
                else
                {
                    break;
                }

            }
        }
    }
}
