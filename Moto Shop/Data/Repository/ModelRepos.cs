using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moto_Shop.Data.Interfaces;
using Moto_Shop.Data.Models;

namespace Moto_Shop.Data.Repository
{
    public class ModelRepos : IMotoModel
    {
        private readonly MotoDBContext motoDB;
        public ModelRepos(MotoDBContext motoDBContext)
        {
            this.motoDB = motoDBContext;
        }
        public IEnumerable<ModelMotorcycle> AllModels => motoDB.MotoModels;
    }
}
