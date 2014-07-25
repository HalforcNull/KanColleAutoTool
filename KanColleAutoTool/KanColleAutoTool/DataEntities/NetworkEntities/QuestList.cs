using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanColleAutoTool.DataEntities.NetworkEntities
{
    public class QuestList
    {
        public QuestList_RootObject Data { get; private set; }
        public string requestUri { get { return ""; } }
        public NetworkRequestType Type { get { return NetworkRequestType.QUESTLIST; } }
    }
    public class QuestList_ApiList
    {
        public int api_no { get; set; }
        public int api_category { get; set; }
        public int api_type { get; set; }
        public int api_state { get; set; }
        public string api_title { get; set; }
        public string api_detail { get; set; }
        public List<int> api_get_material { get; set; }
        public int api_bonus_flag { get; set; }
        public int api_progress_flag { get; set; }
    }

    public class QuestList_ApiData
    {
        public int api_count { get; set; }
        public int api_page_count { get; set; }
        public int api_disp_page { get; set; }
        public List<QuestList_ApiList> api_list { get; set; }
        public int api_exec_count { get; set; }
    }

    public class QuestList_RootObject
    {
        public int api_result { get; set; }
        public string api_result_msg { get; set; }
        public QuestList_ApiData api_data { get; set; }
    }
}
