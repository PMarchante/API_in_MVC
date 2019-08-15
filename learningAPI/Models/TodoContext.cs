using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace learningAPI.Models
{
    public class TodoContext:DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> dumb)
            : base(dumb) { }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
