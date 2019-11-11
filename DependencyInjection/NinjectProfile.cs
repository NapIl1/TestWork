using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AprioritDenysKarpenko
{
    public class NinjectProfile : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository>().To<FolderRepository>().InSingletonScope();
            Bind<IFolderDbContext>().To<FolderContext>().InSingletonScope();
        }
    }
}