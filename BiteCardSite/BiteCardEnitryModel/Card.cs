using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteCardEntityModel
{
    public class Card
    {
        public int CardId { get; set; }
        public string CardName { get; set; }
        public int CategoryId { get; set; }
        public int PriceId { get; set; }
        public bool IsLandScape { get; set; }
    }
}
