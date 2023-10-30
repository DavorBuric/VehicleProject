using Ninject.Modules;
using Project.Common.Parameters;
using Project.Common.ParametersCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Common
{
    public class DImodule : NinjectModule
    {
        public override void Load()
        {
            Bind<IFilterParameters>().To<FilterParameters>();
            Bind<ISortParameters>().To<SortParameters>();
            Bind<IPageParameters>().To<PageParameters>();
        }
    }
}
