using System.Collections.Generic;
using ToDoListMVC.Models;

namespace ToDoListMVC.Data
{
    public interface ITodoRepository
    {
        IEnumerable<Item> AllItems { get; }
        Item GetItemById(int id);
        Item Add(Item newItem);
        Item Update(Item updatedItem);
        Item Remove(int id);
    }
}