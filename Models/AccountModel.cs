using Models.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AccountModel
    {
        private UlcerDbContext context = null;
        public AccountModel()
        {
            context = new UlcerDbContext();
        }
        public ACCOUNT Login(string userName, string passWord)
        {
           object[] sqlParams =
            {
                new SqlParameter("@UserName", userName),
                new SqlParameter("@PassWord", passWord)
            };
            var res = context.Database.SqlQuery<ACCOUNT>("Sp_Account_login @UserName, @PassWord", sqlParams).FirstOrDefault();
            return res;
        }
    }
}
