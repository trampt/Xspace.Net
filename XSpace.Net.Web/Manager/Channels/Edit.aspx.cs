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
                    else
                    {
                        Response.Redirect("List.aspx");
                    }
                }
            }
        }
        protected void InitData(int id)
        {
            XSpace.Net.Business.Channels bll = new Business.Channels();
            Model.Channels model= bll.GetModel(id);
            txtName.Text = model.name;
            txtTitle.Text = model.title;
            txtSort.Text = model.sort_id.ToString();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            XSpace.Net.Business.Channels bll = new Business.Channels();
            string name = txtName.Text.Trim();
            string title = txtTitle.Text.Trim();
            string sort_id = txtSort.Text.Trim();
            int islock = chkLock.Checked ? 1 : 0;
            int id = Convert.ToInt32(Request["id"]);
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(title))
            {
                if (!bll.Exists(id,name))
                {
                    //XSpace.Net.Model.Channels model = bll.GetModel(id);
                    XSpace.Net.Model.Channels model = new Model.Channels() { id=id, name = name, title = title, sort_id = Convert.ToInt32(sort_id), is_lock = islock };
                    bll.Update(model);
                    Response.Redirect("List.aspx");
                }
                else
                {
                    lblHint.Text = "该分类[" + name + "]代码已存在，请更换.";
                }
            }
            else
            {
                lblHint.Text = "该分类名称和分类代码均不能为空，请检查.";
            }
        }
    }
}