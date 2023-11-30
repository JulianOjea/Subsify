using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsifyFrontend.Util.Http
{
    public class RequestObject
    {
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime SUB_LAPSE_END { get; set; }
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime SUB_LAPSE_START { get; set; }
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime PLAN_PRICE_START { get; set; }
        public String PLATF_NAME { get; set; }
        public int SUB_LAPSE_ID { get; set; }
        public double SUB_LAPSE_PRICE { get; set; }
        public String PLAN_NAME { get; set; }
        public String CAT_NAME { get; set; }
        public String FR_NAME { get; set; }
        public double FR_VALUE { get; set; }
        public double shared_price { get; set; }
        public int PLATF_ID { get; set; }
        public double PLAN_PRICE_VALUE { get; set; }
        public int PLAN_ID { get; set; }
        public int FR_ID { get; set; }
        public int CAT_ID { get; set; }
        public int PLAN_PRICE_ID { get; set; }
        public int SUBS_ID { get; set; }
        public ImageData PLATF_IMAGE { get; set; }
        public bool SUBS_AUTORENEWAL { get; set; }
        public string PLATF_LINK { get; set; }
        public double SLC_PRICE { get; set; }
        public string USER_ { get; set; }
        public string NAME { get; set; }
    }

    public class ImageData
    {
        public long serializationStartTime { get; set; }
        public long serializationFinalTime { get; set; }
        public byte[] bytes { get; set; }
    }
}
