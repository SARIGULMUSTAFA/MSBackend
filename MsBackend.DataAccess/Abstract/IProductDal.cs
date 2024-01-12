using MsBackend.Core.DataAccess;
using MSBackend.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsBackend.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
    }
}
