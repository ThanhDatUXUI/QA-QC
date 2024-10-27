using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ApplicationDbContext : DbContext
{
    public DbSet<Order> Orders { get; set; }

    public ApplicationDbContext() : base("name=TestDatabase") { }
}
