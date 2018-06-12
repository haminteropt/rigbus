using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;
using Topshelf.ServiceConfigurators;

namespace DummyRigBus
{
    public class Program
    {
        static int Main(string[] args)
        {
            try {
                var exitCode = HostFactory.Run(c =>
                {
                    c.Service<DummyRigService>(service =>
                    {
                        ServiceConfigurator<DummyRigService> s = service;
                        s.ConstructUsing(() => new DummyRigService());
                        s.WhenStarted(a => a.Start());
                        s.WhenStopped(a => a.Stop());
                    });
                    c.SetServiceName("DummyRigHamBus");
                    c.SetDisplayName("DummyRig HamBus server");
                    c.SetDescription("Web server for DummyRig and hambus");
                });
                return (int)exitCode;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                if (e.InnerException != null)
                {
                    Console.WriteLine(e.InnerException.Message);

                    Console.WriteLine("\n\nCould not open COM object! Exiting");


                    return -1;
                }
            }
            return 0;

        }
    }
}
