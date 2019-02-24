<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="XSpace.Net.Web.Index1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Contents/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="Contents/Css/Index.css" rel="stylesheet" />
    
</head>
<body>
     
 

        <div class="container">
            <div class="row">
                <div class="col-md-5">
                    <a href="http://www.matools.com/">
                        <img src="Images/logo.png" alt="到码工具首页" title="到码工具首页" />
                    </a>
                </div>

                <div class="col-md-5 vertical_align">

                    <div class="input-group">

                        <input type="text" class="form-control" placeholder="关键词" aria-describedby="sizing-addon2">
                        <span class="input-group-btn">
                            <button class="btn btn-default" type="button">搜索</button>
                        </span>
                    </div>
                </div>
            </div>
    
    
    
        </div>


        <nav class="navbar navbar-default">
            <div class="container">
                <!-- Brand and toggle get grouped for better mobile display -->
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#topnavbar" aria-expanded="false">
                        <span class="sr-only">Toggle</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
            
                </div>

                <!-- Collect the nav links, forms, and other content for toggling -->
                <div class="collapse navbar-collapse" id="topnavbar">
                    <ul class="nav navbar-nav">
                        <li class="active">
                            <a href="http://www.matools.com/">首页</a>
                        </li>
                        <li>
                            <a href="#api">热门影视</a>
                        </li>
                        <li>
                            <a href="#blog">热门小说</a>
                        </li>
                        <li>
                            <a href="#page">稀缺PDF</a>
                        </li>
                        <li>
                            <a href="#software">好用软件</a>
                        </li>
                        <li>
                            <a href="#pic">PSD素材</a>
                        </li>
               

                    </ul>

                </div><!-- /.navbar-collapse -->
            </div><!-- /.container-fluid -->
        </nav>
    <div class="container">&nbsp;</div>
    <div class="container">
         <div class="left_box">
             <h1 class="nav_title">热门影视</h1>

             <ul class="media">
                 <li class="media_poster">
                     <a href="compare" style="color:black" target="_blank">
                            <img src="Images/movie.jpg" />
                     </a>
                 </li>
                 <li class="media_poster">
                     <a href="compare" style="color:black" target="_blank">
                         <img src="Images/movie.jpg" />
                     </a>
                     <a href="">去下载</a>
                 </li>
                 <li class="media_poster">
                    <a href="compare" style="color:black" target="_blank">
                        <img src="Images/movie.jpg" />
                    </a>
                </li><li class="media_poster">
                    <a href="compare" style="color:black" target="_blank">
                        <img src="Images/movie.jpg" />
                    </a>
                </li><li class="media_poster">
                    <a href="compare" style="color:black" target="_blank">
                        <img src="Images/movie.jpg" />
                    </a>
                </li><li class="media_poster">
                    <a href="compare" style="color:black" target="_blank">
                        <img src="Images/movie.jpg" />
                    </a>
                </li><li class="media_poster">
                    <a href="compare" style="color:black" target="_blank">
                        <img src="Images/movie.jpg" />
                    </a>
                </li><li class="media_poster">
                    <a href="compare" style="color:black" target="_blank">
                        <img src="Images/movie.jpg" />
                    </a>
                </li><li class="media_poster">
                    <a href="compare" style="color:black" target="_blank">
                        <img src="Images/movie.jpg" />
                    </a>
                </li><li class="media_poster">
                    <a href="compare" style="color:black" target="_blank">
                        <img src="Images/movie.jpg" />
                    </a>
                </li><li class="media_poster">
                    <a href="compare" style="color:black" target="_blank">
                        <img src="Images/movie.jpg" />
                    </a>
                </li>
             </ul>

         


         </div>
            <div class="right_sidebar">
                <span class="label label-warning">流浪地球</span>
                <span class="label label-info">无法无天</span>
                <span class="label label-info">原罪</span>
                <span class="label label-primary">杀不死</span>
                <span class="label label-info">流浪地球</span>
                <span class="label label-success">流浪地球</span>
                <span class="label label-info">流浪地球</span>
                <span class="label label-info">流浪地球</span>
            </div>
        </div>


    <script src="Scripts/jquery-1.10.2.js"></script>
    <script type="text/javascript" src="Contents/bootstrap/js/bootstrap.min.js"></script>

</body>
</html>
