<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="XSpace.Net.Web.Manager.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../Contents/bootstrap/css/bootstrap.css" rel="stylesheet" />
 
    <link href="../Contents/Css/Login.css" rel="stylesheet" />
    <link href="../Contents/fontawesome/css/font-awesome.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form_login" runat="server"  class="login-form">
    <div>
    <div class="container">
            <div class="row">
            <div class="col-sm-8 col-sm-offset-2 text">
            <h1><strong></strong></h1>
            <div class="description">
           
            </div>
            </div>
            </div>
            <div class="row">
            <div class="col-sm-6 col-sm-offset-3 form-box">
            <div class="form-top">
            <div class="form-top-left">
            <h3>后台登录</h3>
            </div>
            <div class="form-top-right">
            <i class="fa fa-key"></i>
            </div>
            </div>
            <div class="form-bottom">
         
            <div class="form-group">
            <label class="sr-only" for="form-username">用户名</label>
                <asp:TextBox runat="server" ID="txtUserName" placeholder="Username..." CssClass="form-username form-control required"></asp:TextBox>
             
            </div>
            <div class="form-group">
                <label class="sr-only" for="form-password">密码</label>
                    <asp:TextBox runat="server" ID="txtPassword" TextMode="Password"  placeholder="Password..." CssClass="form-password form-control required" ></asp:TextBox>
            
                </div>
                    <asp:Button runat="server" ID="btnLogin"   CssClass="btn" Text="登录!" OnClientClick="" OnClick="btnLogin_Click"/>
                     <div><asp:Label runat="server" ID="lblHint" CssClass="validate-error"></asp:Label></div>


            </div>
           
            </div>
            </div>
            
            </div>
    </div>
    </form>



     <script type="text/javascript" src="../Contents/Assets/js/jquery-1.7.2.min.js"></script>   
   <%-- <script src="https://cdn.staticfile.org/jquery/2.1.1/jquery.min.js"></script>--%>
    <script type="text/javascript" src="../Scripts/jquery.validate.js"></script>
    <script type="text/javascript" src="../Contents/Scripts/Manager.js"></script>
    <script type="text/javascript" src="../Contents/Assets/js/bootstrap.js"></script>
</body>
</html>
