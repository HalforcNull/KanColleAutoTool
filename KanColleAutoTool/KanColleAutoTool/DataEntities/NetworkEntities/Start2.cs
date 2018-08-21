using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace KanColleAutoTool.DataEntities.NetworkEntities
{
    public class Start2 : NetworkEntity
    {
        public Start2_RootObject Data { get; private set; }
        //public string requestUri { get { return ""; } }
        public NetworkRequestType Type { get { return NetworkRequestType.START2; } }

        public override object getResponseDataObject()
        {
            return Data;
        }

        public override bool loadData(string response)
        {
            try
            {
                Data = (Start2_RootObject)JsonConvert.DeserializeObject(response);
                return true;
            }
            catch (Exception e)
            {
                //need implement;
                return false;
            }
        }

        public override string getRequestData(UserAgents.UserAgent user)
        {
            throw new NotImplementedException();
        }

        public override string getRequestUri(UserAgents.UserAgent user)
        {
            throw new NotImplementedException();
        }
    }

    public class Start2_ApiMstShip
    {
        public int api_id { get; set; }
        public int api_sortno { get; set; }
        public string api_name { get; set; }
        public string api_yomi { get; set; }
        public int api_stype { get; set; }
        public int api_ctype { get; set; }
        public int api_cnum { get; set; }
        public string api_enqflg { get; set; }
        public int api_afterlv { get; set; }
        public string api_aftershipid { get; set; }
        public List<int> api_taik { get; set; }
        public List<int> api_souk { get; set; }
        public List<int> api_tous { get; set; }
        public List<int> api_houg { get; set; }
        public List<int> api_raig { get; set; }
        public List<int> api_baku { get; set; }
        public List<int> api_tyku { get; set; }
        public List<int> api_atap { get; set; }
        public List<int> api_tais { get; set; }
        public List<int> api_houm { get; set; }
        public List<int> api_raim { get; set; }
        public List<int> api_kaih { get; set; }
        public List<int> api_houk { get; set; }
        public List<int> api_raik { get; set; }
        public List<int> api_bakk { get; set; }
        public List<int> api_saku { get; set; }
        public List<int> api_sakb { get; set; }
        public List<int> api_luck { get; set; }
        public int api_sokuh { get; set; }
        public int api_soku { get; set; }
        public int api_leng { get; set; }
        public List<int> api_grow { get; set; }
        public int api_slot_num { get; set; }
        public List<int> api_maxeq { get; set; }
        public List<int> api_defeq { get; set; }
        public int api_buildtime { get; set; }
        public List<int> api_broken { get; set; }
        public List<int> api_powup { get; set; }
        public List<int> api_gumax { get; set; }
        public int api_backs { get; set; }
        public string api_getmes { get; set; }
        public object api_homemes { get; set; }
        public object api_gomes { get; set; }
        public object api_gomes2 { get; set; }
        public string api_sinfo { get; set; }
        public int api_afterfuel { get; set; }
        public int api_afterbull { get; set; }
        public List<object> api_touchs { get; set; }
        public object api_missions { get; set; }
        public object api_systems { get; set; }
        public int api_fuel_max { get; set; }
        public int api_bull_max { get; set; }
        public int api_voicef { get; set; }
    }

    public class Start2_ApiMstShipgraph
    {
        public int api_id { get; set; }
        public int api_sortno { get; set; }
        public string api_filename { get; set; }
        public string api_version { get; set; }
        public List<int> api_boko_n { get; set; }
        public List<int> api_boko_d { get; set; }
        public List<int> api_kaisyu_n { get; set; }
        public List<int> api_kaisyu_d { get; set; }
        public List<int> api_kaizo_n { get; set; }
        public List<int> api_kaizo_d { get; set; }
        public List<int> api_map_n { get; set; }
        public List<int> api_map_d { get; set; }
        public List<int> api_ensyuf_n { get; set; }
        public List<int> api_ensyuf_d { get; set; }
        public List<int> api_ensyue_n { get; set; }
        public List<int> api_battle_n { get; set; }
        public List<int> api_battle_d { get; set; }
        public List<int> api_weda { get; set; }
        public List<int> api_wedb { get; set; }
    }

    public class Start2_ApiMstSlotitemEquiptype
    {
        public int api_id { get; set; }
        public string api_name { get; set; }
        public int api_show_flg { get; set; }
    }

    public class Start2_ApiEquipType
    {
        public int __invalid_name__1 { get; set; }
        public int __invalid_name__2 { get; set; }
        public int __invalid_name__3 { get; set; }
        public int __invalid_name__4 { get; set; }
        public int __invalid_name__5 { get; set; }
        public int __invalid_name__6 { get; set; }
        public int __invalid_name__7 { get; set; }
        public int __invalid_name__8 { get; set; }
        public int __invalid_name__9 { get; set; }
        public int __invalid_name__10 { get; set; }
        public int __invalid_name__11 { get; set; }
        public int __invalid_name__12 { get; set; }
        public int __invalid_name__13 { get; set; }
        public int __invalid_name__14 { get; set; }
        public int __invalid_name__15 { get; set; }
        public int __invalid_name__16 { get; set; }
        public int __invalid_name__17 { get; set; }
        public int __invalid_name__18 { get; set; }
        public int __invalid_name__19 { get; set; }
        public int __invalid_name__20 { get; set; }
        public int __invalid_name__21 { get; set; }
        public int __invalid_name__22 { get; set; }
        public int __invalid_name__23 { get; set; }
        public int __invalid_name__24 { get; set; }
        public int __invalid_name__25 { get; set; }
        public int __invalid_name__26 { get; set; }
        public int __invalid_name__27 { get; set; }
        public int __invalid_name__28 { get; set; }
        public int __invalid_name__29 { get; set; }
        public int __invalid_name__30 { get; set; }
        public int __invalid_name__31 { get; set; }
        public int __invalid_name__32 { get; set; }
        public int __invalid_name__33 { get; set; }
    }

    public class Start2_ApiMstStype
    {
        public int api_id { get; set; }
        public int api_sortno { get; set; }
        public string api_name { get; set; }
        public int api_scnt { get; set; }
        public int api_kcnt { get; set; }
        public Start2_ApiEquipType api_equip_type { get; set; }
    }

    public class Start2_ApiMstSlotitem
    {
        public int api_id { get; set; }
        public int api_sortno { get; set; }
        public string api_name { get; set; }
        public List<int> api_type { get; set; }
        public int api_taik { get; set; }
        public int api_souk { get; set; }
        public int api_houg { get; set; }
        public int api_raig { get; set; }
        public int api_soku { get; set; }
        public int api_baku { get; set; }
        public int api_tyku { get; set; }
        public int api_tais { get; set; }
        public int api_atap { get; set; }
        public int api_houm { get; set; }
        public int api_raim { get; set; }
        public int api_houk { get; set; }
        public int api_raik { get; set; }
        public int api_bakk { get; set; }
        public int api_saku { get; set; }
        public int api_sakb { get; set; }
        public int api_luck { get; set; }
        public int api_leng { get; set; }
        public int api_rare { get; set; }
        public List<int> api_broken { get; set; }
        public string api_info { get; set; }
        public string api_usebull { get; set; }
    }

    public class Start2_ApiMstSlotitemgraph
    {
        public int api_id { get; set; }
        public int api_sortno { get; set; }
        public string api_filename { get; set; }
        public string api_version { get; set; }
    }

    public class Start2_ApiMstFurniture
    {
        public int api_id { get; set; }
        public int api_type { get; set; }
        public int api_no { get; set; }
        public string api_title { get; set; }
        public string api_description { get; set; }
        public int api_rarity { get; set; }
        public int api_price { get; set; }
        public int api_saleflg { get; set; }
    }

    public class Start2_ApiMstFurnituregraph
    {
        public int api_id { get; set; }
        public int api_type { get; set; }
        public int api_no { get; set; }
        public string api_filename { get; set; }
        public string api_version { get; set; }
    }

    public class Start2_ApiMstUseitem
    {
        public int api_id { get; set; }
        public int api_usetype { get; set; }
        public int api_category { get; set; }
        public string api_name { get; set; }
        public List<string> api_description { get; set; }
        public int api_price { get; set; }
    }

    public class Start2_ApiMstPayitem
    {
        public int api_id { get; set; }
        public int api_type { get; set; }
        public string api_name { get; set; }
        public string api_description { get; set; }
        public List<int> api_item { get; set; }
        public int api_price { get; set; }
    }

    public class Start2_ApiMstItemShop
    {
        public List<int> api_cabinet_1 { get; set; }
        public List<int> api_cabinet_2 { get; set; }
    }

    public class Start2_ApiMstMaparea
    {
        public int api_id { get; set; }
        public string api_name { get; set; }
        public int api_type { get; set; }
    }

    public class Start2_ApiMstMapinfo
    {
        public int api_id { get; set; }
        public int api_maparea_id { get; set; }
        public int api_no { get; set; }
        public string api_name { get; set; }
        public int api_level { get; set; }
        public string api_opetext { get; set; }
        public string api_infotext { get; set; }
        public List<int> api_item { get; set; }
        public object api_max_maphp { get; set; }
        public int? api_required_defeat_count { get; set; }
    }

    public class Start2_ApiMstMapbgm
    {
        public int api_id { get; set; }
        public int api_maparea_id { get; set; }
        public int api_no { get; set; }
        public List<int> api_map_bgm { get; set; }
        public List<int> api_boss_bgm { get; set; }
    }

    public class Start2_ApiMstMapcell
    {
        public int api_map_no { get; set; }
        public int api_maparea_id { get; set; }
        public int api_mapinfo_no { get; set; }
        public int api_id { get; set; }
        public int api_no { get; set; }
        public int api_color_no { get; set; }
    }

    public class Start2_ApiMstMission
    {
        public int api_id { get; set; }
        public int api_maparea_id { get; set; }
        public string api_name { get; set; }
        public string api_details { get; set; }
        public int api_time { get; set; }
        public int api_difficulty { get; set; }
        public double api_use_fuel { get; set; }
        public double api_use_bull { get; set; }
        public List<int> api_win_item1 { get; set; }
        public List<int> api_win_item2 { get; set; }
        public int api_return_flag { get; set; }
    }

    public class Start2_ApiBokoMaxShips
    {
        public string api_string_value { get; set; }
        public int api_int_value { get; set; }
    }

    public class Start2_ApiMstConst
    {
        public Start2_ApiBokoMaxShips api_boko_max_ships { get; set; }
    }

    public class Start2_ApiMstShipupgrade
    {
        public int api_id { get; set; }
        public int api_original_ship_id { get; set; }
        public int api_upgrade_type { get; set; }
        public int api_upgrade_level { get; set; }
        public int api_drawing_count { get; set; }
        public int api_sortno { get; set; }
    }

    public class Start2_ApiData
    {
        public List<Start2_ApiMstShip> api_mst_ship { get; set; }
        public List<Start2_ApiMstShipgraph> api_mst_shipgraph { get; set; }
        public List<Start2_ApiMstSlotitemEquiptype> api_mst_slotitem_equiptype { get; set; }
        public List<Start2_ApiMstStype> api_mst_stype { get; set; }
        public List<Start2_ApiMstSlotitem> api_mst_slotitem { get; set; }
        public List<Start2_ApiMstSlotitemgraph> api_mst_slotitemgraph { get; set; }
        public List<Start2_ApiMstFurniture> api_mst_furniture { get; set; }
        public List<Start2_ApiMstFurnituregraph> api_mst_furnituregraph { get; set; }
        public List<Start2_ApiMstUseitem> api_mst_useitem { get; set; }
        public List<Start2_ApiMstPayitem> api_mst_payitem { get; set; }
        public Start2_ApiMstItemShop api_mst_item_shop { get; set; }
        public List<Start2_ApiMstMaparea> api_mst_maparea { get; set; }
        public List<Start2_ApiMstMapinfo> api_mst_mapinfo { get; set; }
        public List<Start2_ApiMstMapbgm> api_mst_mapbgm { get; set; }
        public List<Start2_ApiMstMapcell> api_mst_mapcell { get; set; }
        public List<Start2_ApiMstMission> api_mst_mission { get; set; }
        public Start2_ApiMstConst api_mst_const { get; set; }
        public List<Start2_ApiMstShipupgrade> api_mst_shipupgrade { get; set; }
    }

    public class Start2_RootObject
    {
        public int api_result { get; set; }
        public string api_result_msg { get; set; }
        public Start2_ApiData api_data { get; set; }
    }
}
