using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Toci.Driver.Dal.Invitation.Interfaces;

namespace Toci.Driver.Dal.Invitation
{
    public abstract class DalBase<TModel> : IDal<TModel>
    {
        public abstract List<TModel> Select(Expression<Func<TModel, bool>> @where);
    }
}