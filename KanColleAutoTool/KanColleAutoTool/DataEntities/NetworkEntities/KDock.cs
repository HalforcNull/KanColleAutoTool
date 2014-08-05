using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanColleAutoTool.DataEntities.NetworkEntities
{
    public class KDock:NetworkEntity
    {   
        public KDock_ApiData Data {get; private set;}
        public string requestUri{get {return "";}}
        public NetworkRequestType Type { get { return NetworkRequestType.KDOCK; } }

        public override string getRequestUri(params object[] args)
        {
            throw new NotImplementedException();
        }

        public override object getResponseDataObject()
        {
            throw new NotImplementedException();
        }

        public override bool loadData(string response)
        {
            throw new NotImplementedException();
        }

        public override string getRequestData(UserAgents.UserAgent user)
        {
            throw new NotImplementedException();
        }
    }

    public class KDock_ApiData
    {
        public int api_member_id { get; set; }
        public int api_id { get; set; }
        public int api_state { get; set; }
        public int api_created_ship_id { get; set; }
        public int api_complete_time { get; set; }
        public string api_complete_time_str { get; set; }
        public int api_item1 { get; set; }
        public int api_item2 { get; set; }
        public int api_item3 { get; set; }
        public int api_item4 { get; set; }
        public int api_item5 { get; set; }
    }

    public class KDock_RootObject
    {
        public int api_result { get; set; }
        public string api_result_msg { get; set; }
        public List<KDock_ApiData> api_data { get; set; }
    }
}
