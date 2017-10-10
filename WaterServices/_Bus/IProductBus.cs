using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WaterServices._Bus
{
    public interface IProductBus
    {
        System.Data.DataTable getProducts(string code = "");
        System.Data.DataTable getProductContainers();
        System.Data.DataTable getProductTypes();
        System.Data.DataTable getProductVolumes();
    }
}
