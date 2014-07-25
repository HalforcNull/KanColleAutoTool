using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanColleAutoTool.DataEntities.NetworkEntities
{
    public class Material
    {
        public Material_RootObject Data { get; private set; }
        public string requestUri { get { return ""; } }
        public NetworkRequestType Type { get { return NetworkRequestType.SLOTITEM_MEMBER; } }
    }

    public class Material_ApiData
    {
        public int api_member_id { get; set; }
        public int api_id { get; set; }
        public int api_value { get; set; }
    }

    public class Material_RootObject
    {
        public int api_result { get; set; }
        public string api_result_msg { get; set; }
        public List<Material_ApiData> api_data { get; set; }
    }
}
