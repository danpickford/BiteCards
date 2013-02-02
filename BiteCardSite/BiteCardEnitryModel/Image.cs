﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteCardEntityModel
{
    public class Image
    {
        public int ImageId { get; set; }
        public String ImageUrl { get; set; }
        public virtual Card Card { get; set; }
    }
}
