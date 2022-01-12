<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="FreeTemplateMaint.aspx.cs" Inherits="DXMNCGUI_INFORMA.Transaction.InternalMemo.FreeTemplate.FreeTemplateMaint" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <script type="text/javascript" src="../../../Scripts/Application.js"></script>
    <script type="text/javascript">
        var DocNo;
        function cplMain_EndCallback(s, e)
        {
            switch (cplMain.cpCallbackParam)
            {
                case 'NEW':
                    //apcselectdoctype.Show();
                    break;
                case 'NEW_ENTRY_CONFIRM':
                    break;
                case 'PRINT':
                    var DocNo = cplMain.cpDocNo;
                    var DocKey = cplMain.cpDocKey;
                    var Tipe = cplMain.cpDocType;
                    switch (Tipe) {
                        case 'PEMAKAIAN CASH COLLATERAL':
                            window.open('../../Shared/DocViewer.aspx?ReportType=IM1&Title=Internal Memorandum - ' + Tipe + '&DocNo=' + DocNo + '&DocKey=' + DocKey);
                            break;
                        case 'PELEPASAN CROSS COLLATERAL':
                            window.open('../../Shared/DocViewer.aspx?ReportType=IM2&Title=Internal Memorandum - ' + Tipe + '&DocNo=' + DocNo + '&DocKey=' + DocKey);
                            break;
                        case 'PENDING GIRO':
                            window.open('../../Shared/DocViewer.aspx?ReportType=IM3&Title=Internal Memorandum - ' + Tipe + '&DocNo=' + DocNo + '&DocKey=' + DocKey);
                            break;
                        case 'PERMOHONAN PENGADAAN BARANG & JASA':
                            window.open('../../Shared/DocViewer.aspx?ReportType=IM4&Title=Internal Memorandum - ' + Tipe + '&DocNo=' + DocNo + '&DocKey=' + DocKey);
                            break;
                        case 'BIAYA BULANAN':
                            window.open('../../Shared/DocViewer.aspx?ReportType=IM5&Title=Internal Memorandum - ' + Tipe + '&DocNo=' + DocNo + '&DocKey=' + DocKey);
                            break;
                    }
                    break;
            }
        }
        function gvMain_CustomButtonClick(s, e) {
            switch (e.buttonID) {
                case 'btnPrint':
                    cplMain.PerformCallback('PRINT' + ';PRINT');
                    break;
            }
        }
        function gvApprovalList_CustomButtonClick(s, e) {
            switch (e.buttonID) {
                case "btnShow":
                    cplMain.PerformCallback("SHOW;SHOW");
                    break;
            }
        }
    </script>
    <dx:ASPxHiddenField runat="server" ID="HiddenField" ClientInstanceName="HiddenField"/>
    <dx:ASPxPopupControl ID="apcconfirm" ClientInstanceName="apcconfirm" runat="server" Modal="True"
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" HeaderText="Alert Confirmation !" AllowDragging="True" PopupAnimationType="Fade" EnableViewState="False">
        <ContentCollection>
            <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
                <dx:ASPxFormLayout ID="ASPxFormLayout6" runat="server" Theme="Aqua">
                    <Items>
                        <dx:LayoutGroup ShowCaption="False" GroupBoxDecoration="None" ColCount="2">
                            <Items>
                                <dx:LayoutItem Caption="" ShowCaption="False" ColSpan="2">
                                    <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer7" runat="server">
                                            <dx:ASPxLabel ID="lblmessage" ClientInstanceName="lblmessage" runat="server" Text="" Width="100%">
                                            </dx:ASPxLabel>
                                        </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>
                                <dx:LayoutItem ShowCaption="False" ColSpan="1">
                                    <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer8" runat="server">
                                            <dx:ASPxButton ID="btnSaveConfirm" runat="server" Text="OK" AutoPostBack="False" UseSubmitBehavior="false" Width="100">
                                                <ClientSideEvents Click="function(s, e) { apcconfirm.Hide();cplMain.PerformCallback(cplMain.cplblActionButton + ';'+cplMain.cplblActionButton); }" />
                                            </dx:ASPxButton>
                                        </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>
                                <dx:LayoutItem ShowCaption="False" ColSpan="1">
                                    <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer9" runat="server">
                                            <dx:ASPxButton ID="btnCancelConfirm" runat="server" Text="Cancel" AutoPostBack="False" UseSubmitBehavior="false" Width="100">
                                                <ClientSideEvents Click="function(s, e) { apcconfirm.Hide(); }" />
                                            </dx:ASPxButton>
                                        </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>
                            </Items>
                        </dx:LayoutGroup>
                    </Items>
                </dx:ASPxFormLayout>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxPopupControl>
    <dx:ASPxPopupControl ID="apcalert" ClientInstanceName="apcalert" runat="server" Modal="True" Theme="Aqua"
        PopupHorizontalAlign="WindowCenter" AutoUpdatePosition="true" ShowCloseButton="true" PopupVerticalAlign="WindowCenter" HeaderText="Alert Error!" AllowDragging="True" PopupAnimationType="Fade" EnableViewState="False">
    </dx:ASPxPopupControl>
    <dx:ASPxPopupControl ID="apcApproval" ClientInstanceName="apcApproval" runat="server" Modal="True" Theme="Aqua" Width="750px" CloseAction="CloseButton"
        PopupHorizontalAlign="WindowCenter" AutoUpdatePosition="true" ShowCloseButton="true" PopupVerticalAlign="WindowCenter" HeaderText="Your approval list.." AllowDragging="True" PopupAnimationType="Fade" EnableViewState="False">
        <SettingsAdaptivity Mode="OnWindowInnerWidth" MaxHeight="100%" MaxWidth="100%"/>
        <ContentCollection>
            <dx:PopupControlContentControl runat="server">
                <dx:ASPxFormLayout runat="server">
                    <Items>
                        <dx:LayoutItem ShowCaption="False" Width="100%">
                            <LayoutItemNestedControlCollection>
                                <dx:LayoutItemNestedControlContainer>
                                    <dx:ASPxGridView 
                                        ID="gvApprovalList"
                                        ClientInstanceName="gvApprovalList"
                                        runat="server"
                                        Width="100%"
                                        AutoGenerateColumns="False"
                                        EnableCallBacks="true"
                                        EnablePagingCallbackAnimation="true"
                                        EnableTheming="True" 
                                        OnInit="gvApprovalList_Init" OnDataBinding="gvApprovalList_DataBinding" OnFocusedRowChanged="gvApprovalList_FocusedRowChanged" OnCustomCallback="gvApprovalList_CustomCallback" OnLoad="gvApprovalList_Load"
                                        Theme="Aqua" Font-Size="Small" Font-Names="Calibri" KeyFieldName="DocKey">
                                        <SettingsAdaptivity AdaptivityMode="HideDataCellsWindowLimit" AllowOnlyOneAdaptiveDetailExpanded="True" HideDataCellsAtWindowInnerWidth="700"></SettingsAdaptivity>
                                        <ClientSideEvents CustomButtonClick="function(s, e) { gvApprovalList_CustomButtonClick(s, e); }"/>
                                        <Settings ShowFilterRow="false" ShowGroupPanel="False" ShowFilterRowMenu="false" ShowFilterBar="Hidden" ShowHeaderFilterButton="true" ShowFooter="false" />
                                        <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True" EnableRowHotTrack="true" EnableCustomizationWindow="true" AllowEllipsisInText="true" />
                                        <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                                        <SettingsSearchPanel Visible="True" />
                                        <SettingsFilterControl ViewMode="VisualAndText" AllowHierarchicalColumns="true" ShowAllDataSourceColumns="true" MaxHierarchyDepth="1" />
                                        <SettingsLoadingPanel Mode="Disabled" />
                                        <SettingsPager PageSize="5"></SettingsPager>
                                        <SettingsResizing ColumnResizeMode="Control" Visualization="Live" />
                                        <Columns>
                                            <dx:GridViewDataTextColumn Name="colSourceKey" Caption="SourceKey" FieldName="SourceKey" ReadOnly="True" ShowInCustomizationForm="true" Visible="false" VisibleIndex="0">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Name="colDocNo" Caption="Memo No." FieldName="DocNo" ReadOnly="True" ShowInCustomizationForm="true" Visible="true" VisibleIndex="1" Width="20%">
                                                <HeaderStyle Font-Bold="true" />
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Name="colDocType" Caption="Type" FieldName="DocType" ReadOnly="True" ShowInCustomizationForm="true" Visible="false" VisibleIndex="2">
                                                <HeaderStyle Font-Bold="true" />
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Name="colMemoFrom" Caption="From" FieldName="CreatedMemoBy" ReadOnly="True" ShowInCustomizationForm="true" Visible="true" VisibleIndex="3" Width="20%">
                                                <HeaderStyle Font-Bold="true" />
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewCommandColumn ButtonType="Button" VisibleIndex="4" Caption=" " Width="6%">
                                                <HeaderStyle Font-Bold="true" />
                                                <CustomButtons>
                                                <dx:GridViewCommandColumnCustomButton ID="btnShow" Text="Show"></dx:GridViewCommandColumnCustomButton>
                                                </CustomButtons>
                                            </dx:GridViewCommandColumn>
                                        </Columns>
                                        <Styles>
                                            <AlternatingRow Enabled="True"></AlternatingRow>
                                        </Styles>
                                        <Styles AdaptiveDetailButtonWidth="22" Footer-Font-Bold="true"></Styles>
                                    </dx:ASPxGridView>
                                </dx:LayoutItemNestedControlContainer>
                            </LayoutItemNestedControlCollection>
                        </dx:LayoutItem>
                    </Items>
                </dx:ASPxFormLayout>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxPopupControl>
    <dx:ASPxFormLayout runat="server" ID="FormLayout" ClientInstanceName="FormLayout" Font-Names="Calibri">
        <SettingsAdaptivity AdaptivityMode="SingleColumnWindowLimit" SwitchToSingleColumnAtWindowInnerWidth="800"/>
        <Items>
            <dx:LayoutGroup ShowCaption="True" GroupBoxDecoration="HeadingLine" Caption="Internal Memo Free Template" ColCount="5">
                <GroupBoxStyle>
                    <Caption ForeColor="SlateGray" Font-Size="Larger" Font-Bold="true" BackColor="Transparent"></Caption>
                </GroupBoxStyle>
                <Items>
                    <dx:LayoutItem ShowCaption="False" Width="10%">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                <dx:ASPxButton ID="btnNew" ClientInstanceName="btnNew" runat="server" Text="New" Width="100%" AutoPostBack="false" Theme="Aqua">
                                    <ClientSideEvents Click="function(s,e) { cplMain.PerformCallback('NEW;' + 'NEW');}"/>
                                </dx:ASPxButton>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem ShowCaption="False" Width="10%">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2" runat="server">
                                <dx:ASPxButton ID="btnView" ClientInstanceName="btnView" runat="server" Text="View" OnClick="btnView_Click" Width="100%" Theme="Aqua">
                                </dx:ASPxButton>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem ShowCaption="False" Width="10%">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer3" runat="server">
                                <dx:ASPxButton ID="btnEdit" ClientInstanceName="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" Width="100%" Theme="Aqua">
                                </dx:ASPxButton>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem ShowCaption="False" Width="10%">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer4" runat="server">
                                <dx:ASPxButton ID="btnRefresh" ClientInstanceName="btnRefresh" runat="server" Text="Refresh" OnClick="btnRefresh_Click" Width="100%" Theme="Aqua">
                                </dx:ASPxButton>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:EmptyLayoutItem Width="45%"></dx:EmptyLayoutItem>
                    <dx:LayoutItem ShowCaption="False" Width="15%">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer5" runat="server">
                                <dx:ASPxButton ID="btnApprovalList" ClientInstanceName="btnApprovalList" runat="server" Text="List Approval" Width="100%" Theme="Aqua" AutoPostBack="false" OnClick="btnApprovalList_Click"></dx:ASPxButton>
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
                                    KeyFieldName="DocNo"
                                    Width="100%"
                                    AutoGenerateColumns="False"
                                    EnableCallBacks="true"
                                    EnablePagingCallbackAnimation="true"
                                    OnDataBinding="gvMain_DataBinding"
                                    OnFocusedRowChanged="gvMain_FocusedRowChanged"
                                    OnCustomCallback="gvMain_CustomCallback" OnCustomColumnDisplayText="gvMain_CustomColumnDisplayText"
                                    EnableTheming="True" Theme="Aqua"
                                    Font-Size="Small" Font-Names="Calibri">
                                    <SettingsAdaptivity AdaptivityMode="HideDataCellsWindowLimit" AllowOnlyOneAdaptiveDetailExpanded="True" HideDataCellsAtWindowInnerWidth="700">
                                    </SettingsAdaptivity>
                                    <ClientSideEvents CustomButtonClick="function(s,e) { gvMain_CustomButtonClick(s,e); }"/>
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
                                        <dx:GridViewCommandColumn ButtonType="Button" VisibleIndex="0" Caption=" " Width="10%">
                                            <CustomButtons>
                                                <dx:GridViewCommandColumnCustomButton ID="btnPrint" Text="Download">
                                                </dx:GridViewCommandColumnCustomButton>
                                            </CustomButtons>
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true" />
                                        </dx:GridViewCommandColumn>
                                        <dx:GridViewDataTextColumn Name="colDocKey" Caption="DocKey" FieldName="DocKey" ReadOnly="True" ShowInCustomizationForm="true" Visible="false" Width="15%">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="colDocNo" Caption="Document No." FieldName="DocNo" ReadOnly="True" ShowInCustomizationForm="true" Visible="true" VisibleIndex="0" Width="15%">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataDateColumn Name="colDocDate" Caption="Document Date" FieldName="DocDate" ReadOnly="True" ShowInCustomizationForm="true" VisibleIndex="1" PropertiesDateEdit-DisplayFormatString="dd/MM/yyyy" Width="15%">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataDateColumn>
                                        <dx:GridViewDataTextColumn Name="colRemark1" Caption="Remark" FieldName="Remark1" ReadOnly="True" ShowInCustomizationForm="true" Visible="true" VisibleIndex="2" Width="20%">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataMemoColumn Name="colFrom" Caption="From" FieldName="MemoFrom" ReadOnly="true" ShowInCustomizationForm="true" VisibleIndex="3">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataMemoColumn>
                                        <dx:GridViewDataTextColumn Name="colType" Caption="" FieldName="DocValue" ReadOnly="true" ShowInCustomizationForm="true" VisibleIndex="4" Visible="false">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="colStatus" Caption="Status" FieldName="Status" ReadOnly="true" ShowInCustomizationForm="true" VisibleIndex="5" Visible="true">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="colNextApprover" Caption="Next Approver" FieldName="NextApprover" ReadOnly="true" ShowInCustomizationForm="true" VisibleIndex="6" Visible="true">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataTextColumn>
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
    <dx:ASPxCallback ID="cplMain" runat="server" ClientInstanceName="cplMain" OnCallback="cplMain_Callback">
        <ClientSideEvents EndCallback="cplMain_EndCallback" />
    </dx:ASPxCallback>
</asp:Content>
