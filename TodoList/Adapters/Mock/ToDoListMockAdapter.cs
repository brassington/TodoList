using TodoList.Data.Model;
using TodoList.Adapters.Interfaces;
using TodoList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoList.Adapters.Mock
{
    public class ToDoListMockAdapter : IToDoListAdapter
    {
        public ToDoListViewModel GetToDoListViewModel()
        {
            ToDoListViewModel model = new ToDoListViewModel();



            Task task = new Task
            {
                TaskId = 1,
                TaskName = "Straighten hair",
                TaskDescription = "Drying my hair while using an electric appliance.",
                TaskBegin = DateTime.Now,
                TaskEnd = DateTime.Now.AddDays(1),
                CategoryId = 1
            };

            task.Categories = new List<Category>();

            task.Categories.Add(new Category
             {
                 CategoryId = 1,
                 CategoryName = "Bathroom",
                 Description = "Anything that happens behind closed doors in small room with toilets and sinks."
             });

            model.Task = task;

            return model;
        }
    }
}