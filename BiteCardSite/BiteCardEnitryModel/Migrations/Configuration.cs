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
                new Category { CategoryId = 3, CategoryName = "Valentines" },
                new Category { CategoryId = 4, CategoryName = "Congratulations" },
                new Category { CategoryId = 5, CategoryName = "Thank You" },
                new Category { CategoryId = 6, CategoryName = "New Job" });

            context.Cards.AddOrUpdate(c => c.CardId,
                new Card {CardId = 1, CategoryId = 3, CardName = "V Day", IsLandScape = false, PriceId = 1},
                new Card { CardId = 2, CategoryId = 1, CardName = "Birthday", IsLandScape = false, PriceId = 2 });
           
            context.Prices.AddOrUpdate(p => p.PriceId,
                new Price {PriceId = 1, Total = 1.99},
                new Price { PriceId = 1, Total = 2.99 });

            context.CardImages.AddOrUpdate(c => c.ImageId,
                new Image{Card = context.Cards.First(c => c.CardId == 1), ImageId = 1, ImageUrl = @"../../Content/Images/love1.jpg"},
                new Image { Card = context.Cards.First(c => c.CardId == 2), ImageId = 2, ImageUrl = @"../../Content/Images/birthday.jpg"});
        }
    }
}
