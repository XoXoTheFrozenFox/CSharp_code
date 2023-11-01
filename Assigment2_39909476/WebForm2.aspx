<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Assigment2_39909476.WebForm2" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 625px;
        }
        .auto-style3 {
            width: 625px;
            height: 474px;
        }
        .auto-style4 {
            width: 316px;
            height: 474px;
        }
        .auto-style7 {
            width: 13px;
            height: 20px;
        }
        .auto-style9 {
            width: 229px;
        }
        .auto-style10 {
            width: 316px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-weight: bold; color: #FFFFFF; font-size: large;">

            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" ForeColor="White" Text="Database Information:"></asp:Label>
            <br />
            <br />

            <table style="width:100%;">
                <tr>
                    <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:GridView ID="GridView1" runat="server" BorderColor="#993333" BorderStyle="Solid" Font-Bold="True" ForeColor="White" Height="470px" Width="650px" BorderWidth="2px">
            </asp:GridView>

                    </td>
                    <td class="auto-style4">
                        <br />
                        <br />
                        Search_by:
                        <br />
                        Press enter to search :D<br />
                        <br />
                        Name:<br />
            <asp:TextBox ID="txtName" runat="server" BorderColor="#993333" BorderStyle="Solid" ForeColor="#CC0066" ValidationGroup="a" OnTextChanged="txtName_TextChanged" Width="156px" AutoPostBack="True"></asp:TextBox>
                        <br />
                        <br />
                        Surname:<br />
            <asp:TextBox ID="txtSurname" runat="server" BorderColor="#993333" BorderStyle="Solid" ForeColor="#CC0066" ValidationGroup="a" OnTextChanged="txtSurname_TextChanged" Width="156px" AutoPostBack="True"></asp:TextBox>
                        <br />
                        <br />
                        Email:<br />
            <asp:TextBox ID="txtEmail" runat="server" BorderColor="#993333" BorderStyle="Solid" ForeColor="#CC0066" ValidationGroup="a" OnTextChanged="txtEmail_TextChanged" Width="156px" AutoPostBack="True"></asp:TextBox>
                        <br />
                        <br />
                        <br />
                        Delete:<br />
                        <asp:DropDownList ID="DropDownList1" runat="server" ForeColor="#CC0066" Width="176px" Height="31px" style="margin-left: 0px" ValidationGroup="a" AutoPostBack="True">
            </asp:DropDownList>
                        <br />
                        <br />
            <asp:Button ID="btnDelete" runat="server" BackColor="White" BorderColor="#993333" BorderStyle="Solid" BorderWidth="4px" ForeColor="#CC0066" Height="52px" OnClick="btnDelete_Click" style="margin-left: 0px; margin-right: 4px" Text="Delete" Width="245px" ValidationGroup="a" />
                        <br />
                        <br />
                        Back:<br />
            <asp:Button ID="btnBack" runat="server" BackColor="White" BorderColor="#993333" BorderStyle="Solid" BorderWidth="4px" ForeColor="#CC0066" Height="52px" OnClick="btnContinue_Click" style="margin-left: 0px; margin-right: 4px" Text="Back" Width="245px" ValidationGroup="a" />
                        <br />
                        <br />
                        <br />
                    </td>
                    <td class="auto-style7">
                        <br />
                        Filter_by:&nbsp; <asp:Button ID="btnNormal" runat="server" BackColor="White" BorderColor="#993333" BorderStyle="Solid" BorderWidth="4px" ForeColor="#CC0066" Height="52px" OnClick="btnNormal_Click" style="margin-left: 0px; margin-right: 4px" Text="Normal" Width="245px" ValidationGroup="a" />
                        <br />
                        <br />
            <asp:Button ID="btnVIP" runat="server" BackColor="White" BorderColor="#993333" BorderStyle="Solid" BorderWidth="4px" ForeColor="#CC0066" Height="52px" OnClick="btnVIP_Click" style="margin-left: 0px; margin-right: 4px" Text="VIP" Width="245px" ValidationGroup="a" />
                        <br />
                        <br />
            <asp:Button ID="btnVIPplus" runat="server" BackColor="White" BorderColor="#993333" BorderStyle="Solid" BorderWidth="4px" ForeColor="#CC0066" Height="52px" OnClick="btnVIPplus_Click" style="margin-left: 0px; margin-right: 4px" Text="VIP+" Width="245px" ValidationGroup="a" />
                        <br />
                        <br />
                        <br />
                        Reset_Database:<asp:Button ID="btnReset" runat="server" BackColor="White" BorderColor="#993333" BorderStyle="Solid" BorderWidth="4px" ForeColor="#CC0066" Height="52px" OnClick="btnReset_Click" style="margin-left: 0px; margin-right: 4px" Text="Reset" Width="245px" ValidationGroup="a" />
                        <br />
                        <br />
                        &nbsp;<br />
                        Update_the_selected_record:<br />
                        <asp:DropDownList ID="DropDownList2" runat="server" ForeColor="#CC0066" Width="176px" Height="31px" style="margin-left: 0px" ValidationGroup="a" AutoPostBack="True">
            </asp:DropDownList>
                        <br />
                        Double click the_buttons_<br />
                        to update the record.<br />
                        Name:<br />
            <asp:TextBox ID="txtNameUpdate" runat="server" BorderColor="#993333" BorderStyle="Solid" ForeColor="#CC0066" ValidationGroup="a" Width="143px" AutoPostBack="True"></asp:TextBox>
                        <asp:Button ID="btnNameUpdate" runat="server" ForeColor="#CC0066" OnClick="btnNameUpdate_Click" Text="Update" />
                        <br />
                        Surname:<br />
            <asp:TextBox ID="txtSurnameUpdate" runat="server" BorderColor="#993333" BorderStyle="Solid" ForeColor="#CC0066" ValidationGroup="a" Width="143px" AutoPostBack="True"></asp:TextBox>
                        <asp:Button ID="btnSurnameUpdate" runat="server" ForeColor="#CC0066" OnClick="btnSurnameUpdate_Click" Text="Update" />
                        <br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td class="auto-style10"><br />
&nbsp;<br />
            <br />
            <br />
                        <br />
                        <br />
            <br />
                    </td>
                    <td class="auto-style9">
                        <br />
                        <br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style10">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>

            <br />
            <br />
            <br />
            <br />

        </div>
        <script src="script.js"></script><!-- This is where we connect the javascript animations with the main program. -->
        <link rel="stylesheet" href="style.css" /><!-- This is where we connect the CSS styling with the main program. -->
        <p style="text-align: left">
        </p>
    </form>
</body>
</html>
