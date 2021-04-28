using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoListMVC.Data;
using ToDoListMVC.Models;

namespace ToDoListMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITodoRepository todoRepository;

        public HomeController(ITodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        public IActionResult Index()
        {
            ViewBag.ShowControlls = true;
            var items = todoRepository.AllItems.OrderBy(i => i.Deadline);
            return View(items);
        }

        public IActionResult Information()
        {
            return View();
        }
    }
}