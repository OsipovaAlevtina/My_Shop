using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Data.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int LampId { get; set; }

        public uint Price { get; set; }

        public virtual Lamp lamp { get; set; }

        public virtual Order order { get; set; }
    }
}
