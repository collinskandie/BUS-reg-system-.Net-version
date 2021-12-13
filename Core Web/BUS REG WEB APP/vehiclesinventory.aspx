﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vehiclesinventory.aspx.cs" Inherits="BUS_REG_WEB_APP.vehiclesinventory" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Buses List</title>
    <link href='https://unpkg.com/boxicons@2.1.0/css/boxicons.min.css' rel='stylesheet'>
    <link rel="stylesheet" href="css/pagecss.css">
    <link href="datatables/css/jquery.dataTables.min.css" rel="stylesheet" />
    <link rel=" stylesheet " href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css " integrity="sha512-Fo3rlrZj/k7ujTnHg4CGR2D7kSs0v4LLanw2qksYuRlEzO+tcaEPQogQ0KaoGN26/zrn20ImR1DfuLWnOo7aBA==" crossorigin="
        anonymous " referrerpolicy="no-referrer " />
</head>

<body>
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
                <a href="adminpanel.aspx">
                    <i class='bx bx-grid-alt'></i>
                    <span class="link_name">Home</span>
                </a>
            </li>
            <li>
                <a href="vehiclesinventory.aspx">
                    <i class='bx bxs-bus-school'></i>
                    <span class="link_name">All Buses</span>
                </a>
            </li>
            <li>
                <a href="alldriversaspx.aspx">
                    <i class="fas fa-user"></i>
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
           <span><i class="fas fa-sign-out-alt" id="log_out"></i>Log Out</span>
        </div>
    </div>
    <div class="main_section">
        <div class="page_header">
            <h1>All Buses</h1>
            <p>List of buses available on the system</p>
        </div>
        <hr>
        <div class="page_content">
            <form runat="server">
                  <asp:GridView ID="allbuses" runat="server"></asp:GridView>
            </form>
           
        </div>
    </div>
    <script src="js/first.js"></script>

</body>

</html>