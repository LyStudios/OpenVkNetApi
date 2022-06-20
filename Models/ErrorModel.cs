using System.Collections.Generic;

namespace OpenVkNetApi.Models
{
    class ErrorModel
    {
        public int error_code { get; set; }
        public string error_msg { get; set; }
        public List<RequestParam> request_params { get; set; }
    }
    class RequestParam
    {
        public string key { get; set; }
        public object value { get; set; }
    }
}
