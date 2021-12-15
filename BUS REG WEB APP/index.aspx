<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="BUS_REG_WEB_APP.index" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Online Bus Registatration</title>
    <link rel="stylesheet" href="css/style.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta2/css/all.min.css" integrity="sha512-YWzhKL2whUzgiheMoBFwW8CKV4qpHQAEuvilg9FAn5VJUDwKZZxkJNuGM4XkWuk94WCrrwslk8yWNGmY1EduTA==" crossorigin="anonymous" referrerpolicy="no-referrer"
    />
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com">
    <link href="https://fonts.googleapis.com/css2?family=Baloo+Da+2:wght@400;500;600;800&family=Josefin+Slab:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;1,100;1,200;1,300;1,400;1,500;1,600;1,700&family=Mulish:ital,wght@0,200;0,300;0,400;0,500;1,200;1,300;1,400&display=swap"
        rel="stylesheet">
</head>

<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="hamburger-menu">
            <div class="line line-1"></div>
            <div class="line line-2"></div>
            <div class="line line-3"></div>
            <span>Close</span>
        </div>
        <header class="header">
            <div class="image-wrapper">
                <img src="img/scania.jpg" />
                
            </div>
            <div class="banner">
                <h1>Bus Registration System</h1>
                <p>Here to Help You Anywhere</p>
               <asp:LinkButton class="button" ID="LinkButton1" runat="server">Search For A Bus</asp:LinkButton>                              
            </div>
        </header>
        <section class="sidebar">
            <ul class="menu">
                <li class="menu-item">
                    <a href="#" class="menu-link" data-content="Home">Home</a>
                </li>
                <li class="menu-item">
                    <a href="#" class="menu-link" data-content="Team">Team</a>
                </li>
                <li class="menu-item">
                    <a href="#" class="menu-link" data-content="About Us">About Us</a>
                </li>
                <li class="menu-item">
                    <a href="#" class="menu-link" data-content="Contact">Contact</a>
                </li>
                <li class="menu-item">
                    <a href="userlogin.aspx" class="menu-link" data-content="Login">Login</a>
                </li>
            </ul>
            <div class="socia-media">
                <a href="#"><i class="fab fa-facebook-f"></i></a>
                <a href="#"><i class="fab fa-twitter"></i></a>
                <a href="#"><i class="fab fa-instagram"></i></a>
            </div>
        </section>
        </div>
        <div>
        </div>
    </form>
    <script src="js/script.js"></script>
    </body>
    </html>
      