<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Main.master" CodeBehind="Default.aspx.cs" Inherits="DXMNCGUI_INFORMA._Default" %>


<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
    <dx:ASPxFormLayout runat="server" ID="FormLayout" ClientInstanceName="FormLayout" Font-Names="Calibri">
        <SettingsAdaptivity AdaptivityMode="SingleColumnWindowLimit" SwitchToSingleColumnAtWindowInnerWidth="800"/>
        <Items>
            <dx:LayoutGroup ShowCaption="True" GroupBoxDecoration="None" Caption="Home" ColCount="4">
                <GroupBoxStyle>
                    <Caption ForeColor="SlateGray" Font-Size="Larger" Font-Bold="true" BackColor="Transparent"></Caption>
                </GroupBoxStyle>
                <Items>
                    <dx:LayoutItem ShowCaption="False">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxImage runat="server" ImageUrl="~/Content/Images/HomeBackground2.png">
                                    <Border BorderColor="WhiteSmoke" BorderStyle="None" BorderWidth="4" />
                                </dx:ASPxImage>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
            </dx:LayoutGroup>
        </Items>
    </dx:ASPxFormLayout>
</asp:Content>