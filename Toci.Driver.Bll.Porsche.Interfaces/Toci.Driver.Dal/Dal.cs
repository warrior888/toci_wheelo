using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Toci.Driver.Dal.Invitation.Interfaces;

namespace Toci.Driver.Dal.Invitation
{
    public class Dal<TModel> : DalBase<TModel> where TModel : class
    {
        DriverEntities DriverEntities = new DriverEntities();

        public override List<TModel> Select(Expression<Func<TModel, bool>> @where)
        {
            //DriverEntities.Set<TModel>().s
            return null;
        }
    }
}