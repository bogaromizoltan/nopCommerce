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

namespace Nop.Plugin.Extension.MyPortal.Infrastructure
{
    public class DepencencyRegistrar : IDependencyRegistrar
    {
        private const string CONTEXT_NAME = "nop_object_context_myportal";

        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder, NopConfig config)
        {
            //loghoz kéne ha lenne
            //builder.RegisterType<MyPortalRecordObjectContext>().As<IViewTrackingService>().InstancePerLifetimeScope();

            //data context
            
            DependencyRegistrarExtensions.RegisterPluginDataContext<MyPortalRecordObjectContext>(this, builder, CONTEXT_NAME);

            //override required repository with our custom context
            builder.RegisterType<EfRepository<MyPortalRecord>>()
                .As<IRepository<MyPortalRecord>>()
                .WithParameter(ResolvedParameter.ForNamed<IDbContext>(CONTEXT_NAME))
                .InstancePerLifetimeScope();
        }

        public int Order
        {
            get { return 1; }
        }
    }
}
