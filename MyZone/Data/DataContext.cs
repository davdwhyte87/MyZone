using System;
using Microsoft.EntityFrameworkCore;

namespace MyZone.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
