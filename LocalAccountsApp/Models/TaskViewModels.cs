using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LocalAccountsApp.Models
{
    public class Tasks
    {
        public int Id { get; set; }
        public bool Complete { get; set; }
        public string Text { get; set; }
        public string IdUser { get; set; }
    }

    public class TasksContext : DbContext
    {
        public TasksContext() : base("DefaultConnection")
        {

        }
        public DbSet<Tasks> Tasks { get; set; }
    }
}