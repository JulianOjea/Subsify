using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsifyFrontend.Model.Entity
{
    internal class SubLapse
    {
        public SubLapse(string uSER_)
        {
            USER_ = uSER_;
        }

        public int SUB_LAPSE_ID { get; set; }
        public DateTime SUB_LAPSE_START { get; set; }
        public DateTime SUB_LAPSE_END { get; set; }
        public int SUBS_ID { get; set; }
        public string USER_ { get; set; }
        public List<SubLapse> getByApiResponse(ApiResponse ar)
        {
            //st<SubLapse> slList;
            foreach(var item in ar.Data)
            {

            }
            return null;
        }
    }
}
