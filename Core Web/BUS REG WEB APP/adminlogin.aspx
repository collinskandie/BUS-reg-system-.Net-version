<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="BUS_REG_WEB_APP.WebForm2" %>

<!DOCTYPE html>
<html>

<head>
    <title>Admin Login Page</title>
    <link href="css/loginstyle.css" rel="stylesheet" />
    
</head>
<body>
    <img src="img/scania.jpg" />
    <div class="loginbox">
        <img src="img/avatar.png" class="avatar">
        <h2>Admin Login Here</h2>
        <form id="adminlogin" runat="server">
        <p>Username</p>
        <asp:TextBox ID="Username" runat="server"  placeholder="Username"></asp:TextBox> 
            <br />
            <p>Password</p> 
        <asp:TextBox ID="Password" runat="server" type="password"  placeholder="Password"></asp:TextBox><br>
        <br>
        <asp:Button ID="login" runat="server" Text="Login" OnClick="login_Click" /> <br>
            <br>
            <a href="index.aspx"><<.back to home page</a> <br>
        <a href="userlogin.aspx">Regular user Login</a>

        </form>

    </div> 


</body>

</html>
