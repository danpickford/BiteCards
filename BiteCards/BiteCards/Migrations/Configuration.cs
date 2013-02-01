using BiteCards.Classes.Entities;

namespace BiteCards.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BiteCards.Classes.Context.BrowsingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BiteCards.Classes.Context.BrowsingContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.CardCategories.AddOrUpdate(c => c.CategoryId,
               new Category { CategoryName = "Birthday" },
                new Category { CategoryName = "Valentines Day" },
                new Category { CategoryName = "Get Well Soon" });

            context.Cards.AddOrUpdate(c => c.CardId,
           new Card { CardName = "Funny Birthday", CategoryId = 1, IsLandScape = false, PriceId = 1 },
           new Card { CardName = "Funny Valentines", CategoryId = 2, IsLandScape = false, PriceId = 2 },
           new Card { CardName = "Funny Get Well Soon", CategoryId = 3, IsLandScape = true, PriceId = 3 });

            

            context.CardImages.AddOrUpdate(c => c.ImageId,
                new CardImage {Card = context.Cards.First(x => x.CardId == 1), ImageUrl = "front1.jpg"},
                new CardImage { Card = context.Cards.First(x => x.CardId == 1), ImageUrl = "front2.jpg" },
                new CardImage { Card = context.Cards.First(x => x.CardId == 2), ImageUrl = "front2.jpg" },
                new CardImage { Card = context.Cards.First(x => x.CardId == 2), ImageUrl = "back2.jpg" },
                new CardImage { Card = context.Cards.First(x => x.CardId == 3), ImageUrl = "front3.jpg" },
                new CardImage { Card = context.Cards.First(x => x.CardId == 3), ImageUrl = "front4.jpg" });
        }
    }
}
