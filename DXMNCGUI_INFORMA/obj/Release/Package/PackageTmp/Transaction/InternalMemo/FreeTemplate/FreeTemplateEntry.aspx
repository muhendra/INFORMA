<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="FreeTemplateEntry.aspx.cs" Inherits="DXMNCGUI_INFORMA.Transaction.InternalMemo.FreeTemplate.FreeTemplateEntry" %>

<%@ Register Assembly="DevExpress.Web.ASPxRichEdit.v17.2, Version=17.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRichEdit" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxRichEdit.v17.2, Version=17.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxTreeList" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        function OnExceptionOccurred(s, e) {
            e.handled = true;
            alert(e.message);
            window.location.reload();
        }
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
        function OnNameChanged(s, e) {
            gvApproval.GetEditor("colNIK").SetValue(s.GetSelectedItem().GetColumnText('NIK'));
        }
    </script>
    <dx:ASPxHiddenField runat="server" ID="HiddenField" ClientInstanceName="HiddenField"/>
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
        PopupHorizontalAlign="WindowCenter" AutoUpdatePosition="true" ShowCloseButton="true" PopupVerticalAlign="WindowCenter" HeaderText="Alert!" AllowDragging="True" PopupAnimationType="Fade" EnableViewState="False">
    </dx:ASPxPopupControl>
    <dx:ASPxFormLayout runat="server" ID="FormLayout1" ClientInstanceName="FormLayout1" Font-Names="Calibri">
        <SettingsAdaptivity AdaptivityMode="SingleColumnWindowLimit" SwitchToSingleColumnAtWindowInnerWidth="800"/>
        <Items>
            <dx:LayoutGroup ShowCaption="True" GroupBoxDecoration="HeadingLine" Caption="Internal Memo Entry [Free Template]" ColCount="1">
                <GroupBoxStyle Border-BorderColor="#bfdafe">
                    <Caption ForeColor="#1872c4" Font-Size="Larger" Font-Bold="true" BackColor="Transparent"></Caption>
                </GroupBoxStyle>
                <Items>
                    <dx:LayoutGroup ShowCaption="False" GroupBoxDecoration="Box" ColCount="1">
                        <GroupBoxStyle Border-BorderColor="#bfdafe">
                            <Caption ForeColor="#1872c4" Font-Size="Larger" Font-Bold="true" BackColor="Transparent"></Caption>
                        </GroupBoxStyle>
                        <Items>
                            <dx:EmptyLayoutItem Width="25%"></dx:EmptyLayoutItem>
                            <dx:LayoutItem ShowCaption="False" Width="50%" HorizontalAlign="Center">
                                <CaptionStyle Font-Bold="true" ForeColor="#1872c4"></CaptionStyle>
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer>
                                        <dx:ASPxLabel runat="server" ID="lblHeader" ClientInstanceName="lblHeader" Text="Internal Memo Entry" ForeColor="#1872c4" Font-Bold="true" Font-Size="24"></dx:ASPxLabel>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:EmptyLayoutItem Width="25%"></dx:EmptyLayoutItem>
                            <dx:LayoutItem ShowCaption="True" Caption="Memo No." Width="25%">
                                <CaptionStyle Font-Bold="true" ForeColor="#1872c4"></CaptionStyle>
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer>
                                        <dx:ASPxTextBox runat="server" ID="txtDocNo" ClientInstanceName="txtDocNo" Theme="Aqua" ClientEnabled="false"></dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:EmptyLayoutItem Width="75%"></dx:EmptyLayoutItem>
                            <dx:LayoutItem ShowCaption="True" Caption="Memo Date" Width="25%">
                                <CaptionStyle Font-Bold="true" ForeColor="#1872c4"></CaptionStyle>
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer>
                                        <dx:ASPxDateEdit runat="server" ID="deDocDate" ClientInstanceName="deDocDate" DisplayFormatString="dd/MM/yyyy" Theme="Aqua"></dx:ASPxDateEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:EmptyLayoutItem Width="75%"></dx:EmptyLayoutItem>
                            <dx:LayoutItem ShowCaption="True" Caption="Status" Width="25%">
                                <CaptionStyle Font-Bold="true" ForeColor="#1872c4"></CaptionStyle>
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer>
                                        <dx:ASPxTextBox runat="server" ID="txtStatus" ClientInstanceName="txtStatus" Theme="Aqua" ClientEnabled="false"></dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:EmptyLayoutItem Width="75%"></dx:EmptyLayoutItem>
                            <dx:EmptyLayoutItem Width="100%"></dx:EmptyLayoutItem>
                            <dx:LayoutItem ShowCaption="True" Caption="Dari" Width="25%">
                                <CaptionStyle Font-Bold="true" ForeColor="#1872c4"></CaptionStyle>
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer>
                                        <dx:ASPxTextBox runat="server" ID="txtDari" ClientInstanceName="txtDari" Theme="Aqua" ClientEnabled="false"></dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:EmptyLayoutItem Width="75%"></dx:EmptyLayoutItem>
                            <dx:LayoutItem ShowCaption="True" Caption="Branch" Width="25%">
                                <CaptionStyle Font-Bold="true" ForeColor="#1872c4"></CaptionStyle>
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer>
                                        <dx:ASPxTextBox runat="server" ID="txtCabang" ClientInstanceName="txtCabang" Theme="Aqua" ClientEnabled="false"></dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:EmptyLayoutItem Width="75%"></dx:EmptyLayoutItem>
                            <dx:LayoutItem ShowCaption="True" Caption="Remark" Width="25%">
                                <CaptionStyle Font-Bold="true" ForeColor="#1872c4"></CaptionStyle>
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer>
                                        <dx:ASPxMemo runat="server" ID="mmRemark" ClientInstanceName="mmRemark" Height="75px" Theme="Aqua"></dx:ASPxMemo>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:EmptyLayoutItem Width="75%"></dx:EmptyLayoutItem>
                            <dx:EmptyLayoutItem Width="100%"></dx:EmptyLayoutItem>
                            <dx:LayoutItem ShowCaption="True" Caption="" Width="25%">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer>
                                        <dx:ASPxButton runat="server" Text="Save" ID="btnSave" ClientInstanceName="btnSave" AutoPostBack="false" Theme="Material" BackColor="#1872c4">
                                            <HoverStyle BackColor="DeepSkyBlue"></HoverStyle>
                                            <ClientSideEvents  Click="function(s,e) { cplMain.PerformCallback('SAVE_CONFIRM;' + 'SAVE_CONFIRM'); }"/>
                                        </dx:ASPxButton>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:EmptyLayoutItem Width="75%"></dx:EmptyLayoutItem>
                            <dx:LayoutItem ShowCaption="True" Caption="" Width="25%">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer>
                                        <dx:ASPxButton runat="server" Text="Approve" ID="btnApprove" ClientInstanceName="btnApprove" AutoPostBack="false" Theme="Material">
                                            <HoverStyle BackColor="LightSeaGreen"></HoverStyle>
                                            <ClientSideEvents  Click="function(s,e) { cplMain.PerformCallback('APPROVE_CONFIRM;' + 'APPROVE_CONFIRM'); }"/>
                                        </dx:ASPxButton>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:EmptyLayoutItem Width="75%"></dx:EmptyLayoutItem>
                            <dx:LayoutItem ShowCaption="True" Caption="" Width="25%">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer>
                                        <dx:ASPxButton runat="server" Text="Reject" ID="btnReject" ClientInstanceName="btnApprove" AutoPostBack="false" Theme="Material" BackColor="DarkRed">
                                            <HoverStyle BackColor="Red"></HoverStyle>
                                            <ClientSideEvents  Click="function(s,e) { cplMain.PerformCallback('REJECT_CONFIRM;' + 'REJECT_CONFIRM'); }"/>
                                        </dx:ASPxButton>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:EmptyLayoutItem Width="75%"></dx:EmptyLayoutItem>
                        </Items>
                    </dx:LayoutGroup>
                    <dx:LayoutGroup ShowCaption="True" GroupBoxDecoration="Box" Caption="Approval Listing" ColCount="1">
                        <GroupBoxStyle Border-BorderColor="#bfdafe">
                            <Caption ForeColor="#1872c4" Font-Size="10" Font-Bold="True" BackColor="White"></Caption>
                        </GroupBoxStyle>
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
                                            <%--<ClientSideEvents EndCallback="gvApproval_EndCallback" />--%>
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
                    <dx:LayoutItem ShowCaption="False" Width="100%">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxRichEdit ID="DemoRichEdit" 
                                        runat="server" Width="100%" Height="700px" Theme="Aqua" ShowConfirmOnLosingChanges="false"
                                        ActiveTabIndex="1" OnInit="DemoRichEdit_Init" OnPreRender="DemoRichEdit_PreRender" WorkDirectory="~\App_Data\Temporary File">
                                    <ClientSideEvents CallbackError="OnExceptionOccurred"></ClientSideEvents>
                                    <SettingsDocumentSelector FileListSettings-View="Details"></SettingsDocumentSelector>
                                    <RibbonTabs>
                                        <dx:RERFileTab>
                                            <Groups>
                                                <dx:RERFileCommonGroup>
                                                    <Items>
                                                        <dx:RERNewCommand Size="Large">
                                                        </dx:RERNewCommand>
                                                        <dx:REROpenCommand Size="Large" Text="Open Memo">
                                                        </dx:REROpenCommand>
                                                        <dx:RERSaveCommand Size="Large">
                                                        </dx:RERSaveCommand>
                                                        <dx:RERSaveAsCommand Size="Large">
                                                        </dx:RERSaveAsCommand>
                                                        <dx:RERPrintCommand Size="Large">
                                                        </dx:RERPrintCommand>
                                                    </Items>
                                                </dx:RERFileCommonGroup>
                                            </Groups>
                                        </dx:RERFileTab>
                                        <dx:RERHomeTab>
                                            <Groups>
                                                <dx:RERUndoGroup>
                                                    <Items>
                                                        <dx:RERUndoCommand>
                                                        </dx:RERUndoCommand>
                                                        <dx:RERRedoCommand>
                                                        </dx:RERRedoCommand>
                                                    </Items>
                                                </dx:RERUndoGroup>
                                                <dx:RERClipboardGroup>
                                                    <Items>
                                                        <dx:RERPasteCommand Size="Large">
                                                        </dx:RERPasteCommand>
                                                        <dx:RERCutCommand>
                                                        </dx:RERCutCommand>
                                                        <dx:RERCopyCommand>
                                                        </dx:RERCopyCommand>
                                                    </Items>
                                                </dx:RERClipboardGroup>
                                                <dx:RERFontGroup>
                                                    <Items>
                                                        <dx:RERFontNameCommand>
                                                            <PropertiesComboBox DropDownStyle="DropDown" ValueType="System.Object" Width="150px">
                                                            </PropertiesComboBox>
                                                        </dx:RERFontNameCommand>
                                                        <dx:RERFontSizeCommand>
                                                            <PropertiesComboBox DropDownStyle="DropDown" ValueType="System.Int32" Width="60px">
                                                            </PropertiesComboBox>
                                                        </dx:RERFontSizeCommand>
                                                        <dx:RERIncreaseFontSizeCommand>
                                                        </dx:RERIncreaseFontSizeCommand>
                                                        <dx:RERDecreaseFontSizeCommand>
                                                        </dx:RERDecreaseFontSizeCommand>
                                                        <dx:RERChangeCaseCommand DropDownMode="False">
                                                        </dx:RERChangeCaseCommand>
                                                        <dx:RERFontBoldCommand>
                                                        </dx:RERFontBoldCommand>
                                                        <dx:RERFontItalicCommand>
                                                        </dx:RERFontItalicCommand>
                                                        <dx:RERFontUnderlineCommand>
                                                        </dx:RERFontUnderlineCommand>
                                                        <dx:RERFontStrikeoutCommand>
                                                        </dx:RERFontStrikeoutCommand>
                                                        <dx:RERFontSuperscriptCommand>
                                                        </dx:RERFontSuperscriptCommand>
                                                        <dx:RERFontSubscriptCommand>
                                                        </dx:RERFontSubscriptCommand>
                                                        <dx:RERFontColorCommand AutomaticColorItemCaption="Automatic" AutomaticColorItemValue="0" Color="Black" EnableAutomaticColorItem="True" EnableCustomColors="True">
                                                        </dx:RERFontColorCommand>
                                                        <dx:RERFontBackColorCommand AutomaticColor="" AutomaticColorItemCaption="No Color" AutomaticColorItemValue="16777215" EnableAutomaticColorItem="True" EnableCustomColors="True">
                                                        </dx:RERFontBackColorCommand>
                                                        <dx:RERClearFormattingCommand>
                                                        </dx:RERClearFormattingCommand>
                                                    </Items>
                                                </dx:RERFontGroup>
                                                <dx:RERParagraphGroup>
                                                    <Items>
                                                        <dx:RERBulletedListCommand>
                                                        </dx:RERBulletedListCommand>
                                                        <dx:RERNumberingListCommand>
                                                        </dx:RERNumberingListCommand>
                                                        <dx:RERMultilevelListCommand>
                                                        </dx:RERMultilevelListCommand>
                                                        <dx:RERDecreaseIndentCommand>
                                                        </dx:RERDecreaseIndentCommand>
                                                        <dx:RERIncreaseIndentCommand>
                                                        </dx:RERIncreaseIndentCommand>
                                                        <dx:RERShowWhitespaceCommand>
                                                        </dx:RERShowWhitespaceCommand>
                                                        <dx:RERAlignLeftCommand>
                                                        </dx:RERAlignLeftCommand>
                                                        <dx:RERAlignCenterCommand>
                                                        </dx:RERAlignCenterCommand>
                                                        <dx:RERAlignRightCommand>
                                                        </dx:RERAlignRightCommand>
                                                        <dx:RERAlignJustifyCommand>
                                                        </dx:RERAlignJustifyCommand>
                                                        <dx:RERParagraphLineSpacingCommand DropDownMode="False">
                                                        </dx:RERParagraphLineSpacingCommand>
                                                        <dx:RERParagraphBackColorCommand AutomaticColor="" AutomaticColorItemCaption="No Color" AutomaticColorItemValue="16777215" EnableAutomaticColorItem="True" EnableCustomColors="True">
                                                        </dx:RERParagraphBackColorCommand>
                                                    </Items>
                                                </dx:RERParagraphGroup>
                                                <dx:RERStylesGroup>
                                                    <Items>
                                                        <dx:RERChangeStyleCommand MaxColumnCount="10" MaxTextWidth="65px" MinColumnCount="2">
                                                            <PropertiesDropDownGallery RowCount="3" />
                                                        </dx:RERChangeStyleCommand>
                                                    </Items>
                                                </dx:RERStylesGroup>
                                                <dx:REREditingGroup>
                                                    <Items>
                                                        <dx:RERSelectAllCommand>
                                                        </dx:RERSelectAllCommand>
                                                    </Items>
                                                </dx:REREditingGroup>
                                            </Groups>
                                        </dx:RERHomeTab>
                                        <dx:RERInsertTab>
                                            <Groups>
                                                <dx:RERPagesGroup>
                                                    <Items>
                                                        <dx:RERInsertPageBreakCommand Size="Large">
                                                        </dx:RERInsertPageBreakCommand>
                                                    </Items>
                                                </dx:RERPagesGroup>
                                                <dx:RERTablesGroup>
                                                    <Items>
                                                        <dx:RERInsertTableCommand Size="Large">
                                                        </dx:RERInsertTableCommand>
                                                    </Items>
                                                </dx:RERTablesGroup>
                                                <%--                        <dx:RERIllustrationsGroup>
                                                <Items>
                                                    <dx:RERInsertPictureCommand Size="Large">
                                                    </dx:RERInsertPictureCommand>
                                                </Items>
                                            </dx:RERIllustrationsGroup>--%>
                                                <dx:RERLinksGroup>
                                                    <Items>
                                                        <dx:RERShowBookmarksFormCommand Size="Large">
                                                        </dx:RERShowBookmarksFormCommand>
                                                        <%--                                <dx:RERShowHyperlinkFormCommand Size="Large">
                                                    </dx:RERShowHyperlinkFormCommand>--%>
                                                    </Items>
                                                </dx:RERLinksGroup>
                                                <dx:RERHeaderAndFooterGroup Text="Header &amp; Footer">
                                                    <Items>
                                                        <dx:REREditPageHeaderCommand Size="Large">
                                                        </dx:REREditPageHeaderCommand>
                                                        <dx:REREditPageFooterCommand Size="Large">
                                                        </dx:REREditPageFooterCommand>
                                                        <dx:RERInsertPageNumberFieldCommand Size="Large">
                                                        </dx:RERInsertPageNumberFieldCommand>
                                                        <dx:RERInsertPageCountFieldCommand Size="Large">
                                                        </dx:RERInsertPageCountFieldCommand>
                                                    </Items>
                                                </dx:RERHeaderAndFooterGroup>
                                                <dx:RERSymbolsGroup>
                                                    <Items>
                                                        <dx:RERShowSymbolFormCommand Size="Large">
                                                        </dx:RERShowSymbolFormCommand>
                                                    </Items>
                                                </dx:RERSymbolsGroup>
                                            </Groups>
                                        </dx:RERInsertTab>
                                        <dx:RERPageLayoutTab>
                                            <Groups>
                                                <dx:RERPageSetupGroup>
                                                    <Items>
                                                        <dx:RERPageMarginsCommand DropDownMode="False" Size="Large">
                                                        </dx:RERPageMarginsCommand>
                                                        <dx:RERChangeSectionPageOrientationCommand DropDownMode="False" Size="Large">
                                                        </dx:RERChangeSectionPageOrientationCommand>
                                                        <dx:RERChangeSectionPaperKindCommand DropDownMode="False" Size="Large">
                                                        </dx:RERChangeSectionPaperKindCommand>
                                                        <dx:RERSetSectionColumnsCommand DropDownMode="False" Size="Large">
                                                        </dx:RERSetSectionColumnsCommand>
                                                        <dx:RERInsertBreakCommand DropDownMode="False" Size="Large">
                                                        </dx:RERInsertBreakCommand>
                                                    </Items>
                                                </dx:RERPageSetupGroup>
                                                <dx:RERBackgroundGroup>
                                                    <Items>
                                                        <dx:RERChangePageColorCommand AutomaticColor="Transparent" AutomaticColorItemCaption="No Color" AutomaticColorItemValue="16777215" Color="Transparent" DropDownMode="False" EnableAutomaticColorItem="True" EnableCustomColors="True" Size="Large">
                                                        </dx:RERChangePageColorCommand>
                                                    </Items>
                                                </dx:RERBackgroundGroup>
                                            </Groups>
                                        </dx:RERPageLayoutTab>
                                        <dx:RERMailMergeTab Text="Mail Merge">
                                            <Groups>
                                                <dx:RERInsertFieldsGroup>
                                                    <Items>
                                                        <dx:RERCreateFieldCommand Size="Large">
                                                        </dx:RERCreateFieldCommand>
                                                        <dx:RERInsertMergeFieldCommand Size="Large">
                                                        </dx:RERInsertMergeFieldCommand>
                                                    </Items>
                                                </dx:RERInsertFieldsGroup>
                                                <dx:RERMailMergeViewGroup>
                                                    <Items>
                                                        <dx:RERToggleViewMergedDataCommand Size="Large">
                                                        </dx:RERToggleViewMergedDataCommand>
                                                        <dx:RERToggleShowAllFieldCodesCommand Size="Large">
                                                        </dx:RERToggleShowAllFieldCodesCommand>
                                                        <dx:RERToggleShowAllFieldResultsCommand Size="Large">
                                                        </dx:RERToggleShowAllFieldResultsCommand>
                                                        <dx:RERUpdateAllFieldsCommand Size="Large">
                                                        </dx:RERUpdateAllFieldsCommand>
                                                    </Items>
                                                </dx:RERMailMergeViewGroup>
                                                <dx:RERCurrentRecordGroup>
                                                    <Items>
                                                        <dx:RERFirstDataRecordCommand Size="Large">
                                                        </dx:RERFirstDataRecordCommand>
                                                        <dx:RERPreviousDataRecordCommand Size="Large">
                                                        </dx:RERPreviousDataRecordCommand>
                                                        <dx:RERNextDataRecordCommand Size="Large">
                                                        </dx:RERNextDataRecordCommand>
                                                        <dx:RERLastDataRecordCommand Size="Large">
                                                        </dx:RERLastDataRecordCommand>
                                                    </Items>
                                                </dx:RERCurrentRecordGroup>
                                                <dx:RERFinishMailMergeGroup>
                                                    <Items>
                                                        <dx:RERFinishAndMergeCommand Size="Large">
                                                        </dx:RERFinishAndMergeCommand>
                                                    </Items>
                                                </dx:RERFinishMailMergeGroup>
                                            </Groups>
                                        </dx:RERMailMergeTab>
                                        <dx:RERViewTab>
                                            <Groups>
                                                <dx:RERShowGroup>
                                                    <Items>
                                                        <dx:RERToggleShowHorizontalRulerCommand Size="Large">
                                                        </dx:RERToggleShowHorizontalRulerCommand>
                                                    </Items>
                                                </dx:RERShowGroup>
                                                <dx:RERViewGroup>
                                                    <Items>
                                                        <dx:RERToggleFullScreenCommand Size="Large">
                                                        </dx:RERToggleFullScreenCommand>
                                                    </Items>
                                                </dx:RERViewGroup>
                                            </Groups>
                                        </dx:RERViewTab>
                                    </RibbonTabs>
                                </dx:ASPxRichEdit>
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

