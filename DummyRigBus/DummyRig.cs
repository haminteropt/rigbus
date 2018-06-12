using DummyRigBus.RestRig;
using Newtonsoft.Json;
using RigBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

//{
//    "Freq": 14313000,
//    "FreqA": 14313000,
//    "FreqB": 7000000,
//    "Mode": "USB",
//    "Pitch": 0,
//    "RigType": "PowerSDR",
//    "Rit": "RitOff",
//    "RitOffset": 0,
//    "Status": null,
//    "StatusStr": null,
//    "Split": "SplitOff",
//    "Tx": "RX",
//    "Vfo": "VFOAA",
//    "Xit": "XitOff"
//}

namespace DummyRigBus
{
    public class DummyRig: IRig
    {
        private static DummyRig instance = null;


        private Rigs rigState = Rigs.Instance;

        private DummyRig()
        {     
        }
        private void ParamsChangeEvent(int RigNumber, int Params)
        {
            if (RigNumber != 1 && RigNumber != 2) return;
            Console.WriteLine(String.Format("Param: {0}", Params));
            RigState rigState = GetRigState();
            var json = JsonConvert.SerializeObject(rigState);
        }

        public RigState GetRigState()
        {
            var rigs = Rigs.Instance;
            return rigs.rigState;
        }

        public void setMode(string mode)
        {
            mode = mode.ToUpper();

            if (mode != "undefine")
                ;
        }

        public void setFreq(int freq)
        {
            Console.WriteLine("setting rig: {0}",  freq);
        }

        public void SetRigState(RigState state)
        {
            setFreq(state.Freq);
            setFreqA(state.FreqA);
            setFreqB(state.FreqB);
        }

        public void setRigState(RigState state)
        {
            throw new NotImplementedException();
        }

        public void setFreqA(int freq)
        {

        }

        public void setFreqB(int freq)
        {

        }

        public void setPitch(int pitch)
        {

        }

        public void setRit(string rit)
        {
        }

        public void setRitOffset(int ritOffset)
        {

        }
        // todo
        public void setVfo(string split)
        {

        }

        public void set(string xit)
        {
            throw new NotImplementedException();
        }

        public RigState getRigState()
        {
            throw new NotImplementedException();
        }

        public string getMode()
        {
            throw new NotImplementedException();
        }

        public int getFreq()
        {
            throw new NotImplementedException();
        }

        public int getFreqA()
        {
            throw new NotImplementedException();
        }

        public int getFreqB()
        {
            throw new NotImplementedException();
        }

        public int getPitch()
        {
            throw new NotImplementedException();
        }

        public int getRit()
        {
            throw new NotImplementedException();
        }

        public int getRitOffset()
        {
            throw new NotImplementedException();
        }

        public string getVfo()
        {
            throw new NotImplementedException();
        }

        public string get()
        {
            throw new NotImplementedException();
        }

        public static DummyRig Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DummyRig();
                }
                return instance;
            }
        }
    }
}
