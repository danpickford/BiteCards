using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BiteCards.Classes.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CardId { get; set; }
        public float TotalBilled { get; set; }

        public virtual List<Card> Card { get; set; }
    }
}