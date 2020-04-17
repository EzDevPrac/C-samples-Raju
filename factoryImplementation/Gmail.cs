using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Gmail:IObject
    {
        public string emailId;
        public string name;
        public Int32 phoneNo;


        public virtual string GetInfo()
        {
            return string.Format("Emailid is {0}.Name of sender is {1}. Phone number of the sender is {2}.", emailId, name, phoneNo);
        }
    }
}
