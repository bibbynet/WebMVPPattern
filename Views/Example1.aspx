<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Example1.aspx.cs" Inherits="WebMVPPattern.Views.Example1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>example1</h1>
        <asp:TextBox runat="server" ID="txtDatetimeNow"></asp:TextBox> 
        <asp:Button runat="server" ID="btnGetDatetime" Text="Submit"/>
        <hr/>
        <h1>example2</h1>
        <asp:GridView runat="server" ID="gvPersonData"></asp:GridView>
    </div>
    </form>
</body>
</html>
