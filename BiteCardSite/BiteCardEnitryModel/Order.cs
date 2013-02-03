using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteCardEntityModel
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CardId { get; set; }
        public float TotalBilled { get; set; }
        public virtual List<Message> Message { get; set; }
    }
}
