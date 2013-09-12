using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoList.Adapters.Interfaces;
using TodoList.Adapters.Mock;
using TodoList.Data.Model;
using TodoList.Models;

namespace TodoList.Controllers
{
    public class HomeController : Controller
    {
        private IToDoListAdapter _adapter;

        //public HomeController(IToDoListAdapter adapter)
        //{
        //    _adapter = adapter;
        //}

        public HomeController()
        {
            _adapter = new ToDoListMockAdapter();
        }

        public ActionResult Index()
        {
            ToDoListViewModel model = _adapter.GetToDoListViewModel();
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
