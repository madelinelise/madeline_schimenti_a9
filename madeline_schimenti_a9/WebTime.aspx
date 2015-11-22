<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebTime.aspx.cs" Inherits="madeline_schimenti_a9.WebTime" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>&nbsp;Simple Web Form Example</title>
    <style type="text/css">
        .timeStyle {
            color: #FFFF00;
            font-size: xx-large;
            background-color: #000000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Current time on the Web server:</h1>
        <p>
            <asp:Label ID="timeLabel" runat="server" CssClass="timeStyle"></asp:Label>
        </p>
        <p>
            Change properties:</p>
        <p>
            <asp:Label ID="labelChangeBgColor" runat="server" Text="Background Color: "></asp:Label>
            <asp:DropDownList ID="DropDownListColor" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListColor_SelectedIndexChanged">
                <asp:ListItem>Drop Down</asp:ListItem>
                <asp:ListItem>Red</asp:ListItem>
                <asp:ListItem>Blue</asp:ListItem>
                <asp:ListItem>Green</asp:ListItem>
            </asp:DropDownList>

        </p>
        <p>

            <asp:Label ID="labelChangeFontColor" runat="server" Text="Font Color: "></asp:Label>
            <asp:DropDownList ID="DropDownFontColor" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownFontColor_SelectedIndexChanged">
                <asp:ListItem>Drop Down</asp:ListItem>
                <asp:ListItem>White</asp:ListItem>
                <asp:ListItem>Black</asp:ListItem>
                <asp:ListItem>Blue</asp:ListItem>
                <asp:ListItem>Green</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Font Size"></asp:Label>
            <asp:DropDownList ID="DropDownFontSize" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" ViewStateMode="Enabled">
                <asp:ListItem>Drop Down</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>12</asp:ListItem>
                <asp:ListItem>14</asp:ListItem>
                <asp:ListItem>16</asp:ListItem>
                <asp:ListItem>18</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
            </asp:DropDownList>
        </p>
    
    </div>
    </form>
</body>
</html>

