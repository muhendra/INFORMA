<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="FreeTextMemoEntry.aspx.cs" Inherits="DXMNCGUI_INFORMA.Transaction.InternalMemo.FreeTextMemo.FreeTextMemoEntry" %>
<%@ Register Assembly="DevExpress.Web.ASPxRichEdit.v17.2, Version=17.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRichEdit" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxRichEdit.v17.2, Version=17.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxTreeList" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript" src="../../Scripts/Application.js"></script>
    <script type="text/javascript">
        var DocNo;
        function cplMain_EndCallback(s, e) {
            switch (cplMain.cpCallbackParam) {
                case "APPROVE_CONFIRM":
                    if (cplMain.cplblmessageError.length > 0) {
                        apcalert.SetContentHtml(cplMain.cplblmessageError);
                        apcalert.Show();
                        break;
                    }
                    if (ASPxClientEdit.ValidateGroup("ValidationSave")) {
                        mmDecisionNote.SetVisible(true);
                        apcconfirm.Show();
                        lblmessage.SetText(cplMain.cplblmessage);
                    }
                    break;
                case "APPROVE":
                    apcalert.SetContentHtml(cplMain.cpAlertMessage);
                    apcalert.Show();
                    break;
                case "REJECT_CONFIRM":
                    if (cplMain.cplblmessageError.length > 0) {
                        apcalert.SetContentHtml(cplMain.cplblmessageError);
                        apcalert.Show();
                        break;
                    }
                    if (ASPxClientEdit.ValidateGroup("ValidationSave")) {
                        mmDecisionNote.SetVisible(true);
                        apcconfirm.Show();
                        lblmessage.SetText(cplMain.cplblmessage);
                    }
                    break;
                case "REJECT":
                    apcalert.SetContentHtml(cplMain.cpAlertMessage);
                    apcalert.Show();
                    break;
                case "SAVE_CONFIRM":
                    if (cplMain.cplblmessageError.length > 0) {
                        apcalert.SetContentHtml(cplMain.cplblmessageError);
                        apcalert.Show();
                        break;
                    }
                    if (ASPxClientEdit.ValidateGroup("ValidationSave")) {
                        apcconfirm.Show();
                        lblmessage.SetText(cplMain.cplblmessage);
                    }
                    break;
                case "SAVE":
                    apcalert.SetContentHtml(cplMain.cpAlertMessage);
                    apcalert.Show();
                    break;
            }
        }
        function gvApproval_EndCallback(s, e) {
            if (s.cpCmd == "INSERT" || s.cpCmd == "UPDATE" || s.cpCmd == "DELETE") {
                s.cpCmd = "";
            }
        }

        function OnNameChanged(s, e) {
            gvApproval.GetEditor("colNIK").SetValue(s.GetSelectedItem().GetColumnText('NIK'));
        }
    </script>

    <dx:ASPxHiddenField runat="server" ID="HiddenField" ClientInstanceName="HiddenField" />
    <dx:ASPxPopupControl ID="apcconfirm" ClientInstanceName="apcconfirm" runat="server" Modal="True" Theme="Aqua"
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" HeaderText="Alert Confirmation !" AllowDragging="True" PopupAnimationType="Fade" EnableViewState="False">
        <ContentCollection>
            <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
                <dx:ASPxFormLayout ID="ASPxFormLayout6" runat="server">
                    <Items>
                        <dx:LayoutGroup ShowCaption="False" GroupBoxDecoration="None" ColCount="2">
                            <Items>
                                <dx:LayoutItem Caption="" ShowCaption="False" ColSpan="2">
                                    <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer7" runat="server">
                                            <dx:ASPxLabel ID="lblmessage" ClientInstanceName="lblmessage" runat="server" Text="" Width="100%" Theme="Aqua">
                                            </dx:ASPxLabel>
                                        </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>
                                <dx:LayoutItem ShowCaption="False" ColSpan="2">
                                    <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                            <dx:ASPxMemo runat="server" ID="mmDecisionNote" ClientInstanceName="mmDecisionNote" ClientVisible="false" Width="100%" Height="50px" Theme="Aqua">
                                            </dx:ASPxMemo>
                                        </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>
                                <dx:LayoutItem ShowCaption="False" ColSpan="1">
                                    <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer8" runat="server">
                                            <dx:ASPxButton ID="btnSaveConfirm" runat="server" Text="OK" AutoPostBack="False" UseSubmitBehavior="false" Width="100" Theme="Aqua">
                                                <ClientSideEvents Click="function(s, e) { apcconfirm.Hide();cplMain.PerformCallback(cplMain.cplblActionButton + ';'+cplMain.cplblActionButton); }" />
                                            </dx:ASPxButton>
                                        </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>
                                <dx:LayoutItem ShowCaption="False" ColSpan="1">
                                    <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer9" runat="server">
                                            <dx:ASPxButton ID="btnCancelConfirm" runat="server" Text="Cancel" AutoPostBack="False" UseSubmitBehavior="false" Width="100" Theme="Aqua">
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
    <dx:ASPxPopupControl ID="apcalert" ClientInstanceName="apcalert" runat="server" Modal="True"
        PopupHorizontalAlign="WindowCenter" AutoUpdatePosition="true" ShowCloseButton="true" PopupVerticalAlign="WindowCenter" HeaderText="Alert !" AllowDragging="True" PopupAnimationType="Fade" EnableViewState="False">
    </dx:ASPxPopupControl>
    <dx:ASPxFormLayout runat="server" ID="FormLayout" ClientInstanceName="FormLayout" Font-Names="Calibri">
        <SettingsAdaptivity AdaptivityMode="SingleColumnWindowLimit" SwitchToSingleColumnAtWindowInnerWidth="800" />
        <Items>
            <dx:LayoutGroup ShowCaption="True" GroupBoxDecoration="Box" Caption="Free Template Memo" ColCount="4">
                <Items>
                    <dx:LayoutItem ShowCaption="False" HorizontalAlign="Center" Width="100%" ColSpan="4">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxLabel runat="server" Text="FREE TEMPLATE MEMO" Font-Bold="true" Font-Size="Large" Font-Underline="true" ForeColor="#808080">
                                </dx:ASPxLabel>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem ShowCaption="False" HorizontalAlign="Center" Width="100%" ColSpan="4">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxLabel runat="server" ID="lblDocNo" ClientInstanceName="lblDocNo" Text="" Font-Bold="true" Font-Size="Medium" ForeColor="#808080" Visible="false"></dx:ASPxLabel>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem ShowCaption="True" Caption="Memo">
                        <CaptionStyle Font-Bold="true" ForeColor="#1872c4"></CaptionStyle>
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxTextBox runat="server" ID="txtMemo" ClientInstanceName="txtMemo" Width="100%" Theme="Aqua"></dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                    <dx:LayoutItem ShowCaption="True" Caption="Status">
                        <CaptionStyle Font-Bold="true" ForeColor="#1872c4"></CaptionStyle>
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxTextBox runat="server" ID="txtStatus" ClientInstanceName="txtStatus" Width="100%" Theme="Aqua"></dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    
                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                    <dx:LayoutItem ShowCaption="True" Caption="Tanggal">
                        <CaptionStyle Font-Bold="true" ForeColor="#1872c4"></CaptionStyle>
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxDateEdit runat="server" ID="deTanggal" ClientInstanceName="deTanggal" DisplayFormatString="dd/MM/yyyy" Width="100%" Theme="Aqua" CalendarProperties-ShowClearButton="false"></dx:ASPxDateEdit>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    

                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                    <dx:TabbedLayoutGroup Name="tbLayoutGroup" ClientInstanceName="tbLayoutGroup" Height="100px" Width="100%" ActiveTabIndex="0" Border-BorderStyle="Solid" Border-BorderWidth="0" Border-BorderColor="#d1ecee">
                        <Styles>
                            <ContentStyle Font-Names="Calibri"></ContentStyle>
                        </Styles>
                        <Items>
                            <dx:LayoutGroup Name="lgDetailMemo" GroupBoxDecoration="Box" Caption="Free Text Memo" GroupBoxStyle-Caption-BackColor="White" ColCount="4" Visible="True">
                                <Items>
                                    <dx:LayoutItem ShowCaption="False" HorizontalAlign="Center" Width="100%" ColSpan="4">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxRichEdit ID="reMemo" runat="server" ClientInstanceName="reMemo" WorkDirectory="~\App_Data\WorkDirectory" ReadOnly="false" ShowConfirmOnLosingChanges="false">
                                                    <Settings>
                                                        <Behavior CreateNew="Hidden" SaveAs="Disabled" Open="Disabled" Save="Disabled" Printing="Disabled" />
                                                    </Settings>
                                                </dx:ASPxRichEdit>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    
                                </Items>
                            </dx:LayoutGroup>
                            <dx:LayoutGroup Name="lgDetailApproval" GroupBoxDecoration="Box" Caption="Approval" GroupBoxStyle-Caption-BackColor="White" ColCount="4" Visible="True">
                                <Items>
                                    <dx:LayoutItem ShowCaption="False" Width="100%">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxGridView
                                                    runat="server"
                                                    ID="gvApproval"
                                                    ClientInstanceName="gvApproval"
                                                    Width="100%"
                                                    KeyFieldName="DtlAppKey"
                                                    AutoGenerateColumns="False"
                                                    EnableCallBacks="true"
                                                    EnablePagingCallbackAnimation="true"
                                                    EnableTheming="True"
                                                    Theme="Aqua"
                                                    Font-Names="Calibri"
                                                    OnDataBinding="gvApproval_DataBinding"
                                                    OnRowInserting="gvApproval_RowInserting"
                                                    OnRowUpdating="gvApproval_RowUpdating"
                                                    OnRowDeleting="gvApproval_RowDeleting"
                                                    OnCustomCallback="gvApproval_CustomCallback"
                                                    OnAutoFilterCellEditorInitialize="gvApproval_AutoFilterCellEditorInitialize" OnCellEditorInitialize="gvApproval_CellEditorInitialize"
                                                    OnCustomColumnDisplayText="gvApproval_CustomColumnDisplayText">
                                                    <SettingsAdaptivity AdaptivityMode="HideDataCellsWindowLimit" AllowOnlyOneAdaptiveDetailExpanded="True" HideDataCellsAtWindowInnerWidth="700"></SettingsAdaptivity>
                                                    <ClientSideEvents EndCallback="gvApproval_EndCallback" />
                                                    <Settings ShowFilterRow="false" ShowGroupPanel="false" ShowFilterRowMenu="false" ShowFilterBar="Auto" ShowHeaderFilterButton="false" />
                                                    <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True" FilterRowMode="OnClick" EnableRowHotTrack="true" />
                                                    <SettingsDataSecurity AllowDelete="true" AllowEdit="true" AllowInsert="true" />
                                                    <SettingsSearchPanel Visible="false" />
                                                    <SettingsFilterControl ViewMode="VisualAndText" AllowHierarchicalColumns="true" ShowAllDataSourceColumns="true" MaxHierarchyDepth="1" />
                                                    <SettingsPager PageSize="5" AllButton-Visible="true" Summary-Visible="true" Visible="true"></SettingsPager>
                                                    <SettingsText ConfirmDelete="Are you really want to Delete?" />
                                                    <SettingsEditing Mode="Inline" NewItemRowPosition="Bottom"></SettingsEditing>
                                                    <SettingsCommandButton>
                                                        <NewButton ButtonType="Button" Text="Add New" Styles-Style-Width="75px">
                                                        </NewButton>
                                                        <EditButton Text="Edit" ButtonType="Button" Styles-Style-Width="75px"></EditButton>
                                                        <UpdateButton Text="Save" ButtonType="Button" Styles-Style-Width="75px"></UpdateButton>
                                                        <CancelButton ButtonType="Button" Styles-Style-Width="75px"></CancelButton>
                                                        <DeleteButton ButtonType="Button" Styles-Style-Width="75px"></DeleteButton>
                                                    </SettingsCommandButton>
                                                    <Columns>
                                                        <dx:GridViewDataTextColumn Name="colNo" Caption="No" ReadOnly="True" UnboundType="String" VisibleIndex="0" Width="2%">
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                            <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False"
                                                                AllowDragDrop="False" AllowGroup="False" AllowHeaderFilter="False"
                                                                AllowSort="False" />
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewCommandColumn Name="ClmnCommand" ShowApplyFilterButton="true" ShowClearFilterButton="true" ShowDeleteButton="True" ShowEditButton="True" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="1" Width="10%">
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                        </dx:GridViewCommandColumn>
                                                        <dx:GridViewDataTextColumn Name="colDtlAppKey" Caption="DtlAppKey" FieldName="DtlAppKey" ReadOnly="True" Visible="false" VisibleIndex="2">
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Name="colDocKey" Caption="DocKey" FieldName="DocKey" ReadOnly="True" ShowInCustomizationForm="true" Visible="false" VisibleIndex="3">
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Name="colSeq" Caption="Seq" FieldName="Seq" ReadOnly="True" ShowInCustomizationForm="true" Visible="false" VisibleIndex="4">
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Name="colNIK" FieldName="NIK" ShowInCustomizationForm="True" Caption="NIK" ReadOnly="true" Width="10%">
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataComboBoxColumn Name="colNama" FieldName="Nama" ShowInCustomizationForm="True" Caption="Nama" Width="10%">
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                            <PropertiesComboBox EnableCallbackMode="true" ClientInstanceName="colNama" DropDownRows="10" IncrementalFilteringDelay="500" IncrementalFilteringMode="Contains" DisplayFormatString="{1}" TextFormatString="{1}" DropDownStyle="DropDownList" ValueField="Nama" TextField="Nama" Width="100%">
                                                                <ClientSideEvents SelectedIndexChanged="OnNameChanged" />
                                                                <ItemStyle Wrap="True"></ItemStyle>
                                                                <Columns>
                                                                    <dx:ListBoxColumn FieldName="NIK" Caption="NIK" Width="150px" />
                                                                    <dx:ListBoxColumn FieldName="Nama" Caption="Nama" Width="150px" />
                                                                </Columns>
                                                                <ValidationSettings ValidateOnLeave="true" ValidationGroup="ValidationSave" Display="Dynamic" ErrorDisplayMode="ImageWithText">
                                                                    <RequiredField ErrorText="* Value can't be empty." IsRequired="true" />
                                                                </ValidationSettings>
                                                            </PropertiesComboBox>
                                                        </dx:GridViewDataComboBoxColumn>
                                                        <dx:GridViewDataTextColumn Name="colJabatan" FieldName="Jabatan" Caption="Jabatan" Width="10%">
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataCheckColumn Name="colIsDecision" FieldName="IsDecision" ShowInCustomizationForm="True" Caption="Decision?" ReadOnly="true" Width="5%">
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                            <PropertiesCheckEdit ValueChecked="T" ValueGrayed="N" ClientInstanceName="colIsApprove" ValueType="System.Char" ValueUnchecked="F"></PropertiesCheckEdit>
                                                        </dx:GridViewDataCheckColumn>
                                                        <dx:GridViewDataTextColumn Name="colDecisionState" FieldName="DecisionState" Caption="State" ReadOnly="true" Width="10%">
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataDateColumn Name="colDecisionDate" FieldName="DecisionDate" Caption="Decision Date" PropertiesDateEdit-DisplayFormatString="dd/MM/yyyy hh:mm:ss tt" ReadOnly="true" Width="10%">
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                        </dx:GridViewDataDateColumn>
                                                        <dx:GridViewDataMemoColumn Name="colDecisionNote" FieldName="DecisionNote" Caption="Note" ReadOnly="true" PropertiesMemoEdit-Height="16px">
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                        </dx:GridViewDataMemoColumn>
                                                    </Columns>
                                                </dx:ASPxGridView>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                </Items>
                            </dx:LayoutGroup>
                        </Items>
                    </dx:TabbedLayoutGroup>
                </Items>
            </dx:LayoutGroup>
            <dx:LayoutGroup ShowCaption="False" GroupBoxDecoration="HeadingLine" ColCount="5">
                <Items>
                    <dx:EmptyLayoutItem Width="40%"></dx:EmptyLayoutItem>
                    <dx:LayoutItem ShowCaption="False" Width="10%">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxButton runat="server" ID="btnReject" ClientInstanceName="btnReject" Text="Reject" AutoPostBack="false" Theme="Aqua" ClientVisible="false">
                                    <ClientSideEvents Click="function(s,e) { cplMain.PerformCallback('REJECT_CONFIRM;' + 'REJECT_CONFIRM'); }" />
                                </dx:ASPxButton>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem ShowCaption="False" Width="10%">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxButton runat="server" ID="btnApprove" ClientInstanceName="btnApprove" Text="Approve" AutoPostBack="false" Theme="Aqua" ClientVisible="false">
                                    <ClientSideEvents Click="function(s,e) { cplMain.PerformCallback('APPROVE_CONFIRM;' + 'APPROVE_CONFIRM'); }" />
                                </dx:ASPxButton>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem ShowCaption="False" Width="10%">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxButton runat="server" ID="btnSave" ClientInstanceName="btnSave" Text="Save" AutoPostBack="false" Theme="Aqua">
                                    <ClientSideEvents Click="function(s,e) { cplMain.PerformCallback('SAVE_CONFIRM;' + 'SAVE_CONFIRM'); }" />
                                </dx:ASPxButton>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem ShowCaption="False" Width="10%">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxButton runat="server" ID="btnBack" ClientInstanceName="btnBack" Text="Back" AutoPostBack="false" Theme="Aqua" OnClick="btnBack_Click">
                                </dx:ASPxButton>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem ShowCaption="False" Width="10%">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxButton ID="btnexport" runat="server" Text="Export PDF" OnClick="btnexport_Click1" UseSubmitBehavior="false" Width="100" Theme="Aqua"></dx:ASPxButton>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
            </dx:LayoutGroup>
            <%--<dx:EmptyLayoutItem Width="50%"></dx:EmptyLayoutItem>--%>
            

            
        </Items>
    </dx:ASPxFormLayout>

    <dx:ASPxCallback ID="cplMain" runat="server" ClientInstanceName="cplMain" OnCallback="cplMain_Callback">
        <ClientSideEvents EndCallback="cplMain_EndCallback" />
    </dx:ASPxCallback>
</asp:Content>
