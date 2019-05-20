<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color: #99FF33">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #CCFF33">
    <div style="background-color: #99FF33">
        <h2>
            Computer Club T-Shirt Order Form</h2>
        <h4>
            First Name:&nbsp;
            <asp:TextBox ID="txtFirst" runat="server" 
                Style="position: relative; top: 0px; left: 0px; width: 128px;"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            Last Name:&nbsp;
            <asp:TextBox ID="txtLast" runat="server" Style="position: relative"></asp:TextBox></h4>
        <h4>
            Phone:&nbsp;
            <asp:TextBox ID="txtPhone" runat="server" Style="position: relative"></asp:TextBox>&nbsp;&nbsp;&nbsp;
            Email: &nbsp;<asp:TextBox ID="txtEmail" runat="server" 
                Style="position: relative; top: 0px; left: 0px;"></asp:TextBox></h4>
        <h3>
            T-Shirt Selections for order:</h3>
        <h3>
            Size:&nbsp;
            <asp:DropDownList ID="ddListSize" runat="server" AutoPostBack="True" Style="position: relative">
                <asp:ListItem>Small</asp:ListItem>
                <asp:ListItem>Medium</asp:ListItem>
                <asp:ListItem>Large</asp:ListItem>
                <asp:ListItem>X-Large</asp:ListItem>
                <asp:ListItem>XX-Large</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp; Quantity:&nbsp;<asp:TextBox ID="txtQty" runat="server" 
                Font-Size="Smaller" 
                Style="left: 2px; position: relative; top: 0px; width: 30px; height: 19px;">1</asp:TextBox>&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnProcess" runat="server" OnClick="btnProcess_Click" Style="left: 51px;
                position: relative; top: -26px" Text="Place Order" /></h3>
        <h3 style="height: 24px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblResult" runat="server" Font-Size="Medium" Style="left: 0px; position: relative;
                top: -1px; width: 575px;"></asp:Label><br />
            &nbsp;</h3>
        <p style="height: 24px; font-size: x-large">
        <asp:Label ID="lblTotal" runat="server" Font-Bold="True" ForeColor="#C00000" Style="left: 0px;
            position: relative; top: -19px; width: 241px;" Font-Size="X-Large"></asp:Label>
        </p>
        <br />
        <br style="background-color: #99FF33" />
        <br />
    
    </div>
    </form>
</body>
</html>
