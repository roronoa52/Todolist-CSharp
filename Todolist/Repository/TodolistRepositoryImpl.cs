using Dapper;
using Npgsql;
using Todolist.Entity;

namespace Todolist.Repository
{
    public class TodolistRepositoryImpl : TodolistRepository
    {
        private static List<Todo> todos = new List<Todo>();

        NpgsqlConnection connection;

        public TodolistRepositoryImpl(string localhost, string database, string username, string password)
        {
            var connectionURL = $"Host={localhost};Database={database};Username={username};Password={password}";
            this.connection = new NpgsqlConnection(connectionURL);
        }

        public List<Todo> getAll()
        {
            var sql = "SELECT id, todo FROM todo";

            return connection.Query<Todo>(sql).ToList();
        }

        public void remove(string todo)
        {
            var sql = "DELETE FROM todo WHERE todo = @todo";
            connection.Execute(sql, new { todo });
        }

        public void save(Todo todo)
        {
            var sql = "INSERT INTO todo (todo) VALUES( @todo )";
            connection.Execute(sql, new { todo.todo });
        }
    }
}