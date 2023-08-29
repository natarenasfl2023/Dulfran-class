<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_productos.aspx.cs" Inherits="APP_COMERCIO.frm_productos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="STYLE_PRODUCTOS.css" rel="stylesheet" type="text/css" />

    <title></title>
</head>
<body>
   <form id="form1" runat="server">
        
            <center>
             <br />
             <div class="div">
                 <br />
            <h3> Formulario de Registro Productos</h3>
            
            <asp:TextBox ID="txt_codigo" runat="server" placeholder="Código" CssClass="cajas"></asp:TextBox>
            <asp:TextBox ID="txt_nombre" runat="server" placeholder="Nombre" CssClass="cajas"></asp:TextBox>
            <asp:TextBox ID="txt_existencia" runat="server" placeholder="Existencia" CssClass="cajas"></asp:TextBox>
            <asp:TextBox ID="txt_valor_compra" runat="server" placeholder="Valor Compra" CssClass="cajas"></asp:TextBox>
            <asp:TextBox ID="txt_ganancia" runat="server" placeholder="Ganancia" CssClass="cajas"></asp:TextBox>
            <asp:DropDownList ID="DropDown_categoria" runat="server" placeholder="Categoria" CssClass="cajas" DataSourceID="Categorias" DataTextField="Descripcion" DataValueField="Descripcion" OnSelectedIndexChanged="DropDown_categoria_SelectedIndexChanged"></asp:DropDownList>
                 <asp:SqlDataSource ID="Categorias" runat="server" ConnectionString="<%$ ConnectionStrings:dbs_comercioConnectionString %>" ProviderName="<%$ ConnectionStrings:dbs_comercioConnectionString.ProviderName %>" SelectCommand="SELECT [Descripcion] FROM [tblcategoria]"></asp:SqlDataSource>
            <asp:TextBox ID="txt_especificaciones" runat="server" placeholder="Especificaciones" CssClass="cajas"></asp:TextBox>
            <asp:TextBox ID="txt_valor_venta" runat="server" placeholder="Valor Venta" CssClass="cajas"></asp:TextBox>
            <asp:DropDownList ID="DropDown_estado" runat="server" placeholder="Estado" CssClass="cajas" DataSourceID="Estado" DataTextField="Descripcion" DataValueField="Descripcion"></asp:DropDownList>
                 <asp:SqlDataSource ID="Estado" runat="server" ConnectionString="<%$ ConnectionStrings:dbs_comercioConnectionString %>" SelectCommand="SELECT [Descripcion] FROM [tblestado]"></asp:SqlDataSource>
            <asp:TextBox ID="txt_usuario" runat="server" placeholder="Usuario" CssClass="cajas"></asp:TextBox>

            <asp:Button ID="btn_registrar" runat="server" Text="Registrar" CssClass="botones" OnClick="btn_registrar_Click" />
            <asp:Button ID="btn_cancelar" runat="server" Text="Cancelar" CssClass="botones" OnClick="btn_cancelar_Click"/>
            <asp:Button ID="btn_consultar" runat="server" Text="Consultar" CssClass="botones" OnClick="btn_consultar_Click" />
                 <br /><br />
                 <asp:Label ID="lbl_mensaje" runat="server" Text=""></asp:Label>
            </div>
                  
            </center>
       
    </form>
</body>
</html>
