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
                new Category { CategoryId = 1, CategoryName = "Birthday" },
                new Category { CategoryId = 2, CategoryName = "Wedding" },
                new Category { CategoryId = 3, CategoryName = "Valentines" },
                new Category { CategoryId = 4, CategoryName = "Congratulations" },
                new Category { CategoryId = 5, CategoryName = "Thank You" },
                new Category { CategoryId = 6, CategoryName = "New Job" });

            var card1 = new Card { CardId = 1, CategoryId = 3, CardName = "V Day", IsLandScape = false, PriceId = 1 };

            context.Cards.AddOrUpdate(c => c.CardId, card1);
            context.CardImages.AddOrUpdate(c => c.ImageId,
                                           new Image
                                               {
                                                   Card = card1,
                                                   ImageId = 1,
                                                   ImageUrl = @"http://www.danpickford.com/bitecard/Content/Images/love1.jpg"
                                               });

            card1 = new Card { CardId = 2, CategoryId = 1, CardName = "Birthday", IsLandScape = false, PriceId = 2 };

            context.Cards.AddOrUpdate(c => c.CardId, card1);
            context.CardImages.AddOrUpdate(c => c.ImageId,
                               new Image { Card = card1, ImageId = 2, ImageUrl = @"http://www.danpickford.com/bitecard/Content/Images/birthday.jpg" });


            context.Prices.AddOrUpdate(p => p.PriceId,
                new Price { PriceId = 1, Total = 1.99 },
                new Price { PriceId = 1, Total = 2.99 });

        }
    }
}
