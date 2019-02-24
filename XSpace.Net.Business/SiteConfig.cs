using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace XSpace.Net.Business
{
    public class SiteConfig
    {
        public Model.SiteConfig GetConfig(string xml)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(xml);
            Model.SiteConfig model = new Model.SiteConfig();
            DataTable dt= ds.Tables["site"];
            if (dt.Rows.Count > 0)
            {
                model.Name = dt.Rows[0]["name"].ToString();
                model.Url = dt.Rows[0]["url"].ToString();
                model.Keyword = dt.Rows[0]["keyword"].ToString();
            }
            return model;
        }
        public bool SetConfig(string xml,Model.SiteConfig model)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(xml);
         
            DataTable dt = ds.Tables["site"];
            if (dt.Rows.Count > 0)
            {
                dt.Rows[0]["name"] = model.Name;
                dt.Rows[0]["url"] = model.Url;
                dt.Rows[0]["keyword"] = model.Keyword;
            }

            ds.WriteXml(xml);
            return true;
        }
    }
}
