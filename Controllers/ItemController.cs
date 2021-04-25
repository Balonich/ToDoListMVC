using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoListMVC.Data;
using ToDoListMVC.Models;

namespace ToDoListMVC.Controllers
{
    public class ItemController : Controller
    {
        private readonly ITodoRepository todoRepository;

        [BindProperty]
        public Item Item { get; set; }

        public ItemController(ITodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        [HttpGet]
        public IActionResult Create(int? itemId)
        {
            if (itemId.HasValue)
            {
                Item = todoRepository.GetItemById(itemId.Value);
            }
            else
            {
                Item = new Item();
            }

            if (Item == null)
            {
                return RedirectToAction("NotFound");
            }
            return View(Item);
        }

        [HttpPost]
        public IActionResult Create(Item newItem)
        {
            if (ModelState.IsValid)
            {
                todoRepository.Add(newItem);
                return RedirectToAction("Index", "Home");
            }
            return View(newItem);
        }

        [HttpGet]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(int itemId)
        {
            Item = todoRepository.GetItemById(itemId);
            if (Item == null)
            {
                return RedirectToAction("NotFound");
            }
            return View(Item);
        }

        [HttpPost]
        public IActionResult Delete(int itemId)
        {
            var removedItem = todoRepository.Remove(itemId);

            if (removedItem == null)
            {
                return RedirectToAction("NotFound");
            }
            // TODO:
            // add message
            ViewBag.Message = "Item was successfully removed!";
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Done(int itemId)
        {
            var item = todoRepository.GetItemById(itemId);
            if (item != null)
            {
                if (item.Done)
                {
                    item.Done = false;
                }
                else
                {
                    item.Done = true;
                }
            }
            return RedirectToAction("Index", "Home");
        }
    }
}