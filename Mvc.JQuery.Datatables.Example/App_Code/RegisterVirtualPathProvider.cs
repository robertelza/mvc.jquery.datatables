using System.Reflection;
using System.Linq;
using Mvc.JQuery.DataTables.Core;

namespace Mvc.JQuery.DataTables.Example.App_Code
{
    public class RegisterVirtualPathProvider
    {
        public static void AppInitialize()
        {
            System.Web.Hosting.HostingEnvironment.RegisterVirtualPathProvider(new EmbeddedResourceVirtualPathProvider.Vpp()
            {
                {typeof(Mvc.JQuery.DataTables.DataTablesHelper).Assembly, @"..\Mvc.JQuery.DataTables"},
                {typeof(Marker).Assembly, @"..\Mvc.JQuery.DataTables.Core"},

            });
        }
    }
}