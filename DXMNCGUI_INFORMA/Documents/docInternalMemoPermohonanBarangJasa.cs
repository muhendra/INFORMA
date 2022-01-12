using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for docInternalMemoPermohonanBarangJasa
/// </summary>
public class docInternalMemoPermohonanBarangJasa : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private ReportHeaderBand ReportHeader;
    private XRLine xrLine1;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell3;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell8;
    private XRTableCell xrTableCell9;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell11;
    private XRTableCell xrTableCell12;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell6;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell13;
    private XRTableCell xrTableCell14;
    private XRTableCell xrTableCell15;
    private XRLabel xrLabel1;
    private XRLabel xrLabel2;
    private GroupHeaderBand GroupHeader1;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    private DevExpress.XtraReports.Parameters.Parameter DocKey;
    private DevExpress.XtraReports.Parameters.Parameter DocNo;
    private XRLabel xrLabel3;
    private XRTable xrTable2;
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell17;
    private XRTableCell xrTableCell18;
    private XRTableCell xrTableCell19;
    private XRTableCell xrTableCell20;
    private DetailReportBand DetailReport;
    private DetailBand Detail1;
    private XRTable xrTable3;
    private XRTableRow xrTableRow7;
    private XRTableCell xrTableCell21;
    private XRTableCell xrTableCell22;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell24;
    private XRTableCell xrTableCell25;
    private XRLabel xrLabel16;
    private XRLabel xrLabel14;
    private XRPageInfo xrPageInfo1;
    private XRLabel xrLabel15;
    private XRLabel xrLabel13;
    private GroupFooterBand GroupFooter2;
    private XRLabel xrLabel4;
    private ReportFooterBand ReportFooter1;
    private XRTable xrTable6;
    private XRTableRow xrTableRow21;
    private XRTableCell xrTableCell52;
    private XRTableCell xrTableCell53;
    private XRTableRow xrTableRow22;
    private XRTableCell xrTableCell54;
    private XRTableCell xrTableCell55;
    private XRTableRow xrTableRow23;
    private XRTableCell xrTableCell56;
    private XRTableCell lblDisetujuiName;
    private XRTableRow xrTableRow24;
    private XRTableCell xrTableCell58;
    private XRTableCell lblDisetujuiJabatan;
    private XRTable xrTabIT;
    private XRTableRow xrTableRow25;
    private XRTableCell xrTableCell60;
    private XRTableCell xrTableCell61;
    private XRTableRow xrTableRow26;
    private XRTableCell lblReviewITName;
    private XRTableCell xrTableCell63;
    private XRTableRow xrTableRow27;
    private XRTableCell lblReviewITJabatan;
    private XRTableCell xrTableCell65;
    private XRTable xrTabBudget;
    private XRTableRow xrTableRow28;
    private XRTableCell xrTableCell66;
    private XRTableCell xrTableCell67;
    private XRTableRow xrTableRow29;
    private XRTableCell lblReviewBudgetName;
    private XRTableCell xrTableCell69;
    private XRTableRow xrTableRow30;
    private XRTableCell lblReviewBudgetJabatan;
    private XRTableCell xrTableCell71;
    private XRTable xrTabCFO;
    private XRTableRow xrTableRow31;
    private XRTableCell xrTableCell72;
    private XRTableCell xrTableCell73;
    private XRTableRow xrTableRow32;
    private XRTableCell lblKeputusanCFOName;
    private XRTableCell xrTableCell75;
    private XRTableRow xrTableRow33;
    private XRTableCell lblKeputusanCFOJabatan;
    private XRTableCell xrTableCell77;
    private XRPictureBox picBoxPurchaseReq1;
    private XRPictureBox picBoxPurchaseReq2;
    private XRLabel lblPurchaseReq1;
    private XRLabel lblPurchaseReq2;
    private XRPictureBox picBoxPurchaseReq3;
    private XRPictureBox picBoxPurchaseReq4;
    private XRLabel lblPurchaseReq3;
    private XRLabel lblPurchaseReq4;
    private XRPictureBox picBoxPurchaseReq5;
    private XRPictureBox picBoxPurchaseReq6;
    private XRLabel lblPurchaseReq5;
    private XRLabel lblPurchaseReq6;
    private XRPictureBox picBoxPurchaseReq7;
    private XRPictureBox picBoxPurchaseReq8;
    private XRLabel lblPurchaseReq7;
    private XRLabel lblPurchaseReq8;
    private XRPictureBox picBoxMySign1;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public docInternalMemoPermohonanBarangJasa()
    {
        InitializeComponent();
        //
        // TODO: Add constructor logic here
        //
    }

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(docInternalMemoPermohonanBarangJasa));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.MasterDetailInfo masterDetailInfo1 = new DevExpress.DataAccess.Sql.MasterDetailInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.MasterDetailInfo masterDetailInfo2 = new DevExpress.DataAccess.Sql.MasterDetailInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.DocKey = new DevExpress.XtraReports.Parameters.Parameter();
            this.DocNo = new DevExpress.XtraReports.Parameters.Parameter();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupFooter2 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter1 = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow21 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell52 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell53 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow22 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell54 = new DevExpress.XtraReports.UI.XRTableCell();
            this.picBoxMySign1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableCell55 = new DevExpress.XtraReports.UI.XRTableCell();
            this.picBoxPurchaseReq1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.picBoxPurchaseReq2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.lblPurchaseReq1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblPurchaseReq2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow23 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell56 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblDisetujuiName = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow24 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell58 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblDisetujuiJabatan = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTabIT = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow25 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell60 = new DevExpress.XtraReports.UI.XRTableCell();
            this.picBoxPurchaseReq3 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.picBoxPurchaseReq4 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableCell61 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblPurchaseReq3 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblPurchaseReq4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow26 = new DevExpress.XtraReports.UI.XRTableRow();
            this.lblReviewITName = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell63 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow27 = new DevExpress.XtraReports.UI.XRTableRow();
            this.lblReviewITJabatan = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell65 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTabBudget = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow28 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell66 = new DevExpress.XtraReports.UI.XRTableCell();
            this.picBoxPurchaseReq5 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.picBoxPurchaseReq6 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableCell67 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblPurchaseReq5 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblPurchaseReq6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow29 = new DevExpress.XtraReports.UI.XRTableRow();
            this.lblReviewBudgetName = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell69 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow30 = new DevExpress.XtraReports.UI.XRTableRow();
            this.lblReviewBudgetJabatan = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell71 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTabCFO = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow31 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell72 = new DevExpress.XtraReports.UI.XRTableCell();
            this.picBoxPurchaseReq7 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.picBoxPurchaseReq8 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableCell73 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblPurchaseReq7 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblPurchaseReq8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow32 = new DevExpress.XtraReports.UI.XRTableRow();
            this.lblKeputusanCFOName = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell75 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow33 = new DevExpress.XtraReports.UI.XRTableRow();
            this.lblKeputusanCFOJabatan = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell77 = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTabIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTabBudget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTabCFO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel15,
            this.xrLabel13});
            this.TopMargin.HeightF = 45.83333F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel15
            // 
            this.xrLabel15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DocType]")});
            this.xrLabel15.Font = new System.Drawing.Font("Tahoma", 5.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel15.ForeColor = System.Drawing.Color.DarkGray;
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(40.37334F, 25.70836F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(265.625F, 15.70835F);
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseForeColor = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "xrLabel8";
            // 
            // xrLabel13
            // 
            this.xrLabel13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DocNo]")});
            this.xrLabel13.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.xrLabel13.ForeColor = System.Drawing.Color.DarkGray;
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(40.37204F, 10.00001F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(133.3333F, 15.70835F);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseForeColor = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "xrLabel8";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel16,
            this.xrLabel14,
            this.xrPageInfo1});
            this.BottomMargin.HeightF = 71.875F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel16
            // 
            this.xrLabel16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MemoPerihal]")});
            this.xrLabel16.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.xrLabel16.ForeColor = System.Drawing.Color.DarkGray;
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(40.37204F, 39.0625F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(320.5804F, 13.62502F);
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseForeColor = false;
            this.xrLabel16.Text = "xrLabel14";
            // 
            // xrLabel14
            // 
            this.xrLabel14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DocNo]")});
            this.xrLabel14.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.xrLabel14.ForeColor = System.Drawing.Color.DarkGray;
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(40.37077F, 23.35421F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(133.3333F, 15.70835F);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseForeColor = false;
            this.xrLabel14.Text = "xrLabel8";
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(360.9523F, 23.35421F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(26.04166F, 16.75002F);
            this.xrPageInfo1.StylePriority.UseFont = false;
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.xrTable1,
            this.xrLabel1,
            this.xrLabel2});
            this.ReportHeader.HeightF = 242.7083F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrLine1
            // 
            this.xrLine1.LineWidth = 2;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(39.5F, 227.2971F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(647.2585F, 7.142548F);
            // 
            // xrTable1
            // 
            this.xrTable1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(39.5F, 111.3889F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1,
            this.xrTableRow3,
            this.xrTableRow4,
            this.xrTableRow2,
            this.xrTableRow5});
            this.xrTable1.SizeF = new System.Drawing.SizeF(333.375F, 104.1667F);
            this.xrTable1.StylePriority.UseFont = false;
            this.xrTable1.StylePriority.UseTextAlignment = false;
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.Text = "Kepada";
            this.xrTableCell1.Weight = 1.1096236359843479D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.Text = ":";
            this.xrTableCell2.Weight = 0.15524725618000446D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MemoTo]")});
            this.xrTableCell3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.Text = "xrTableCell3";
            this.xrTableCell3.Weight = 6.2551291078356472D;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell9});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseFont = false;
            this.xrTableCell7.Text = "CC";
            this.xrTableCell7.Weight = 1.1096236359843479D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.StylePriority.UseFont = false;
            this.xrTableCell8.Text = ":";
            this.xrTableCell8.Weight = 0.15524725618000446D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MemoCC]")});
            this.xrTableCell9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.StylePriority.UseFont = false;
            this.xrTableCell9.Text = "xrTableCell9";
            this.xrTableCell9.Weight = 6.2551291078356472D;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell10,
            this.xrTableCell11,
            this.xrTableCell12});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 1D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.StylePriority.UseFont = false;
            this.xrTableCell10.Text = "Dari";
            this.xrTableCell10.Weight = 1.1096236359843479D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.StylePriority.UseFont = false;
            this.xrTableCell11.Text = ":";
            this.xrTableCell11.Weight = 0.15524725618000446D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MemoFrom]")});
            this.xrTableCell12.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.StylePriority.UseFont = false;
            this.xrTableCell12.Text = "xrTableCell12";
            this.xrTableCell12.Weight = 6.2551291078356472D;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.Text = "Tanggal";
            this.xrTableCell4.Weight = 1.1096236359843479D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.Text = ":";
            this.xrTableCell5.Weight = 0.15524725618000446D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DocDate]")});
            this.xrTableCell6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.Text = "xrTableCell6";
            this.xrTableCell6.TextFormatString = "{0:dd/MM/yyyy}";
            this.xrTableCell6.Weight = 6.2551291078356472D;
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell13,
            this.xrTableCell14,
            this.xrTableCell15});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 1D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.StylePriority.UseFont = false;
            this.xrTableCell13.Text = "Perihal";
            this.xrTableCell13.Weight = 1.1096236359843479D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.StylePriority.UseFont = false;
            this.xrTableCell14.Text = ":";
            this.xrTableCell14.Weight = 0.15524725618000446D;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MemoPerihal]")});
            this.xrTableCell15.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.StylePriority.UseFont = false;
            this.xrTableCell15.Text = "xrTableCell15";
            this.xrTableCell15.Weight = 6.2551291078356472D;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(40.37334F, 10.00001F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(646.3852F, 26.12498F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "INTERNAL MEMORANDUM";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrLabel2
            // 
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DocNo]")});
            this.xrLabel2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(40.37334F, 36.12499F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(647.2585F, 25.08333F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "INTERNAL MEMORANDUM";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrTable2});
            this.GroupHeader1.HeightF = 76.12498F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(39.5F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(647.2585F, 36.54165F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Berdasarkan evaluasi terkait kebutuhan pengadaan barang yang telah dilakukan pada" +
    " departemen kami, maka dengan ini diajukan permohonan pengadaan barang dengan ke" +
    "tentuan sebagai berikut :";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            // 
            // xrTable2
            // 
            this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(39.5F, 51.12498F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow6});
            this.xrTable2.SizeF = new System.Drawing.SizeF(647.2585F, 25F);
            this.xrTable2.StylePriority.UseBorders = false;
            this.xrTable2.StylePriority.UseFont = false;
            this.xrTable2.StylePriority.UseTextAlignment = false;
            this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell16,
            this.xrTableCell17,
            this.xrTableCell18,
            this.xrTableCell19,
            this.xrTableCell20});
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.Weight = 1D;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.StylePriority.UseFont = false;
            this.xrTableCell16.Text = "Nama Barang";
            this.xrTableCell16.Weight = 1.8610031058919914D;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.StylePriority.UseFont = false;
            this.xrTableCell17.Text = "Kategori";
            this.xrTableCell17.Weight = 0.71428206529134342D;
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.StylePriority.UseFont = false;
            this.xrTableCell18.Text = "Jumlah";
            this.xrTableCell18.Weight = 0.42471482881666522D;
            // 
            // xrTableCell19
            // 
            this.xrTableCell19.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell19.Name = "xrTableCell19";
            this.xrTableCell19.StylePriority.UseFont = false;
            this.xrTableCell19.Text = "Spesifikasi Barang";
            this.xrTableCell19.Weight = 1D;
            // 
            // xrTableCell20
            // 
            this.xrTableCell20.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell20.Name = "xrTableCell20";
            this.xrTableCell20.StylePriority.UseFont = false;
            this.xrTableCell20.Text = "Keterangan";
            this.xrTableCell20.Weight = 1D;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "SqlLocalConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.MetaSerializable = "<Meta X=\"20\" Y=\"20\" Width=\"100\" Height=\"649\" />";
            customSqlQuery1.Name = "InternalMemo";
            queryParameter1.Name = "DocKey";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.DocKey]", typeof(int));
            customSqlQuery1.Parameters.Add(queryParameter1);
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            customSqlQuery2.MetaSerializable = "<Meta X=\"140\" Y=\"20\" Width=\"100\" Height=\"190\" />";
            customSqlQuery2.Name = "InternalMemoApprovalList";
            queryParameter2.Name = "Dockey";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.DocKey]", typeof(int));
            customSqlQuery2.Parameters.Add(queryParameter2);
            customSqlQuery2.Sql = resources.GetString("customSqlQuery2.Sql");
            customSqlQuery3.MetaSerializable = "<Meta X=\"260\" Y=\"20\" Width=\"100\" Height=\"190\" />";
            customSqlQuery3.Name = "InternalMemoDetailPurchaseRequest";
            queryParameter3.Name = "DocKey";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.DocKey]", typeof(int));
            customSqlQuery3.Parameters.Add(queryParameter3);
            customSqlQuery3.Sql = resources.GetString("customSqlQuery3.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1,
            customSqlQuery2,
            customSqlQuery3});
            masterDetailInfo1.DetailQueryName = "InternalMemoApprovalList";
            relationColumnInfo1.NestedKeyColumn = "DocKey";
            relationColumnInfo1.ParentKeyColumn = "DocKey";
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo1);
            masterDetailInfo1.MasterQueryName = "InternalMemo";
            masterDetailInfo2.DetailQueryName = "InternalMemoDetailPurchaseRequest";
            relationColumnInfo2.NestedKeyColumn = "DocKey";
            relationColumnInfo2.ParentKeyColumn = "DocKey";
            masterDetailInfo2.KeyColumns.Add(relationColumnInfo2);
            masterDetailInfo2.MasterQueryName = "InternalMemo";
            this.sqlDataSource1.Relations.AddRange(new DevExpress.DataAccess.Sql.MasterDetailInfo[] {
            masterDetailInfo1,
            masterDetailInfo2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // DocKey
            // 
            this.DocKey.Description = "DocKey";
            this.DocKey.Name = "DocKey";
            this.DocKey.Type = typeof(int);
            this.DocKey.ValueInfo = "0";
            this.DocKey.Visible = false;
            // 
            // DocNo
            // 
            this.DocNo.Description = "DocNo";
            this.DocNo.Name = "DocNo";
            this.DocNo.Visible = false;
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1});
            this.DetailReport.DataMember = "InternalMemoDetailPurchaseRequest";
            this.DetailReport.DataSource = this.sqlDataSource1;
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3});
            this.Detail1.HeightF = 25F;
            this.Detail1.Name = "Detail1";
            // 
            // xrTable3
            // 
            this.xrTable3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(39.5F, 0F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow7});
            this.xrTable3.SizeF = new System.Drawing.SizeF(647.2585F, 25F);
            this.xrTable3.StylePriority.UseBorders = false;
            this.xrTable3.StylePriority.UseFont = false;
            this.xrTable3.StylePriority.UseTextAlignment = false;
            this.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell21,
            this.xrTableCell22,
            this.xrTableCell23,
            this.xrTableCell24,
            this.xrTableCell25});
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.Weight = 1D;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NamaBarang] + [IsBudget]")});
            this.xrTableCell21.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.StylePriority.UseFont = false;
            this.xrTableCell21.Text = "Nama Barang";
            this.xrTableCell21.Weight = 1.8610031058919914D;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Kategori]")});
            this.xrTableCell22.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.StylePriority.UseFont = false;
            this.xrTableCell22.Text = "Kategori";
            this.xrTableCell22.Weight = 0.71428206529134342D;
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Qty]")});
            this.xrTableCell23.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.StylePriority.UseFont = false;
            this.xrTableCell23.Text = "Jumlah";
            this.xrTableCell23.Weight = 0.42471482881666522D;
            // 
            // xrTableCell24
            // 
            this.xrTableCell24.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Spesifikasi]")});
            this.xrTableCell24.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell24.Name = "xrTableCell24";
            this.xrTableCell24.StylePriority.UseFont = false;
            this.xrTableCell24.Text = "Spesifikasi Barang";
            this.xrTableCell24.Weight = 1D;
            // 
            // xrTableCell25
            // 
            this.xrTableCell25.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Keterangan]")});
            this.xrTableCell25.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell25.Name = "xrTableCell25";
            this.xrTableCell25.StylePriority.UseFont = false;
            this.xrTableCell25.Text = "Keterangan";
            this.xrTableCell25.Weight = 1D;
            // 
            // GroupFooter2
            // 
            this.GroupFooter2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4});
            this.GroupFooter2.HeightF = 32.99999F;
            this.GroupFooter2.Name = "GroupFooter2";
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(39.5F, 10.00001F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(647.2585F, 22.99999F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Demikian kami sampaikan atas perhatian dan kerjasamanya kami ucapkan terimakasih." +
    "";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            // 
            // ReportFooter1
            // 
            this.ReportFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable6,
            this.xrTabIT,
            this.xrTabBudget,
            this.xrTabCFO});
            this.ReportFooter1.HeightF = 627.0834F;
            this.ReportFooter1.Name = "ReportFooter1";
            // 
            // xrTable6
            // 
            this.xrTable6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(40.37334F, 10.00001F);
            this.xrTable6.Name = "xrTable6";
            this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow21,
            this.xrTableRow22,
            this.xrTableRow23,
            this.xrTableRow24});
            this.xrTable6.SizeF = new System.Drawing.SizeF(647.2585F, 184.375F);
            this.xrTable6.StylePriority.UseBorders = false;
            // 
            // xrTableRow21
            // 
            this.xrTableRow21.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell52,
            this.xrTableCell53});
            this.xrTableRow21.Name = "xrTableRow21";
            this.xrTableRow21.Weight = 1D;
            // 
            // xrTableCell52
            // 
            this.xrTableCell52.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell52.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell52.Name = "xrTableCell52";
            this.xrTableCell52.StylePriority.UseBorders = false;
            this.xrTableCell52.StylePriority.UseFont = false;
            this.xrTableCell52.StylePriority.UseTextAlignment = false;
            this.xrTableCell52.Text = "Diajukan Oleh,";
            this.xrTableCell52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell52.Weight = 1.54517110506745D;
            // 
            // xrTableCell53
            // 
            this.xrTableCell53.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell53.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell53.Name = "xrTableCell53";
            this.xrTableCell53.StylePriority.UseBorders = false;
            this.xrTableCell53.StylePriority.UseFont = false;
            this.xrTableCell53.StylePriority.UseTextAlignment = false;
            this.xrTableCell53.Text = "Disetujui Oleh,";
            this.xrTableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell53.Weight = 1.45482889493255D;
            // 
            // xrTableRow22
            // 
            this.xrTableRow22.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell54,
            this.xrTableCell55});
            this.xrTableRow22.Name = "xrTableRow22";
            this.xrTableRow22.Weight = 4.2916668701171874D;
            // 
            // xrTableCell54
            // 
            this.xrTableCell54.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell54.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.picBoxMySign1});
            this.xrTableCell54.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell54.Name = "xrTableCell54";
            this.xrTableCell54.StylePriority.UseBorders = false;
            this.xrTableCell54.StylePriority.UseFont = false;
            this.xrTableCell54.Weight = 1.54517110506745D;
            // 
            // picBoxMySign1
            // 
            this.picBoxMySign1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxMySign1.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMySign1.Image")));
            this.picBoxMySign1.LocationFloat = new DevExpress.Utils.PointFloat(55.20064F, 39.84375F);
            this.picBoxMySign1.Name = "picBoxMySign1";
            this.picBoxMySign1.SizeF = new System.Drawing.SizeF(226.0417F, 57.44788F);
            this.picBoxMySign1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxMySign1.StylePriority.UseBorders = false;
            // 
            // xrTableCell55
            // 
            this.xrTableCell55.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell55.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.picBoxPurchaseReq1,
            this.picBoxPurchaseReq2,
            this.lblPurchaseReq1,
            this.lblPurchaseReq2});
            this.xrTableCell55.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell55.Name = "xrTableCell55";
            this.xrTableCell55.StylePriority.UseBorders = false;
            this.xrTableCell55.StylePriority.UseFont = false;
            this.xrTableCell55.Weight = 1.45482889493255D;
            // 
            // picBoxPurchaseReq1
            // 
            this.picBoxPurchaseReq1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPurchaseReq1.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPurchaseReq1.Image")));
            this.picBoxPurchaseReq1.LocationFloat = new DevExpress.Utils.PointFloat(81.86687F, 13.66665F);
            this.picBoxPurchaseReq1.Name = "picBoxPurchaseReq1";
            this.picBoxPurchaseReq1.SizeF = new System.Drawing.SizeF(57.39584F, 52.70831F);
            this.picBoxPurchaseReq1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPurchaseReq1.StylePriority.UseBorders = false;
            this.picBoxPurchaseReq1.Visible = false;
            // 
            // picBoxPurchaseReq2
            // 
            this.picBoxPurchaseReq2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPurchaseReq2.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPurchaseReq2.Image")));
            this.picBoxPurchaseReq2.LocationFloat = new DevExpress.Utils.PointFloat(81.86684F, 14.24526F);
            this.picBoxPurchaseReq2.Name = "picBoxPurchaseReq2";
            this.picBoxPurchaseReq2.SizeF = new System.Drawing.SizeF(57.39584F, 52.70831F);
            this.picBoxPurchaseReq2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPurchaseReq2.StylePriority.UseBorders = false;
            this.picBoxPurchaseReq2.Visible = false;
            // 
            // lblPurchaseReq1
            // 
            this.lblPurchaseReq1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPurchaseReq1.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPurchaseReq1.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPurchaseReq1.LocationFloat = new DevExpress.Utils.PointFloat(107.7339F, 66.95361F);
            this.lblPurchaseReq1.Name = "lblPurchaseReq1";
            this.lblPurchaseReq1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPurchaseReq1.SizeF = new System.Drawing.SizeF(182.945F, 13.62504F);
            this.lblPurchaseReq1.StylePriority.UseBorders = false;
            this.lblPurchaseReq1.StylePriority.UseFont = false;
            this.lblPurchaseReq1.StylePriority.UseForeColor = false;
            this.lblPurchaseReq1.Text = "Approve datetime";
            this.lblPurchaseReq1.Visible = false;
            // 
            // lblPurchaseReq2
            // 
            this.lblPurchaseReq2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPurchaseReq2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPurchaseReq2.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPurchaseReq2.LocationFloat = new DevExpress.Utils.PointFloat(107.7339F, 80.57876F);
            this.lblPurchaseReq2.Name = "lblPurchaseReq2";
            this.lblPurchaseReq2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPurchaseReq2.SizeF = new System.Drawing.SizeF(182.945F, 13.62505F);
            this.lblPurchaseReq2.StylePriority.UseBorders = false;
            this.lblPurchaseReq2.StylePriority.UseFont = false;
            this.lblPurchaseReq2.StylePriority.UseForeColor = false;
            this.lblPurchaseReq2.Text = "Note";
            this.lblPurchaseReq2.Visible = false;
            // 
            // xrTableRow23
            // 
            this.xrTableRow23.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell56,
            this.lblDisetujuiName});
            this.xrTableRow23.Name = "xrTableRow23";
            this.xrTableRow23.Weight = 1.041666259765625D;
            // 
            // xrTableCell56
            // 
            this.xrTableCell56.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell56.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MemoFrom]")});
            this.xrTableCell56.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell56.Name = "xrTableCell56";
            this.xrTableCell56.StylePriority.UseBorders = false;
            this.xrTableCell56.StylePriority.UseFont = false;
            this.xrTableCell56.StylePriority.UseTextAlignment = false;
            this.xrTableCell56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableCell56.Weight = 1.54517110506745D;
            // 
            // lblDisetujuiName
            // 
            this.lblDisetujuiName.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.lblDisetujuiName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisetujuiName.Name = "lblDisetujuiName";
            this.lblDisetujuiName.StylePriority.UseBorders = false;
            this.lblDisetujuiName.StylePriority.UseFont = false;
            this.lblDisetujuiName.StylePriority.UseTextAlignment = false;
            this.lblDisetujuiName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.lblDisetujuiName.Weight = 1.45482889493255D;
            // 
            // xrTableRow24
            // 
            this.xrTableRow24.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell58,
            this.lblDisetujuiJabatan});
            this.xrTableRow24.Name = "xrTableRow24";
            this.xrTableRow24.Weight = 1.041666259765625D;
            // 
            // xrTableCell58
            // 
            this.xrTableCell58.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell58.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell58.Name = "xrTableCell58";
            this.xrTableCell58.StylePriority.UseBorders = false;
            this.xrTableCell58.StylePriority.UseFont = false;
            this.xrTableCell58.StylePriority.UseTextAlignment = false;
            this.xrTableCell58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell58.Weight = 1.54517110506745D;
            // 
            // lblDisetujuiJabatan
            // 
            this.lblDisetujuiJabatan.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lblDisetujuiJabatan.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisetujuiJabatan.Name = "lblDisetujuiJabatan";
            this.lblDisetujuiJabatan.StylePriority.UseBorders = false;
            this.lblDisetujuiJabatan.StylePriority.UseFont = false;
            this.lblDisetujuiJabatan.StylePriority.UseTextAlignment = false;
            this.lblDisetujuiJabatan.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.lblDisetujuiJabatan.Weight = 1.45482889493255D;
            // 
            // xrTabIT
            // 
            this.xrTabIT.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTabIT.LocationFloat = new DevExpress.Utils.PointFloat(40.37334F, 214.5834F);
            this.xrTabIT.Name = "xrTabIT";
            this.xrTabIT.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow25,
            this.xrTableRow26,
            this.xrTableRow27});
            this.xrTabIT.SizeF = new System.Drawing.SizeF(647.2585F, 137.5F);
            this.xrTabIT.StylePriority.UseBorders = false;
            // 
            // xrTableRow25
            // 
            this.xrTableRow25.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell60,
            this.xrTableCell61});
            this.xrTableRow25.Name = "xrTableRow25";
            this.xrTableRow25.Weight = 1.8409091085638862D;
            // 
            // xrTableCell60
            // 
            this.xrTableCell60.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell60.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.picBoxPurchaseReq3,
            this.picBoxPurchaseReq4});
            this.xrTableCell60.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell60.Name = "xrTableCell60";
            this.xrTableCell60.StylePriority.UseBorders = false;
            this.xrTableCell60.StylePriority.UseFont = false;
            this.xrTableCell60.Weight = 1.54517110506745D;
            // 
            // picBoxPurchaseReq3
            // 
            this.picBoxPurchaseReq3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPurchaseReq3.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPurchaseReq3.Image")));
            this.picBoxPurchaseReq3.LocationFloat = new DevExpress.Utils.PointFloat(63.43614F, 9.99999F);
            this.picBoxPurchaseReq3.Name = "picBoxPurchaseReq3";
            this.picBoxPurchaseReq3.SizeF = new System.Drawing.SizeF(69.89584F, 64.37498F);
            this.picBoxPurchaseReq3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPurchaseReq3.StylePriority.UseBorders = false;
            this.picBoxPurchaseReq3.Visible = false;
            // 
            // picBoxPurchaseReq4
            // 
            this.picBoxPurchaseReq4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPurchaseReq4.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPurchaseReq4.Image")));
            this.picBoxPurchaseReq4.LocationFloat = new DevExpress.Utils.PointFloat(63.43489F, 9.99999F);
            this.picBoxPurchaseReq4.Name = "picBoxPurchaseReq4";
            this.picBoxPurchaseReq4.SizeF = new System.Drawing.SizeF(69.89584F, 64.37495F);
            this.picBoxPurchaseReq4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPurchaseReq4.StylePriority.UseBorders = false;
            this.picBoxPurchaseReq4.Visible = false;
            // 
            // xrTableCell61
            // 
            this.xrTableCell61.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell61.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblPurchaseReq3,
            this.lblPurchaseReq4});
            this.xrTableCell61.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell61.Name = "xrTableCell61";
            this.xrTableCell61.StylePriority.UseBorders = false;
            this.xrTableCell61.StylePriority.UseFont = false;
            this.xrTableCell61.Text = "Review :";
            this.xrTableCell61.Weight = 1.45482889493255D;
            // 
            // lblPurchaseReq3
            // 
            this.lblPurchaseReq3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPurchaseReq3.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPurchaseReq3.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPurchaseReq3.LocationFloat = new DevExpress.Utils.PointFloat(35.14627F, 27.66647F);
            this.lblPurchaseReq3.Name = "lblPurchaseReq3";
            this.lblPurchaseReq3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPurchaseReq3.SizeF = new System.Drawing.SizeF(255.5327F, 13.62503F);
            this.lblPurchaseReq3.StylePriority.UseBorders = false;
            this.lblPurchaseReq3.StylePriority.UseFont = false;
            this.lblPurchaseReq3.StylePriority.UseForeColor = false;
            this.lblPurchaseReq3.Text = "Approve datetime";
            this.lblPurchaseReq3.Visible = false;
            // 
            // lblPurchaseReq4
            // 
            this.lblPurchaseReq4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPurchaseReq4.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPurchaseReq4.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPurchaseReq4.LocationFloat = new DevExpress.Utils.PointFloat(35.14627F, 41.29162F);
            this.lblPurchaseReq4.Name = "lblPurchaseReq4";
            this.lblPurchaseReq4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPurchaseReq4.SizeF = new System.Drawing.SizeF(255.5327F, 13.62503F);
            this.lblPurchaseReq4.StylePriority.UseBorders = false;
            this.lblPurchaseReq4.StylePriority.UseFont = false;
            this.lblPurchaseReq4.StylePriority.UseForeColor = false;
            this.lblPurchaseReq4.Text = "Note";
            this.lblPurchaseReq4.Visible = false;
            // 
            // xrTableRow26
            // 
            this.xrTableRow26.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.lblReviewITName,
            this.xrTableCell63});
            this.xrTableRow26.Name = "xrTableRow26";
            this.xrTableRow26.Weight = 0.56818175512897784D;
            // 
            // lblReviewITName
            // 
            this.lblReviewITName.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.lblReviewITName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewITName.Name = "lblReviewITName";
            this.lblReviewITName.StylePriority.UseBorders = false;
            this.lblReviewITName.StylePriority.UseFont = false;
            this.lblReviewITName.StylePriority.UseTextAlignment = false;
            this.lblReviewITName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.lblReviewITName.Weight = 1.54517110506745D;
            // 
            // xrTableCell63
            // 
            this.xrTableCell63.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell63.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell63.Name = "xrTableCell63";
            this.xrTableCell63.StylePriority.UseBorders = false;
            this.xrTableCell63.StylePriority.UseFont = false;
            this.xrTableCell63.StylePriority.UseTextAlignment = false;
            this.xrTableCell63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableCell63.Weight = 1.45482889493255D;
            // 
            // xrTableRow27
            // 
            this.xrTableRow27.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.lblReviewITJabatan,
            this.xrTableCell65});
            this.xrTableRow27.Name = "xrTableRow27";
            this.xrTableRow27.Weight = 0.59090913630713593D;
            // 
            // lblReviewITJabatan
            // 
            this.lblReviewITJabatan.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.lblReviewITJabatan.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewITJabatan.Name = "lblReviewITJabatan";
            this.lblReviewITJabatan.StylePriority.UseBorders = false;
            this.lblReviewITJabatan.StylePriority.UseFont = false;
            this.lblReviewITJabatan.StylePriority.UseTextAlignment = false;
            this.lblReviewITJabatan.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.lblReviewITJabatan.Weight = 1.54517110506745D;
            // 
            // xrTableCell65
            // 
            this.xrTableCell65.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell65.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell65.Name = "xrTableCell65";
            this.xrTableCell65.StylePriority.UseBorders = false;
            this.xrTableCell65.StylePriority.UseFont = false;
            this.xrTableCell65.StylePriority.UseTextAlignment = false;
            this.xrTableCell65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell65.Weight = 1.45482889493255D;
            // 
            // xrTabBudget
            // 
            this.xrTabBudget.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTabBudget.LocationFloat = new DevExpress.Utils.PointFloat(40.37334F, 352.0833F);
            this.xrTabBudget.Name = "xrTabBudget";
            this.xrTabBudget.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow28,
            this.xrTableRow29,
            this.xrTableRow30});
            this.xrTabBudget.SizeF = new System.Drawing.SizeF(647.2585F, 137.5F);
            this.xrTabBudget.StylePriority.UseBorders = false;
            // 
            // xrTableRow28
            // 
            this.xrTableRow28.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell66,
            this.xrTableCell67});
            this.xrTableRow28.Name = "xrTableRow28";
            this.xrTableRow28.Weight = 1.8409091085638862D;
            // 
            // xrTableCell66
            // 
            this.xrTableCell66.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell66.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.picBoxPurchaseReq5,
            this.picBoxPurchaseReq6});
            this.xrTableCell66.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell66.Name = "xrTableCell66";
            this.xrTableCell66.StylePriority.UseBorders = false;
            this.xrTableCell66.StylePriority.UseFont = false;
            this.xrTableCell66.Weight = 1.54517110506745D;
            // 
            // picBoxPurchaseReq5
            // 
            this.picBoxPurchaseReq5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPurchaseReq5.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPurchaseReq5.Image")));
            this.picBoxPurchaseReq5.LocationFloat = new DevExpress.Utils.PointFloat(63.43619F, 8.041541F);
            this.picBoxPurchaseReq5.Name = "picBoxPurchaseReq5";
            this.picBoxPurchaseReq5.SizeF = new System.Drawing.SizeF(69.89583F, 66.33342F);
            this.picBoxPurchaseReq5.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPurchaseReq5.StylePriority.UseBorders = false;
            this.picBoxPurchaseReq5.Visible = false;
            // 
            // picBoxPurchaseReq6
            // 
            this.picBoxPurchaseReq6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPurchaseReq6.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPurchaseReq6.Image")));
            this.picBoxPurchaseReq6.LocationFloat = new DevExpress.Utils.PointFloat(63.43489F, 8.041573F);
            this.picBoxPurchaseReq6.Name = "picBoxPurchaseReq6";
            this.picBoxPurchaseReq6.SizeF = new System.Drawing.SizeF(69.8958F, 66.33342F);
            this.picBoxPurchaseReq6.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPurchaseReq6.StylePriority.UseBorders = false;
            this.picBoxPurchaseReq6.Visible = false;
            // 
            // xrTableCell67
            // 
            this.xrTableCell67.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell67.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblPurchaseReq5,
            this.lblPurchaseReq6});
            this.xrTableCell67.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell67.Name = "xrTableCell67";
            this.xrTableCell67.StylePriority.UseBorders = false;
            this.xrTableCell67.StylePriority.UseFont = false;
            this.xrTableCell67.Text = "Review :";
            this.xrTableCell67.Weight = 1.45482889493255D;
            // 
            // lblPurchaseReq5
            // 
            this.lblPurchaseReq5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPurchaseReq5.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPurchaseReq5.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPurchaseReq5.LocationFloat = new DevExpress.Utils.PointFloat(35.14627F, 39.08323F);
            this.lblPurchaseReq5.Name = "lblPurchaseReq5";
            this.lblPurchaseReq5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPurchaseReq5.SizeF = new System.Drawing.SizeF(255.5327F, 13.62505F);
            this.lblPurchaseReq5.StylePriority.UseBorders = false;
            this.lblPurchaseReq5.StylePriority.UseFont = false;
            this.lblPurchaseReq5.StylePriority.UseForeColor = false;
            this.lblPurchaseReq5.Text = "Approve datetime";
            this.lblPurchaseReq5.Visible = false;
            // 
            // lblPurchaseReq6
            // 
            this.lblPurchaseReq6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPurchaseReq6.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPurchaseReq6.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPurchaseReq6.LocationFloat = new DevExpress.Utils.PointFloat(35.14627F, 52.70837F);
            this.lblPurchaseReq6.Name = "lblPurchaseReq6";
            this.lblPurchaseReq6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPurchaseReq6.SizeF = new System.Drawing.SizeF(255.5327F, 13.62505F);
            this.lblPurchaseReq6.StylePriority.UseBorders = false;
            this.lblPurchaseReq6.StylePriority.UseFont = false;
            this.lblPurchaseReq6.StylePriority.UseForeColor = false;
            this.lblPurchaseReq6.Text = "Note";
            this.lblPurchaseReq6.Visible = false;
            // 
            // xrTableRow29
            // 
            this.xrTableRow29.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.lblReviewBudgetName,
            this.xrTableCell69});
            this.xrTableRow29.Name = "xrTableRow29";
            this.xrTableRow29.Weight = 0.56818175512897784D;
            // 
            // lblReviewBudgetName
            // 
            this.lblReviewBudgetName.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.lblReviewBudgetName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewBudgetName.Name = "lblReviewBudgetName";
            this.lblReviewBudgetName.StylePriority.UseBorders = false;
            this.lblReviewBudgetName.StylePriority.UseFont = false;
            this.lblReviewBudgetName.StylePriority.UseTextAlignment = false;
            this.lblReviewBudgetName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.lblReviewBudgetName.Weight = 1.54517110506745D;
            // 
            // xrTableCell69
            // 
            this.xrTableCell69.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell69.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell69.Name = "xrTableCell69";
            this.xrTableCell69.StylePriority.UseBorders = false;
            this.xrTableCell69.StylePriority.UseFont = false;
            this.xrTableCell69.StylePriority.UseTextAlignment = false;
            this.xrTableCell69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableCell69.Weight = 1.45482889493255D;
            // 
            // xrTableRow30
            // 
            this.xrTableRow30.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.lblReviewBudgetJabatan,
            this.xrTableCell71});
            this.xrTableRow30.Name = "xrTableRow30";
            this.xrTableRow30.Weight = 0.59090913630713593D;
            // 
            // lblReviewBudgetJabatan
            // 
            this.lblReviewBudgetJabatan.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.lblReviewBudgetJabatan.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewBudgetJabatan.Name = "lblReviewBudgetJabatan";
            this.lblReviewBudgetJabatan.StylePriority.UseBorders = false;
            this.lblReviewBudgetJabatan.StylePriority.UseFont = false;
            this.lblReviewBudgetJabatan.StylePriority.UseTextAlignment = false;
            this.lblReviewBudgetJabatan.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.lblReviewBudgetJabatan.Weight = 1.54517110506745D;
            // 
            // xrTableCell71
            // 
            this.xrTableCell71.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell71.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell71.Name = "xrTableCell71";
            this.xrTableCell71.StylePriority.UseBorders = false;
            this.xrTableCell71.StylePriority.UseFont = false;
            this.xrTableCell71.StylePriority.UseTextAlignment = false;
            this.xrTableCell71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell71.Weight = 1.45482889493255D;
            // 
            // xrTabCFO
            // 
            this.xrTabCFO.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTabCFO.LocationFloat = new DevExpress.Utils.PointFloat(40.37334F, 489.5833F);
            this.xrTabCFO.Name = "xrTabCFO";
            this.xrTabCFO.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow31,
            this.xrTableRow32,
            this.xrTableRow33});
            this.xrTabCFO.SizeF = new System.Drawing.SizeF(647.2585F, 137.5F);
            this.xrTabCFO.StylePriority.UseBorders = false;
            // 
            // xrTableRow31
            // 
            this.xrTableRow31.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell72,
            this.xrTableCell73});
            this.xrTableRow31.Name = "xrTableRow31";
            this.xrTableRow31.Weight = 1.8409091085638862D;
            // 
            // xrTableCell72
            // 
            this.xrTableCell72.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell72.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.picBoxPurchaseReq7,
            this.picBoxPurchaseReq8});
            this.xrTableCell72.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell72.Name = "xrTableCell72";
            this.xrTableCell72.StylePriority.UseBorders = false;
            this.xrTableCell72.StylePriority.UseFont = false;
            this.xrTableCell72.Weight = 1.54517110506745D;
            // 
            // picBoxPurchaseReq7
            // 
            this.picBoxPurchaseReq7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPurchaseReq7.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPurchaseReq7.Image")));
            this.picBoxPurchaseReq7.LocationFloat = new DevExpress.Utils.PointFloat(63.43489F, 9.99999F);
            this.picBoxPurchaseReq7.Name = "picBoxPurchaseReq7";
            this.picBoxPurchaseReq7.SizeF = new System.Drawing.SizeF(69.89581F, 64.375F);
            this.picBoxPurchaseReq7.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPurchaseReq7.StylePriority.UseBorders = false;
            this.picBoxPurchaseReq7.Visible = false;
            // 
            // picBoxPurchaseReq8
            // 
            this.picBoxPurchaseReq8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPurchaseReq8.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPurchaseReq8.Image")));
            this.picBoxPurchaseReq8.LocationFloat = new DevExpress.Utils.PointFloat(63.43619F, 9.99999F);
            this.picBoxPurchaseReq8.Name = "picBoxPurchaseReq8";
            this.picBoxPurchaseReq8.SizeF = new System.Drawing.SizeF(69.89449F, 64.375F);
            this.picBoxPurchaseReq8.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPurchaseReq8.StylePriority.UseBorders = false;
            this.picBoxPurchaseReq8.Visible = false;
            // 
            // xrTableCell73
            // 
            this.xrTableCell73.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell73.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblPurchaseReq7,
            this.lblPurchaseReq8});
            this.xrTableCell73.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell73.Name = "xrTableCell73";
            this.xrTableCell73.StylePriority.UseBorders = false;
            this.xrTableCell73.StylePriority.UseFont = false;
            this.xrTableCell73.Text = "Keputusan :";
            this.xrTableCell73.Weight = 1.45482889493255D;
            // 
            // lblPurchaseReq7
            // 
            this.lblPurchaseReq7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPurchaseReq7.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPurchaseReq7.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPurchaseReq7.LocationFloat = new DevExpress.Utils.PointFloat(35.14627F, 27.66635F);
            this.lblPurchaseReq7.Name = "lblPurchaseReq7";
            this.lblPurchaseReq7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPurchaseReq7.SizeF = new System.Drawing.SizeF(255.5327F, 13.62505F);
            this.lblPurchaseReq7.StylePriority.UseBorders = false;
            this.lblPurchaseReq7.StylePriority.UseFont = false;
            this.lblPurchaseReq7.StylePriority.UseForeColor = false;
            this.lblPurchaseReq7.Text = "Approve datetime";
            this.lblPurchaseReq7.Visible = false;
            // 
            // lblPurchaseReq8
            // 
            this.lblPurchaseReq8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPurchaseReq8.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPurchaseReq8.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPurchaseReq8.LocationFloat = new DevExpress.Utils.PointFloat(35.14627F, 41.29155F);
            this.lblPurchaseReq8.Name = "lblPurchaseReq8";
            this.lblPurchaseReq8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPurchaseReq8.SizeF = new System.Drawing.SizeF(255.5327F, 13.62508F);
            this.lblPurchaseReq8.StylePriority.UseBorders = false;
            this.lblPurchaseReq8.StylePriority.UseFont = false;
            this.lblPurchaseReq8.StylePriority.UseForeColor = false;
            this.lblPurchaseReq8.Text = "Note";
            this.lblPurchaseReq8.Visible = false;
            // 
            // xrTableRow32
            // 
            this.xrTableRow32.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.lblKeputusanCFOName,
            this.xrTableCell75});
            this.xrTableRow32.Name = "xrTableRow32";
            this.xrTableRow32.Weight = 0.56818175512897784D;
            // 
            // lblKeputusanCFOName
            // 
            this.lblKeputusanCFOName.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.lblKeputusanCFOName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeputusanCFOName.Name = "lblKeputusanCFOName";
            this.lblKeputusanCFOName.StylePriority.UseBorders = false;
            this.lblKeputusanCFOName.StylePriority.UseFont = false;
            this.lblKeputusanCFOName.StylePriority.UseTextAlignment = false;
            this.lblKeputusanCFOName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.lblKeputusanCFOName.Weight = 1.54517110506745D;
            // 
            // xrTableCell75
            // 
            this.xrTableCell75.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell75.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell75.Name = "xrTableCell75";
            this.xrTableCell75.StylePriority.UseBorders = false;
            this.xrTableCell75.StylePriority.UseFont = false;
            this.xrTableCell75.StylePriority.UseTextAlignment = false;
            this.xrTableCell75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableCell75.Weight = 1.45482889493255D;
            // 
            // xrTableRow33
            // 
            this.xrTableRow33.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.lblKeputusanCFOJabatan,
            this.xrTableCell77});
            this.xrTableRow33.Name = "xrTableRow33";
            this.xrTableRow33.Weight = 0.59090913630713593D;
            // 
            // lblKeputusanCFOJabatan
            // 
            this.lblKeputusanCFOJabatan.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeputusanCFOJabatan.Name = "lblKeputusanCFOJabatan";
            this.lblKeputusanCFOJabatan.StylePriority.UseFont = false;
            this.lblKeputusanCFOJabatan.StylePriority.UseTextAlignment = false;
            this.lblKeputusanCFOJabatan.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.lblKeputusanCFOJabatan.Weight = 1.54517110506745D;
            // 
            // xrTableCell77
            // 
            this.xrTableCell77.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell77.Name = "xrTableCell77";
            this.xrTableCell77.StylePriority.UseFont = false;
            this.xrTableCell77.StylePriority.UseTextAlignment = false;
            this.xrTableCell77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell77.Weight = 1.45482889493255D;
            // 
            // docInternalMemoPermohonanBarangJasa
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader1,
            this.DetailReport,
            this.GroupFooter2,
            this.ReportFooter1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "InternalMemo";
            this.DataSource = this.sqlDataSource1;
            this.Margins = new System.Drawing.Printing.Margins(48, 51, 46, 72);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.DocKey,
            this.DocNo});
            this.Version = "17.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTabIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTabBudget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTabCFO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
