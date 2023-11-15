using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubsifyFrontend.Util.Http
{
    public class ApiResponse
    {
        public int code { get; set; }
        public string message { get; set; }
        public List<object> data { get; set; }

        public ApiResponse(int code) { this.code = code; }
    }
}
