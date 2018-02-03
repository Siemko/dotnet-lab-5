using System.Data.Entity;
using Lab5.Core.Entities;

namespace Lab5.Core
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}