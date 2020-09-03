using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace businessApp.Models.Respuestas
{
    public class ResponseBase
    {
        public string type { get; set; }
        public string title { get; set; }
        public int status { get; set; }
        public string detail { get; set; }
        public object errors { get; set; }
        public object result { get; set; }
    }
}
