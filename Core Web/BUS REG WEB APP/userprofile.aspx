<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userprofile.aspx.cs" Inherits="BUS_REG_WEB_APP.WebForm4" %>

<!DOCTYPE html>
<html>

<head>
    <meta charset="UTF-8">
    <title>User Profile</title>
    <link href="css/userprofilestyle.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

</head>

<body>
    
    <div class="container">
        <form id="profile" runat="server">
        <div class="title">
            <centre>
                <h2>Your Profile</h2>
            <span>Account status -</span>
                <asp:Label ID="status" runat="server" Text="Label"></asp:Label>
            </centre>
           
        </div>
        
            <div class="user-details">
                <div class="input-box">
                    <span class="details">Full name</span>
                    <asp:TextBox ID="fullname" runat="server" placeholder="Full name" required="text"></asp:TextBox>
                </div>
                <div class="input-box">
                    <span class="details">IDnumber</span>
                    <asp:TextBox ID="IDnumber" runat="server" placeholder="Enter your ID number" required="text" ReadOnly="True" ></asp:TextBox>
                </div>
                <div class="input-box">
                    <span class="details">Email</span>
                    <asp:TextBox ID="Email" runat="server" placeholder="Your Email" required="text" ReadOnly="True" ></asp:TextBox>
                </div>
                <div class="input-box">
                    <span class="details">Phone number</span>
                    <asp:TextBox ID="phoneNumber" runat="server" placeholder="Phone Number" required="text" ></asp:TextBox>
                </div>
                <div class="input-box">
                    <span class="details">Password</span>
                    <asp:TextBox ID="Password" runat="server" placeholder="Your Password" required="Password" ReadOnly="True" ></asp:TextBox>
                </div>
                <div class="input-box">
                    <span class="details">New Password</span>
                   <asp:TextBox ID="newPass" runat="server" placeholder="New Password" required="Password" ></asp:TextBox>
                </div>
            </div>           
            <div class="button">
                <asp:Button ID="submit" runat="server" Text="Update" /> 
            </div>
            <a href="uservehicles.aspx">Check My vehicles</a> <br>
        
    </form>
       
        <div class="foot">
            <p>&copy Collins Kandie 2021.</p> 
        </div>     

    </div>        
   

</body>

</html>


