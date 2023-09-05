using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppAssisgn16.Models;

namespace WebAppAssisgn16.Data
{
    public class WebAppAssisgn16DbContext : DbContext
    {
        public WebAppAssisgn16DbContext (DbContextOptions<WebAppAssisgn16DbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppAssisgn16.Models.Task> Task { get; set; } = default!;
    }
}
