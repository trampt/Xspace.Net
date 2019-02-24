<%@ Page Language="C#" AutoEventWireup="true"    Inherits="XSpace.Net.Web.upfile" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<title>图片预览效果</title>
<script src="Scripts/CJL.0.1.min.js"></script>
<script src="Scripts/ImagePreview.js"></script>
<script src="Scripts/jquery-1.5.js"></script>
<script type="text/javascript" src="Scripts/jquery.form.js"></script>
    
<style>
.perview {width:800px;background:#fff;font-size:12px; border-collapse:collapse; margin:auto; padding:auto;}
.perview td, .perview th {padding:5px;border:1px solid #ccc;}
.perview th {background-color:#f0f0f0; height:20px;}
.perview a:link, .perview a:visited, .perview a:hover, .perview a:active {color:#00F;}
.perview table{ width:100%;border-collapse:collapse;}
</style>
<SCRIPT>
    //清空File控件的值，并且预览处显示默认的图片
    function clearFileInput() {
        var form = document.createElement('form');
        document.body.appendChild(form);
        //记住file在旧表单中的的位置
        var file = document.getElementById("idFile");
        var pos = file.nextSibling;
        form.appendChild(file);
        form.reset();//通过reset来清空File控件的值
        document.getElementById("colspan").appendChild(file);
        document.body.removeChild(form);
        //在预览处显示图片 这是在浏览器支持滤镜的情况使用的
        document.getElementById("idImg").style.filter = "progid:DXImageTransform.Microsoft.AlphaImageLoader(sizingMethod='scale',src='upfiles/images/abshiu.jpg'";
        //这是是火狐里面显示默认图片的
        if (navigator.userAgent.indexOf('Firefox') >= 0) {
            $("#idImg").attr('src', 'upfiles/images/abshiu.jpg');
        }
    }
    function upLoadFile() {
         
        var options = {
            type: "POST",
            url: 'Tools/UploadImg.ashx',
            success: showResponse
        };

        // 将options传给ajaxForm
        $('#myForm').ajaxSubmit(options);

    }
    function showResponse(data) {
        alert(data);
    }
</SCRIPT>
</head>
<body>
<form id="myForm" runat="server">
    <table border="0" class="perview">
	    <tr>
			    <th width="45%">选择文件</th>
			    <th width="45%">预览图</th>
			    <th width="10%">上传图片</th>
		</tr>
	    <tr>
		    <td height="200"><span id="colspan"><input id="idFile" runat="server" name="pic" type="file"  /></span>&nbsp;&nbsp;&nbsp;&nbsp;<input type="button" id="resets" name="resets" value="还原" onclick="clearFileInput()" /></td>
		    <td align="center"><img id="idImg" src="upfiles/images/abshiu.jpg" /></td>
		    <td><input type="button" name="resets" value="上传保存图片" onclick="upLoadFile()" /></td>
	    </tr>
    </table>
    <script>

        var ip = new ImagePreview($$("idFile"), $$("idImg"), {
            maxWidth: 200, maxHeight: 200, action: "/Tools/ImagePreview.ashx"
        });
        ip.img.src = ImagePreview.TRANSPARENT;
        ip.file.onchange = function () { ip.preview(); };
        

    </script>
    </form>
</body>
</html>
