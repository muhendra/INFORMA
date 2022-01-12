<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="InternalMemoEntry.aspx.cs" Inherits="DXMNCGUI_INFORMA.Transaction.InternalMemo.InternalMemoEntry" %>
<%@ Register Assembly="DevExpress.Web.ASPxRichEdit.v17.2, Version=17.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRichEdit" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxRichEdit.v17.2, Version=17.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxTreeList" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript" src="../../Scripts/Application.js"></script>
    <script type="text/javascript">
        var DocNo;
        function cplMain_EndCallback(s, e) {
            switch (cplMain.cpCallbackParam) {
                case "CONTRACT_ONCHANGE":
                    OnContractChanged();
                    gvDetailCashColl.Refresh();
                    break;
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
                case "RETURN_CONFIRM":
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
                case "RETURN":
                    apcalert.SetContentHtml(cplMain.cpAlertMessage);
                    apcalert.Show();
                    break;
                case "FREETEXT_NUMB_UPDATE":

                    break;
            }
        }
        function gvApproval_EndCallback(s, e) {
            if (s.cpCmd == "INSERT" || s.cpCmd == "UPDATE" || s.cpCmd == "DELETE") {
                s.cpCmd = "";
            }
        }
        function OnContractChanged(s, e) {
            var grid = luKontrakNo.GetGridView();
            grid.GetRowValues(grid.GetFocusedRowIndex(), 'DEBITUR;CIF;DEBITURADDRESS;INSTALLMENT', OnGetSelectedFieldValues);
        }
        function OnGetSelectedFieldValues(selectedValues) {
            txtDebitur.SetValue(selectedValues[0]);
            txtCIF.SetValue(selectedValues[1]);
            mmAlamat.SetValue(selectedValues[2]);
            seAngsuran.SetValue(selectedValues[3]);
        }
        function OnNameChanged(s, e) {
            gvApproval.GetEditor("colNIK").SetValue(s.GetSelectedItem().GetColumnText('NIK'));
        }

        var isResetRequired = false;
        function onSelectedAgreementNoChanged(cmbAgreementNo) {
            isResetRequired = true;
            gvDetailCrossColl.GetEditor("AssetDesc").PerformCallback(cmbAgreementNo.GetValue().toString());
        }
        function onAssetDescEndCallback(s, e) {
            if (isResetRequired) {
                isResetRequired = false;
                s.SetSelectedIndex(0);
            }
        }
        function onSelectedPendingGiroAgreementNoChanged(s) {
            isResetRequired = true;
            gvDetailPendingGiro.GetEditor("colNamaBank").Clear();
            gvDetailPendingGiro.GetEditor("colNominalGiro").Clear();
            gvDetailPendingGiro.GetEditor("colTgljatuhTempoGiro").Clear();
            gvDetailPendingGiro.GetEditor("colLamaPenundaan").Clear();
            gvDetailPendingGiro.GetEditor("colTgldijalankanKembali").Clear();
            gvDetailPendingGiro.GetEditor("colAngsuranDariKe").Clear();

            gvDetailPendingGiro.GetEditor("colNamaDebitur").SetValue(s.GetSelectedItem().GetColumnText('Debitur'));
            gvDetailPendingGiro.GetEditor("NoGiro").PerformCallback(s.GetValue().toString());
        }
        function onNoGiroEndCallback(s, e) {
            if (isResetRequired) {
                isResetRequired = false;
                s.SetSelectedIndex(0);
            }
        }
        function onSelectedPendingGiroCheqNoChanged(s, e) {
            gvDetailPendingGiro.GetEditor("colNamaBank").SetValue(s.GetSelectedItem().GetColumnText('CHEQBANKPDC'));
            gvDetailPendingGiro.GetEditor("colNominalGiro").SetValue(s.GetSelectedItem().GetColumnText('CHEQAMOUNT'));
            gvDetailPendingGiro.GetEditor("colTgljatuhTempoGiro").SetValue(new Date(s.GetSelectedItem().GetColumnText('CHEQDATE')));
        }
        function diffDay() {
            var date1 = gvDetailPendingGiro.GetEditValue("colTgljatuhTempoGiro");
            var date2 = gvDetailPendingGiro.GetEditValue("colTgldijalankanKembali");
            var diff = (date2 - date1) / (1000 * 3600 * 24);
            gvDetailPendingGiro.GetEditor("colLamaPenundaan").SetValue(diff);
        }

        function onFreeTextInit(s) {
            if (ASPx.Browser.Chrome && ASPx.Browser.Version >= 77) {
                var createHelperFrame = s.createHelperFrame;
                s.createHelperFrame = function () {
                    var helperFrame = createHelperFrame.call(this);
                    helperFrame.frameElement.addEventListener("load", function () {
                        if (helperFrame.frameElement.contentDocument.contentType === "application/pdf")
                            helperFrame.frameElement.contentWindow.print();
                    });
                    return helperFrame;
                }
            }

            reTemplate.commands.updateAllFields.execute();
            reTemplate.commands.showAllFieldCodes.execute(false);

            //cplMain.PerformCallback("FREETEXT;");
        }

        function onFreeTextEndCallBack() {
           
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
            <dx:LayoutGroup ShowCaption="True" GroupBoxDecoration="Box" Caption="Internal Memo New Entry" ColCount="4">
                <Items>
                    <dx:LayoutItem ShowCaption="False" HorizontalAlign="Center" Width="100%" ColSpan="4">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxLabel runat="server" Text="INTERNAL MEMORANDUM" Font-Bold="true" Font-Size="Large" Font-Underline="true" ForeColor="#808080">
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
                    <dx:LayoutItem ShowCaption="True" Caption="Kepada">
                        <CaptionStyle Font-Bold="true" ForeColor="#1872c4"></CaptionStyle>
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxTextBox runat="server" ID="txtKepada" ClientInstanceName="txtKepada" Width="100%" Theme="Aqua" NullText="">
                                    <ClientSideEvents TextChanged="OnFreeTextHeaderChange" />
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                    <dx:LayoutItem ShowCaption="True" Caption="Tembusan / CC">
                        <CaptionStyle Font-Bold="true" ForeColor="#1872c4"></CaptionStyle>
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxTextBox runat="server" ID="txtTembusan" ClientInstanceName="txtTembusan" Width="100%" Theme="Aqua" NullText="">
                                    <ClientSideEvents TextChanged="OnFreeTextHeaderChange" />
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                    <dx:LayoutItem ShowCaption="True" Caption="Dari">
                        <CaptionStyle Font-Bold="true" ForeColor="#1872c4"></CaptionStyle>
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxTextBox runat="server" ID="txtDari" ClientInstanceName="txtDari" Width="100%" Theme="Aqua" MaxLength="255"></dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                    <dx:LayoutItem ShowCaption="True" Caption="Cabang">
                        <CaptionStyle Font-Bold="true" ForeColor="#1872c4"></CaptionStyle>
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxTextBox runat="server" ID="txtCabang" ClientInstanceName="txtCabang" Width="100%" Theme="Aqua"></dx:ASPxTextBox>
                                <%--<dx:ASPxGridLookup
                                    runat="server"
                                    ID="luCabang"
                                    ClientInstanceName="luCabang" OnDataBinding="luCabang_DataBinding"
                                    AutoGenerateColumns="False"
                                    DisplayFormatString="{1}"
                                    TextFormatString="{1}"
                                    KeyFieldName="C_CODE"
                                    SelectionMode="Single"
                                    Theme="Aqua"
                                    Width="100%" GridViewProperties-EnablePagingCallbackAnimation="true" AnimationType="Slide">
                                    <GridViewProperties>
                                        <SettingsBehavior AllowFocusedRow="True" AllowSelectSingleRowOnly="True" EnableRowHotTrack="true" />
                                        <Settings ShowFilterBar="Hidden" ShowFilterRow="false" ShowFilterRowMenu="True" ShowFilterRowMenuLikeItem="True" ShowHeaderFilterButton="True" ShowStatusBar="Visible"  />
                                        <SettingsSearchPanel ShowApplyButton="True" ShowClearButton="True" Visible="True" />
                                    </GridViewProperties>
                                    <Columns>
                                        <dx:GridViewDataColumn Caption="Code" FieldName="C_CODE" ShowInCustomizationForm="True" VisibleIndex="0">
                                        </dx:GridViewDataColumn>
                                        <dx:GridViewDataColumn Caption="Branch" FieldName="C_NAME" ShowInCustomizationForm="True" VisibleIndex="1">
                                        </dx:GridViewDataColumn>
                                    </Columns>
                                </dx:ASPxGridLookup>--%>
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
                    <dx:LayoutItem ShowCaption="True" Caption="Perihal">
                        <CaptionStyle Font-Bold="true" ForeColor="#1872c4"></CaptionStyle>
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxMemo runat="server" ID="mmPerihal" ClientInstanceName="mmPerihal" Width="100%" Height="75px" Theme="Aqua" NullText="">
                                    <ClientSideEvents TextChanged="OnFreeTextHeaderChange"/>
                                </dx:ASPxMemo>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                    <dx:LayoutItem Name="liNoKontrak" ShowCaption="True" Caption="No Kontrak">
                        <CaptionStyle Font-Bold="true" ForeColor="#1872c4"></CaptionStyle>
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxGridLookup
                                    runat="server"
                                    ID="luKontrakNo"
                                    ClientInstanceName="luKontrakNo" OnDataBinding="luKontrakNo_DataBinding"
                                    AutoGenerateColumns="False"
                                    DisplayFormatString="{1}"
                                    TextFormatString="{1}"
                                    KeyFieldName="NO KONTRAK"
                                    SelectionMode="Single"
                                    Theme="Aqua"
                                    Width="100%" GridViewProperties-EnablePagingCallbackAnimation="true" AnimationType="Slide">
                                    <ClientSideEvents ValueChanged="function(s,e) { cplMain.PerformCallback('CONTRACT_ONCHANGE;' + 'CHANGE'); }" />
                                    <GridViewProperties>
                                        <SettingsBehavior AllowFocusedRow="True" AllowSelectSingleRowOnly="True" EnableRowHotTrack="true" />
                                        <Settings ShowFilterBar="Hidden" ShowFilterRow="false" ShowFilterRowMenu="True" ShowFilterRowMenuLikeItem="True" ShowHeaderFilterButton="True" ShowStatusBar="Visible" />
                                        <SettingsSearchPanel ShowApplyButton="True" ShowClearButton="True" Visible="True" />
                                    </GridViewProperties>
                                    <Columns>
                                        <dx:GridViewDataColumn Caption="Branch" FieldName="CABANG" ShowInCustomizationForm="True" VisibleIndex="1">
                                        </dx:GridViewDataColumn>
                                        <dx:GridViewDataColumn Caption="Application No" FieldName="NO KONTRAK" ShowInCustomizationForm="True" VisibleIndex="2">
                                        </dx:GridViewDataColumn>
                                        <dx:GridViewDataColumn Caption="Debtor" FieldName="DEBITUR" ShowInCustomizationForm="True" VisibleIndex="3">
                                        </dx:GridViewDataColumn>
                                        <dx:GridViewDataColumn Caption="Jenis Pembiayaan" FieldName="JENIS PEMBIAYAAN" ShowInCustomizationForm="True" VisibleIndex="4">
                                        </dx:GridViewDataColumn>
                                        <dx:GridViewDataColumn Caption="Product Facility" FieldName="PRODUCT FACILITY" ShowInCustomizationForm="True" VisibleIndex="5">
                                        </dx:GridViewDataColumn>
                                        <dx:GridViewDataSpinEditColumn Caption="Tenor" FieldName="TENOR" ShowInCustomizationForm="true" VisibleIndex="6">
                                        </dx:GridViewDataSpinEditColumn>
                                        <dx:GridViewDataSpinEditColumn Caption="NTF" FieldName="NTF" ShowInCustomizationForm="true" VisibleIndex="7" Visible="false">
                                        </dx:GridViewDataSpinEditColumn>
                                        <dx:GridViewDataSpinEditColumn Caption="Outstanding AR" FieldName="OUTSTANDING AR" ShowInCustomizationForm="true" VisibleIndex="8" Visible="false">
                                        </dx:GridViewDataSpinEditColumn>
                                        <dx:GridViewDataSpinEditColumn Caption="Overdue" FieldName="OVERDUE" ShowInCustomizationForm="true" VisibleIndex="9" Visible="false">
                                        </dx:GridViewDataSpinEditColumn>
                                        <dx:GridViewDataDateColumn Caption="Last payment" FieldName="LAST PAYMENT" ShowInCustomizationForm="true" VisibleIndex="10" Visible="false">
                                        </dx:GridViewDataDateColumn>
                                        <dx:GridViewDataSpinEditColumn Caption="Sisa Tenor" FieldName="SISA TENOR" ShowInCustomizationForm="true" VisibleIndex="11" Visible="false">
                                        </dx:GridViewDataSpinEditColumn>
                                        <dx:GridViewDataDateColumn Caption="Next Duedate" FieldName="NEXT DUEDATE" ShowInCustomizationForm="true" VisibleIndex="12" Visible="false">
                                        </dx:GridViewDataDateColumn>
                                        <dx:GridViewDataColumn Caption="CIF" FieldName="CIF" ShowInCustomizationForm="True" Visible="false">
                                        </dx:GridViewDataColumn>
                                        <dx:GridViewDataColumn Caption="DEBITURADDRESS" FieldName="DEBITURADDRESS" ShowInCustomizationForm="True" Visible="false">
                                        </dx:GridViewDataColumn>
                                        <dx:GridViewDataColumn Caption="INSTALLMENT" FieldName="INSTALLMENT" ShowInCustomizationForm="True" Visible="false">
                                        </dx:GridViewDataColumn>
                                    </Columns>
                                    <GridViewStyles AdaptiveDetailButtonWidth="22"></GridViewStyles>
                                </dx:ASPxGridLookup>
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
                            <dx:LayoutGroup Name="lgDetailAssetCashColl" GroupBoxDecoration="Box" ShowCaption="False" Caption="Detail Pemakaian Cash Collateral" GroupBoxStyle-Caption-BackColor="WhiteSmoke" ColCount="4" Visible="false">
                                <Items>
                                    <dx:LayoutItem ShowCaption="False">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxLabel runat="server" ID="lblDataAsset" ClientInstanceName="lblDataAsset" Text="A. DATA ASET & KEWAJIBAN DEBITUR" Font-Size="Larger" Font-Bold="true" Font-Underline="true" ForeColor="#808080"></dx:ASPxLabel>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:LayoutItem ShowCaption="True" Caption="CIF">
                                        <CaptionStyle Font-Bold="true" ForeColor="#1872c4"></CaptionStyle>
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxTextBox runat="server" ID="txtCIF" ClientInstanceName="txtCIF" Width="100%" Theme="Aqua"></dx:ASPxTextBox>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:LayoutItem ShowCaption="True" Caption="Debitur">
                                        <CaptionStyle Font-Bold="true" ForeColor="#1872c4"></CaptionStyle>
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxTextBox runat="server" ID="txtDebitur" ClientInstanceName="txtDebitur" Width="100%" Theme="Aqua"></dx:ASPxTextBox>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:LayoutItem ShowCaption="True" Caption="Alamat">
                                        <CaptionStyle Font-Bold="true" ForeColor="#1872c4"></CaptionStyle>
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxMemo runat="server" ID="mmAlamat" ClientInstanceName="mmAlamat" Width="100%" Height="75px" Theme="Aqua"></dx:ASPxMemo>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:LayoutItem ShowCaption="True" Caption="Angsuran">
                                        <CaptionStyle Font-Bold="true" ForeColor="#1872c4"></CaptionStyle>
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxSpinEdit runat="server" ID="seAngsuran" ClientInstanceName="seAngsuran" Width="100%" MinValue="0" MaxValue="999999999999999" DisplayFormatString="#,0.00" SpinButtons-ShowIncrementButtons="false" Font-Bold="true" Theme="Aqua"></dx:ASPxSpinEdit>
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
                                    <dx:LayoutItem ShowCaption="False" Width="100%" ColSpan="4">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxGridView
                                                    runat="server"
                                                    ID="gvDetailCashColl"
                                                    ClientInstanceName="gvDetailCashColl"
                                                    Width="100%"
                                                    AutoGenerateColumns="False"
                                                    EnableCallBacks="true"
                                                    EnablePagingCallbackAnimation="true"
                                                    Font-Names="Calibri" Font-Size="9" ForeColor="#142e5d" KeyFieldName="DtlKey"
                                                    OnDataBinding="gvDetailCashColl_DataBinding" OnCustomCallback="gvDetailCashColl_CustomCallback" OnCustomColumnDisplayText="gvDetailCashColl_CustomColumnDisplayText" Theme="Aqua">
                                                    <SettingsAdaptivity AdaptivityMode="HideDataCellsWindowLimit" AllowOnlyOneAdaptiveDetailExpanded="True" HideDataCellsAtWindowInnerWidth="700"></SettingsAdaptivity>
                                                    <ClientSideEvents />
                                                    <Settings ShowFilterRow="false" ShowGroupPanel="false" ShowFilterRowMenu="false" ShowFilterBar="Auto" ShowHeaderFilterButton="false" />
                                                    <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True" FilterRowMode="OnClick" EnableRowHotTrack="true" />
                                                    <SettingsDataSecurity AllowDelete="true" AllowEdit="true" AllowInsert="true" />
                                                    <SettingsFilterControl ViewMode="VisualAndText" AllowHierarchicalColumns="true" ShowAllDataSourceColumns="true" MaxHierarchyDepth="1" />
                                                    <SettingsPager PageSize="1000" AllButton-Visible="true" Summary-Visible="true" Visible="true"></SettingsPager>
                                                    <Columns>
                                                        <dx:GridViewDataTextColumn Name="colNo" Caption="No" ReadOnly="True" UnboundType="String" VisibleIndex="0" Width="2%">
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Name="colDesc" Caption="Asset Description" ReadOnly="True" FieldName="AssetDesc" UnboundType="String" VisibleIndex="1" Width="38%">
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Name="colNorangKaNoMesin" Caption="No Rangka" ReadOnly="True" FieldName="NoRangka" UnboundType="String" VisibleIndex="2" Width="20%">
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Name="colNorangKaNoMesin" Caption="No Mesin" ReadOnly="True" FieldName="NoMesin" UnboundType="String" VisibleIndex="3" Width="20%">
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Name="colTahun" Caption="Tahun" ReadOnly="True" FieldName="Tahun" UnboundType="String" VisibleIndex="4" Width="20%">
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                        </dx:GridViewDataTextColumn>
                                                    </Columns>
                                                </dx:ASPxGridView>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:LayoutItem ShowCaption="False">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxLabel runat="server" ID="lblBackground" ClientInstanceName="lblBackground" Text="B. LATAR BELAKANG" Font-Size="Larger" Font-Bold="true" Font-Underline="true" ForeColor="#808080"></dx:ASPxLabel>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:LayoutItem ShowCaption="False" Width="100%" ColSpan="4">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxMemo runat="server" ID="mmBackground" ClientInstanceName="mmBackground" Width="100%" Height="75px" Theme="Aqua"></dx:ASPxMemo>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:LayoutItem ShowCaption="False">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxLabel runat="server" ID="lblCostAndBenefit" ClientInstanceName="lblCostAndBenefit" Text="C. COST & BENEFIT ANALYSIS" Font-Size="Larger" Font-Bold="true" Font-Underline="true" ForeColor="#808080"></dx:ASPxLabel>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:LayoutItem ShowCaption="False" Width="100%" ColSpan="4">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxMemo runat="server" ID="mmCostAndBenefit" ClientInstanceName="mmCostAndBenefit" Width="100%" Height="75px" Theme="Aqua"></dx:ASPxMemo>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                </Items>
                            </dx:LayoutGroup>
                            <dx:LayoutGroup Name="lgDetailAssetCrossColl" GroupBoxDecoration="Box" ShowCaption="False" Caption="Detail Pelepasan Cross Collateral" GroupBoxStyle-Caption-BackColor="WhiteSmoke" ColCount="4" Visible="false">
                                <Items>
                                    <dx:LayoutItem ShowCaption="False">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxLabel runat="server" ID="lblHeader" ClientInstanceName="lblHeader" Text="A.HEADER" Font-Size="Larger" Font-Bold="true" Font-Underline="true" ForeColor="#808080"></dx:ASPxLabel>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:LayoutItem ShowCaption="False" Width="100%" ColSpan="4">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxMemo runat="server" ID="mmHeader" ClientInstanceName="mmHeader" Width="100%" Height="75px" Theme="Aqua"></dx:ASPxMemo>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:LayoutItem ShowCaption="False">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxLabel runat="server" ID="lblDetailCrossColl" ClientInstanceName="lblDetailCrossColl" Text="B.DETAIL ASSET" Font-Size="Larger" Font-Bold="true" Font-Underline="true" ForeColor="#808080"></dx:ASPxLabel>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:LayoutItem ShowCaption="False" Width="100%" ColSpan="4">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxGridView
                                                    runat="server"
                                                    ID="gvDetailCrossColl"
                                                    ClientInstanceName="gvDetailCrossColl"
                                                    Width="100%"
                                                    AutoGenerateColumns="False" KeyFieldName="DtlKey"
                                                    EnableCallBacks="true"
                                                    EnablePagingCallbackAnimation="true"
                                                    Font-Names="Calibri" Font-Size="9" ForeColor="#142e5d" Theme="Aqua"
                                                    OnDataBinding="gvDetailCrossColl_DataBinding" OnCustomCallback="gvDetailCrossColl_CustomCallback" OnCellEditorInitialize="gvDetailCrossColl_CellEditorInitialize"
                                                    OnRowInserting="gvDetailCrossColl_RowInserting" OnRowUpdating="gvDetailCrossColl_RowUpdating" OnRowDeleting="gvDetailCrossColl_RowDeleting">
                                                    <SettingsAdaptivity AdaptivityMode="HideDataCellsWindowLimit" AllowOnlyOneAdaptiveDetailExpanded="True" HideDataCellsAtWindowInnerWidth="700"></SettingsAdaptivity>
                                                    <ClientSideEvents />
                                                    <Settings ShowFilterRow="false" ShowGroupPanel="false" ShowFilterRowMenu="false" ShowFilterBar="Auto" ShowHeaderFilterButton="false" />
                                                    <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True" FilterRowMode="OnClick" EnableRowHotTrack="true" />
                                                    <SettingsDataSecurity AllowDelete="true" AllowEdit="true" AllowInsert="true" />
                                                    <SettingsFilterControl ViewMode="VisualAndText" AllowHierarchicalColumns="true" ShowAllDataSourceColumns="true" MaxHierarchyDepth="1" />
                                                    <SettingsPager PageSize="1000" AllButton-Visible="true" Summary-Visible="true" Visible="true"></SettingsPager>
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
                                                        <dx:GridViewCommandColumn Name="ClmnCommand" ShowApplyFilterButton="true" ShowClearFilterButton="true" ShowDeleteButton="True" ShowEditButton="True" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" Width="10%">
                                                            <HeaderStyle Font-Bold="true" ForeColor="#1872c4" />
                                                        </dx:GridViewCommandColumn>
                                                        <dx:GridViewDataComboBoxColumn Name="colAgreement" FieldName="AgreementNo" ShowInCustomizationForm="True" Caption="Agreement">
                                                            <HeaderStyle Font-Bold="true" ForeColor="#1872c4" />
                                                            <PropertiesComboBox EnableCallbackMode="true" ClientInstanceName="AgreementNo" DropDownRows="10" IncrementalFilteringDelay="500" ItemStyle-Wrap="True" IncrementalFilteringMode="Contains" DisplayFormatString="{0}" TextFormatString="{0} {1}" DropDownStyle="DropDownList" ValueField="NO KONTRAK" TextField="NO KONTRAK">
                                                                <ClientSideEvents SelectedIndexChanged="function(s,e) {onSelectedAgreementNoChanged(s);}" />
                                                                <ItemStyle Wrap="True"></ItemStyle>
                                                                <Columns>
                                                                    <dx:ListBoxColumn FieldName="NO KONTRAK" Caption="Agreement" />
                                                                    <dx:ListBoxColumn FieldName="Debitur" Caption="Debitur" />
                                                                </Columns>
                                                                <ValidationSettings ValidateOnLeave="true" ValidationGroup="ValidationSave" Display="Dynamic" ErrorDisplayMode="ImageWithText">
                                                                    <RequiredField ErrorText="* Value can't be empty." IsRequired="true" />
                                                                </ValidationSettings>
                                                            </PropertiesComboBox>
                                                        </dx:GridViewDataComboBoxColumn>
                                                        <dx:GridViewDataComboBoxColumn Name="colDescription" ShowInCustomizationForm="True" FieldName="AssetDesc" Caption="Asset Description">
                                                            <HeaderStyle Font-Bold="true" ForeColor="#1872c4" />
                                                            <Settings AutoFilterCondition="Contains" />
                                                            <PropertiesComboBox EnableCallbackMode="true" ClientInstanceName="AssetDesc" DropDownRows="10" IncrementalFilteringDelay="500" ItemStyle-Wrap="True" IncrementalFilteringMode="Contains" DisplayFormatString="{0}" TextFormatString="{0}" DropDownStyle="DropDownList" ValueField="Description" TextField="Description">
                                                                <ClientSideEvents EndCallback="onAssetDescEndCallback" />
                                                                <ItemStyle Wrap="True"></ItemStyle>
                                                                <Columns>
                                                                    <dx:ListBoxColumn FieldName="Description" Caption="Asset Desc" />
                                                                </Columns>
                                                                <ValidationSettings ValidateOnLeave="true" ValidationGroup="ValidationSave" Display="Dynamic" ErrorDisplayMode="ImageWithText">
                                                                    <RequiredField ErrorText="* Value can't be empty." IsRequired="true" />
                                                                </ValidationSettings>
                                                            </PropertiesComboBox>
                                                        </dx:GridViewDataComboBoxColumn>
                                                        <dx:GridViewDataSpinEditColumn
                                                            Name="colMarketValue"
                                                            Caption="Market Value"
                                                            FieldName="ValueAsset"
                                                            ReadOnly="false"
                                                            ShowInCustomizationForm="True"
                                                            PropertiesSpinEdit-DisplayFormatString="{0:#,0.##}"
                                                            PropertiesSpinEdit-DisplayFormatInEditMode="true"
                                                            PropertiesSpinEdit-AllowMouseWheel="false"
                                                            PropertiesSpinEdit-SpinButtons-ShowIncrementButtons="false"
                                                            PropertiesSpinEdit-MinValue="0"
                                                            PropertiesSpinEdit-MaxValue="999999999999999">
                                                            <HeaderStyle Font-Bold="true" ForeColor="#1872c4" />
                                                        </dx:GridViewDataSpinEditColumn>
                                                        <dx:GridViewDataSpinEditColumn
                                                            Name="colOSPH"
                                                            Caption="OSPH"
                                                            FieldName="OSPH"
                                                            ReadOnly="false"
                                                            ShowInCustomizationForm="True"
                                                            PropertiesSpinEdit-DisplayFormatString="{0:#,0.##}"
                                                            PropertiesSpinEdit-DisplayFormatInEditMode="true"
                                                            PropertiesSpinEdit-AllowMouseWheel="false"
                                                            PropertiesSpinEdit-SpinButtons-ShowIncrementButtons="false"
                                                            PropertiesSpinEdit-MinValue="0"
                                                            PropertiesSpinEdit-MaxValue="999999999999999">
                                                            <HeaderStyle Font-Bold="true" ForeColor="#1872c4" />
                                                        </dx:GridViewDataSpinEditColumn>
                                                        <dx:GridViewBandColumn Caption="Kondisi Pembayaran">
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" HorizontalAlign="Center" />
                                                            <Columns>
                                                                <dx:GridViewDataTextColumn Name="colCicilanKe" Caption="Cicilan Ke/Tenor" FieldName="CicilanTenor" ReadOnly="False" UnboundType="String" VisibleIndex="6">
                                                                    <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataSpinEditColumn
                                                                    Name="colDendaBerjalan"
                                                                    Caption="Denda Berjalan"
                                                                    FieldName="DendaBerjalan"
                                                                    ReadOnly="false"
                                                                    ShowInCustomizationForm="True"
                                                                    PropertiesSpinEdit-DisplayFormatString="{0:#,0.##}"
                                                                    PropertiesSpinEdit-DisplayFormatInEditMode="true"
                                                                    PropertiesSpinEdit-AllowMouseWheel="false"
                                                                    PropertiesSpinEdit-SpinButtons-ShowIncrementButtons="false"
                                                                    PropertiesSpinEdit-MinValue="0"
                                                                    PropertiesSpinEdit-MaxValue="999999999999999"
                                                                    VisibleIndex="7">
                                                                    <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                                </dx:GridViewDataSpinEditColumn>
                                                            </Columns>
                                                        </dx:GridViewBandColumn>
                                                    </Columns>
                                                </dx:ASPxGridView>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:LayoutItem ShowCaption="False">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxLabel runat="server" ID="lblFooter" ClientInstanceName="lblFooter" Text="C.FOOTER" Font-Size="Larger" Font-Bold="true" Font-Underline="true" ForeColor="#808080"></dx:ASPxLabel>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:LayoutItem ShowCaption="False" Width="100%" ColSpan="4">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxMemo runat="server" ID="mmFooter" ClientInstanceName="mmFooter" Width="100%" Height="75px" Theme="Aqua"></dx:ASPxMemo>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                </Items>
                            </dx:LayoutGroup>
                            <dx:LayoutGroup Name="lgDetailPendingGiro" GroupBoxDecoration="Box" Caption="Detail Pending Giro" GroupBoxStyle-Caption-BackColor="White" ColCount="4" Visible="False">
                                <Items>
                                    <dx:LayoutItem ShowCaption="True" Caption="No. Surat Debitur">
                                        <CaptionStyle Font-Bold="true" ForeColor="#1872c4"></CaptionStyle>
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxTextBox runat="server" ID="txtNoSuratDebitur" ClientInstanceName="txtNoSuratDebitur" Width="100%" Theme="Aqua"></dx:ASPxTextBox>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:LayoutItem ShowCaption="True" Caption="Tolakan Ke">
                                        <CaptionStyle Font-Bold="true" ForeColor="#1872c4"></CaptionStyle>
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxTextBox runat="server" ID="txtTolakanKe" ClientInstanceName="txtTolakanKe" Width="100%" Theme="Aqua"></dx:ASPxTextBox>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:LayoutItem ShowCaption="True" Caption="Tgl Pengajuan Sebelumnya">
                                        <CaptionStyle Font-Bold="true" ForeColor="#1872c4"></CaptionStyle>
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxDateEdit runat="server" ID="deTglPengajuanSebelumnya" ClientInstanceName="deTglPengajuanSebelumnya" DisplayFormatString="dd/MM/yyyy" Width="100%" Theme="Aqua" CalendarProperties-ShowClearButton="false"></dx:ASPxDateEdit>
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
                                    <dx:LayoutItem ShowCaption="False" Width="100%" ColSpan="4">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxGridView
                                                    runat="server"
                                                    ID="gvDetailPendingGiro"
                                                    ClientInstanceName="gvDetailPendingGiro"
                                                    Width="100%"
                                                    AutoGenerateColumns="False"
                                                    EnableCallBacks="true"
                                                    EnablePagingCallbackAnimation="true"
                                                    Font-Names="Calibri" Font-Size="9" ForeColor="#142e5d" KeyFieldName="DtlKey"
                                                    OnDataBinding="gvDetailPendingGiro_DataBinding" OnCustomCallback="gvDetailPendingGiro_CustomCallback" OnCustomColumnDisplayText="gvDetailPendingGiro_CustomColumnDisplayText" OnRowInserting="gvDetailPendingGiro_RowInserting"
                                                    OnRowUpdating="gvDetailPendingGiro_RowUpdating" OnRowDeleting="gvDetailPendingGiro_RowDeleting"
                                                    OnCellEditorInitialize="gvDetailPendingGiro_CellEditorInitialize" Theme="Aqua">
                                                    <SettingsAdaptivity AdaptivityMode="HideDataCellsWindowLimit" AllowOnlyOneAdaptiveDetailExpanded="True" HideDataCellsAtWindowInnerWidth="700"></SettingsAdaptivity>
                                                    <ClientSideEvents />
                                                    <Settings ShowFilterRow="false" ShowGroupPanel="false" ShowFilterRowMenu="false" ShowFilterBar="Auto" ShowHeaderFilterButton="false" />
                                                    <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True" FilterRowMode="OnClick" EnableRowHotTrack="true" />
                                                    <SettingsDataSecurity AllowDelete="true" AllowEdit="true" AllowInsert="true" />
                                                    <SettingsFilterControl ViewMode="VisualAndText" AllowHierarchicalColumns="true" ShowAllDataSourceColumns="true" MaxHierarchyDepth="1" />
                                                    <SettingsPager PageSize="1000" AllButton-Visible="true" Summary-Visible="true" Visible="true"></SettingsPager>
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
                                                        <dx:GridViewCommandColumn Name="ClmnCommand" ShowApplyFilterButton="true" ShowClearFilterButton="true" ShowDeleteButton="True" ShowEditButton="True" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" Width="10%">
                                                            <HeaderStyle Font-Bold="true" ForeColor="#1872c4" />
                                                        </dx:GridViewCommandColumn>
                                                        <dx:GridViewDataComboBoxColumn Name="colAgreement" FieldName="AgreementNo" ShowInCustomizationForm="True" Caption="Agreement">
                                                            <HeaderStyle Font-Bold="true" ForeColor="#1872c4" />
                                                            <Settings AutoFilterCondition="Contains" />
                                                            <PropertiesComboBox EnableCallbackMode="true" ClientInstanceName="AgreementNo" DropDownRows="10" IncrementalFilteringDelay="500" ItemStyle-Wrap="True" IncrementalFilteringMode="Contains" DisplayFormatString="{0}" TextFormatString="{0} {1}" DropDownStyle="DropDownList" ValueField="NO KONTRAK" TextField="NO KONTRAK">
                                                                <ClientSideEvents SelectedIndexChanged="function(s,e) {onSelectedPendingGiroAgreementNoChanged(s);}" />
                                                                <ItemStyle Wrap="True"></ItemStyle>
                                                                <Columns>
                                                                    <dx:ListBoxColumn FieldName="NO KONTRAK" Caption="Agreement" />
                                                                    <dx:ListBoxColumn FieldName="Debitur" Caption="Debitur" />
                                                                </Columns>
                                                                <ValidationSettings ValidateOnLeave="true" ValidationGroup="ValidationSave" Display="Dynamic" ErrorDisplayMode="ImageWithText">
                                                                    <RequiredField ErrorText="* Value can't be empty." IsRequired="true" />
                                                                </ValidationSettings>
                                                            </PropertiesComboBox>
                                                        </dx:GridViewDataComboBoxColumn>
                                                        <dx:GridViewDataTextColumn Name="colNamaDebitur" FieldName="NamaDebitur" Caption="Nama Debitur" ShowInCustomizationForm="True" ReadOnly="true">
                                                            <PropertiesTextEdit Style-BackColor="#f7faff"></PropertiesTextEdit>
                                                            <HeaderStyle Font-Bold="true" ForeColor="#1872c4" />
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataComboBoxColumn Name="colNoGiro" FieldName="NoGiro" ShowInCustomizationForm="True" Caption="No. Giro">
                                                            <HeaderStyle Font-Bold="true" ForeColor="#1872c4" />
                                                            <Settings AutoFilterCondition="Contains" />
                                                            <PropertiesComboBox EnableCallbackMode="true" ClientInstanceName="colNoGiro" DropDownRows="10" IncrementalFilteringDelay="500" ItemStyle-Wrap="True" IncrementalFilteringMode="Contains" DisplayFormatString="{0}" TextFormatString="{0}" DropDownStyle="DropDownList" ValueField="CHEQNO" TextField="CHEQNO">
                                                                <ClientSideEvents SelectedIndexChanged="function(s,e) {onSelectedPendingGiroCheqNoChanged(s);}" />
                                                                <ItemStyle Wrap="True"></ItemStyle>
                                                                <Columns>
                                                                    <dx:ListBoxColumn FieldName="CHEQNO" Caption="No. Cheq" />
                                                                    <dx:ListBoxColumn FieldName="CHEQBANKPDC" Caption="Bank" />
                                                                    <dx:ListBoxColumn FieldName="CHEQAMOUNT" Caption="Nominal" />
                                                                    <dx:ListBoxColumn FieldName="CHEQDATE" Caption="Cheq Date." />
                                                                </Columns>
                                                                <ValidationSettings ValidateOnLeave="true" ValidationGroup="ValidationSave" Display="Dynamic" ErrorDisplayMode="ImageWithText">
                                                                    <RequiredField ErrorText="* Value can't be empty." IsRequired="true" />
                                                                </ValidationSettings>
                                                            </PropertiesComboBox>
                                                        </dx:GridViewDataComboBoxColumn>
                                                        <dx:GridViewDataTextColumn Name="colNamaBank" FieldName="NamaBank" Caption="Nama Bank" ShowInCustomizationForm="True" ReadOnly="true">
                                                            <PropertiesTextEdit Style-BackColor="#f7faff"></PropertiesTextEdit>
                                                            <HeaderStyle Font-Bold="true" ForeColor="#1872c4" />
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataSpinEditColumn
                                                            Name="colNominalGiro"
                                                            Caption="Nominal Giro (Rp.)"
                                                            FieldName="NominalGiro"
                                                            ShowInCustomizationForm="True"
                                                            PropertiesSpinEdit-DisplayFormatString="{0:#,0.##}"
                                                            PropertiesSpinEdit-DisplayFormatInEditMode="true"
                                                            PropertiesSpinEdit-AllowMouseWheel="false"
                                                            PropertiesSpinEdit-SpinButtons-ShowIncrementButtons="false"
                                                            PropertiesSpinEdit-MinValue="0"
                                                            PropertiesSpinEdit-MaxValue="999999999999999" ReadOnly="true">
                                                            <HeaderStyle Font-Bold="true" ForeColor="#1872c4" />
                                                            <PropertiesSpinEdit Style-BackColor="#f7faff"></PropertiesSpinEdit>
                                                        </dx:GridViewDataSpinEditColumn>
                                                        <dx:GridViewDataDateColumn Name="colTgljatuhTempoGiro" FieldName="TglJatuhTempo" Caption="Tgl. Jatuh Tempo" PropertiesDateEdit-DisplayFormatString="dd/MM/yyyy" ReadOnly="true">
                                                            <PropertiesDateEdit Style-BackColor="#f7faff" DisplayFormatString="dd/MM/yyyy"></PropertiesDateEdit>
                                                            <HeaderStyle Font-Bold="true" ForeColor="#1872c4" />
                                                        </dx:GridViewDataDateColumn>
                                                        <dx:GridViewDataSpinEditColumn
                                                            Name="colLamaPenundaan"
                                                            Caption="Lama Penundaan"
                                                            FieldName="LamaPenundaan"
                                                            ReadOnly="true"
                                                            ShowInCustomizationForm="True"
                                                            PropertiesSpinEdit-DisplayFormatString="{0:#,0.##}"
                                                            PropertiesSpinEdit-DisplayFormatInEditMode="true"
                                                            PropertiesSpinEdit-AllowMouseWheel="false"
                                                            PropertiesSpinEdit-SpinButtons-ShowIncrementButtons="false"
                                                            PropertiesSpinEdit-MinValue="0"
                                                            PropertiesSpinEdit-MaxValue="999999999999999">
                                                            <HeaderStyle Font-Bold="true" ForeColor="#1872c4" />
                                                            <PropertiesSpinEdit Style-BackColor="#f7faff"></PropertiesSpinEdit>
                                                        </dx:GridViewDataSpinEditColumn>
                                                        <dx:GridViewDataDateColumn Name="colTgldijalankanKembali" FieldName="TglDiJalankanKembali" Caption="Tgl. di Jalankan Kembali" PropertiesDateEdit-DisplayFormatString="dd/MM/yyyy">
                                                            <PropertiesDateEdit DisplayFormatString="dd/MM/yyyy"></PropertiesDateEdit>
                                                            <HeaderStyle Font-Bold="true" ForeColor="#1872c4" />
                                                            <PropertiesDateEdit>
                                                                <ClientSideEvents DateChanged="diffDay" />
                                                            </PropertiesDateEdit>
                                                        </dx:GridViewDataDateColumn>
                                                        <dx:GridViewDataTextColumn Name="colAngsuranDariKe" FieldName="AngsuranDariKe" Caption="Angsuran Ke / Dari" ShowInCustomizationForm="True">
                                                            <HeaderStyle Font-Bold="true" ForeColor="#1872c4" />
                                                        </dx:GridViewDataTextColumn>
                                                    </Columns>
                                                </dx:ASPxGridView>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:LayoutItem ShowCaption="True" Caption="Alasan Penundaan" Width="100%">
                                        <CaptionSettings Location="Top" />
                                        <CaptionStyle Font-Bold="true" ForeColor="#1872c4"></CaptionStyle>
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxMemo runat="server" ID="mmAlasanPenundaan" ClientInstanceName="mmAlasanPenundaan" Width="100%" Height="75px" Theme="Aqua"></dx:ASPxMemo>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                </Items>
                            </dx:LayoutGroup>
                            <dx:LayoutGroup Name="lgDetailPurchaseRequest" GroupBoxDecoration="Box" Caption="Detail Purchase Request" GroupBoxStyle-Caption-BackColor="White" ColCount="4" Visible="False">
                                <Items>
                                    <dx:LayoutItem ShowCaption="False" Width="100%">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxGridView
                                                    runat="server"
                                                    ID="gvPurchaseRequest"
                                                    ClientInstanceName="gvPurchaseRequest"
                                                    Width="100%"
                                                    KeyFieldName="DtlKey"
                                                    AutoGenerateColumns="False"
                                                    EnableCallBacks="true"
                                                    EnablePagingCallbackAnimation="true"
                                                    EnableTheming="True"
                                                    Theme="Aqua"
                                                    Font-Names="Calibri"
                                                    OnDataBinding="gvPurchaseRequest_DataBinding"
                                                    OnRowInserting="gvPurchaseRequest_RowInserting"
                                                    OnRowUpdating="gvPurchaseRequest_RowUpdating"
                                                    OnRowDeleting="gvPurchaseRequest_RowDeleting"
                                                    OnCustomCallback="gvPurchaseRequest_CustomCallback"
                                                    OnCellEditorInitialize="gvPurchaseRequest_CellEditorInitialize"
                                                    OnCustomColumnDisplayText="gvPurchaseRequest_CustomColumnDisplayText">
                                                    <SettingsAdaptivity AdaptivityMode="HideDataCellsWindowLimit" AllowOnlyOneAdaptiveDetailExpanded="True" HideDataCellsAtWindowInnerWidth="700"></SettingsAdaptivity>
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
                                                        <dx:GridViewDataTextColumn Name="colPurchaseReqDtlKey" Caption="DtlKey" FieldName="DtlKey" ReadOnly="True" Visible="false" VisibleIndex="2">
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Name="colPurchaseReqDocKey" Caption="DocKey" FieldName="DocKey" ReadOnly="True" ShowInCustomizationForm="true" Visible="false" VisibleIndex="3">
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Name="colPurchaseReqSeq" Caption="Seq" FieldName="Seq" ReadOnly="True" ShowInCustomizationForm="true" Visible="false" VisibleIndex="4">
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Name="colPurchaseReqNamaBarang" FieldName="NamaBarang" ShowInCustomizationForm="True" Caption="Nama Barang" Width="20%">
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataComboBoxColumn Name="colPurchaseReqKategori" FieldName="Kategori" ShowInCustomizationForm="True" Caption="Kategori" Width="5%">
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                            <PropertiesComboBox EnableCallbackMode="true" ClientInstanceName="colPurchaseReqKategori" DropDownRows="10" IncrementalFilteringDelay="500" IncrementalFilteringMode="Contains" DisplayFormatString="{0}" TextFormatString="{0}" DropDownStyle="DropDownList" ValueField="Kategori" TextField="Kategori" Width="100%">
                                                                <ItemStyle Wrap="True"></ItemStyle>
                                                                <Items>
                                                                    <dx:ListEditItem Text="IT" Value="IT" />
                                                                    <dx:ListEditItem Text="NON IT" Value="NON IT" />
                                                                </Items>
                                                                <ValidationSettings ValidateOnLeave="true" ValidationGroup="ValidationSave" Display="Dynamic" ErrorDisplayMode="ImageWithText">
                                                                    <RequiredField ErrorText="* Value can't be empty." IsRequired="true" />
                                                                </ValidationSettings>
                                                            </PropertiesComboBox>
                                                        </dx:GridViewDataComboBoxColumn>
                                                        <dx:GridViewDataSpinEditColumn
                                                            Name="colPurchaseReqQty"
                                                            Caption="Jumlah"
                                                            FieldName="Qty"
                                                            ReadOnly="false" Width="5%"
                                                            ShowInCustomizationForm="True"
                                                            PropertiesSpinEdit-DisplayFormatString="{0:#,0.##}"
                                                            PropertiesSpinEdit-DisplayFormatInEditMode="true"
                                                            PropertiesSpinEdit-AllowMouseWheel="false"
                                                            PropertiesSpinEdit-SpinButtons-ShowIncrementButtons="false"
                                                            PropertiesSpinEdit-MinValue="0"
                                                            PropertiesSpinEdit-MaxValue="999999999999999">
                                                            <HeaderStyle Font-Bold="true" ForeColor="#1872c4" />
                                                        </dx:GridViewDataSpinEditColumn>
                                                        <dx:GridViewDataMemoColumn Name="colPurchaseReqSpec" FieldName="Spesifikasi" ShowInCustomizationForm="True" Caption="Spesifikasi" Width="10%">
                                                            <PropertiesMemoEdit Height="16px"></PropertiesMemoEdit>
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                        </dx:GridViewDataMemoColumn>
                                                        <dx:GridViewDataMemoColumn Name="colPurchaseReqKet" FieldName="Keterangan" ShowInCustomizationForm="True" Caption="Keterangan" Width="10%">
                                                            <PropertiesMemoEdit Height="16px"></PropertiesMemoEdit>
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                        </dx:GridViewDataMemoColumn>
                                                        <dx:GridViewDataCheckColumn Name="colPurchaseReqIsBudget" FieldName="IsBudget" ShowInCustomizationForm="True" Caption="Is Budget?" Width="5%">
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                            <PropertiesCheckEdit ValueChecked="T" ValueGrayed="N" ClientInstanceName="colPurchaseReqIsBudget" ValueType="System.Char" ValueUnchecked="F"></PropertiesCheckEdit>
                                                        </dx:GridViewDataCheckColumn>
                                                    </Columns>
                                                </dx:ASPxGridView>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                </Items>
                            </dx:LayoutGroup>
                            <dx:LayoutGroup Name="lgDetailBiayaBulanan" GroupBoxDecoration="Box" Caption="Detail Biaya Bulanan" GroupBoxStyle-Caption-BackColor="White" ColCount="4" Visible="False">
                                <Items>
                                    <dx:LayoutItem ShowCaption="True" Caption="No. PV">
                                        <CaptionSettings Location="Top" />
                                        <CaptionStyle Font-Bold="true" ForeColor="#1872c4"></CaptionStyle>
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxTextBox runat="server" ID="txtBiayaBulananPVNo" ClientInstanceName="txtBiayaBulananPVNo" Width="100%" Theme="Aqua"></dx:ASPxTextBox>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:LayoutItem ShowCaption="True" Caption="Header" Width="100%">
                                        <CaptionSettings Location="Top" />
                                        <CaptionStyle Font-Bold="true" ForeColor="#1872c4"></CaptionStyle>
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxMemo runat="server" ID="mmBiayaBulananHeader" ClientInstanceName="mmBiayaBulananHeader" Width="100%" Height="75px" Theme="Aqua"></dx:ASPxMemo>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:LayoutItem ShowCaption="False" Width="100%">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxGridView
                                                    runat="server"
                                                    ID="gvBiayaBulanan"
                                                    ClientInstanceName="gvBiayaBulanan"
                                                    Width="100%"
                                                    KeyFieldName="DtlKey"
                                                    AutoGenerateColumns="False"
                                                    EnableCallBacks="true"
                                                    EnablePagingCallbackAnimation="true"
                                                    EnableTheming="True"
                                                    Theme="Aqua"
                                                    Font-Names="Calibri"
                                                    OnDataBinding="gvBiayaBulanan_DataBinding"
                                                    OnRowInserting="gvBiayaBulanan_RowInserting"
                                                    OnRowUpdating="gvBiayaBulanan_RowUpdating"
                                                    OnRowDeleting="gvBiayaBulanan_RowDeleting"
                                                    OnCustomCallback="gvBiayaBulanan_CustomCallback"
                                                    OnCellEditorInitialize="gvBiayaBulanan_CellEditorInitialize"
                                                    OnCustomColumnDisplayText="gvBiayaBulanan_CustomColumnDisplayText">
                                                    <SettingsAdaptivity AdaptivityMode="HideDataCellsWindowLimit" AllowOnlyOneAdaptiveDetailExpanded="True" HideDataCellsAtWindowInnerWidth="700"></SettingsAdaptivity>
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
                                                        <dx:GridViewDataTextColumn Name="colDtlKey" Caption="DtlKey" FieldName="DtlKey" ReadOnly="True" Visible="false" VisibleIndex="2">
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Name="colDocKey" Caption="DocKey" FieldName="DocKey" ReadOnly="True" ShowInCustomizationForm="true" Visible="false" VisibleIndex="3">
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Name="colSeq" Caption="Seq" FieldName="Seq" ReadOnly="True" ShowInCustomizationForm="true" Visible="false" VisibleIndex="4">
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Name="colKeterangan" FieldName="Keterangan" ShowInCustomizationForm="True" Caption="Keterangan" Width="20%">
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Name="colPeriode" FieldName="Periode" ShowInCustomizationForm="True" Caption="Periode" Width="5%">
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataMemoColumn Name="colRemark1" FieldName="Remark1" ShowInCustomizationForm="True" Caption="Remark 1" Width="10%">
                                                            <PropertiesMemoEdit Height="16px"></PropertiesMemoEdit>
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                        </dx:GridViewDataMemoColumn>
                                                        <dx:GridViewDataMemoColumn Name="colRemark2" FieldName="Remark2" ShowInCustomizationForm="True" Caption="Remark 2" Width="10%">
                                                            <PropertiesMemoEdit Height="16px"></PropertiesMemoEdit>
                                                            <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                        </dx:GridViewDataMemoColumn>
                                                        <dx:GridViewDataSpinEditColumn
                                                            Name="colTotal"
                                                            Caption="Total"
                                                            FieldName="Total"
                                                            ReadOnly="false" Width="5%"
                                                            ShowInCustomizationForm="True"
                                                            PropertiesSpinEdit-DisplayFormatString="{0:#,0.##}"
                                                            PropertiesSpinEdit-DisplayFormatInEditMode="true"
                                                            PropertiesSpinEdit-AllowMouseWheel="false"
                                                            PropertiesSpinEdit-SpinButtons-ShowIncrementButtons="false"
                                                            PropertiesSpinEdit-MinValue="0"
                                                            PropertiesSpinEdit-MaxValue="999999999999999">
                                                            <HeaderStyle Font-Bold="true" ForeColor="#1872c4" />
                                                        </dx:GridViewDataSpinEditColumn>
                                                    </Columns>
                                                </dx:ASPxGridView>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:LayoutItem ShowCaption="True" Caption="Footer" Width="100%">
                                        <CaptionSettings Location="Top" />
                                        <CaptionStyle Font-Bold="true" ForeColor="#1872c4"></CaptionStyle>
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxMemo runat="server" ID="mmBiayaBulananFooter" ClientInstanceName="mmBiayaBulananFooter" Width="100%" Height="75px" Theme="Aqua"></dx:ASPxMemo>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                </Items>
                            </dx:LayoutGroup>
                            <dx:LayoutGroup Name="lgFreeTextMemo" GroupBoxDecoration="Box" Caption="Free Text Memo" GroupBoxStyle-Caption-BackColor="White" ColCount="4" Visible="false">
                                <Items>
                                    <dx:LayoutItem ShowCaption="False" HorizontalAlign="Center" Width="100%" ColSpan="4">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <%--<dx:ASPxRichEdit ID="reMemo" runat="server" ClientInstanceName="reMemo" ReadOnly="false" ShowConfirmOnLosingChanges="false" ViewStateMode="Disabled" Width="100%" OnInit="reMemo_Init">
                                                    <Settings>
                                                        <Behavior CreateNew="Hidden" SaveAs="Disabled" Open="Disabled" Save="Disabled" />
                                                    </Settings>
                                                </dx:ASPxRichEdit>--%>

                                                <dx:ASPxRichEdit ID="reTemplate" runat="server" ClientInstanceName="reTemplate" OnCalculateDocumentVariable="reTemplate_CalculateDocumentVariable" ShowConfirmOnLosingChanges="false" ViewStateMode="Disabled" Width="100%" OnPreRender="reTemplate_PreRender" OnInit="reTemplate_Init" WorkDirectory="AppData">
                                                    <Settings>
                                                        <Behavior CreateNew="Hidden" SaveAs="Disabled" Open="Disabled" Save="Disabled"/>
                                                    </Settings>
                                                    <ClientSideEvents Init="onFreeTextInit"/>
                                                </dx:ASPxRichEdit>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>

                                    <dx:LayoutItem ShowCaption="False" HorizontalAlign="Center" Width="100%" ColSpan="4">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>

                                    <dx:LayoutItem ShowCaption="False" HorizontalAlign="Center" Width="100%" ColSpan="4">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxButton runat="server" ID="btnExportPDF" ClientInstanceName="btnExportPDF" Text="Download PDF" AutoPostBack="false" Theme="Aqua" OnClick="btnExportPDF_Click" Visible ="false">
                                                </dx:ASPxButton>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>

                                    <%--<dx:LayoutItem ShowCaption="False" HorizontalAlign="Center" Width="100%" ColSpan="4">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxButton runat="server" ID="btnSaveTemplate" ClientInstanceName="btnSaveTemplate" Text="Template Save" AutoPostBack="false" Theme="Aqua" OnClick="btnSaveTemplate_Click">
                                                </dx:ASPxButton>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:LayoutItem ShowCaption="False" HorizontalAlign="Center" Width="100%" ColSpan="4">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxButton runat="server" ID="btnOpenTemplate" ClientInstanceName="btnOpenTemplate" Text="Template Open" AutoPostBack="false" Theme="Aqua" OnClick="btnOpenTemplate_Click">
                                                </dx:ASPxButton>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>--%>
                                    
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
                            <dx:LayoutGroup Name="lgDetailUploadDoc" GroupBoxDecoration="Box" Caption="Upload Document" GroupBoxStyle-Caption-BackColor="White" ColCount="4" Visible="False">
                                <Items>
                                    <dx:LayoutItem ShowCaption="False" Width="100%">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxGridView
                                                        runat="server"
                                                        ID="gvUploadDoc"
                                                        ClientInstanceName="gvUploadDoc"
                                                        Width="100%" 
                                                        KeyFieldName="ID"
                                                        AutoGenerateColumns="False" 
                                                        Theme="Aqua"
                                                        EnableCallBacks="true"
                                                        EnablePagingCallbackAnimation="true"
                                                        Font-Names="Calibri" Font-Size="9" ForeColor="#142e5d"
                                                        OnDataBinding="gvUploadDoc_DataBinding" 
                                                        OnCustomCallback="gvUploadDoc_CustomCallback" 
                                                        OnCustomButtonCallback="gvUploadDoc_CustomButtonCallback">
                                                        <SettingsAdaptivity AdaptivityMode="HideDataCellsWindowLimit" AllowOnlyOneAdaptiveDetailExpanded="True" HideDataCellsAtWindowInnerWidth="700"></SettingsAdaptivity>
                                                        <Settings ShowFilterRow="false" ShowGroupPanel="false" ShowFilterRowMenu="false" ShowFilterBar="Auto" ShowHeaderFilterButton="false" />
                                                        <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True" FilterRowMode="OnClick" EnableRowHotTrack="true" />
                                                        <SettingsDataSecurity AllowDelete="true" AllowEdit="true" AllowInsert="true" />
                                                        <SettingsFilterControl ViewMode="VisualAndText" AllowHierarchicalColumns="true" ShowAllDataSourceColumns="true" MaxHierarchyDepth="1" />
                                                        <SettingsPager PageSize="1000" AllButton-Visible="true" Summary-Visible="true" Visible="true"></SettingsPager>
                                                        <Columns>
                                                            <dx:GridViewDataTextColumn Name="colID" Caption="ID." FieldName="ID" ReadOnly="True" Visible="false">
                                                                    <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                            </dx:GridViewDataTextColumn>
                                                            <dx:GridViewDataTextColumn Name="colNo" Caption="No." FieldName="No" ReadOnly="True" UnboundType="String">
                                                                    <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                            </dx:GridViewDataTextColumn>
                                                            <dx:GridViewDataTextColumn Name="colAppNo" Caption="Memo No." FieldName="AppNo" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                                                    <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                            </dx:GridViewDataTextColumn>
                                                            <dx:GridViewDataDateColumn Name="colName" Caption="Document Type" FieldName="Name" ReadOnly="True" ShowInCustomizationForm="true" PropertiesDateEdit-DisplayFormatString="dd/MM/yyyy hh:mm:ss" Visible="true">
                                                                    <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                            </dx:GridViewDataDateColumn>
                                                            <dx:GridViewDataTextColumn Name="colExt" Caption="Ext." FieldName="Ext" ReadOnly="True" UnboundType="String">
                                                                    <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                            </dx:GridViewDataTextColumn>
                                                            <dx:GridViewDataTextColumn Name="colRemarks" Caption="Remark" FieldName="Remarks" ReadOnly="True" UnboundType="String">
                                                                    <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                            </dx:GridViewDataTextColumn>
                                                            <dx:GridViewCommandColumn ButtonType="Link"  Caption="">
                                                                <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                                <CustomButtons>
                                                                    <dx:GridViewCommandColumnCustomButton ID="btnDownload" Text="Download">
                                                                    </dx:GridViewCommandColumnCustomButton>
                                                                </CustomButtons>
                                                            </dx:GridViewCommandColumn>
                                                        </Columns>
                                                </dx:ASPxGridView>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                </Items>
                            </dx:LayoutGroup>
                            <dx:LayoutGroup Name="lgDetailPendGiroHist" GroupBoxDecoration="Box" Caption="History Pending Giro" GroupBoxStyle-Caption-BackColor="White" ColCount="4" Visible="False">
                                <Items>
                                    <dx:LayoutItem ShowCaption="False" Width="100%">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxGridView
                                                        runat="server"
                                                        ID="gvPendGiroHist"
                                                        ClientInstanceName="gvPendGiroHist"
                                                        Width="100%" 
                                                        KeyFieldName="DtlAppKey"
                                                        AutoGenerateColumns="False" 
                                                        Theme="Aqua"
                                                        EnableCallBacks="true"
                                                        EnablePagingCallbackAnimation="true"
                                                        Font-Names="Calibri" Font-Size="9" ForeColor="#142e5d"
                                                        OnDataBinding="gvPendGiroHist_DataBinding" 
                                                        OnCustomCallback="gvPendGiroHist_CustomCallback" 
                                                        OnCustomButtonCallback="gvPendGiroHist_CustomButtonCallback" OnCustomCellMerge="gvPendGiroHist_CustomCellMerge">
                                                        <SettingsAdaptivity AdaptivityMode="HideDataCellsWindowLimit" AllowOnlyOneAdaptiveDetailExpanded="True" HideDataCellsAtWindowInnerWidth="700"></SettingsAdaptivity>
                                                        <Settings ShowFilterRow="false" ShowGroupPanel="false" ShowFilterRowMenu="false" ShowFilterBar="Auto" ShowHeaderFilterButton="false" />
                                                        <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True" FilterRowMode="OnClick" EnableRowHotTrack="true" AllowCellMerge="true"/>
                                                        <SettingsDataSecurity AllowDelete="true" AllowEdit="true" AllowInsert="true" />
                                                        <SettingsFilterControl ViewMode="VisualAndText" AllowHierarchicalColumns="true" ShowAllDataSourceColumns="true" MaxHierarchyDepth="1" />
                                                        <SettingsPager PageSize="1000" AllButton-Visible="true" Summary-Visible="true" Visible="true"></SettingsPager>
                                                        <Columns>
                                                            <dx:GridViewDataTextColumn Name="colDocNo" Caption="Memo No." FieldName="DocNo" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                                                    <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                            </dx:GridViewDataTextColumn>
                                                            <dx:GridViewDataDateColumn Name="colDocDate" Caption="Memo Date" FieldName="DocDate" ReadOnly="True" ShowInCustomizationForm="true" PropertiesDateEdit-DisplayFormatString="dd/MM/yyyy" Visible="true">
                                                                    <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                            </dx:GridViewDataDateColumn>
                                                            <dx:GridViewDataTextColumn Name="colStatus" Caption="Current Status" FieldName="Status" ReadOnly="True" UnboundType="String">
                                                                    <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                            </dx:GridViewDataTextColumn>
                                                            <dx:GridViewDataTextColumn Name="colApprover" Caption="Approver" FieldName="Nama" ReadOnly="True" UnboundType="String">
                                                                    <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                            </dx:GridViewDataTextColumn>
                                                            <dx:GridViewDataDateColumn Name="colDecisionDate" Caption="Decision Date" FieldName="DecisionDate" ReadOnly="True" ShowInCustomizationForm="true" PropertiesDateEdit-DisplayFormatString="dd/MM/yyyy hh:mm:ss" Visible="true">
                                                                    <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                            </dx:GridViewDataDateColumn>
                                                            <dx:GridViewDataTextColumn Name="colDecisionState" Caption="State" FieldName="DecisionState" ReadOnly="True" UnboundType="String">
                                                                    <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                            </dx:GridViewDataTextColumn>
                                                            <dx:GridViewDataTextColumn Name="colDecisionNote" Caption="Note" FieldName="DecisionNote" ReadOnly="True" UnboundType="String">
                                                                    <HeaderStyle Font-Bold="true" BackColor="#f0f0f0" ForeColor="#1872c4" />
                                                            </dx:GridViewDataTextColumn>
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
            <dx:EmptyLayoutItem Width="45%"></dx:EmptyLayoutItem>
            <dx:LayoutItem ShowCaption="False" Width="10%">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer>
                        <dx:ASPxButton runat="server" ID="btnBackToCreator" ClientInstanceName="btnBackToCreator" Text="Back to Creator" AutoPostBack="false" Theme="Aqua" ClientVisible="false">
                            <ClientSideEvents Click="function(s,e) { cplMain.PerformCallback('RETURN_CONFIRM;' + 'RETURN_CONFIRM'); }" />
                        </dx:ASPxButton>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
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
            
        </Items>
    </dx:ASPxFormLayout>
    <dx:ASPxCallback ID="cplMain" runat="server" ClientInstanceName="cplMain" OnCallback="cplMain_Callback">
        <ClientSideEvents EndCallback="cplMain_EndCallback" />
    </dx:ASPxCallback>
    
</asp:Content>
