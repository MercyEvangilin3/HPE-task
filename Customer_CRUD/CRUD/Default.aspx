<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <div style ="font-size:x-large" align="center">Customer Info<br />
        </div>
        <table class="nav-justified">
            <tr>
                <td>&nbsp;</td>
                <td style="width: 330px">Customer Id</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Font-Size="Medium" Height="25px" Width="142px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="height: 22px"></td>
                <td style="width: 330px; height: 22px">FIrstName</td>
                <td style="height: 22px">
                    <asp:TextBox ID="TextBox2" runat="server" Font-Size="Medium"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td style="width: 330px">Lastname</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Font-Size="Medium"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td style="width: 330px">Email</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" Font-Size="Medium"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td style="width: 330px">ContactNumber</td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server" Font-Size="Medium"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="height: 22px"></td>
                <td style="width: 330px; height: 22px">Address</td>
                <td style="height: 22px">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>America</asp:ListItem>
                        <asp:ListItem>USA</asp:ListItem>
                        <asp:ListItem>London</asp:ListItem>
                        <asp:ListItem>Germany</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td style="width: 330px">&nbsp;</td>
                <td>&nbsp;
                    <asp:Button ID="Button1" runat="server" BackColor="#9933FF" BorderColor="#9933FF" OnClick="Button1_Click" Text="Insert" />
                    <asp:Button ID="Button2" runat="server" BackColor="#9933FF" BorderColor="#9933FF" OnClick="Button2_Click" Text="Update" />
&nbsp;
                    <asp:Button ID="Button3" runat="server" BackColor="#9933FF" BorderColor="#9933FF" OnClick="Button3_Click" Text="Delete" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button4" runat="server" BackColor="#9933FF" BorderColor="#9933FF" OnClick="Button4_Click" Text="Search" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td style="width: 330px">&nbsp;</td>
                <td>
                    <asp:GridView ID="GridView1" runat="server" Width="478px">
                    </asp:GridView>
                </td>
            </tr>
        </table>
        <br />

    </div>

</asp:Content>
