<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="resources.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="resorucesfalse" runat="server">
        Please Login or Sign Up to view this page.
    </div>
    <div id="resourcestrue" runat="server">
        
        <style>
            #contents {
                width: 70%;
                background: #FAFAFA;
                padding: 0px;
                margin: 50px auto;
                box-shadow: 1px 1px 25px rgba(0, 0, 0, 0.35);
                border: 3px solid #305A72;
            }

                #contents td, #contents th {
                    
                    padding: 8px;
                    text-align: center;
                }

                #contents tr:nth-child(even) {
                    background-color: #f2f2f2;
                }

                #contents tr:hover {
                    background-color: #ddd;
                }

                #contents th {
                    padding-top: 12px;
                    padding-bottom: 12px;
                    background-color: darkblue;
                    color: white;
                }
        </style>
        </head>
        <body>

            <table id="contents">
                <tr>
                    <th>Name</th>
                    <th>Link</th>
                </tr>
                <tr>
                    <td>Stanford University Team Document</td>
                    <td>
                        <asp:LinkButton ID="Stanford_U" Font-Underline="false" runat="server" Text="Download" class="download"
                            OnClick="Stanford_U_Click" /></td>
                </tr>
                <tr>
                    <td>National Taiwan University Team Document</td>
                    <td>
                        <asp:LinkButton ID="National_Taiwan_U" Font-Underline="false" runat="server" Text="Download" class="download"
                            OnClick="National_Taiwan_U_Click" /></td>
                </tr>
                
                <tr>
                    <td>KTH Royal University Team Document</td>
                    <td>
                        <asp:LinkButton ID="KTH_Royal_U" Font-Underline="false" runat="server" Text="Download" class="download"
                            OnClick="KTH_Royal_U_Click" /></td>
                </tr>

            </table>
    </div>
</asp:Content>
