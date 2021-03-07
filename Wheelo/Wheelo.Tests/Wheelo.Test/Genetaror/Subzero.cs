using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wheelo.Nfs.Database.Persistence;
using Wheelo.Nfs.Database.Persistence.Models;
using System.Net.Http;

namespace Wheelo.Test.Generator
{
    [TestClass]
    public class SubZero
    {
        protected JohnnyCage FinishHim = new JohnnyCage();

        [TestMethod]
        public async Task BrutalityAsync()
        {
     
            Fatality(50);
        }

        public int Fatality(int numRows)
        {

            for (int i = 0; i < numRows; i++)
            {
                string Email = FinishHim.GetRandomWord(8);
                string Login = FinishHim.GetRandomWord(5);
                string Name = FinishHim.GetRandomWord(5);
                string Passoword = FinishHim.GetRandomWord(5);
                string Surname = FinishHim.GetRandomWord(5);
                string phone = FinishHim.GetRandomWord(5);


                User x = new User()
                {
                    Email = Email + i,
                    Login = Login + i,
                    Name = Name + i,
                    Password = Passoword + i,
                    Surname = Surname + i,
                    Phone = phone + i,

                };



                PostgresqlRepository<User> repouser = new PostgresqlRepository<User>();
                repouser.Insert(x);
            }


            return 1;



        }
    }
}