using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BiteCards.Classes.Entities;

namespace BiteCards.Classes.Context
{
    public class BrowsingContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<Category> CardCategories { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<CardImage> CardImages { get; set; }

    }
}