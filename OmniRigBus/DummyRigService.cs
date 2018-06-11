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
            rigs.PopulateRigs(2);
            populateRigs(0);
            populateRigs(1);
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
        private void populateRigs(int rigId)
        {
            rigs.RigList[rigId].Freq = 14300000;
            rigs.RigList[rigId].FreqA = 14300000;
            rigs.RigList[rigId].FreqB = 14300000;
            rigs.RigList[rigId].Mode = "USB";
            rigs.RigList[rigId].RigType = "Dummy";
            rigs.RigList[rigId].Rit = "VFOAA";
            rigs.RigList[rigId].RitOffset = 0;
            rigs.RigList[rigId].Status = "";
            rigs.RigList[rigId].StatusStr = "";
            rigs.RigList[rigId].Split = "VFOAA";
            rigs.RigList[rigId].Tx = "VFOAA";
            rigs.RigList[rigId].Vfo = "VFOAA";
            rigs.RigList[rigId].Xit = "VFOAA";
        }
    }
}
