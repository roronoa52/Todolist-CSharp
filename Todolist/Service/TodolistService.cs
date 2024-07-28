using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todolist.Service
{
    public interface TodolistService
    {
        void showTodolist();

        void addTodolist(string todo);

        void removeTodolist(string todo);
    }
}
