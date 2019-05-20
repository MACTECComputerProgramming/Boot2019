<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-size: xx-large; font-weight: bold; color: #009900; text-align: center;">
    
        <br />
        Williamsburg KY<br />
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/Location.jpg" />

  
        <br />
    
    </div>
        <h3 style="color: #008000">Great Reasons to Visit Williamsburg, Kentucky</h3>
    <ul class="round" style="color: #008000">
        <li class="one">
            <h3>Close to 
                 <a href="http://www.stateparks.com/cumberland_falls.html">Cumberland Falls</a>
            </h3>
            <strong>Cumberland Falls</strong>, sometimes called the <strong>Little 
            Niagara of the South</strong>, or the Great Falls, is a large 
            waterfall on the <strong>Cumberland River</strong>.&nbsp;
        </li>
        <li class="two">
            <h3 style="color: #008000">Within an hour drive to 
                <a href="http://www.lakecumberland.com/">Lake Cumberland</a>
            </h3>
            The Lake Cumberland <strong>shoreline measures 1,255 miles </strong>and the main <strong>lake 
            is 101 miles long</strong> and over one mile across at its widest point. &nbsp;
        </li>
        <li class="three">
            <h3>Small town lifestyle

            </h3>
            Lots of <strong>history</strong>..endless trails to explore and sites to see
            in <strong>Williamsburg</strong>.&nbsp;
        </li>
    </ul>
        <asp:Button ID="btnClick" runat="server" OnClick="btnClick_Click" 
            Text="More Information" />
        <asp:Label ID="lblOutput" runat="server"></asp:Label>
    </form>
</body>
</html>
