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

        public System.Data.DataTable getAccountLogs(string name, DateTime? from, DateTime? to)
        {
            return repo.getAccountLogs(name, from, to);
        }
    }
}
