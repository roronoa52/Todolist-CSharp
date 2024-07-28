using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todolist.Entity;

namespace Todolist.Repository
{
    public interface TodolistRepository
    {
        List<Todo> getAll();

        void save(Todo todo);

        void remove(string todo);

    }
}
