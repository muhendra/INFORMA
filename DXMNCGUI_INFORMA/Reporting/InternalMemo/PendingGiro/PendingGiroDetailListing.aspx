<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="PendingGiroDetailListing.aspx.cs" Inherits="DXMNCGUI_INFORMA.Reporting.InternalMemo.PendingGiro.PendingGiroDetailListing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript" src="~/Scripts/Application.js"></script>
    <script type="text/javascript">
    </script>
    <dx:ASPxHiddenField runat="server" ID="HiddenField" ClientInstanceName="HiddenField"/>
    <dx:ASPxFormLayout runat="server" ID="FormLayout" ClientInstanceName="FormLayout" Font-Names="Calibri">
        <SettingsAdaptivity AdaptivityMode="SingleColumnWindowLimit" SwitchToSingleColumnAtWindowInnerWidth="800"/>
        <Items>
            <dx:LayoutGroup ShowCaption="True" GroupBoxDecoration="HeadingLine" Caption="Pending Giro Detail Listing" ColCount="5">
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
                                    DataSourceID="sdsPendingGiroDetailListing"
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
                                        <dx:GridViewDataTextColumn Name="colDebitur" Caption="Debitur" FieldName="NamaDebitur" ReadOnly="True" ShowInCustomizationForm="true">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="colAgreement" Caption="Agreement" FieldName="AgreementNo" ReadOnly="True" ShowInCustomizationForm="true">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="colNoGiro" Caption="No. Giro" FieldName="NoGiro" ReadOnly="True" ShowInCustomizationForm="true">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataSpinEditColumn Name="colNominalGiro" Caption="Nominal Giro" FieldName="NominalGiro" ReadOnly="True" PropertiesSpinEdit-DisplayFormatString="#,0.00" ShowInCustomizationForm="true">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                            <CellStyle Font-Bold="true"></CellStyle>
                                        </dx:GridViewDataSpinEditColumn>
                                        <dx:GridViewDataDateColumn Name="colTglJatuhTempo" Caption="Tgl Jatuh Tempo" FieldName="TglJatuhTempo" ReadOnly="True" ShowInCustomizationForm="true" PropertiesDateEdit-DisplayFormatString="dd/MM/yyyy">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataDateColumn>
                                        <dx:GridViewDataDateColumn Name="colTglDiJalankanKembali" Caption="Tgl Di Jalankan Kembali" FieldName="TglDiJalankanKembali" ReadOnly="True" ShowInCustomizationForm="true" PropertiesDateEdit-DisplayFormatString="dd/MM/yyyy">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataDateColumn>
                                        <dx:GridViewDataTextColumn Name="colStatus" Caption="Status" FieldName="Status" ReadOnly="True" ShowInCustomizationForm="true">
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
    <asp:SqlDataSource ID="sdsPendingGiroDetailListing" runat="server" ConnectionString="<%$ ConnectionStrings:SqlLocalConnectionString %>" ProviderName="<%$ ConnectionStrings:SqlLocalConnectionString.ProviderName %>"
        SelectCommand="SELECT 
                        A.DocNo,
                        A.DocDate,
                        A.MemoBranch,
                        B.NamaDebitur,
                        B.AgreementNo,
                        B.NoGiro,
                        B.NominalGiro,
                        B.TglJatuhTempo,
                        B.TglDiJalankanKembali,
                        A.Status,
                        (SELECT TOP 1 Nama FROM [InternalMemoApprovalList] WHERE DocKey = A.DocKey ORDER BY Seq DESC) AS FinalApprover,
                        (SELECT TOP 1 DecisionNote FROM [InternalMemoApprovalList] WHERE DocKey = A.DocKey ORDER BY Seq DESC) AS FinalApprovalNote
                        FROM [dbo].[InternalMemo] A
                        INNER JOIN [dbo].[InternalMemoDetailPendingGiro] B 
                        ON A.DocKey = B.DocKey WHERE A.DocType = 'PENDING GIRO'
                        ORDER BY A.DocDate"></asp:SqlDataSource>
</asp:Content>
