<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    &nbsp;<section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Gateway to the Cumberlands</h1>
            </hgroup>
            <p style="font-size: medium; font-weight: bold; color: #FFFFFF">
                Williamsburg is a Great Place to Visit!</p>
        </div>
    </section>
</asp:Content>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Great Reasons to Visit Williamsburg, Kentucky</h3>
    <ol class="round">
        <li class="one">
            <h5>Close to Cumberland Falls</h5>
            <strong>Cumberland Falls</strong>, sometimes called the <strong>Little 
            Niagara of the South</strong>, or the Great Falls, is a large 
            waterfall on the <strong>Cumberland River</strong>.&nbsp;
            <a href="http://www.stateparks.com/cumberland_falls.html">Learn more…</a>
        </li>
        <li class="two">
            <h5>Within an hour drive to Lake Cumberland</h5>
            The Lake Cumberland <strong>shoreline measures 1,255 miles </strong>and the main <strong>lake 
            is 101 miles long</strong> and over one mile across at its widest point. &nbsp;
            <a href="http://www.lakecumberland.com/">Learn more…</a>
        </li>
        <li class="three">
            <h5>Small town lifestyle</h5>
            Lots of <strong>history</strong>..endless trails to explore and sites to see
            in <strong>Williamsburg</strong>.&nbsp;
            <a href="http://go.microsoft.com/fwlink/?LinkId=245143">Learn more…</a>
        </li>
    </ol>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
strong{font-weight:700}</style>
</asp:Content>
