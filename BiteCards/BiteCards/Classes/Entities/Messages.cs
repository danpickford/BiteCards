using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BiteCards.Classes.Entities
{
    public class Messages
    {
        public int MessageId { get; set; }
        public string MessageText { get; set; }

        public virtual Card Card { get; set; }
    }
}