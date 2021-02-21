<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="KR1._Default" %>

<%@ Register assembly="KR1" namespace="ServerControl1" tagprefix="aspSample" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <div>
         <h1>
             Fibonacci number. ASP.NET AJAX
         </h1>
     <br />
         Number:<asp:TextBox runat="server" ID="MaxValue" Text="2500" />
     <br />
     <asp:UpdatePanel runat="server" ID="ResultPanel">
         <ContentTemplate>
             <asp:Button runat="server" ID="GoButton" Text="Calculate" OnClick="GoButton_Click" />
             <br />
             <aspSample:WelcomeLabel ID="WelcomeLabel1" runat="server" />
             <br />
             <small>Panel render Time=<%=DateTime.Now.ToString() %></small>
         </ContentTemplate>
     </asp:UpdatePanel>
     <asp:UpdateProgress runat="server" ID="UpdateProgress1">
        <ProgressTemplate>
             <div style="position:absolute;
                         left:701px; top:168px;
                         padding:40px 60px 40px 60px;
                         background-color:lightyellow;
                         font-size:larger;
                         filter:alpha(opacity=80);"
                 >
                Updating ....
             </div>
         </ProgressTemplate>
     </asp:UpdateProgress>
     <small>Page render Time2=<% =DateTime.Now.ToString() %></small>
     </div>
</asp:Content>
