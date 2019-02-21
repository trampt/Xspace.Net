using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XSpace.Net.Web.Manager.Channels
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            XSpace.Net.Business.Channels bll=new Business.Channels();
            string name = txtName.Text.Trim();
            string title = txtTitle.Text.Trim();
            string sort_id = txtSort.Text.Trim();
            int islock = chkLock.Checked ? 1 : 0;
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(title))
            {
                if (!bll.Exists(name))
                {
                    XSpace.Net.Model.Channels model = new Model.Channels() { name = name, title = title, sort_id = Convert.ToInt32(sort_id), is_lock=islock };
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