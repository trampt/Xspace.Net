using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XSpace.Net.Web.Manager.Managers
{
    public partial class List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { InitBind(); }
        }
        protected void InitBind()
        {
            XSpace.Net.Business.Managers dal = new Business.Managers();
            RepList.DataSource= dal.ListAll().Tables[0];
            RepList.DataBind();
            
        }

        protected void RepList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
          
            if (e.CommandName == "delete")
            {

                int id =Convert.ToInt32( e.CommandArgument.ToString());
                XSpace.Net.Business.Managers dal = new Business.Managers();
                if (dal.Delete(id))
                {
                    InitBind();
                }
                else { }
            }
        }

      
    }
}