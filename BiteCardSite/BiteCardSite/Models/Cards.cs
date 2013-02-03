using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BiteCardEntityModel;
namespace BiteCardSite.Models
{
    public class Cards
    {
        public List<Card> PageCards;
    }

    public class Card
    {
        public int cardId { get; set; }
        public string CardName { get; set; }
        public string CardFrontImage { get; set; }
    }
}