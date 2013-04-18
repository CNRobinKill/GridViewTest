<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GridViewTest.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
    <link href="css.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False"
                HeaderStyle-VerticalAlign="Middle" CellPadding="3" Font-Size="9pt" BackColor="White"
                BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" Height="249px" Width="598px"
                CaptionAlign="Bottom" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing"
                OnRowUpdating="GridView1_RowUpdating" OnRowDataBound="GridView1_RowDataBound">
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <Columns>
                    <asp:BoundField DataField="CID" HeaderText="用户ID" ReadOnly="True">
                        <ItemStyle Width="50px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Name" HeaderText="姓名">
                        <ItemStyle Width="50px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Sex" HeaderText="性别">
                        <ItemStyle Width="50px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Address" HeaderText="家庭住址">
                        <ItemStyle Width="150px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Post" HeaderText="邮政编码">
                        <ItemStyle Width="50px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Price" HeaderText="价格" ReadOnly="True">
                        <ItemStyle Width="50px" />
                    </asp:BoundField>
                    <asp:CommandField HeaderText="选择" ShowSelectButton="True" />
                    <asp:CommandField HeaderText="编辑" ShowEditButton="True" />
                    <asp:CommandField HeaderText="删除" ShowDeleteButton="True" />
                </Columns>
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" VerticalAlign="Middle" />
            </asp:GridView>
   </div>
   </form>
</body>
</html>
