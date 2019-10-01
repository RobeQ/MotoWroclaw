using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MotoWroclaw.Data.Accounts;

namespace MotoWroclaw.Data
{
    public class MotoWroclawContext : DbContext
    {
        public MotoWroclawContext(DbContextOptions<MotoWroclawContext> options) : base(options)
        {            
        }

        public DbSet<User> Users { get; set; }
    }
}
