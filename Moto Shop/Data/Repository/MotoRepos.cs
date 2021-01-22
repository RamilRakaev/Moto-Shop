using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moto_Shop.Data.Interfaces;
using Moto_Shop.Data.Models;

namespace Moto_Shop.Data.Repository
{
    public class MotoRepos : IAllProducts
    {
        private readonly MotoDBContext motoDB;
        public MotoRepos(MotoDBContext motoDBContext)
        {
            this.motoDB = motoDBContext;
        }
        public IEnumerable<Product> Products => motoDB.Moto.Include(c=>c.Model);

        public IEnumerable<Product> GetFavoriteMoto => motoDB.Moto.Where(m => m.IsFavorite).Include(m => m.Model);

        public Product GetMoto(int MotoId) => motoDB.Moto.FirstOrDefault(m => m.Id == MotoId);
       
    }
}
