<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="font-size: xx-large">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
        .auto-style2 {
            font-size: large;
            font-weight: bold;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #00FFFF">
    <div>
    
        <asp:Button ID="btn7" runat="server" Text="7" Font-Size="XX-Large" OnClick="btns_Click" 
             />
        <asp:Button ID="btn8" runat="server" Text="8" Font-Size="XX-Large" 
            OnClick="btns_Click" />
        <asp:Button ID="btn9" runat="server" Text="9" Font-Size="XX-Large" 
            OnClick="btns_Click" />
        <asp:Button ID="btnMinus" runat="server" Font-Size="XX-Large" Text="-" 
            OnClick="btns_Click" />
    
    </div>
        <asp:Button ID="btn4" runat="server" Text="4" Font-Size="XX-Large" 
            OnClick="btns_Click" />
        <asp:Button ID="btn5" runat="server" Text="5" Font-Size="XX-Large" 
            OnClick="btns_Click" />
        <asp:Button ID="btn6" runat="server" Text="6" Font-Size="XX-Large" 
            OnClick="btns_Click" />
        <asp:Button ID="btnDivide" runat="server" Font-Size="XX-Large" Text="/" 
            OnClick="btns_Click" />
        <br />
        <asp:Button ID="btn1" runat="server" Text="1" Font-Size="XX-Large" 
            OnClick="btns_Click" />
        <asp:Button ID="btn2" runat="server" Text="2" Font-Size="XX-Large" 
            OnClick="btns_Click" />
        <asp:Button ID="btn3" runat="server" Text="3" Font-Size="XX-Large" 
            OnClick="btns_Click" />
        <asp:Button ID="btnMultiply" runat="server" Font-Size="XX-Large" Text="*" 
            OnClick="btns_Click" />
        <br />
        <asp:Button ID="btn0" runat="server" Font-Size="XX-Large" Text="0" 
            OnClick="btns_Click" />
        <asp:Button ID="btnAdd" runat="server" Font-Size="XX-Large" Text="+" 
            OnClick="btns_Click" />
        <asp:Button ID="btnMod" runat="server" Font-Size="X-Large" Height="48px" 
            Text="%" Width="38px" OnClick="btns_Click" />
        <asp:Button ID="btnEqual" runat="server" Font-Size="XX-Large" Text="=" 
            OnClick="btns_Click" />
        <br />

        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" 
            Text="Clear - Reset Everything" Width="177px" />
        <br />

        <br />
        <asp:Label ID="Label1" runat="server" Text="Operand 1:" 
            style="font-size: x-large"></asp:Label>
        <asp:TextBox ID="txtBxOp1" runat="server" CssClass="auto-style2" Width="91px"></asp:TextBox>
    &nbsp;<p class="auto-style1">
        Operand 2:<asp:TextBox ID="txtBxOp2" runat="server" CssClass="auto-style2" 
                Width="89px"></asp:TextBox>
        </p>
        <p class="auto-style1">
            Operator:<asp:TextBox ID="txtBxOp" runat="server" CssClass="auto-style2" 
                Width="16px"></asp:TextBox>
        </p>
        <p class="auto-style1">
            Result:<asp:TextBox ID="txtBxResult" runat="server" CssClass="auto-style2" 
                Width="125px"></asp:TextBox>
        </p>
    </form>
    </body>
</html>
