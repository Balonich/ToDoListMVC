using System;
using System.Collections.Generic;
using System.Linq;
using ToDoListMVC.Models;

namespace ToDoListMVC.Data
{
    public class InMemoryTodoRepository : ITodoRepository
    {
        private List<Item> items;

        public InMemoryTodoRepository()
        {
            items = new List<Item>()
            {
                new Item
                {
                    ID = 1,
                    Title = "DB",
                    Description = "Add database with entity framework",
                    Deadline = DateTime.Now.AddDays(2),
                },
                new Item
                {
                    ID = 2,
                    Title = "Messages",
                    Description = "Add messages on index page to inform about actions (create/edit/delete)",
                    Deadline = DateTime.Now.AddDays(2),
                    Done = true
                },
                new Item
                {
                    ID = 3,
                    Title = "Deadline",
                    Description = "Crossout deadline when expired",
                    Deadline = DateTime.Now.AddDays(2),
                },
                new Item
                {
                    ID = 4,
                    Title = "Controls",
                    Description = "Do not show controls on the delete page",
                    Deadline = DateTime.Now.AddDays(2),
                },
                new Item
                {
                    ID = 5,
                    Title = "Filter",
                    Description = "Two containers with completed and not completed todos",
                    Deadline = DateTime.Now.AddDays(2),
                },
                new Item
                {
                    ID = 6,
                    Title = "Validation",
                    Description = "Model validation on edit/create page",
                    Deadline = DateTime.Now.AddDays(2),
                },
                new Item
                {
                    ID = 7,
                    Title = "Information",
                    Description = "Add information page, describe why this project was created",
                    Deadline = DateTime.Now.AddDays(2),
                },
                new Item
                {
                    ID = 8,
                    Title = "Scrolling",
                    Description = "Scrolling is not working (not showing) when there are more than 9 items",
                    Deadline = DateTime.Now.AddDays(2),
                }
            };
        }

        public IEnumerable<Item> AllItems => items;

        public Item Add(Item newItem)
        {
            newItem.ID = items.Max(i => i.ID) + 1;
            items.Add(newItem);
            return newItem;
        }

        public Item Update(Item updatedItem)
        {
            var item = items.SingleOrDefault(r => r.ID == updatedItem.ID);
            if (item != null)
            {
                item.Title = updatedItem.Title;
                item.Description = updatedItem.Description;
                item.Deadline = updatedItem.Deadline;
                item.Done = updatedItem.Done;
            }
            return item;
        }

        public Item GetItemById(int id)
        {
            return items.FirstOrDefault(i => i.ID == id);
        }

        public Item Remove(int id)
        {
            var item = GetItemById(id);
            if (item != null)
            {
                items.Remove(item);
            }
            return item;
        }
    }
}