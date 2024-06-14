using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InkCraft.Models;

namespace InkCraft.Data
{
    public class InkCraftContext : DbContext
    {
        public InkCraftContext (DbContextOptions<InkCraftContext> options)
            : base(options)
        {
        }

        public DbSet<InkCraft.Models.Paper> Paper { get; set; } = default!;
    }
}
