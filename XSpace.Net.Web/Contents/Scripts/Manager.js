/*login page*/
$(document).ready(function () {
    
    $("#form_login").validate({
        rules: {
            txtUserName: "required",
            txtPassword: { required: true, minlength: 8 }
        },
        messages: {
            txtUserName: "请输入您的用户名",
            txtPassword: { required: "请输入您的密码", minlength: "密码长度必须大于8" }
        } ,
        errorPlacement: function (error, element) {
            //error.css('font-family', '华文隶书'); //设置字体的样式
            element.after(error)
        },
        errorClass: "validate-error"
   
    });

    jQuery.validator.addMethod("isPhone", function (value, element) {
        var length = value.length;
        var mobile = /^(((13[0-9]{1})|(15[0-9]{1})|(18[0-9]{1})|(17[0-9]{1}))+\d{8})$/;
        return this.optional(element) || (length == 11 && mobile.test(value));
    }, "请填写正确的手机号码");
     
        
    $("#form1").validate({
        rules: {
            txtUserName: "required",
            txtPhone:{isPhone:true}
            //txtPassword: { required: true, minlength: 8 }
        },
        messages: {
            txtUserName: "请输入您的用户名",
            txtPhone:"电话号码不正确"
           // txtPassword: { required: "请输入您的密码", minlength: "密码长度必须大于8" }
        },
        errorPlacement: function (error, element) {
            //error.css('font-family', '华文隶书'); //设置字体的样式
            element.after(error)
        },
        errorClass: "validate-error"

    });
 
});



$(document).ready(function () {
    $("a[data-del='true']").click(function () {
        if (confirm("确定删除吗?")) {
            return true;
        }
        return false;


    });
});
 
 

$.extend($.validator.messages, {
    required: "必填字段",
    remote: "请修正该字段",
    email: "请输入正确格式的电子邮件",
    url: "请输入合法的网址",
    date: "请输入合法的日期",
    dateISO: "请输入合法的日期 (ISO).",
    number: "请输入合法的数字",
    digits: "只能输入整数",
    creditcard: "请输入合法的信用卡号",
    equalTo: "请再次输入相同的值",
    accept: "请输入拥有合法后缀名的字符串",
    maxlength: $.validator.format("请输入一个长度最多是 {0} 的字符串"),
    minlength: $.validator.format("请输入一个长度最少是 {0} 的字符串"),
    rangelength: $.validator.format("请输入一个长度介于 {0} 和 {1} 之间的字符串"),
    range: $.validator.format("请输入一个介于 {0} 和 {1} 之间的值"),
    max: $.validator.format("请输入一个最大为 {0} 的值"),
    min: $.validator.format("请输入一个最小为 {0} 的值")
});
    