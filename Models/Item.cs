using System;

namespace ToDoListMVC.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; } = DateTime.Now;
        public bool Done { get; set; }
    }
}