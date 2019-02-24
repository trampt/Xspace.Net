<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="XSpace.Net.Web.Manager.Index" %>
<%@ Register src="header.ascx" tagname="header" tagprefix="uc1" %>
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
     
       

    
    

    <form id="form1" runat="server">
     
       

        <uc1:header ID="header1" runat="server"  CurModule="Control"/>
    

<div class="main" style="border-bottom:0">
     
    <div class="container">
        <div class="widget widget-table action-table">
            <div class="widget-header">
                <i class="icon-th-list"></i>
                <h3>资讯分类</h3><a class="pull-right" style="margin-right:12px;" href="/Admin/Channel/Add"><span class="glyphicon glyphicon-plus"></span></a>
            </div>
            <!-- /widget-header -->
            <div class="widget-content">
                <table class="table table-striped table-bordered table-responsive">
                    <thead>
                        <tr>
                            <th> ID </th>
                            <th> 分类代码 </th>
                            <th> 分类名称 </th>
                            <th class="hidden-xs hidden-sm"> 排序</th>
                            <th class="hidden-xs hidden-sm"> 状态</th>
                            <th class="td-actions visible-xs"> </th>
                        </tr>
                    </thead>
                    <tbody>
                            <tr>
                                <td>1</td>
                                <td> movies </td>
                                <td> 热门影视 </td>
                                <td class="hidden-xs hidden-sm"> 5 </td>
                                <td class="hidden-xs hidden-sm"> 可用 </td>
                                <td class="td-actions"><a href="/Admin/Channel/Edit/1" class="btn btn-small btn-success"><i class="btn-icon-only icon-edit-sign"> </i></a><a data-del="true" data-id="1" href="/Admin/Channel/Delete/1" class="btn btn-danger btn-small"><i class="btn-icon-only icon-remove"> </i></a></td>
                            </tr>
                            <tr>
                                <td>2</td>
                                <td> pdfshow </td>
                                <td> PDF资源 </td>
                                <td class="hidden-xs hidden-sm"> 2 </td>
                                <td class="hidden-xs hidden-sm"> 可用 </td>
                                <td class="td-actions"><a href="/Admin/Channel/Edit/2" class="btn btn-small btn-success"><i class="btn-icon-only icon-edit-sign"> </i></a><a data-del="true" data-id="2" href="/Admin/Channel/Delete/2" class="btn btn-danger btn-small"><i class="btn-icon-only icon-remove"> </i></a></td>
                            </tr>
                            <tr>
                                <td>1003</td>
                                <td> 111111 </td>
                                <td> 11111 </td>
                                <td class="hidden-xs hidden-sm"> 11 </td>
                                <td class="hidden-xs hidden-sm"> 可用 </td>
                                <td class="td-actions"><a href="/Admin/Channel/Edit/1003" class="btn btn-small btn-success"><i class="btn-icon-only icon-edit-sign"> </i></a><a data-del="true" data-id="1003" href="/Admin/Channel/Delete/1003" class="btn btn-danger btn-small"><i class="btn-icon-only icon-remove"> </i></a></td>
                            </tr>
                     
                       

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
     
     <script src="https://cdn.staticfile.org/jquery/2.1.1/jquery.min.js"></script>
    <script type="text/javascript" src="../Scripts/jquery.validate.js"></script>
    <script type="text/javascript" src="../Contents/Scripts/Manager.js"></script>
    <script type="text/javascript" src="../Contents/Bootstrap/js/bootstrap.js"></script>


    
 
   

   
   

     <!-- /Calendar -->
        
    </form>
</body>
</html>
