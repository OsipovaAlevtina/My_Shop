using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Data.Models
{
    public class Category
    {
        public int Id { set; get; }

        public string CategoryName { set; get; }

        public string Desc { set; get; }

        public List<Lamp> Lamps { set; get; }

    }
}
