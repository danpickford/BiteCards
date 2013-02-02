namespace BiteCardEntityModel.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BiteCardEntityModel.BiteCardDatabaseContexts>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BiteCardEntityModel.BiteCardDatabaseContexts context)
        {
            //  This method will be called after migrating to the latest version.
            context.CardCategories.AddOrUpdate(c => c.CategoryId,
                new Category {CategoryId = 1, CategoryName = "Birthday"},
                new Category { CategoryId = 2, CategoryName = "Wedding" },
                new Category { CategoryId = 3, CategoryName = "Anniversary" },
                new Category { CategoryId = 4, CategoryName = "Congratulations" },
                new Category { CategoryId = 5, CategoryName = "Thank You" },
                new Category { CategoryId = 6, CategoryName = "New Job" });
        }
    }
}
