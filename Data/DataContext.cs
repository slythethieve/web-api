using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace web_api.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Character> Characters => Set<Character>();

        public DbSet<User> Users => Set<User>();

        public DbSet<Weapon> Weapons => Set<Weapon>();
        
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            
        }
    }
}