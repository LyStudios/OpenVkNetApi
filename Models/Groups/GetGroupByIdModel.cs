using System.Collections.Generic;

namespace OpenVkNetApi.Models.Groups
{
    public class GetGroupByIdModel
    {
        public List<GetByIdResponse> response { get; set; }
    }
    public class GetByIdResponse
    {
        public int id { get; set; }
        public string name { get; set; }
        public string screen_name { get; set; }
        public bool is_closed { get; set; }
        public string type { get; set; }
        public bool can_access_closed { get; set; }
    }
}
