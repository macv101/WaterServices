using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using WaterServices._Repository;

namespace WaterServices._Bus
{
    public class ProductBus : IProductBus
    {

        private IProductRepository repo;

        public ProductBus()
        {
            repo = new ProductRepository();
        }

        public DataTable getProducts(string code)
        {
            return repo.getProducts(code);
        }

        public DataTable getProductContainers()
        {
            return repo.getProductContainers();
        }

        public DataTable getProductTypes()
        {
            return repo.getProductTypes();
        }

        public DataTable getProductVolumes()
        {   
            return repo.getProductVolumes();
        }
    }
}
