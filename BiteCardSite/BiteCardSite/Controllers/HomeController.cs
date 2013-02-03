using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BiteCardSite.Models;
using BiteCardEntityModel;
using Card = BiteCardSite.Models.Card;

namespace BiteCardSite.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var currentModel = new IndexPage();
            using (var categories = new BiteCardDatabaseContexts())
            {
                ViewBag.Categories = categories.CardCategories.Select(c => c.CategoryName).ToList();
            }
            ViewBag.promoURL = "http://www.danpickford.com/bitecard/Content/Images/hp-slider-valentines-personalised-cards.png";
            return View("Index", currentModel);
        }

        public ActionResult Valentines()
        {

            var currentModel = new Cards();
            currentModel.PageCards = new List<Card>();
            using (var dbCards = new BiteCardDatabaseContexts())
            {
                ViewBag.Categories = dbCards.CardCategories.Select(c => c.CategoryName).ToList();
                foreach (var card in dbCards.Cards.Where(c => c.CategoryId == 3))
                {
                    var thisCard = new BiteCardSite.Models.Card();
                    thisCard.cardId = card.CardId;
                    thisCard.CardName = card.CardName;
                    thisCard.CardFrontImage = dbCards.CardImages.FirstOrDefault(x => x.Card.CardId == card.CardId).ImageUrl;
                    currentModel.PageCards.Add(thisCard);
                }

            }
            return View("Valentines", currentModel);
        }

        public ActionResult Birthday()
        {
            var currentModel = new Cards();
            currentModel.PageCards = new List<Card>();
            using (var dbCards = new BiteCardDatabaseContexts())
            {
                ViewBag.Categories = dbCards.CardCategories.Select(c => c.CategoryName).ToList();
                foreach (var card in dbCards.Cards.Where(c => c.CategoryId == 1))
                {
                    var thisCard = new BiteCardSite.Models.Card();
                    thisCard.cardId = card.CardId;
                    thisCard.CardName = card.CardName;
                    thisCard.CardFrontImage = dbCards.CardImages.FirstOrDefault(x => x.Card.CardId == card.CardId).ImageUrl;
                    currentModel.PageCards.Add(thisCard);
                }

            }
            return View("Birthday", currentModel);
        }
        public ActionResult CardFocus(int cardId)
        {
            var currentModel = new CardFocus();
            using (var WholeCard = new BiteCardDatabaseContexts())
            {
                ViewBag.Categories = WholeCard.CardCategories.Select(c => c.CategoryName).ToList();
                currentModel.cardId = WholeCard.Cards.FirstOrDefault(c => c.CardId == cardId).CardId;
                currentModel.CardName = WholeCard.Cards.FirstOrDefault(c => c.CardId == cardId).CardName;
                currentModel.isLandScape = WholeCard.Cards.FirstOrDefault(c => c.CardId == cardId).IsLandScape;
                currentModel.CardImages = WholeCard.CardImages.Where(i => i.Card.CardId == cardId).ToList();
                currentModel.CardOrder = new Order();
                currentModel.CardPrices =
                    WholeCard.Prices.FirstOrDefault(p => p.PriceId == cardId);
                currentModel.CardMessages = new List<Message>();
            }
            return View("CardFocus", currentModel);
        }

    }
}
