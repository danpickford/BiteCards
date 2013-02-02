using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteCardEntityModel
{
    public class BiteCardDatabaseContexts : DbContext
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<Category> CardCategories { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Image> CardImages { get; set; }

        public DbSet<Message> CardMessages { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
