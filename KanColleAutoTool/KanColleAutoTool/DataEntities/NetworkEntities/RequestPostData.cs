using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KanColleAutoTool.DataEntities.NetworkEntities;


namespace KanColleAutoTool.DataEntities.NetworkEntities
{
    public class RequestPostData : NetworkEntity
    {
        public HttpRequests RequestType { get; private set; }

        public string RequestString { get { return getRequestString(); } }

        protected abstract string getRequestString()
        {
            return "";
        }
    }
}
