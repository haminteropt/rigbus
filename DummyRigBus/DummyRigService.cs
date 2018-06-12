using DummyRigBus.RestRig;
using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyRigBus
{
    public class DummyRigService
    {
        private IDisposable app;
        private Rigs rigs = Rigs.Instance;
        public DummyRigService()
        {
            populateRig();
        }
        public void Start()
        {
            string baseAddress = "http://localhost:7302/";
            app = WebApp.Start<Startup>(url: baseAddress);
        }
        public void Stop()
        {
            app.Dispose();
        }
        private void populateRig()
        {
            rigs.populateRig();
        }
    }
}
