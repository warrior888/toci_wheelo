using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wheelo.MortalCombat.Database;
using Wheelo.Nfs.Database.Persistence.Models;

namespace Wheelo.Nfs.Database.Persistence
{
    public class PostgresqlRepository<TModel> : Repository<TModel>
    {
        protected wheeloContext DbContext = new wheeloContext();
        public override bool Delete(TModel model)
        {
            throw new NotImplementedException();
        }

        public override TModel Insert(TModel model)
        {
            EntityEntry entry = DbContext.Add(model);
            DbContext.SaveChanges();

            return (TModel)entry.Entity;
        }

        public override IQueryable<TModel> Select()
        {
            throw new NotImplementedException();
        }
    }
}
