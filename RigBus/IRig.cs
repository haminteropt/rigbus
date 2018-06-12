using System;
using System.Collections.Generic;
using System.Text;

namespace RigBus
{
    public interface IRig
    {
        void setRigState( RigState state);
        void setMode( string mode);
        void setFreq(int freq);
        void setFreqA(int freq);
        void setFreqB(int freq);
        void setPitch(int pitch);
        void setRit(string rit);
        void setRitOffset(int freq);
        void setVfo(string freq);
        void set(string xit);

        RigState getRigState();
        string getMode();
        int getFreq();
        int getFreqA();
        int getFreqB();
        int getPitch();
        int getRit();
        int getRitOffset();
        string getVfo();
        string get();
    }
}
