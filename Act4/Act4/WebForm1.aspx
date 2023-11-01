<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Act4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Birthday reservation:"></asp:Label>
            <br />
            Are you going to pay with cash or card?<br />
            <asp:Button ID="btnCash" runat="server" OnClick="btnCash_Click" Text="cash" />
            <asp:Button ID="btnCard" runat="server" OnClick="btnCard_Click" Text="card" />
            <br />
        </div>
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
&nbsp;<asp:Label ID="lblError" runat="server"></asp:Label>
    </form>
</body>
</html>
