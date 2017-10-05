using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WaterServices._Repository;

namespace WaterServices._Bus
{
    public class AccountLogBus : IAccountLogBus
    {
        private IAccountLogRepository repo;

        public AccountLogBus()
        {
            repo = new AccountLogRepository();
        }

        public System.Data.DataTable getAccountLogs(string name)
        {
            System.Data.DataTable ret = repo.getAccountLogs(name);
            ret.Columns.Remove("id");
            ret.Columns.Remove("dDate");
            ret.Columns.Remove("id1");
            ret.Columns.Remove("id2");
            ret.Columns.Remove("sCode1");
            ret.Columns.Remove("sCode2");
            ret.Columns.Remove("sCode3");
            ret.Columns["sCompany"].SetOrdinal(0);
            ret.Columns["sFirstName"].SetOrdinal(1);
            ret.Columns["sLastName"].SetOrdinal(2);
            ret.Columns["sCode"].SetOrdinal(3);
            ret.Columns["sPhone"].SetOrdinal(4);
            ret.Columns["iQuantity"].SetOrdinal(5);
            ret.Columns["fPrice"].SetOrdinal(6);
            ret.Columns["iInterval"].SetOrdinal(7);            
            return ret;
        }
    }
}
