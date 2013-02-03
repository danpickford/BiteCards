using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BiteCardEntityModel;

namespace BiteCardSite.Models
{
    public class CardFocus
    {
        public int cardId { get; set; }
        public string CardName { get; set; }
        public bool isLandScape { get; set; }

        public new List<Image> CardImages;
        public new Price CardPrices;
        public new List<Message> CardMessages;
        public new Order CardOrder;
    }
}