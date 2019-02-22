using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XSpace.Net.Web.Manager.Managers
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            XSpace.Net.Business.Managers bll = new Business.Managers();
            string name = txtName.Text.Trim();
            XSpace.Net.Model.Managers model = new Model.Managers();
            model.user_name = name;
            model.password = XSpace.Net.Utils.MD5Encrypt.MD5Encoding(txtPassword.Text);
            model.email = txtEmail.Text;
            int islock = chkLock.Checked ? 1 : 0;
            model.is_lock = islock;
            if (!string.IsNullOrEmpty(name))
            {
                if (!bll.Exists(name))
                {
                    bll.Add(model);
                    
                    Response.Redirect("List.aspx");
                }
                else
                {
                    lblHint.Text = "该管理员[" + name + "]代码已存在，请更换.";
                }
            }
            else {
                lblHint.Text = "管理员不能为空，请检查.";
            }
        }
    }
}