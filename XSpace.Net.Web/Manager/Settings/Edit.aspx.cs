using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
namespace XSpace.Net.Web.Manager.Settings
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitData(); 
            }
        }
        protected void InitData( )
        {
            string path = Server.MapPath("~/Config/site.xml");
            Model.SiteConfig model = new Business.SiteConfig().GetConfig(path);
            txtName.Text = model.Name;
            txtKeyword.Text = model.Keyword;
            txtUrl.Text = model.Url;
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            string path = Server.MapPath("~/Config/site.xml");
            Model.SiteConfig model = new Model.SiteConfig();
            model.Name = txtName.Text;
            model.Keyword = txtKeyword.Text;

            model.Url= txtUrl.Text ;
            new Business.SiteConfig().SetConfig(path,model);
        }
    }
}