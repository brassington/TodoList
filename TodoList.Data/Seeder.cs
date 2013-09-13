using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Data.Model;
using System.Data.Entity.Migrations;

namespace TodoList.Data
{
    public class Seeder
    {
        public static void Seed(ToDoContext context,
            bool seedTasks = true,
            bool seedCategories = true
            )
        {
            if (seedTasks) SeedTasks(context);
            context.SaveChanges();

            if (seedCategories) SeedCategories(context);
            context.SaveChanges();
        }


        private static void SeedCategories(ToDoContext context)
        {
            context.Categories.AddOrUpdate(c => c.CategoryName,
                new Category() { CategoryId = 1, CategoryName = "Monday", Description = "The second day of the week" },
                new Category() { CategoryId = 2, CategoryName = "Tuesday", Description = "The third day of the week" }
                );
        }


        private static void SeedTasks(ToDoContext context)
        {
            context.Task.AddOrUpdate(c => c.TaskName,
                new TodoList.Data.Model.Task() { TaskId = 1, TaskName = "Blob", TaskDescription = "Lake Blob", TaskBegin = DateTime.Now, TaskEnd = DateTime.Now.AddHours(4), CategoryId = 1 },
                new TodoList.Data.Model.Task() { TaskId = 2, TaskName = "Fishing", TaskDescription = "Finding food", TaskBegin = DateTime.Now, TaskEnd = DateTime.Now.AddHours(4), CategoryId = 1 },
                new TodoList.Data.Model.Task() { TaskId = 3, TaskName = "Jumping off a bridge", TaskDescription = "Acting like a G", TaskBegin = DateTime.Now, TaskEnd = DateTime.Now.AddHours(4), CategoryId = 2 },
                new TodoList.Data.Model.Task() { TaskId = 4, TaskName = "Smoking the SQL", TaskDescription = "Working with cross joins all day long", TaskBegin = DateTime.Now, TaskEnd = DateTime.Now.AddHours(4), CategoryId = 2 },
                new TodoList.Data.Model.Task() { TaskId = 5, TaskName = "Swimming", TaskDescription = "in cess pools.", TaskBegin = DateTime.Now, TaskEnd = DateTime.Now.AddHours(4), CategoryId = 1 },
                new TodoList.Data.Model.Task() { TaskId = 6, TaskName = "Programming", TaskDescription = "before, during, and after... everything.", TaskBegin = DateTime.Now, TaskEnd = DateTime.Now.AddHours(4), CategoryId = 2 },
                new TodoList.Data.Model.Task() { TaskId = 7, TaskName = "Feeding kids in Africa", TaskDescription = "Being superman, or a tax exempt non-profit", TaskBegin = DateTime.Now, TaskEnd = DateTime.Now.AddHours(4), CategoryId = 1 }
                );
        }


    }
}