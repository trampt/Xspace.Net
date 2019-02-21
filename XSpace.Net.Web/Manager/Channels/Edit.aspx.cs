using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XSpace.Net.Web.Manager.Channels
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(Request["id"]))
                { 
                int id;
                bool flag = int.TryParse(Request["id"], out id);
                if (flag)
                {
                    InitData(id);
                }
                else {
                    Response.Redirect("List.aspx");
                }
                }
            }
        }
        protected void InitData(int id)
        { 
            
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            XSpace.Net.Business.Channels bll=new Business.Channels();
            string name = Request["name"];
            string title = Request["title"];
            string sort_id = Request["sort_id"];
            string islock=Request["channellock"];
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(title))
            {
                if (!bll.Exists(name))
                {
                    XSpace.Net.Model.Channels model = new Model.Channels() { name = name, title = title, sort_id = Convert.ToInt32(sort_id), is_lock = islock == "true" ? 1 : 0 };
                    bll.Add(model);
                    Response.Redirect("List.aspx");
                }
                else
                {
                    lblHint.Text = "该分类[" + name + "]代码已存在，请更换.";
                }
            }
            else {
                lblHint.Text = "该分类名称和分类代码均不能为空，请检查.";
            }
        }
    }
}