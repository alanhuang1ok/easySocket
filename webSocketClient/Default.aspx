<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="webSocketClient._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to ASP.NET!  
    </h2>
     <asp:Button ID="callSocket" runat="server" Text="调用远处SOCKET" 
        onclick="callSocket_Click" />
    <br />

    <div >
        <asp:Label ID="lab_result" runat="server" ForeColor="Red"></asp:Label>
    </div>

    </asp:Content>
