using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BiteCards.Classes.Entities
{
    public class CardImage
    {
        [Key]
        public int ImageId { get; set; }
        public String ImageUrl { get; set; }
        public virtual Card Card { get; set; }
    }
}