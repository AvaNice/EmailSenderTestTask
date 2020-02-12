<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ShippingNotice.aspx.cs" Inherits="EmailSender.ShippingNotice" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="ShippingResultLabel" runat="server" Text="Label"></asp:Label>
<br />
<asp:Button ID="ShippingNoticeOKButton" runat="server" OnClick="ShippingNoticeOKButton_Click" Text="Button" />
</asp:Content>
