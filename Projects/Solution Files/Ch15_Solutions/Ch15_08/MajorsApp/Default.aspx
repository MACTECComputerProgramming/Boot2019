<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color: #0000CC; color: #FFFF00">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h2>Department Chairs</h2>
        </div>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
            DataFile="~/App_Data/StudentDataBase.accdb" 
            SelectCommand="SELECT [major_ID], [major_Name], [major_Chair] FROM [Department]">
        </asp:AccessDataSource>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="AccessDataSource1" 
            AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" 
            BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" 
            DataKeyNames="major_ID" ForeColor="Black" Width="224px">
            <Columns>
                <asp:BoundField DataField="major_Name" HeaderText="Major" 
                    SortExpression="major_Name" />
                <asp:BoundField DataField="major_Chair" HeaderText="Chair" 
                    SortExpression="major_Chair" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
    </form>
</body>
</html>
