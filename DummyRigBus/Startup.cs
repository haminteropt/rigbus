using Microsoft.Owin.Cors;
using Owin;
using Swashbuckle.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace DummyRigBus
{
    public class Startup
    {
        private DummyRig rig;
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            rig = DummyRig.Instance;
            // Configure Web API for self-host. 
            var config = new HttpConfiguration();

            config.EnableSwagger(c => c.SingleApiVersion("v1", "Dummy rig controlled by RigBus")).
            EnableSwaggerUi();

            config.MapHttpAttributeRoutes();


            app.UseWebApi(config);
        }
    }
}
