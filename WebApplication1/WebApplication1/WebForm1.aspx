<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table align="center">
            <tr>
                <td align="center">
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
            </tr>
            <tr>
                <td align="left">
                    <asp:Button ID="Button1" runat="server" Text="Save and compress" OnClick="Button1_Click" />
                </td>
            </tr>
            <tr>
                <td align="left">
                    <asp:GridView ID="gvZip" runat="server" AutoGenerateColumns="false" OnRowCommand="gvZip_RowCommand" OnSelectedIndexChanged="gvZip_SelectedIndexChanged">
                        <Columns>
                            <asp:TemplateField HeaderText="Click to Download">
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkDownload" runat="server" Text='<%#Bind("Name")%>' CommandName="Download" CommandArgument='<%#Bind("Name") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
