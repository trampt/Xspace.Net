<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="XSpace.Net.Web.Manager.Channels.Add" %>

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
<nav class="navbar navbar-default navbar-fixed-top">
    <div class="container">
        <!-- Brand and toggle get grouped for better mobile display -->
        <div class="navbar-header">
           
            <a class="navbar-brand" href="#">云享资源后台</a>
        </div>

        <!-- Collect the nav links, forms, and other content for toggling -->
            <!-- /.navbar-collapse -->
    </div><!-- /.container-fluid -->
</nav>
            <!-- /container -->
 
        <!-- /navbar-inner -->
 
    <!-- /navbar -->
    <div class="subnavbar">
        <div class="subnavbar-inner">
            <div class="container">
                <ul class="mainnav">
                    <li class="active"><a href="/Manager/Index.aspx"><i class="icon-dashboard"></i><span>控制中心</span> </a> </li>
                    <li><a href="/Admin/System/Index.aspx"><i class="icon-list-alt"></i><span>系统管理</span> </a> </li>
                    <li><a href="/Admin/Users/Index.aspx"><i class="icon-facetime-video"></i><span>用户管理</span> </a></li>
                    <li class="dropdown">
                        <a href="/Admin/Channel/Index.aspx" class="dropdown-toggle" data-toggle="dropdown"> <i class="icon-apple"></i><span>资讯管理</span> <b class="caret"></b></a>
                        <ul class="dropdown-menu">
                            <li><a href="/Admin/Channel/Index.aspx">资讯分类</a></li>
                            <li><a href="/Admin/Resources/Index.aspx">资讯管理</a></li>

                        </ul>
                    </li>
                    <li><a href="/Admin/Orders/Index.aspx"><i class="icon-android"></i><span>用户订单</span> </a></li>

                    <li><a href="/Admin/Settings/Index.aspx"><i class="icon-code"></i><span>设置</span> </a> </li>
                </ul>
            </div>
            <!-- /container -->
        </div>
        <!-- /subnavbar-inner -->
    </div>

  

    

<div class="main" style="border-bottom:0">
    <div class="container">
        <div class="panel panel-success">
            <div class="panel-heading">
                添加资讯分类
            </div>
            
                <div class="panel-body">
                    <div class="form-group">
                        <label for="channelcode">分类代码</label>
                        <input type="hidden" id="channelid" name="channelid"  />
                        <asp:TextBox runat="server" ID="txtName" CssClass="form-control required"  placeholder="code" maxlength="20" minlength="5"></asp:TextBox>
                        

                    </div>
                    <div class="form-group">
                        <label for="channeltitle">分类名称</label>
                         <asp:TextBox runat="server" ID="txtTitle" CssClass="form-control required"  placeholder="title" maxlength="50" minlength="5"></asp:TextBox>
                        
                        
                       
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
                    <asp:Button runat="server" CssClass="btn btn-default" ID="btnAdd" Text="添加" OnClick="btnAdd_Click" />
                 
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
