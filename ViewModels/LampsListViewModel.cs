using MyShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.ViewModels
{
    public class LampsListViewModel
    {
        public IEnumerable<Lamp> AllLamps { get; set; }

        public string LampCategory { get; set; }
    }
}
