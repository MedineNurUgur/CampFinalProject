using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Prodect tablosu ile ilgili sql operasyonları burada tanımlanır.
    public interface IProductDal : IEntityRepository<Product>
    {
        
    }
}
