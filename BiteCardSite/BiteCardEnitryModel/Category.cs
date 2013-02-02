using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteCardEntityModel
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public String CategoryName { get; set; }
    }
}
