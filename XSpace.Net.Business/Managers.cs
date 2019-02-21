using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XSpace.Net.Business
{
    public class Managers
    {
        public bool Login(string uname, string pwd)
        {
            IDAL.IManagers manager = DBUtils.GetManagerHandler();
            bool isExists = manager.Exists(uname, XSpace.Net.Utils.MD5Encrypt.MD5Encoding(pwd));
            return isExists;
        }
    }
}
