using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanColleAutoTool.DataEntities.NetworkEntities
{

    public class Charge
    {
        public CHARGE_RootObject Data { get; private set; }
        public string requestUri { get { return ""; } }
        public NetworkRequestType Type { get { return NetworkRequestType.CHARGE} }
    }

    public class CHARGE_ApiShip
    {
        public int api_id { get; set; }
        public int api_fuel { get; set; }
        public int api_bull { get; set; }
        public List<int> api_onslot { get; set; }
    }

    public class CHARGE_ApiData
    {
        public List<CHARGE_ApiShip> api_ship { get; set; }
        public List<int> api_material { get; set; }
        public int api_use_bou { get; set; }
    }

    public class CHARGE_RootObject
    {
        public int api_result { get; set; }
        public string api_result_msg { get; set; }
        public CHARGE_ApiData api_data { get; set; }
    }
}
