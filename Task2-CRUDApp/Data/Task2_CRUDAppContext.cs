using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task2_CRUDApp.Models;

namespace Task2_CRUDApp.Data
{
    public class Task2_CRUDAppContext : DbContext
    {
        public Task2_CRUDAppContext (DbContextOptions<Task2_CRUDAppContext> options)
            : base(options)
        {
        }

        public DbSet<Task2_CRUDApp.Models.Product> Product { get; set; } = default!;
    }
}
