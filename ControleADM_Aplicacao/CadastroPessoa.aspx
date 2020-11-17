<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroPessoa.aspx.cs" Inherits="ControleADM_Aplicacao.CadastroPessoa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <form id="form1" >  
        <div>  
            <table class="auto-style1">  
                <tr>  
                    <td>Código :</td>  
                    <td>  
                        <asp:TextBox ID="txtId" runat="server" MaxLength="8" Width="120px"></asp:TextBox>  
                        <br />
                    </td>   
               </tr>   
                <tr>  
                    <td>Nome :</td>  
                    <td>  
                        <asp:TextBox ID="txtNome" runat="server" MaxLength="256"  Width="320px"></asp:TextBox>  
                        <br />
                    </td>   
               </tr>   
                <tr>  
                    <td>CPF :</td>  
                    <td>  
                        <asp:TextBox ID="txtCPF" runat="server"  Width="120px" ></asp:TextBox>  
                        <br />
                    </td>   
               </tr>   
                <tr>  
                    <td>Endereço :</td>  
                    <td>  
                        <asp:TextBox ID="txtEndereco" runat="server"  MaxLength="256"  Width="320px" ></asp:TextBox>  
                        <br />
                    </td>   
               </tr>   
                <tr> 
                    <td></td>
                    <td>  
                        <asp:Button ID="btn" runat="server" Text="Alterar" />  
                        <asp:Button ID="btnExcluir" runat="server" Text="Excluir" />
                    </td>  
                        
                </tr>  
            </table>  
        </div>  
    </form>  
</asp:Content>
