using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wheelo.MortalCombat.Database.Interfaces;

namespace Wheelo.MortalCombat.Database
{
    public class Repository : IRepository<IModel>
    {
        public bool Delete(IModel model)
        {
            return true;
        }

        public IQueryable<IModel> Select()
        {
            throw new NotImplementedException();
        }
    }
}
