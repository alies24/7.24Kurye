using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Intercepters;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers
{
    public class AutofacModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CourierManager>().As<ICourierService>().SingleInstance();
            builder.RegisterType<EfCourierDal>().As<ICourierDal>().SingleInstance();
            builder.RegisterType<AuthManager>().As<IAuthService>().SingleInstance(); 
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance(); 
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();
            builder.RegisterType<EfVehicleDal>().As<IVehicleDal>().SingleInstance();
            builder.RegisterType<VehicleManager>().As<IVehicleService>().SingleInstance();




            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
               .EnableInterfaceInterceptors(new ProxyGenerationOptions()
               {
                   Selector = new AspectInterceptorSelector()
               }).SingleInstance();
        }
       
    }
}
