using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Data.Models
{
    public class Lamp
    {
        public int Id { set; get; }

        public string Name { set; get; }

        public string ShortDesc { set; get; }

        public string LongDesc { set; get; }

        public string Img { set; get; }

        public ushort Price { set; get; }

        public bool IfFavourite { set; get; }

        public bool Available { set; get; }

        public int CategoryID { set; get; }

        public virtual Category Category { set; get; }
    }
}
