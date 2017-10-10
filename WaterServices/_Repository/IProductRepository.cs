using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WaterServices._Repository
{
    public interface IProductRepository
    {
        System.Data.DataTable getProducts(string code = "");
        System.Data.DataTable getProductContainers();
        System.Data.DataTable getProductTypes();
        System.Data.DataTable getProductVolumes();
    }
}
