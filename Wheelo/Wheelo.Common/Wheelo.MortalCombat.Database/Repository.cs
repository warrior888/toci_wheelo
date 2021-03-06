using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wheelo.MortalCombat.Database.Interfaces;

namespace Wheelo.MortalCombat.Database
{
    public abstract class Repository<TModel> : IRepository<TModel>
    {
        public abstract bool Delete(TModel model);
        public abstract TModel Insert(TModel model);
        public abstract IQueryable<TModel> Select();
    }
}
