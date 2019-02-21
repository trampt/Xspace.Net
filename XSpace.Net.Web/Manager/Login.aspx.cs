using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XSpace.Net.Web.Manager
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            XSpace.Net.Business.Managers bm = new Business.Managers();
            if (bm.Login(txtUserName.Text.Trim(), txtPassword.Text))
            {
                Response.Redirect("Index.aspx");
            }
            else {
                txtPassword.Text = "";
                txtUserName.Text = "";
                lblHint.Text = "<i class=\"fa fa-exclamation-triangle\"></i> &nbsp;登录失败，请重试...";
                //Page.ClientScript.RegisterStartupScript(this.GetType(), "loginhint", "<script>$('#myModal').modal('show');</script>");
                
            }
        }
    }
}