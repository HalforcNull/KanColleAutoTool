using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KanColleAutoTool;
using KanColleAutoTool.Masters.NetworkMasterComponent;
using KanColleAutoTool.DataEntities;
using KanColleAutoTool.DataEntities;
using KanColleAutoTool.DataEntities.NetworkEntities;
using KanColleAutoTool.UserAgents;

namespace KanColleAutoTool.Masters
{
    public sealed class NetworkMaster 
    {
        private static volatile NetworkMaster instance;
        private static object syncRoot = new Object();
        private HttpPoster poster;
        private ResponseTranslator responseHandler;

        private NetworkMaster()
        {

        }

        public NetworkMaster MasterObject
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new NetworkMaster();
                    }
                }
                return instance;
            }
        }

        public static bool Post( HttpRequests _request, UserAgent _user )
        {


            return true;
        }
    }
}
