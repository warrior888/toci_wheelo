using System;
using System.Linq;
using System.Linq.Expressions;
using Toci.Driver.Dal.Invitation.Interfaces;

namespace Toci.Driver.Dal.Invitation
{
    public class UserRepository<TModel> : DalBase<TModel>, IUserRepository
    {
        public UserRepository(DriverEntities db) : base(db)
        {
        }


        public void RegisterUser(Users user)
        {
           
        }
    }
}