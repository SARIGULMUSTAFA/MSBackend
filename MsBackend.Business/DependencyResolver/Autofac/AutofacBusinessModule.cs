using Autofac;
using MsBackend.Business.Abstract;
using MsBackend.Business.Concrete;
using MsBackend.DataAccess.Abstract;
using MsBackend.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsBackend.Business.DependencyResolver.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();

            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();
        }
    }
}
