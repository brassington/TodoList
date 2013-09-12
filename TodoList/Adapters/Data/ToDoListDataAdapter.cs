using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TodoList.Adapters.Interfaces;
using TodoList.Data;
using TodoList.Data.Model;
using TodoList.Models;

namespace TodoList.Adapters.Data
{
    public class ToDoListDataAdapter : IToDoListAdapter
    {

        public ToDoListViewModel GetToDoListViewModel()
        {
            ToDoListViewModel model = null;
            model = new ToDoListViewModel();

            ToDoContext db = new ToDoContext();

            model.Task = db.Task
                .Include("Category")
                .FirstOrDefault();

            return model;
        }
    }
}