using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace XSpace.Net.Business
{
    public class Channels
    {
        public DataSet ListAll()
        {
            IDAL.IChannels channel = DBUtils.GetChannelHandler();
          DataSet ds= channel.GetList("1=1");
          return ds;
        }

        public bool Delete(int id)
        {
            IDAL.IChannels channel = DBUtils.GetChannelHandler();
            bool flag = channel.Delete(id);
            return flag;
        }

        public bool Exists(string name)
        {
            IDAL.IChannels channel = DBUtils.GetChannelHandler();
            bool flag = channel.Exists(name);
            return flag;
        }
        public bool Exists(int id,string name)
        {
            IDAL.IChannels channel = DBUtils.GetChannelHandler();
            bool flag = channel.Exists(id,name);
            return flag;
        }
        public int Add(XSpace.Net.Model.Channels model)
        {
            IDAL.IChannels channel = DBUtils.GetChannelHandler();
            int ret = channel.Add(model);
            return ret; 
        }
        public Model.Channels GetModel(int id)
        {
            IDAL.IChannels channel = DBUtils.GetChannelHandler();
           Model.Channels model = channel.GetModel(id);
           return model;
        }

        public bool Update(XSpace.Net.Model.Channels model)
        {
            IDAL.IChannels channel = DBUtils.GetChannelHandler();
            return channel.Update(model);
        }
    }
}
