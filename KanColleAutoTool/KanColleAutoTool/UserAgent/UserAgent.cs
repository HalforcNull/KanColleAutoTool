using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanColleAutoTool.Operations
{
    class UserAgent
    {
        public UserAgent(string _api, string _ip, string _startTime)
        {
            ApiToken = _api;
            Ip = _ip;
            StartTime = _startTime;
        }

        #region prop
        public string ApiToken { get; private set; }
        public string Ip { get; private set; }
        public string StartTime { get; private set; }
        //private List<Action> ActionsList { get; set; }

        #endregion

        #region public method
        public void act(Action _Action)
        {
            throw new NotImplementedException();
        }

        public void 

        #endregion

    }
}
