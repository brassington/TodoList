﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TodoList.Data.Model;

namespace TodoList.Models
{
    public class ToDoListViewModel
    {
        public int TaskId { get; set; }
        public Task Task { get; set; }
    }
}
