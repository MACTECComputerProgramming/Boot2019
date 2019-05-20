<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Williamsburg KY</h2>
    </hgroup>

    <article>
        <p>        
            Located in Southeastern Kentucky
        </p>

        <p>        
            54 miles from Knoxville Tennessee
        </p>
         <p>        
            91 miles from Lexington Kentucky
        </p>
        <p>        
            Population 5,245
        </p>
    </article>

    <aside>
        <h3>Williamsburg, KY</h3>
        <p>        
            Located on Interstate 75 in Southeastern Kentucky.
        </p>
        <ul>
            <li><a runat="server" href="~/">Home</a></li>
            <li><a runat="server" href="~/About.aspx">About</a></li>
            <li><a runat="server" href="~/Contact.aspx">Contact</a></li>
        </ul>
    </aside>
</asp:Content>