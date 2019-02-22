using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XSpace.Net.Web.Manager.Users
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            XSpace.Net.Business.Users bll = new Business.Users();
            string name = txtName.Text.Trim();
            XSpace.Net.Model.Users model = new Model.Users();
            model.user_name = name;
            model.password = XSpace.Net.Utils.MD5Encrypt.MD5Encoding(txtPassword.Text);
            model.email = txtEmail.Text;
            int islock = chkLock.Checked ? 1 : 0;
            model.status = islock;
            if (!string.IsNullOrEmpty(name))
            {
                if (!bll.Exists(name))
                {
                    bll.Add(model);
                    
                    Response.Redirect("List.aspx");
                }
                else
                {
                    lblHint.Text = "该用户[" + name + "]代码已存在，请更换.";
                }
            }
            else {
                lblHint.Text = "用户名不能为空，请检查.";
            }
        }
    }
}