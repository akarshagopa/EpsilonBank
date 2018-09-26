using EpsilonBank.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpsilonBank.ComputationMethods
{
    public class CompMethods
    {
        private BankContext db;

        public CompMethods(BankContext context)
        {
            db = context;
        }

        //deposit
        public void AddBalance(long checkingAccNo)
        {
            var checkingAccount = db.TBL_Account.Where(c => c.AccNo == checkingAccNo).First();
            checkingAccount.Balance = db.TBL_Transaction.Where(c => c.AccNo == checkingAccNo).Sum(t => t.TransAmount);
            db.SaveChanges();
        }
    }
}