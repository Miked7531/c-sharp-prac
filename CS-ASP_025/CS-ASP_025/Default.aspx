﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_025.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBox ID="CheckBox1" runat="server" />
            <br />
            <br />
            <asp:CheckBox ID="CheckBox2" runat="server" />
            <br />
            <br />
            <asp:CheckBox ID="CheckBox3" runat="server" />
            <br />
            <br />
            <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="Add" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
