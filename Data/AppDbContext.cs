using System;
using Microsoft.EntityFrameworkCore;
using ToDoListMVC.Models;

namespace ToDoListMVC.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Item>().HasData(
                new Item
                {
                    ID = 1,
                    Title = "DB",
                    Description = "Add database with entity framework",
                    Deadline = DateTime.Now.AddDays(2),
                });
            modelBuilder.Entity<Item>().HasData(
                new Item
                {
                    ID = 2,
                    Title = "Messages",
                    Description = "Add messages on index page to inform about actions (create/edit/delete)",
                    Deadline = DateTime.Now.AddDays(2),
                    Done = true
                });
            modelBuilder.Entity<Item>().HasData(
                new Item
                {
                    ID = 3,
                    Title = "Deadline",
                    Description = "Crossout deadline when expired",
                    Deadline = DateTime.Now.AddDays(2),
                });
            modelBuilder.Entity<Item>().HasData(
                new Item
                {
                    ID = 4,
                    Title = "Controls",
                    Description = "Do not show controls on the delete page",
                    Deadline = DateTime.Now.AddDays(2),
                });
            modelBuilder.Entity<Item>().HasData(
                new Item
                {
                    ID = 5,
                    Title = "Filter",
                    Description = "Two containers with completed and not completed todos",
                    Deadline = DateTime.Now.AddDays(2),
                });
            modelBuilder.Entity<Item>().HasData(
                new Item
                {
                    ID = 6,
                    Title = "Validation",
                    Description = "Model validation on edit/create page",
                    Deadline = DateTime.Now.AddDays(2),
                });
            modelBuilder.Entity<Item>().HasData(
                new Item
                {
                    ID = 7,
                    Title = "Information",
                    Description = "Add information page, describe why this project was created",
                    Deadline = DateTime.Now.AddDays(2),
                });
            modelBuilder.Entity<Item>().HasData(
                new Item
                {
                    ID = 8,
                    Title = "Scrolling",
                    Description = "Scrolling is not working (not showing) when there are more than 9 items",
                    Deadline = DateTime.Now.AddDays(2),
                });
        }
    }
}