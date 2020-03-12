using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Toci.Driver.Dal.Invitation.Interfaces
{
    public interface IDal<TModel>
    {
        List<TModel> Select(Expression<Func<TModel, bool>> where);
    }
}