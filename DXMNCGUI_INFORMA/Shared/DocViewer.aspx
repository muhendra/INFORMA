<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DocViewer.aspx.cs" Inherits="DXMNCGUI_INFORMA.Shared.DocViewer" %>
<%@ Register Assembly="DevExpress.XtraReports.v17.2.Web, Version=17.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxRichEdit.v17.2, Version=17.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRichEdit" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxRichEdit.v17.2, Version=17.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxTreeList" TagPrefix="dx" %>
<!DOCTYPE html>
<script type="text/javascript" src="../../Scripts/Application.js"></script>
<script type="text/javascript">
    function cplMain_EndCallback(s, e) {
        switch (cplMain.cpCallbackParam) {
            case "FREETEXT_PDF":
                break;
        }
    }

    function onRichInit(s) {
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

        reMemo.commands.updateAllFields.execute();
        reMemo.commands.showAllFieldCodes.execute(false);
        reMemo.GetRibbon().SetActiveTabIndex(0);

    }
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dx:ASPxRoundPanel ID="pnlMain" runat="server" ShowCollapseButton="true" ClientInstanceName="pnlMain" Width="100%" Height="100%">
            <PanelCollection>
                <dx:PanelContent>
                    <dx:ASPxDocumentViewer ID="dvrMain" runat="server" ClientInstanceName="dvrMain" Theme="Aqua"></dx:ASPxDocumentViewer>
                    <dx:ASPxRichEdit ID="reMemo" runat="server" ClientInstanceName="reMemo" ShowConfirmOnLosingChanges="false" Visible="false" Height="800px" Width="100%" OnInit="reMemo_Init" OnCalculateDocumentVariable="reMemo_CalculateDocumentVariable" OnPreRender="reMemo_PreRender">
                        <ClientSideEvents Init="onRichInit" />
                        <Settings>
                            <Behavior CreateNew="Hidden" SaveAs="Disabled" Open="Disabled" Save="Disabled"   />
                        </Settings>
                        <StylesRibbon ></StylesRibbon>
                    </dx:ASPxRichEdit>
                </dx:PanelContent>
            </PanelCollection>
        </dx:ASPxRoundPanel>
    </div>
    </form>
    <dx:ASPxCallback ID="cplMain" runat="server" ClientInstanceName="cplMain" OnCallback="cplMain_Callback">
        <ClientSideEvents EndCallback="cplMain_EndCallback" />
    </dx:ASPxCallback>
</body>
</html>
