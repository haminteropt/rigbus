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
        private Rigs()
        {
            RigList = new List<RigState>();
        }

        public void PopulateRigs(int numberOfRigs)
        {
            while (RigList.Count != numberOfRigs)
            {
                RigList.Add(new RigState());
            }
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
