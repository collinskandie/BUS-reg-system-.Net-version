<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="usersignup.aspx.cs" Inherits="BUS_REG_WEB_APP.WebForm3" %>

<!DOCTYPE html>
<html>

<head>
    <meta charset="UTF-8">
    <title>User sign up</title>
    <link href="css/signupstyle.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

</head>

<body>
    <div class="container">
        <div class="title">Registration</div>
        <form id="usersignup" runat="server">
            <div class="user-details">
                <div class="input-box">
                    <span class="details">Full name</span>
                    <asp:TextBox ID="fullname" runat="server" placeholder="Full name" required="text"></asp:TextBox>
                </div>
                <div class="input-box">
                    <span class="details">IDnumber</span>
                    <asp:TextBox ID="IDnumber" runat="server" placeholder="Enter your ID number" required="text" ></asp:TextBox>
                </div>
                <div class="input-box">
                    <span class="details">Email</span>
                    <asp:TextBox ID="Email" runat="server" placeholder="Your Email" required="text" ></asp:TextBox>
                </div>
                <div class="input-box">
                    <span class="details">Phone number</span>
                    <asp:TextBox ID="phoneNumber" runat="server" placeholder="Phone Number" required="text" ></asp:TextBox>
                </div>
                <div class="input-box">
                    <span class="details">Password</span>
                    <asp:TextBox ID="Password" runat="server" placeholder="Your Password" required="Password" ></asp:TextBox>
                </div>
                <div class="input-box">
                    <span class="details">Confirm Password</span>
                   <asp:TextBox ID="confirmPass" runat="server" placeholder="Confirm Your Password" required="Password" ></asp:TextBox>
                </div>
            </div>           
            <div class="button">
                <asp:Button ID="submit" runat="server" Text="Register" /> 
            </div>
        </form>
        <div class="foot">
            <p>&copy Collins Kandie 2021.</p> 
        </div>     

    </div>

</body>

</html>

