<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="FreeTextMemoDetailListing.aspx.cs" Inherits="DXMNCGUI_INFORMA.Reporting.InternalMemo.FreeText.FreeTextMemoDetailListing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript" src="~/Scripts/Application.js"></script>
    <script type="text/javascript">
    </script>
    <dx:ASPxHiddenField runat="server" ID="HiddenField" ClientInstanceName="HiddenField"/>
    <dx:ASPxFormLayout runat="server" ID="FormLayout" ClientInstanceName="FormLayout" Font-Names="Calibri">
        <SettingsAdaptivity AdaptivityMode="SingleColumnWindowLimit" SwitchToSingleColumnAtWindowInnerWidth="800"/>
        <Items>
            <dx:LayoutGroup ShowCaption="True" GroupBoxDecoration="HeadingLine" Caption="Free Text Memo Listing" ColCount="5">
                <GroupBoxStyle>
                    <Caption ForeColor="SlateGray" Font-Size="Larger" Font-Bold="true" BackColor="Transparent"></Caption>
                </GroupBoxStyle>
                <Items>
                    <dx:LayoutItem ShowCaption="False" Width="10%">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer4" runat="server">
                                <dx:ASPxButton ID="btnRefresh" ClientInstanceName="btnRefresh" runat="server" Text="Refresh" OnClick="btnRefresh_Click" Width="100%" Theme="Aqua">
                                </dx:ASPxButton>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
            </dx:LayoutGroup>
            <dx:LayoutGroup ShowCaption="False" ColCount="1" GroupBoxDecoration="None">
                <GroupBoxStyle>
                    <Caption ForeColor="SlateGray" Font-Size="Larger" Font-Bold="true" BackColor="Transparent"></Caption>
                </GroupBoxStyle>
                <Items>
                    <dx:LayoutItem ShowCaption="False">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxGridView
                                    ID="gvMain"
                                    ClientInstanceName="gvMain"
                                    runat="server" 
                                    DataSourceID="sdsFreeTextListing"
                                    KeyFieldName="DocNo"
                                    Width="100%"
                                    AutoGenerateColumns="False"
                                    EnableCallBacks="true"
                                    EnablePagingCallbackAnimation="true"
                                    EnableTheming="True" Theme="Aqua"
                                    Font-Size="Small" Font-Names="Calibri">
                                    <SettingsAdaptivity AdaptivityMode="HideDataCellsWindowLimit" AllowOnlyOneAdaptiveDetailExpanded="True" HideDataCellsAtWindowInnerWidth="700">
                                    </SettingsAdaptivity>
                                    <Settings ShowFilterRow="false" ShowGroupPanel="True" ShowFilterRowMenu="true" ShowFilterBar="Auto" ShowHeaderFilterButton="true" ShowFooter="true"/>
                                    <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True" FilterRowMode="OnClick" EnableRowHotTrack="true" EnableCustomizationWindow="true" AllowEllipsisInText="true" />
                                    <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                                    <SettingsSearchPanel Visible="True" />
                                    <SettingsFilterControl ViewMode="VisualAndText" AllowHierarchicalColumns="true" ShowAllDataSourceColumns="true" MaxHierarchyDepth="1" />
                                    <SettingsLoadingPanel Mode="Disabled" />
                                    <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="WYSIWYG" Landscape="true" PaperKind="A4" />
                                    <SettingsPager PageSize="15"></SettingsPager>
                                    <SettingsResizing ColumnResizeMode="Control" Visualization="Live" />
                                    <Toolbars>
                                        <dx:GridViewToolbar ItemAlign="Right" EnableAdaptivity="true" Position="Top">
                                            <Items>
                                                <dx:GridViewToolbarItem Command="ShowCustomizationWindow" DisplayMode="ImageWithText" />
                                                <dx:GridViewToolbarItem Command="ExportToXlsx" Text="Export to .xlsx" ToolTip="Click here to export grid data to excel" />
                                            </Items>
                                        </dx:GridViewToolbar>
                                    </Toolbars>
                                    <Columns>
                                        <dx:GridViewDataTextColumn Name="colDocNo" Caption="Memo No." FieldName="DocNo" ReadOnly="True" ShowInCustomizationForm="true">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataDateColumn Name="colDocDate" Caption="Memo Date" FieldName="DocDate" ReadOnly="True" ShowInCustomizationForm="true" PropertiesDateEdit-DisplayFormatString="dd/MM/yyyy">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataDateColumn>
                                        <dx:GridViewDataTextColumn Name="colBranch" Caption="Cabang" FieldName="MemoBranch" ReadOnly="True" ShowInCustomizationForm="true">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="colStatus" Caption="Status" FieldName="Status" ReadOnly="True" ShowInCustomizationForm="true">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataTextColumn>

                                        <dx:GridViewDataTextColumn Name="colMemoFrom" Caption="From" FieldName="MemoFrom" ReadOnly="True" ShowInCustomizationForm="true">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="colMemoTo" Caption="To" FieldName="MemoTo" ReadOnly="True" ShowInCustomizationForm="true">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="colMemoPerihal" Caption="Perihal" FieldName="MemoPerihal" ReadOnly="True" ShowInCustomizationForm="true">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataTextColumn>

                                        <dx:GridViewDataTextColumn Name="colFinalApprover" Caption="Final Approver" FieldName="FinalApprover" ReadOnly="True" ShowInCustomizationForm="true">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataMemoColumn Name="colFinalApprovalNote" Caption="Final Approval Note" FieldName="FinalApprovalNote" ReadOnly="True" ShowInCustomizationForm="true">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataMemoColumn>
                                    </Columns>
                                    <Styles AdaptiveDetailButtonWidth="22">
                                        <AlternatingRow Enabled="True"></AlternatingRow>
                                    </Styles>
                                </dx:ASPxGridView>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
            </dx:LayoutGroup>
        </Items>
    </dx:ASPxFormLayout>
    <asp:SqlDataSource ID="sdsFreeTextListing" runat="server" ConnectionString="<%$ ConnectionStrings:SqlLocalConnectionString %>" ProviderName="<%$ ConnectionStrings:SqlLocalConnectionString.ProviderName %>"
        SelectCommand="SELECT 
	            A.DocNo,
	            A.DocDate,
	            A.MemoBranch,
	            A.Status,
	            A.MemoFrom,
	            A.MemoTo,
	            A.MemoPerihal,
	            (SELECT TOP 1 Nama FROM [InternalMemoApprovalList] WHERE DocKey = A.DocKey ORDER BY Seq DESC) AS FinalApprover,
	            (SELECT TOP 1 DecisionNote FROM [InternalMemoApprovalList] WHERE DocKey = A.DocKey ORDER BY Seq DESC) AS FinalApprovalNote
            FROM [dbo].[InternalMemo] A 
            WHERE A.DocType = 'FREE TEXT MEMO'
            ORDER BY A.DocDate Desc"></asp:SqlDataSource>
</asp:Content>
