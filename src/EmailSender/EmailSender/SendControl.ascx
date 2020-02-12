<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SendControl.ascx.cs" Inherits="EmailSender.SendControl" %>
<asp:Label ID="AddressLabel" runat="server" Text="Label"></asp:Label>
<br />
<asp:TextBox ID="AddressTextBox" runat="server" AutoPostBack="true" CssClass="input"></asp:TextBox>
<br />
<asp:Label ID="InvalidAddressLabel" runat="server" Text="Label" Visible="False"></asp:Label>
<br />
<asp:Label ID="MessageLabel" runat="server" Text="Label"></asp:Label>
<br />
<asp:TextBox ID="MessageTextBox" runat="server" CssClass="textarea" AutoPostBack="true" Rows="10" TextMode="MultiLine" OnTextChanged="MessageTextBox_TextChanged" OnDisposed="AddressTextBox_TextChanged"></asp:TextBox>
<br />
<asp:Button ID="SendButton" runat="server" CssClass="button" OnClick="SendButton_Click" Text="Button" />

