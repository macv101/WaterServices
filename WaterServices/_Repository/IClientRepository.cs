using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WaterServices._Repository
{
    public interface IClientRepository
    {
        System.Data.DataTable getClients();
        System.Data.DataTable getClientById(string id);
        System.Data.DataTable getClientAndLocationById(string id);
    }
}
