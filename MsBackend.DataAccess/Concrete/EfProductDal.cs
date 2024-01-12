using MsBackend.Core.DataAccess.EntityFramework;
using MsBackend.DataAccess.Abstract;
using MSBackend.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsBackend.DataAccess.Concrete
{
    public class EfProductDal:EfEntityRepositoryBase<Product,MsBackendDbContext>,IProductDal
    {
    }
}
