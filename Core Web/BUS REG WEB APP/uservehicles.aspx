<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="uservehicles.aspx.cs" Inherits="BUS_REG_WEB_APP.uservehicles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User vehicles</title>
      <link href="css/userprofilestyle.css" rel="stylesheet" />
    
</head>
<body>
    
        <div class="container">
        <div class="title">
            <centre>
                <h2>Buses you Own</h2>
            <span>list of buses -</span>
                <asp:Label ID="Label1" runat="server" Text="owned"></asp:Label>
            </centre> 
            </div>
        <form id="myvehicles" runat="server">
        <div class="row">
            <div class="col">
                <asp:GridView ID="carlist" runat="server" CssClass="table"></asp:GridView>
            </div>
        </div>
        </form>
        <div class="foot">
            <center>
                 <p>&copy Collins Kandie 2021.</p>
            </center>            
         </div>
        </div>
   
</body>
</html>
