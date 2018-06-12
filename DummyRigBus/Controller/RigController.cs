using Newtonsoft.Json;
using DummyRigBus.RestRig;
using RigBus;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace DummyRigBus.Controller
{
    public class Freq
    {
        public int rigId { get; set; }
        public int freq { get; set; }
    }
    public class Mode
    {
        public int rigId { get; set; }
        public string mode { get; set; }
    }
    //[RoutePrefix("v1/RigBus/Rigs")]
    public class DummyRigController : ApiController
    {
        private Rigs rigs = Rigs.Instance;
        private DummyRig dummyRig = DummyRig.Instance;

        public DummyRigController()
        {

        }
        // GET api/rig 
        [Route("api/RigBus/V1/RigsInfo")]
        public RigState Get()
        {
            dummyRig.GetRigState();
            return rigs.rigState;
        }


        [Route("api/RigBus/V1/freq")]
        public void PutFreq([FromBody]Freq value)
        {
            if (value.rigId != 1 && value.rigId != 2)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            Console.WriteLine("rig {0} freq value: {1}",value.rigId, value.freq);
            dummyRig.setFreq(value.freq);
        }

        [Route("api/RigBus/V1/mode")]
        public void PutMode([FromBody]Mode value)
        {
            if (value.rigId != 1 && value.rigId != 2)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            Console.WriteLine("rig {0} freq value: {1}", value.rigId, value.mode);
            dummyRig.setMode(value.mode);
        }
        [Route("api/RigBus/V1/setRig")]
        public void Put(int id, [FromBody]RigState value)
        {
            dummyRig.SetRigState(value);
        }

    }
}
