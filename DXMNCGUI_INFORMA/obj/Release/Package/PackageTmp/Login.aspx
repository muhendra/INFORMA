<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DXMNCGUI_INFORMA.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="Content/Login.css" />
    <title></title>
</head>
<body>
    <div class="body"></div>
		<div class="grad"></div>
		<div class="header">
			<div>IN<span>FORMA</div>
		</div>
        <div class="header2">
			<div>Internal<span> Form Management System</div>
		</div>
		<br>
        <form runat="server">
		    <div class="login">
			    <input type="text" placeholder="username" name="txtUsername" id="txtUsername" runat="server"><br>
			    <input type="password" placeholder="password" name="txtPassword" id="txtPassword" runat="server"><br>
                <dx:ASPxLabel runat="server" ID="lblMessage" Text="Error label" ForeColor="Red" Visible="true" Font-Size="8" Font-Bold="true" Font-Names="Exo" Font-Italic="true"></dx:ASPxLabel><br>
                <div class="btnlogin">
                    <dx:ASPxButton runat="server" ID="btnLogin" Text="Login" Font-Names="Exo" Font-Bold="true" ForeColor="#666666" OnClick="btnLogin_Click">
                        <Border BorderStyle="None"/>
                        <HoverStyle BackColor="#ddb88a"></HoverStyle>
                    </dx:ASPxButton>
                </div>
		    </div>
        </form>
</body>
</html>
