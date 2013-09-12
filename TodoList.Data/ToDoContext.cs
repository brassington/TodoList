using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Data.Model;

namespace TodoList.Data
{
    public class ToDoContext : DbContext
    {
        public DbSet<TodoList.Data.Model.Task> Task { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
