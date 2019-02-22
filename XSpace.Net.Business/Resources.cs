using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace XSpace.Net.Business
{
    public class Resources
    {
        public DataSet ListAll()
        {
            IDAL.IResources handler = DBUtils.GetResourceHandler();
            DataSet ds = handler.GetList("1=1");
          return ds;
        }

        public bool Delete(int id)
        {
            IDAL.IResources handler = DBUtils.GetResourceHandler();
            bool flag = handler.Delete(id);
            return flag;
        }

        public bool Exists(string title)
        {
            IDAL.IResources handler = DBUtils.GetResourceHandler();
            bool flag = handler.Exists(title);
            return flag;
        }
        
        public int Add(XSpace.Net.Model.Resources model)
        {
            IDAL.IResources handler = DBUtils.GetResourceHandler();
            int ret = handler.Add(model);
            return ret; 
        }
        public Model.Resources GetModel(int id)
        {
            IDAL.IResources handler = DBUtils.GetResourceHandler();
            Model.Resources model = handler.GetModel(id);
           return model;
        }

        public bool Update(XSpace.Net.Model.Resources model)
        {
            IDAL.IResources handler = DBUtils.GetResourceHandler();
            return handler.Update(model);
        }

        public DataSet GetListByPage(int pageSize, int pageIndex,  out int pageCount,string strWhere="1=1", string orderBy="id")
        {
            IDAL.IResources handler = DBUtils.GetResourceHandler();
            return handler.GetListByPage(pageSize, pageIndex, out pageCount);
        }
    }
}
