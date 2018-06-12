using RigBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyRigBus.RestRig
{
    public class Rigs
    {
        public List<RigState> RigList { get; private set; }

        private static Rigs instance = null;
        public RigState rigState = new RigState();
        private Rigs()
        {

        }
        public void populateRig()
        {
            rigState.Freq = 14300000;
            rigState.FreqA = 14300000;
            rigState.FreqB = 14300000;
            rigState.Mode = "USB";
            rigState.RigType = "Dummy";
            rigState.Rit = "VFOAA";
            rigState.RitOffset = 0;
            rigState.Status = "";
            rigState.StatusStr = "";
            rigState.Split = "VFOAA";
            rigState.Tx = "VFOAA";
            rigState.Vfo = "VFOAA";
            rigState.Xit = "VFOAA";
        }
        public static Rigs Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Rigs();
                }
                return instance;
            }
        }
    }
}
