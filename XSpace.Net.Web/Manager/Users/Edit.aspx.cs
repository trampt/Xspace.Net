using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XSpace.Net.Web.Manager.Users
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
            XSpace.Net.Business.Users bll = new Business.Users();
            Model.Users model= bll.GetModel(id);
            txtName.Text = model.user_name;
            //txtPassword.Text = model.password;
            //txtConPassword.Text = model.password;
            txtEmail.Text = model.email;
            chkLock.Checked = model.status == 0 ? false : true;
            txtPhone.Text = model.mobile;
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            XSpace.Net.Business.Users bll = new Business.Users();
            string name = txtName.Text.Trim();
            Model.Users model = bll.GetModel( Convert.ToInt32(Request["id"]));
          
            model.user_name = name;
            if (txtPassword.Text != "")
            {
                model.password = XSpace.Net.Utils.MD5Encrypt.MD5Encoding(txtPassword.Text);
            }
            model.email = txtEmail.Text;
            int islock = chkLock.Checked ? 1 : 0;
            model.status = islock;
            model.mobile = txtPhone.Text;

            if (!string.IsNullOrEmpty(name))
            {
                if (!bll.Exists(name,Convert.ToInt32(Request["id"])))
                {
                    bll.Update(model);

                    Response.Redirect("List.aspx");
                }
                else
                {
                    lblHint.Text = "该用户[" + name + "]已存在，请更换.";
                }
            }
            else
            {
                lblHint.Text = "用户名不能为空，请检查.";
            }
        }
    }
}