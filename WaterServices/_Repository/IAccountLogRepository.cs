using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WaterServices._Repository
{
    public interface IAccountLogRepository
    {
        System.Data.DataTable getAccountLogs(string name = "", DateTime? from = null, DateTime? to = null);
    }
}
