<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userlogin.aspx.cs" Inherits="BUS_REG_WEB_APP.WebForm1" %>

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
        <h2>User Login Here</h2>
        <form id="form1" runat="server">
        <p>Username</p> <br>
        <asp:TextBox ID="username" runat="server" input="text" placeholder="Username"></asp:TextBox> <br>
        <p>Password</p> <br>
        <asp:TextBox ID="password" runat="server" input="password" placeholder="Password"></asp:TextBox><br>
        <br>
        <button>Login</button> <br>
          <a href="#">Forgot Password?</a><br>
         <a href="*">New user</a><br>
         <a href="adminlogin.aspx">Admin Login</a><br>
             </form>

    </div>


    


</body>

</html>
