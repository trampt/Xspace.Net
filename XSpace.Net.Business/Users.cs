using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace XSpace.Net.Business
{
    public class Users
    {
        


        public DataSet ListAll()
        {
            IDAL.IUsers channel = DBUtils.GetUserHandler();
            DataSet ds = channel.GetList("1=1");
            return ds;
        }

        public bool Delete(int id)
        {
            IDAL.IUsers channel = DBUtils.GetUserHandler();
            bool flag = channel.Delete(id);
            return flag;
        }

        public bool Exists(string name)
        {
            IDAL.IUsers channel = DBUtils.GetUserHandler();
            bool flag = channel.Exists(name);
            return flag;
        }
        public bool Exists(string name,int id)
        {
            IDAL.IUsers channel = DBUtils.GetUserHandler();
            bool flag = channel.Exists(name,id);
            return flag;
        }
        public int Add(XSpace.Net.Model.Users model)
        {
            IDAL.IUsers channel = DBUtils.GetUserHandler();
            int ret = channel.Add(model);
            return ret;
        }
        public Model.Users GetModel(int id)
        {
            IDAL.IUsers channel = DBUtils.GetUserHandler();
            Model.Users model = channel.GetModel(id);
            return model;
        }

        public bool Update(XSpace.Net.Model.Managers model)
        {
            IDAL.IManagers channel = DBUtils.GetManagerHandler();
            return channel.Update(model);
        }


    }
}
