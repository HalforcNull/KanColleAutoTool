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
    delegate void netWorkResponseProcess(NetworkEntity Data);

    public sealed class NetworkMaster 
    {
        private static volatile NetworkMaster instance;
        private static object syncRoot = new Object();
        private HttpPoster poster;
        private ResponseHandler responseHandler;

        
        private Dictionary<NetworkRequestType, netWorkResponseProcess> regedit;

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

        public bool Post(NetworkRequestType request, UserAgent _user)
        {
            NetworkEntity packet = CreateEntity(request);
            string responseString;
            poster.httpPost(packet.getRequestUri(), packet.getRequestData(_user), out responseString);
            packet.loadData(responseString);
            if(!regedit.ContainsKey(request) || regedit[request]==null)
            {
                return true;
            }
            regedit[request](packet);
            
            return true;
        }

        public void Regedit_Add( NetworkRequestType request, netWorkResponseProcess handler)
        {
            if(!regedit.ContainsKey(request))
            {
                regedit.Add(request, handler);
            }
            else
            {
                regedit[request] += handler;
            }
        }

        public void Regedit_Remove( NetworkRequestType request, netWorkResponseProcess handler)
        {

            if (!regedit.ContainsKey(request))
            {
                return;
            }
            else
            {
                regedit[request] -= handler;
            }
        }

        protected NetworkEntity CreateEntity(NetworkRequestType request)
        {
            throw new NotImplementedException();
            switch(request)
            {

            }
        }
    }
}
