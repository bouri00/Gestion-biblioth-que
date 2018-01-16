<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Panier.aspx.cs" Inherits="Library_And_Education.Panier"   %>




<form id="form1" runat="server">




<asp:datalist runat="server" DataKeyField="id_ouvrage" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="Unnamed1_SelectedIndexChanged">
    <ItemTemplate>
        id_ouvrage:
        <asp:Label ID="id_ouvrageLabel" runat="server" Text='<%# Eval("id_ouvrage") %>' />
        <br />
        titre:
        <asp:Label ID="titreLabel" runat="server" Text='<%# Eval("titre") %>' />
        <br />
        nb_pages:
        <asp:Label ID="nb_pagesLabel" runat="server" Text='<%# Eval("nb_pages") %>' />
        <br />
        id_Editeur:
        <asp:Label ID="id_EditeurLabel" runat="server" Text='<%# Eval("id_Editeur") %>' />
        <br />
        Quantite:
        <asp:Label ID="QuantiteLabel" runat="server" Text='<%# Eval("Quantite") %>' />
        <br />
        Type:
        <asp:Label ID="TypeLabel" runat="server" Text='<%# Eval("Type") %>' />
        <br />
        id_Auteur:
        <asp:Label ID="id_AuteurLabel" runat="server" Text='<%# Eval("id_Auteur") %>' />
        <br />
        Photo:
        <asp:Label ID="PhotoLabel" runat="server" Text='<%# Eval("Photo") %>' />
        <br />
        id_type:
        <asp:Label ID="id_typeLabel" runat="server" Text='<%# Eval("id_type") %>' />
        <br />
        libelle:
        <asp:Label ID="libelleLabel" runat="server" Text='<%# Eval("libelle") %>' />
        <br />
        prenomE:
        <asp:Label ID="prenomELabel" runat="server" Text='<%# Eval("prenomE") %>' />
        <br />
        nomE:
        <asp:Label ID="nomELabel" runat="server" Text='<%# Eval("nomE") %>' />
        <br />
        Prix:
        <asp:Label ID="PrixLabel" runat="server" Text='<%# Eval("Prix") %>' />
        <br />
        Description:
        <asp:Label ID="DescriptionLabel" runat="server" Text='<%# Eval("Description") %>' />
        <br />
        Total:
        <asp:Label ID="TotalLabel" runat="server" Text='<%# Eval("Total") %>' />
        <br />
<br />
    </ItemTemplate>
    </asp:datalist>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Manage BooksConnectionString %>" SelectCommand="SELECT * FROM [Ouvrage]"></asp:SqlDataSource>
</form>

