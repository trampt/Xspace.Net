﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="XSpace.Net.Web.Manager.Channels.Edit" %>

<%@ Register Src="~/Manager/header.ascx" TagPrefix="uc1" TagName="header" %>


<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <title>云享资源-后台管理</title>
<meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no">
<meta name="apple-mobile-web-app-capable" content="yes">
<link href="/Contents/bootstrap/css/bootstrap.min.css" rel="stylesheet">
<link href="http://fonts.googleapis.com/css?family=Open+Sans:400italic,600italic,400,600"
        rel="stylesheet">
<link href="/Contents/Assets/css/font-awesome.css" rel="stylesheet">

<link href="/Contents/Assets/css/pages/dashboard.css" rel="stylesheet">
    <link href="/Contents/Css/ManagerIndex.css" rel="stylesheet">

     
<!-- Le HTML5 shim, for IE6-8 support of HTML5 elements -->
<!--[if lt IE 9]>
      <script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
    <![endif]-->
</head>
<body>
     
       <form runat="server" id="form1">
 

  
           <uc1:header runat="server" ID="header" CurModule="Resources"/>
    

<div class="main" style="border-bottom:0">
    <div class="container">
        <div class="panel panel-success">
            <div class="panel-heading">
                编辑资讯分类
            </div>
            
                <div class="panel-body">
                    <div class="form-group">
                        <label for="channelcode">分类代码</label>
                        <input type="hidden" id="channelid" name="channelid"  />
                        <asp:TextBox runat="server" ID="txtName" CssClass="form-control required"  placeholder="code" maxlength="20" minlength="5"></asp:TextBox>
                        

                    </div>
                    <div class="form-group">
                        <label for="channeltitle">分类名称</label>
                         <asp:TextBox runat="server" ID="txtTitle" CssClass="form-control required"  placeholder="title" maxlength="50" minlength="1"></asp:TextBox>
                        
                        
                       
                    </div>
                    <div class="form-group">
                        <label for="channelsort">分类排序</label>

                         <asp:TextBox runat="server" ID="txtSort" CssClass="form-control required number"  placeholder="1" ></asp:TextBox>
                        
                       
                    </div>
                    <div class="form-group">
                        <label for="channellock">是否关闭</label>
                        
                        <div class="switch">
                            <asp:CheckBox runat="server" ID="chkLock" CssClass="" />
                           
                        </div>
 
                         
                    </div>
                    <asp:Button runat="server" CssClass="btn btn-default" ID="btnEdit" Text="编辑" OnClick="btnEdit_Click" />
                 
                </div>
                 <div class="footer">
                    <asp:Label runat="server" ID="lblHint" CssClass="label label-danger" ></asp:Label>
                </div>
                
          
        </div>

    </div>
    </div>


 
   
    <nav class="navbar navbar-default navbar-fixed-bottom">
      
            <div class="container text-center" style="margin-top:15px;">
                 
                    &copy; 2020 <a href="http://www.rcolud.com/">后台管理</a>
                    <!-- /span12 -->
                
                <!-- /row -->
            </div>
            <!-- /container -->
        
        <!-- /footer-inner -->
    </nav>

           </form>
    <!-- /footer -->
    <!-- Le javascript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
     
     <script src="https://cdn.staticfile.org/jquery/2.1.1/jquery.min.js"></script>
    <script type="text/javascript" src="../../Scripts/jquery.validate.js"></script>
    <script type="text/javascript" src="../../Contents/Scripts/Manager.js"></script>
    <script type="text/javascript" src="../../Contents/Bootstrap/js/bootstrap.js"></script>

     <!-- /Calendar -->
</body>
</html>
