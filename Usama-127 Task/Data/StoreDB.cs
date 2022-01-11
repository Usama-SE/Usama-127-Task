using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Usama_127_Task.Models;

namespace Usama_127_Task.Data
{
    public class StoreDB : IdentityDbContext
    {
        public StoreDB(DbContextOptions<StoreDB> options)
            : base(options)
        {
        }
        public DbSet<OrderModel> Orders { get; set; }
    }
}
