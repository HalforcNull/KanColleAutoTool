using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanColleAutoTool.DataEntities.NetworkEntities
{
    enum NetworkRequestType {
        BASIC,
        BATTLE_RESULT,
        BATTLE_MIDNIGHT,
        BATTLE,
        CHARGE,
        KDOCK,
        NDOCK,
        NEXT,
        PORT,
        QUESTLIST,
        SHIP2,
        START2,
        SLOTITEM_MEMBER
    }
    class NetworkEntity:DataEntity
    {
    }
}
