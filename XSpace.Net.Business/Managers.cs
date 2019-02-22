using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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


        public DataSet ListAll()
        {
            IDAL.IManagers channel = DBUtils.GetManagerHandler();
            DataSet ds = channel.GetList("1=1");
            return ds;
        }

        public bool Delete(int id)
        {
            IDAL.IManagers channel = DBUtils.GetManagerHandler();
            bool flag = channel.Delete(id);
            return flag;
        }

        public bool Exists(string name)
        {
            IDAL.IManagers channel = DBUtils.GetManagerHandler();
            bool flag = channel.Exists(name);
            return flag;
        }
        public bool Exists(string name,int id)
        {
            IDAL.IManagers channel = DBUtils.GetManagerHandler();
            bool flag = channel.Exists(name,id);
            return flag;
        }
        public int Add(XSpace.Net.Model.Managers model)
        {
            IDAL.IManagers channel = DBUtils.GetManagerHandler();
            int ret = channel.Add(model);
            return ret;
        }
        public Model.Managers GetModel(int id)
        {
            IDAL.IManagers channel = DBUtils.GetManagerHandler();
            Model.Managers model = channel.GetModel(id);
            return model;
        }

        public bool Update(XSpace.Net.Model.Managers model)
        {
            IDAL.IManagers channel = DBUtils.GetManagerHandler();
            return channel.Update(model);
        }


    }
}
