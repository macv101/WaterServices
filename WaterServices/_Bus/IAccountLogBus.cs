using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace WaterServices._Bus
{
    public interface IAccountLogBus
    {
        System.Data.DataTable getAccountLogs(string name = "");
    }
}
