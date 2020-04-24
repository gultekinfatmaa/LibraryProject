<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ISBN.aspx.cs" Inherits="yazlab2_1.ISBN" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin-left: 0px">
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox" runat="server" Height="127px" style="margin-left: 19px" Width="90px">ISBN</asp:TextBox>
            <asp:Image ID="Image" runat="server" BackColor="Black" Height="123px" style="margin-top: 24px" Width="100px" />
            <asp:Button ID="SelectFile" runat="server" Text="Select File" />
            <asp:Button ID="ExtractFile" runat="server" Text="Extract Text" />
        </div>
    </form>
</body>
</html>
