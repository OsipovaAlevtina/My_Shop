using MyShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Data.Interfaces
{
    public interface IAllLamps
    {
        IEnumerable<Lamp> Lamps { get; }
        IEnumerable<Lamp> GetFavLamp { get; }
        Lamp GetObjectLamp(int lampId);
    }
}
