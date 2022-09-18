using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using radi_list.Models;

namespace radi_list.Data
{
    public class radi_listContext : DbContext
    {
        public radi_listContext (DbContextOptions<radi_listContext> options)
            : base(options)
        {
        }

        public DbSet<radi_list.Models.RadiologyTask> RadiologyTask { get; set; } = default!;
    }
}
