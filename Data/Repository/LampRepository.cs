using Microsoft.EntityFrameworkCore;
using MyShop.Data.Interfaces;
using MyShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Data.Repository
{
    public class LampRepository : IAllLamps
    {
        private readonly AppDBContent appDBContent;

        public LampRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Lamp> Lamps => appDBContent.Lamp.Include(c => c.Category);

        public IEnumerable<Lamp> GetFavLamp => appDBContent.Lamp.Where(p => p.IfFavourite).Include(c => c.Category);

        public Lamp GetObjectLamp(int lampId) => appDBContent.Lamp.FirstOrDefault(p => p.Id == lampId);
    }
}
