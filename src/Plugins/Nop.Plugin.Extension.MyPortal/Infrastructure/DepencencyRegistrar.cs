using Autofac;
using Autofac.Core;
using Nop.Core.Data;
using Nop.Core.Infrastructure;
using Nop.Core.Infrastructure.DependencyManagement;
using Nop.Data;
using Nop.Plugin.Extension.MyPortal.Data;
using Nop.Plugin.Extension.MyPortal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Core.Configuration;
using Nop.Web.Framework.Mvc;
using Nop.Plugin.Extension.MyPortal.Service;

namespace Nop.Plugin.Extension.MyPortal.Infrastructure
{
    public class DepencencyRegistrar : IDependencyRegistrar
    {
        private const string CONTEXT_NAME = "nop_object_context_myportal";

        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder, NopConfig config)
        {
            //loghoz kéne ha lenne
            //builder.RegisterType<ParcelRecordObjectContext>().As<IViewTrackingService>().InstancePerLifetimeScope();

            //data context
            
            DependencyRegistrarExtensions.RegisterPluginDataContext<ParcelRecordObjectContext>(this, builder, CONTEXT_NAME);

            //override required repository with our custom context
            builder.RegisterType<EfRepository<ParcelRecord>>()
                .As<IRepository<ParcelRecord>>()
                .WithParameter(ResolvedParameter.ForNamed<IDbContext>(CONTEXT_NAME))
                .InstancePerLifetimeScope();

            builder.RegisterType<ParcelService>().As<IParcelService>().InstancePerLifetimeScope();
        }

        public int Order
        {
            get { return 1; }
        }
    }
}
