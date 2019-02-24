<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="XSpace.Net.Web.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript" src="Contents/Assets/js/jquery-1.7.2.min.js"></script>
   <%-- <script type="text/javascript" src="Scripts/jquery.form.js"></script>--%>
        <script src="Scripts/ajaxuploadfile.js" type="text/javascript"></script>
</head>
<body>

    <input type="file" id="file111" name="one-specific-file">
    <img src="" id="img111" />
    <button onclick="imageUpload()">上传</button>
    <script type="text/javascript">

        function imageUpload() {
            $.ajaxFileUpload({
                url: '/Tools/UploadImg.ashx', //用于文件上传的服务器端请求地址
                fileElementId: 'file111', //文件上传空间的id属性  <input type="file" id="file" name="file" />
                type: 'post',
                dataType: 'text', //返回值类型 一般设置为json
                success: function (data, status) //服务器成功响应处理函数
                {
                    $("#img111").attr("src", data);
                    alert(data);
                },
                error: function (data, status, e)//服务器响应失败处理函数
                {
                    alert("图片上传失败");
                }
            });
        }

    </script>
   
</body>
</html>
