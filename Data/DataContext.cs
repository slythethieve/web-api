using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace web_api.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Character> Characters => Set<Character>();
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            
        }
    }
}