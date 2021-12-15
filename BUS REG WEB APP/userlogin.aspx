<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userlogin.aspx.cs" Inherits="BUS_REG_WEB_APP.WebForm1" %>

<!DOCTYPE html>
<html>

<head>
    <title>User Login Page</title>
    <link href="css/loginstyle.css" rel="stylesheet" />
    
</head>
<body>
    <img src="img/scania.jpg" />
    
    <div class="loginbox">
        <img src="img/avatar.png" class="avatar">
        <h2>User Login Here</h2>
        <form id="userlogin" runat="server">
        <p>Username or email address</p>
        <asp:TextBox ID="uemail" runat="server" input="text" placeholder="Username or email"></asp:TextBox> <br>
        <p>Password</p>          
        <asp:TextBox ID="password" runat="server" type="password" placeholder="Password"></asp:TextBox><br>
        <asp:Button ID="login" runat="server" Text="Login" OnClick="login_Click" />
        <a href="usersignup.aspx"><input id="SignUp" type="button" value="Sign up" /></a>
           <asp:LinkButton ID="forgotpass" runat="server">Forgot Password?</asp:LinkButton><br>
           <a href="index.aspx"><<.back to home page</a> <br>
            <a href="adminlogin.aspx">Admin Login</a>
             </form>

    </div>


    


</body>

</html>
