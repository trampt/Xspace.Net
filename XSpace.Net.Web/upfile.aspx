<%@ Page Language="C#" AutoEventWireup="true"    Inherits="XSpace.Net.Web.upfile" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<title>ͼƬԤ��Ч��</title>
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
    //���File�ؼ���ֵ������Ԥ������ʾĬ�ϵ�ͼƬ
    function clearFileInput() {
        var form = document.createElement('form');
        document.body.appendChild(form);
        //��סfile�ھɱ��еĵ�λ��
        var file = document.getElementById("idFile");
        var pos = file.nextSibling;
        form.appendChild(file);
        form.reset();//ͨ��reset�����File�ؼ���ֵ
        document.getElementById("colspan").appendChild(file);
        document.body.removeChild(form);
        //��Ԥ������ʾͼƬ �����������֧���˾������ʹ�õ�
        document.getElementById("idImg").style.filter = "progid:DXImageTransform.Microsoft.AlphaImageLoader(sizingMethod='scale',src='upfiles/images/abshiu.jpg'";
        //�����ǻ��������ʾĬ��ͼƬ��
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

        // ��options����ajaxForm
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
			    <th width="45%">ѡ���ļ�</th>
			    <th width="45%">Ԥ��ͼ</th>
			    <th width="10%">�ϴ�ͼƬ</th>
		</tr>
	    <tr>
		    <td height="200"><span id="colspan"><input id="idFile" runat="server" name="pic" type="file"  /></span>&nbsp;&nbsp;&nbsp;&nbsp;<input type="button" id="resets" name="resets" value="��ԭ" onclick="clearFileInput()" /></td>
		    <td align="center"><img id="idImg" src="upfiles/images/abshiu.jpg" /></td>
		    <td><input type="button" name="resets" value="�ϴ�����ͼƬ" onclick="upLoadFile()" /></td>
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
