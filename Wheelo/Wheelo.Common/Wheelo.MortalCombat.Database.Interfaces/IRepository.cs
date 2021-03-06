using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wheelo.MortalCombat.Database.Interfaces
{
    public interface IRepository<TModel> where TModel : IModel
    {
        IQueryable<TModel> Select();


        bool Delete(TModel model);
    }
}
