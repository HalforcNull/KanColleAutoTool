using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanColleAutoTool.DataEntities.NetworkEntities
{

    public class SlotitemMember
    {
        public SLOTITEM_MEMBER_RootObject Data { get; private set; }
        public string requestUri { get { return ""; } }
        public NetworkRequestType Type { get { return NetworkRequestType.SLOTITEM_MEMBER; } }
    }


public class SLOTITEM_MEMBER_ApiData
{
    public int api_id { get; set; }
    public int api_slotitem_id { get; set; }
    public int api_locked { get; set; }
}

public class SLOTITEM_MEMBER_RootObject
{
    public int api_result { get; set; }
    public string api_result_msg { get; set; }
    public List<SLOTITEM_MEMBER_ApiData> api_data { get; set; }
}


}
