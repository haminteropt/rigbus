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
            RigState rigState = GetRigState(RigNumber);
            var json = JsonConvert.SerializeObject(rigState);
        }

        public RigState GetRigState(int rigNum)
        {

            var rigs = Rigs.Instance;
            rigs.PopulateRigs();
            return rigs.RigList[rigNum];
        }

        public void setMode(int rigId, string mode)
        {
            mode = mode.ToUpper();

            if (mode != "undefine")
                ;
        }

        public void setFreq(int v, int freq)
        {
            Console.WriteLine("setting rig: {0} to {1}", v, freq);

        }

        public void SetRigState(int rigNum, RigState state)
        {

            setFreq(rigNum, state.Freq);
            setFreqA(rigNum, state.FreqA);
            setFreqB(rigNum, state.FreqB);


        }

        public void setRigState(int rigId, RigState state)
        {
            throw new NotImplementedException();
        }

        public void setFreqA(int rigId, int freq)
        {

        }

        public void setFreqB(int rigId, int freq)
        {

        }

        public void setPitch(int rigId, int pitch)
        {

        }

        public void setRit(int rigId, string rit)
        {
        }

        public void setRitOffset(int rigId, int ritOffset)
        {

        }
        // todo
        public void setVfo(int rigId, string split)
        {

        }

        public void set(int rigId, string xit)
        {
            throw new NotImplementedException();
        }

        public RigState getRigState(int rigId)
        {
            throw new NotImplementedException();
        }

        public string getMode(int rigId)
        {
            throw new NotImplementedException();
        }

        public int getFreq(int rigId)
        {
            throw new NotImplementedException();
        }

        public int getFreqA(int rigId)
        {
            throw new NotImplementedException();
        }

        public int getFreqB(int rigId)
        {
            throw new NotImplementedException();
        }

        public int getPitch(int rigId)
        {
            throw new NotImplementedException();
        }

        public int getRit(int rigId)
        {
            throw new NotImplementedException();
        }

        public int getRitOffset(int rigId)
        {
            throw new NotImplementedException();
        }

        public string getVfo(int rigId, string freq)
        {
            throw new NotImplementedException();
        }

        public string get(int rigId)
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
