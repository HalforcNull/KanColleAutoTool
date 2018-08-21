using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanColleAutoTool.UserAgents.Operations
{
    class Operation
    {
        protected virtual void checkData()
        {
            return;
        }

        protected abstract void startExecute()
        {
            return;
        }

        protected virtual void queueNewOperation(UserAgent _user)
        {

        }

        public void Start(UserAgent _user)
        {
            checkData();
            startExecute();
            queueNewOperation(_user);
        }
    }
}
