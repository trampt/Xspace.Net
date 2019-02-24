<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="XSpace.Net.Web.Manager.Users.List" %>

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
       
 
  
         <uc1:header runat="server" ID="header"  CurModule="Users" />
    

<div class="main" style="border-bottom:0">
     
    <div class="container">
        <div class="widget widget-table action-table">
            <div class="widget-header">
                <i class="icon-th-list"></i>
                <h3>资讯分类</h3><a class="pull-right" style="margin-right:12px;" href="Add.aspx"><span class="glyphicon glyphicon-plus"></span></a>
            </div>
            <!-- /widget-header -->
            <div class="widget-content">
                <table class="table table-striped table-bordered table-responsive">
                    <thead>
                        <tr>
                            <th> ID </th>
                            <th> 名称 </th>
                            <th> 昵称 </th>
                            <th> 邮件 </th>
                            <th> 电话 </th>
                            <th class="hidden-xs hidden-sm"> 注册时间 </th>
                            <th class="hidden-xs hidden-sm"> 状态</th>
                            <th class="td-actions visible-xs"> &nbsp; </th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater runat="server" ID="RepList" OnItemCommand="RepList_ItemCommand">
                            <ItemTemplate>
                                <tr>
                                    <td><%#Eval("id") %></td>
                                    <td> <%#Eval("user_name") %> </td>
                                     <td> <%#Eval("nick_name") %> </td>
                                     <td> <%#Eval("email") %> </td>
                                     <td> <%#Eval("mobile") %> </td>
                                     <td class="hidden-xs hidden-sm"> <%#Eval("reg_time") %> </td>
                                     
                                    
                                    <td class="hidden-xs hidden-sm"> <%#Eval("status")!=null&&Eval("status").ToString()=="1"?"不可用":"可用" %> </td>
                                    <td class="td-actions"><a href="Edit.aspx?Id=<%#Eval("id") %>" class="btn btn-small btn-success"><i class="btn-icon-only icon-edit-sign"> </i></a>
                                        <asp:LinkButton  runat="server" ID="lblDelete" data-del="true" CommandName="delete" CommandArgument='<%#Eval("id")%>'  Text="<i class='btn-icon-only icon-remove'> </i>" CssClass="btn btn-danger btn-small"></asp:LinkButton>
                                       </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
 

                    </tbody>
                </table>
            </div>
            <!-- /widget-content -->
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
    <!-- /footer -->
    <!-- Le javascript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
         
    </form>

     <script src="https://cdn.staticfile.org/jquery/2.1.1/jquery.min.js"></script>
    <script type="text/javascript" src="../../Scripts/jquery.validate.js"></script>
    <script type="text/javascript" src="../../Contents/Scripts/Manager.js"></script>
    <script type="text/javascript" src="../../Contents/Bootstrap/js/bootstrap.js"></script>

     <!-- /Calendar -->
</body>
</html>
