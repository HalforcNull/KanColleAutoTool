using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanColleAutoTool.DataEntities.NetworkEntities
{

    public class Ndock
    {   
        public NDOCK_RootObject Data {get; private set;}
        public string requestUri{get {return "";}}
        public NetworkRequestType Type{get {return NetworkRequestType.NDOCK;}}
    }

    public class NDOCK_ApiData
    {
        public int api_member_id { get; set; }
        public int api_id { get; set; }
        public int api_state { get; set; }
        public int api_ship_id { get; set; }
        public object api_complete_time { get; set; }
        public string api_complete_time_str { get; set; }
        public int api_item1 { get; set; }
        public int api_item2 { get; set; }
        public int api_item3 { get; set; }
        public int api_item4 { get; set; }
    }

    public class NDOCK_RootObject
    {
        public int api_result { get; set; }
        public string api_result_msg { get; set; }
        public List<NDOCK_ApiData> api_data { get; set; }
    }

}
