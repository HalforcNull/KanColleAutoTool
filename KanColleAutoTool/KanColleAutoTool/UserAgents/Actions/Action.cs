using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KanColleAutoTool.DataEntities;
using KanColleAutoTool.DataEntities.UIEntities;

namespace KanColleAutoTool.UserAgents.Actions
{
    public static class Action
    {
        public static string ActionName { get; protected set; }

        public static ClientUI ActionUI { get; protected set; }

    }
}
