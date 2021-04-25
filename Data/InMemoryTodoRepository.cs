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
                    Title = "Sports",
                    Description = "Go to gym",
                    Deadline = DateTime.Now.AddDays(2),
                },
                new Item
                {
                    ID = 2,
                    Title = "Sports",
                    Description = "Go to gym",
                    Deadline = DateTime.Now.AddDays(2),
                    Done = true
                },
                new Item
                {
                    ID = 3,
                    Title = "Sports",
                    Description = "Go to gym",
                    Deadline = DateTime.Now.AddDays(2),
                },
                new Item
                {
                    ID = 4,
                    Title = "Sports",
                    Description = "Go to gym",
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