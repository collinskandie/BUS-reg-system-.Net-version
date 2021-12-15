<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="alldriversaspx.aspx.cs" Inherits="BUS_REG_WEB_APP.alldriversaspx" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Drivers list</title>
    <link href='https://unpkg.com/boxicons@2.1.0/css/boxicons.min.css' rel='stylesheet'>
    <link rel="stylesheet" href="css/pagecss.css">
    <link href="datatables/css/jquery.dataTables.min.css" rel="stylesheet" />
    <link rel=" stylesheet " href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css " integrity="sha512-Fo3rlrZj/k7ujTnHg4CGR2D7kSs0v4LLanw2qksYuRlEzO+tcaEPQogQ0KaoGN26/zrn20ImR1DfuLWnOo7aBA==" crossorigin="
        anonymous " referrerpolicy="no-referrer " />
</head>

<body>
    <form runat="server">
    <div class="sidebar">
        <div class="logo_content">
            <div class="logo">
                <i class='bx bx-bus'></i>
                <div class="logo_name">BUS REG</div>
            </div>
        </div>
        <i class='bx bx-menu' id="btn"></i>
        <ul class="nav_list">
            <li>
                <a href="index.aspx">
                    <i class='bx bx-grid-alt'></i>
                    <span class="link_name">Home</span>
                </a>
            </li>
            <li>
                <a href="Vehiclesinventory.aspx">
                    <i class='bx bxs-bus-school'></i>
                    <span class="link_name">All Buses</span>
                </a>
            </li>
            <li>
                <a href="alldriversaspx.aspx">
                    <i class="fas fa-users"></i>
                    <span class="link_name">All Drivers</span>
                </a>
            </li>
            <li>
                <a href="allsaccos.aspx">
                    <i class="fas fa-star"></i>
                    <span class="link_name">Registered Saccos</span>
                </a>
            </li>
             <li>
                <a href="allroutes.aspx">
                    <i class="far fa-user"></i>
                    <span class="link_name">Registred Routes</span>
                </a>
            </li>
             <li>
                <a href="allusers.aspx">
                    <i class="far fa-user"></i>
                    <span class="link_name">Users</span>
                </a>
            </li>
        </ul>
        <div class="profile-content">
           <span><i class="fas fa-sign-out-alt" id="log_out"></i>
              <asp:LinkButton ID="LogOut" runat="server" OnClick="login_Click" >Log Out</asp:LinkButton></span>

        </div>


    </div>
    <div class="main_section">
        <div class="page_header">
            <h1>All Drivers</h1>
            <p>List of drivers registred on the system</p>
        </div>
        <hr>
        <div class="page_content">
            <div>
            <h3>Driver registration Form</h3>
            <hr> 
            Drivers ID <br />
            <asp:TextBox ID="driversID" runat="server"></asp:TextBox><br />
            Full Name<br />
            <asp:TextBox ID="Fullname" runat="server"></asp:TextBox><br />
            Drivers Email Address<br>
            <asp:TextBox ID="email" runat="server"></asp:TextBox><br />
            Phone<br>
            <asp:TextBox ID="phone" runat="server"></asp:TextBox><br /> 
              <asp:Button ID="Save" runat="server" Text="Save" OnClick="Save_Click" />
             </div>
            <div class="gridview">
                <h3>Drivers Available in the system</h3>
                <p>
                    <asp:GridView ID="all_drivers" runat="server" AutoGenerateColumns="False" DataKeyNames="DriverID" OnRowEditing="all_drivers_RowEditing" OnRowUpdated="all_drivers_RowUpdated" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" >
                        <AlternatingRowStyle BackColor="#CCCCCC" />
                        <Columns>
                            <asp:TemplateField HeaderText="Driver Id">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("DriverID") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("DriverID") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="DriverFullName" HeaderText="Driver Name"></asp:BoundField>
                            <asp:BoundField DataField="DriverEmail" HeaderText="Email"></asp:BoundField>
                            <asp:BoundField DataField="DriverPhone" HeaderText="Phone Number"></asp:BoundField>
                            <asp:CommandField ButtonType="Button" ShowEditButton="True"></asp:CommandField>
                        </Columns>
                            
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                            
                    </asp:GridView>
                </p>
                
            </div>
        </div>
    </div>
   </form>
    <script src="js/first.js">
 