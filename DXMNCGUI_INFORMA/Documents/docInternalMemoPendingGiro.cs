using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for docInternalMemoPendingGiro
/// </summary>
public class docInternalMemoPendingGiro : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
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
    private XRLabel xrLabel5;
    private XRLabel xrLabel4;
    private XRLabel xrLabel3;
    private XRTable xrTable4;
    private XRTableRow xrTableRow16;
    private XRTableCell xrTableCell45;
    private XRTableCell xrTableCell46;
    private XRTableCell xrTableCell47;
    private XRTableCell xrTableCell48;
    private XRTableCell xrTableCell19;
    private XRTableCell xrTableCell20;
    private XRTableCell xrTableCell21;
    private XRTableCell xrTableCell22;
    private XRTableCell xrTableCell23;
    private DetailReportBand DetailReport;
    private DetailBand Detail1;
    private XRTable xrTable2;
    private XRTableRow xrTableRow7;
    private XRTableCell xrTableCell24;
    private XRTableCell xrTableCell25;
    private XRTableCell xrTableCell26;
    private XRTableCell xrTableCell27;
    private XRTableCell xrTableCell28;
    private XRTableCell xrTableCell29;
    private XRTableCell xrTableCell30;
    private XRTableCell xrTableCell31;
    private XRTableCell xrTableCell32;
    private GroupFooterBand GroupFooter1;
    private XRLabel xrLabel6;
    private XRLabel xrLabel12;
    private XRLabel xrLabel11;
    private XRLabel xrLabel10;
    private XRLabel xrLabel9;
    private XRLabel xrLabel8;
    private XRLabel xrLabel7;
    private ReportFooterBand ReportFooter;
    private XRTable xrTable3;
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell33;
    private XRTableCell xrTableCell18;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell34;
    private XRTableCell xrTableCell35;
    private XRTableCell xrTableCell36;
    private XRTableCell xrTableCell37;
    private XRTableRow xrTableRow9;
    private XRTableCell lblGiroPemohonName;
    private XRTableCell lblGiroReviewName1;
    private XRTableCell lblGiroReviewName2;
    private XRTableCell lblGiroMenyetujuiName;
    private XRTableRow xrTableRow10;
    private XRTableCell lblGiroPemohonJabatan;
    private XRTableCell lblGiroReviewJabatan1;
    private XRTableCell lblGiroReviewJabatan2;
    private XRTableCell lblGiroMenyetujuiJabatan;
    private XRLabel xrLabel13;
    private XRLabel xrLabel15;
    private XRPageInfo xrPageInfo1;
    private XRLabel xrLabel14;
    private XRLabel xrLabel16;
    private DevExpress.XtraReports.Parameters.Parameter DocKey;
    private DevExpress.XtraReports.Parameters.Parameter DocNo;
    private XRLabel lblPendingGiro1;
    private XRLabel lblPendingGiro2;
    private XRPictureBox picBoxPendingGiro2;
    private XRPictureBox picBoxPendingGiro1;
    private XRPictureBox picBoxPendingGiro3;
    private XRPictureBox picBoxPendingGiro4;
    private XRLabel lblPendingGiro3;
    private XRLabel lblPendingGiro4;
    private XRPictureBox picBoxPendingGiro5;
    private XRPictureBox picBoxPendingGiro6;
    private XRLabel lblPendingGiro5;
    private XRLabel lblPendingGiro6;
    private XRPictureBox picBoxMySign1;
    private XRTable xrtblPendingGiroFinalApp;
    private XRTableRow xrTableRow11;
    private XRTableCell xrTableCell17;
    private XRTableRow xrTableRow12;
    private XRTableCell xrTableCell38;
    private XRPictureBox picBoxPendingGiro8;
    private XRPictureBox picBoxPendingGiro7;
    private XRLabel lblPendingGiro7;
    private XRLabel lblPendingGiro8;
    private XRTableRow xrTableRow13;
    private XRTableCell lblGiroMenyetujuiName2;
    private XRTableRow xrTableRow14;
    private XRTableCell lblGiroMenyetujuiJabatan2;
    private XRPictureBox xrPictureBox1;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public docInternalMemoPendingGiro()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(docInternalMemoPendingGiro));
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
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
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
            this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow16 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell45 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell46 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell47 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell48 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
            this.picBoxMySign1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblPendingGiro1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblPendingGiro2 = new DevExpress.XtraReports.UI.XRLabel();
            this.picBoxPendingGiro2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.picBoxPendingGiro1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
            this.picBoxPendingGiro3 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.picBoxPendingGiro4 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.lblPendingGiro3 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblPendingGiro4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
            this.picBoxPendingGiro5 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.picBoxPendingGiro6 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.lblPendingGiro5 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblPendingGiro6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.lblGiroPemohonName = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblGiroReviewName1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblGiroReviewName2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblGiroMenyetujuiName = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.lblGiroPemohonJabatan = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblGiroReviewJabatan1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblGiroReviewJabatan2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblGiroMenyetujuiJabatan = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtblPendingGiroFinalApp = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
            this.picBoxPendingGiro8 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.picBoxPendingGiro7 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.lblPendingGiro7 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblPendingGiro8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
            this.lblGiroMenyetujuiName2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow14 = new DevExpress.XtraReports.UI.XRTableRow();
            this.lblGiroMenyetujuiJabatan2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.DocKey = new DevExpress.XtraReports.Parameters.Parameter();
            this.DocNo = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrtblPendingGiroFinalApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Expanded = false;
            this.Detail.HeightF = 100F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel13,
            this.xrLabel15});
            this.TopMargin.HeightF = 54F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel13
            // 
            this.xrLabel13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DocNo]")});
            this.xrLabel13.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.xrLabel13.ForeColor = System.Drawing.Color.DarkGray;
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(36.74574F, 9.99999F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(265.6263F, 15.70835F);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseForeColor = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "xrLabel8";
            // 
            // xrLabel15
            // 
            this.xrLabel15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DocType]")});
            this.xrLabel15.Font = new System.Drawing.Font("Tahoma", 5.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel15.ForeColor = System.Drawing.Color.DarkGray;
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(36.74706F, 25.70836F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(265.625F, 15.70835F);
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseForeColor = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "xrLabel8";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1,
            this.xrLabel14,
            this.xrLabel16});
            this.BottomMargin.HeightF = 52F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(357.3273F, 9.999997F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(26.04166F, 16.75002F);
            this.xrPageInfo1.StylePriority.UseFont = false;
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel14
            // 
            this.xrLabel14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DocNo]")});
            this.xrLabel14.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.xrLabel14.ForeColor = System.Drawing.Color.DarkGray;
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(36.74574F, 9.999974F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(284.8941F, 15.70835F);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseForeColor = false;
            this.xrLabel14.Text = "xrLabel8";
            // 
            // xrLabel16
            // 
            this.xrLabel16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MemoPerihal]")});
            this.xrLabel16.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.xrLabel16.ForeColor = System.Drawing.Color.DarkGray;
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(36.74704F, 25.70839F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(284.8929F, 13.62502F);
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseForeColor = false;
            this.xrLabel16.Text = "xrLabel14";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "SqlLocalConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "InternalMemo";
            queryParameter1.Name = "DocKey";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.DocKey]", typeof(int));
            customSqlQuery1.Parameters.Add(queryParameter1);
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            customSqlQuery2.Name = "InternalMemoApprovalList";
            queryParameter2.Name = "DocKey";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.DocKey]", typeof(int));
            customSqlQuery2.Parameters.Add(queryParameter2);
            customSqlQuery2.Sql = resources.GetString("customSqlQuery2.Sql");
            customSqlQuery3.Name = "InternalMemoDetailPendingGiro";
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
            masterDetailInfo2.DetailQueryName = "InternalMemoDetailPendingGiro";
            relationColumnInfo2.NestedKeyColumn = "DocKey";
            relationColumnInfo2.ParentKeyColumn = "DocKey";
            masterDetailInfo2.KeyColumns.Add(relationColumnInfo2);
            masterDetailInfo2.MasterQueryName = "InternalMemo";
            this.sqlDataSource1.Relations.AddRange(new DevExpress.DataAccess.Sql.MasterDetailInfo[] {
            masterDetailInfo1,
            masterDetailInfo2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.xrTable1,
            this.xrLabel1,
            this.xrLabel2,
            this.xrPictureBox1});
            this.ReportHeader.HeightF = 216.7313F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrLine1
            // 
            this.xrLine1.LineWidth = 2;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(32.57913F, 209.5887F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(650.3834F, 7.142548F);
            // 
            // xrTable1
            // 
            this.xrTable1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(32.57913F, 108.7374F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1,
            this.xrTableRow3,
            this.xrTableRow4,
            this.xrTableRow2,
            this.xrTableRow5});
            this.xrTable1.SizeF = new System.Drawing.SizeF(650.3834F, 88.06821F);
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
            this.xrTableCell1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.Text = "Kepada";
            this.xrTableCell1.Weight = 1.1096236359843479D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.Text = ":";
            this.xrTableCell2.Weight = 0.15524725618000446D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MemoTo]")});
            this.xrTableCell3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.xrTableCell7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseFont = false;
            this.xrTableCell7.Text = "CC";
            this.xrTableCell7.Weight = 1.1096236359843479D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.StylePriority.UseFont = false;
            this.xrTableCell8.Text = ":";
            this.xrTableCell8.Weight = 0.15524725618000446D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MemoCC]")});
            this.xrTableCell9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.xrTableCell10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.StylePriority.UseFont = false;
            this.xrTableCell10.Text = "Dari";
            this.xrTableCell10.Weight = 1.1096236359843479D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.StylePriority.UseFont = false;
            this.xrTableCell11.Text = ":";
            this.xrTableCell11.Weight = 0.15524725618000446D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MemoFrom]")});
            this.xrTableCell12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.xrTableCell4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.Text = "Tanggal";
            this.xrTableCell4.Weight = 1.1096236359843479D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.Text = ":";
            this.xrTableCell5.Weight = 0.15524725618000446D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DocDate]")});
            this.xrTableCell6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.xrTableCell13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.StylePriority.UseFont = false;
            this.xrTableCell13.Text = "Perihal";
            this.xrTableCell13.Weight = 1.1096236359843479D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.StylePriority.UseFont = false;
            this.xrTableCell14.Text = ":";
            this.xrTableCell14.Weight = 0.15524725618000446D;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MemoPerihal]")});
            this.xrTableCell15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.StylePriority.UseFont = false;
            this.xrTableCell15.Text = "xrTableCell15";
            this.xrTableCell15.Weight = 6.2551291078356472D;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(341.4972F, 9.999997F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(341.4654F, 26.12499F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "INTERNAL MEMORANDUM";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrLabel2
            // 
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DocNo]")});
            this.xrLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(341.4973F, 36.12501F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(341.464F, 20.91666F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "INTERNAL MEMORANDUM";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable4,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3});
            this.GroupHeader1.HeightF = 107.1875F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrTable4
            // 
            this.xrTable4.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(32.57913F, 64.99999F);
            this.xrTable4.Name = "xrTable4";
            this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow16});
            this.xrTable4.SizeF = new System.Drawing.SizeF(651.4264F, 42.1875F);
            this.xrTable4.StylePriority.UseFont = false;
            // 
            // xrTableRow16
            // 
            this.xrTableRow16.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell45,
            this.xrTableCell46,
            this.xrTableCell47,
            this.xrTableCell48,
            this.xrTableCell19,
            this.xrTableCell20,
            this.xrTableCell21,
            this.xrTableCell22,
            this.xrTableCell23});
            this.xrTableRow16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableRow16.Name = "xrTableRow16";
            this.xrTableRow16.StylePriority.UseFont = false;
            this.xrTableRow16.StylePriority.UseTextAlignment = false;
            this.xrTableRow16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableRow16.Weight = 1D;
            // 
            // xrTableCell45
            // 
            this.xrTableCell45.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell45.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell45.Multiline = true;
            this.xrTableCell45.Name = "xrTableCell45";
            this.xrTableCell45.StylePriority.UseBorders = false;
            this.xrTableCell45.StylePriority.UseFont = false;
            this.xrTableCell45.Text = "Nama Debitur";
            this.xrTableCell45.Weight = 0.99434753087628769D;
            // 
            // xrTableCell46
            // 
            this.xrTableCell46.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell46.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell46.Name = "xrTableCell46";
            this.xrTableCell46.StylePriority.UseBorders = false;
            this.xrTableCell46.StylePriority.UseFont = false;
            this.xrTableCell46.Text = "No. Kontrak";
            this.xrTableCell46.Weight = 0.93165487859084917D;
            // 
            // xrTableCell47
            // 
            this.xrTableCell47.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell47.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell47.Name = "xrTableCell47";
            this.xrTableCell47.StylePriority.UseBorders = false;
            this.xrTableCell47.StylePriority.UseFont = false;
            this.xrTableCell47.Text = "Nama Bank";
            this.xrTableCell47.Weight = 0.97566926632051465D;
            // 
            // xrTableCell48
            // 
            this.xrTableCell48.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell48.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell48.Name = "xrTableCell48";
            this.xrTableCell48.StylePriority.UseBorders = false;
            this.xrTableCell48.StylePriority.UseFont = false;
            this.xrTableCell48.Text = "No. Giro";
            this.xrTableCell48.Weight = 0.89452845683434412D;
            // 
            // xrTableCell19
            // 
            this.xrTableCell19.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell19.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell19.Name = "xrTableCell19";
            this.xrTableCell19.StylePriority.UseBorders = false;
            this.xrTableCell19.StylePriority.UseFont = false;
            this.xrTableCell19.Text = "Nominal";
            this.xrTableCell19.Weight = 0.85114742843938118D;
            // 
            // xrTableCell20
            // 
            this.xrTableCell20.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell20.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell20.Name = "xrTableCell20";
            this.xrTableCell20.StylePriority.UseBorders = false;
            this.xrTableCell20.StylePriority.UseFont = false;
            this.xrTableCell20.Text = "Angsuran dari/ke";
            this.xrTableCell20.Weight = 0.66678330023873023D;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell21.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.StylePriority.UseBorders = false;
            this.xrTableCell21.StylePriority.UseFont = false;
            this.xrTableCell21.Text = "Tgl Jatuh Tempo";
            this.xrTableCell21.Weight = 0.66678330023873023D;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell22.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.StylePriority.UseBorders = false;
            this.xrTableCell22.StylePriority.UseFont = false;
            this.xrTableCell22.Text = "Lama Penundaan";
            this.xrTableCell22.Weight = 0.66678330023873023D;
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell23.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.StylePriority.UseBorders = false;
            this.xrTableCell23.StylePriority.UseFont = false;
            this.xrTableCell23.Text = "Tgl dijalankan Kembali";
            this.xrTableCell23.Weight = 0.66678330023873023D;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(32.57914F, 26.12499F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(651.4251F, 26.12498F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Bersama ini kami mohon persetujuan komite kredit untuk penundaan pencairan angsur" +
    "an atas giro :";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MemoRefNo]")});
            this.xrLabel4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(387.1293F, 0F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(170.8333F, 26.125F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(32.57913F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(343.7499F, 26.12498F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Sesuai surat permintaan dari Debitur denagn no. surat :";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1});
            this.DetailReport.DataMember = "InternalMemoDetailPendingGiro";
            this.DetailReport.DataSource = this.sqlDataSource1;
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.Detail1.HeightF = 17.88194F;
            this.Detail1.Name = "Detail1";
            // 
            // xrTable2
            // 
            this.xrTable2.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(32.57913F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow7});
            this.xrTable2.SizeF = new System.Drawing.SizeF(651.4252F, 17.88194F);
            this.xrTable2.StylePriority.UseFont = false;
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell24,
            this.xrTableCell25,
            this.xrTableCell26,
            this.xrTableCell27,
            this.xrTableCell28,
            this.xrTableCell29,
            this.xrTableCell30,
            this.xrTableCell31,
            this.xrTableCell32});
            this.xrTableRow7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.StylePriority.UseFont = false;
            this.xrTableRow7.StylePriority.UseTextAlignment = false;
            this.xrTableRow7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableRow7.Weight = 0.42386827256944448D;
            // 
            // xrTableCell24
            // 
            this.xrTableCell24.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell24.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NamaDebitur]")});
            this.xrTableCell24.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell24.Multiline = true;
            this.xrTableCell24.Name = "xrTableCell24";
            this.xrTableCell24.StylePriority.UseBorders = false;
            this.xrTableCell24.StylePriority.UseFont = false;
            this.xrTableCell24.Text = "Nama Debitur";
            this.xrTableCell24.Weight = 0.99434753087628769D;
            // 
            // xrTableCell25
            // 
            this.xrTableCell25.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell25.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AgreementNo]")});
            this.xrTableCell25.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell25.Name = "xrTableCell25";
            this.xrTableCell25.StylePriority.UseBorders = false;
            this.xrTableCell25.StylePriority.UseFont = false;
            this.xrTableCell25.Text = "No. Kontrak";
            this.xrTableCell25.Weight = 0.93165487859084917D;
            // 
            // xrTableCell26
            // 
            this.xrTableCell26.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell26.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NamaBank]")});
            this.xrTableCell26.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell26.Name = "xrTableCell26";
            this.xrTableCell26.StylePriority.UseBorders = false;
            this.xrTableCell26.StylePriority.UseFont = false;
            this.xrTableCell26.Text = "Nama Bank";
            this.xrTableCell26.Weight = 0.97566926632051465D;
            // 
            // xrTableCell27
            // 
            this.xrTableCell27.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell27.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NoGiro]")});
            this.xrTableCell27.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell27.Name = "xrTableCell27";
            this.xrTableCell27.StylePriority.UseBorders = false;
            this.xrTableCell27.StylePriority.UseFont = false;
            this.xrTableCell27.Text = "No. Giro";
            this.xrTableCell27.Weight = 0.89452845683434412D;
            // 
            // xrTableCell28
            // 
            this.xrTableCell28.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell28.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NominalGiro]")});
            this.xrTableCell28.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell28.Name = "xrTableCell28";
            this.xrTableCell28.StylePriority.UseBorders = false;
            this.xrTableCell28.StylePriority.UseFont = false;
            this.xrTableCell28.Text = "Nominal";
            this.xrTableCell28.TextFormatString = "{0:Rp #,##.00}";
            this.xrTableCell28.Weight = 0.85114742843938118D;
            // 
            // xrTableCell29
            // 
            this.xrTableCell29.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell29.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AngsuranDariKe]")});
            this.xrTableCell29.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell29.Name = "xrTableCell29";
            this.xrTableCell29.StylePriority.UseBorders = false;
            this.xrTableCell29.StylePriority.UseFont = false;
            this.xrTableCell29.Text = "Angsuran dari/ke";
            this.xrTableCell29.Weight = 0.66678330023873023D;
            // 
            // xrTableCell30
            // 
            this.xrTableCell30.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell30.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TglJatuhTempo]")});
            this.xrTableCell30.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell30.Name = "xrTableCell30";
            this.xrTableCell30.StylePriority.UseBorders = false;
            this.xrTableCell30.StylePriority.UseFont = false;
            this.xrTableCell30.Text = "Tgl Jatuh Tempo";
            this.xrTableCell30.TextFormatString = "{0:dd/MM/yyyy}";
            this.xrTableCell30.Weight = 0.66678330023873023D;
            // 
            // xrTableCell31
            // 
            this.xrTableCell31.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell31.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LamaPenundaan]")});
            this.xrTableCell31.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell31.Name = "xrTableCell31";
            this.xrTableCell31.StylePriority.UseBorders = false;
            this.xrTableCell31.StylePriority.UseFont = false;
            this.xrTableCell31.Text = "Lama Penundaan";
            this.xrTableCell31.TextFormatString = "{0:#,## Hari}";
            this.xrTableCell31.Weight = 0.66678330023873023D;
            // 
            // xrTableCell32
            // 
            this.xrTableCell32.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell32.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TglDiJalankanKembali]")});
            this.xrTableCell32.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell32.Name = "xrTableCell32";
            this.xrTableCell32.StylePriority.UseBorders = false;
            this.xrTableCell32.StylePriority.UseFont = false;
            this.xrTableCell32.Text = "Tgl dijalankan Kembali";
            this.xrTableCell32.TextFormatString = "{0:dd/MM/yyyy}";
            this.xrTableCell32.Weight = 0.66678330023873023D;
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel12,
            this.xrLabel11,
            this.xrLabel10,
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel6});
            this.GroupFooter1.HeightF = 209.1667F;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // xrLabel12
            // 
            this.xrLabel12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[GiroPreviousApplyDate]")});
            this.xrLabel12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(247.6814F, 174.7084F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(215.1023F, 26.12498F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "#Tolakan ke :";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel12.TextFormatString = "{0:dd/MM/yyyy}";
            // 
            // xrLabel11
            // 
            this.xrLabel11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[GiroTolakanKe]")});
            this.xrLabel11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(247.6814F, 148.5835F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(215.1023F, 26.12498F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "#Tolakan ke :";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel10
            // 
            this.xrLabel10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(32.57914F, 174.7084F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(215.1023F, 26.12498F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "#Pengajuan sebelumnya tanggal :";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel9
            // 
            this.xrLabel9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(32.57914F, 148.5835F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(215.1023F, 26.12498F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "#Tolakan ke :";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel8
            // 
            this.xrLabel8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(32.58041F, 131.4863F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(215.1022F, 17.09721F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Catatan :";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[GiroReason]")});
            this.xrLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(32.58041F, 31.48625F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(651.4264F, 100F);
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "xrLabel5";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(32.57913F, 9.999994F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(257.418F, 10.91667F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Alasan penundaan pencairan yakni :";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3,
            this.xrtblPendingGiroFinalApp});
            this.ReportFooter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportFooter.HeightF = 373.8636F;
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.StylePriority.UseFont = false;
            // 
            // xrTable3
            // 
            this.xrTable3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(36.74581F, 0F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow6,
            this.xrTableRow8,
            this.xrTableRow9,
            this.xrTableRow10});
            this.xrTable3.SizeF = new System.Drawing.SizeF(647.2585F, 182.1969F);
            this.xrTable3.StylePriority.UseBorders = false;
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell16,
            this.xrTableCell33,
            this.xrTableCell18});
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.StylePriority.UseTextAlignment = false;
            this.xrTableRow6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableRow6.Weight = 0.44394617862015273D;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.StylePriority.UseFont = false;
            this.xrTableCell16.Text = "Pemohon,";
            this.xrTableCell16.Weight = 1D;
            // 
            // xrTableCell33
            // 
            this.xrTableCell33.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell33.Name = "xrTableCell33";
            this.xrTableCell33.StylePriority.UseFont = false;
            this.xrTableCell33.Text = "Mengetahui,";
            this.xrTableCell33.Weight = 2D;
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.StylePriority.UseFont = false;
            this.xrTableCell18.Text = "Menyetujui,";
            this.xrTableCell18.Weight = 1D;
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell34,
            this.xrTableCell35,
            this.xrTableCell36,
            this.xrTableCell37});
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.Weight = 2.0762332916673971D;
            // 
            // xrTableCell34
            // 
            this.xrTableCell34.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.picBoxMySign1});
            this.xrTableCell34.Name = "xrTableCell34";
            this.xrTableCell34.Weight = 1D;
            // 
            // picBoxMySign1
            // 
            this.picBoxMySign1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxMySign1.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMySign1.Image")));
            this.picBoxMySign1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 62.70816F);
            this.picBoxMySign1.Name = "picBoxMySign1";
            this.picBoxMySign1.SizeF = new System.Drawing.SizeF(141.8146F, 40.52057F);
            this.picBoxMySign1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxMySign1.StylePriority.UseBorders = false;
            // 
            // xrTableCell35
            // 
            this.xrTableCell35.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblPendingGiro1,
            this.lblPendingGiro2,
            this.picBoxPendingGiro2,
            this.picBoxPendingGiro1});
            this.xrTableCell35.Name = "xrTableCell35";
            this.xrTableCell35.StylePriority.UseBorders = false;
            this.xrTableCell35.Weight = 1D;
            // 
            // lblPendingGiro1
            // 
            this.lblPendingGiro1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPendingGiro1.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPendingGiro1.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPendingGiro1.LocationFloat = new DevExpress.Utils.PointFloat(34.48431F, 63.28694F);
            this.lblPendingGiro1.Name = "lblPendingGiro1";
            this.lblPendingGiro1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPendingGiro1.SizeF = new System.Drawing.SizeF(124.2827F, 13.62503F);
            this.lblPendingGiro1.StylePriority.UseBorders = false;
            this.lblPendingGiro1.StylePriority.UseFont = false;
            this.lblPendingGiro1.StylePriority.UseForeColor = false;
            this.lblPendingGiro1.Text = "Approve datetime";
            this.lblPendingGiro1.Visible = false;
            // 
            // lblPendingGiro2
            // 
            this.lblPendingGiro2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPendingGiro2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPendingGiro2.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPendingGiro2.LocationFloat = new DevExpress.Utils.PointFloat(8.617306F, 76.91206F);
            this.lblPendingGiro2.Name = "lblPendingGiro2";
            this.lblPendingGiro2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPendingGiro2.SizeF = new System.Drawing.SizeF(150.1497F, 33.66082F);
            this.lblPendingGiro2.StylePriority.UseBorders = false;
            this.lblPendingGiro2.StylePriority.UseFont = false;
            this.lblPendingGiro2.StylePriority.UseForeColor = false;
            this.lblPendingGiro2.Text = "Note";
            this.lblPendingGiro2.Visible = false;
            // 
            // picBoxPendingGiro2
            // 
            this.picBoxPendingGiro2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPendingGiro2.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPendingGiro2.Image")));
            this.picBoxPendingGiro2.LocationFloat = new DevExpress.Utils.PointFloat(8.617337F, 9.421222F);
            this.picBoxPendingGiro2.Name = "picBoxPendingGiro2";
            this.picBoxPendingGiro2.SizeF = new System.Drawing.SizeF(57.39584F, 52.70831F);
            this.picBoxPendingGiro2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPendingGiro2.StylePriority.UseBorders = false;
            this.picBoxPendingGiro2.Visible = false;
            // 
            // picBoxPendingGiro1
            // 
            this.picBoxPendingGiro1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPendingGiro1.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPendingGiro1.Image")));
            this.picBoxPendingGiro1.LocationFloat = new DevExpress.Utils.PointFloat(8.617294F, 9.999983F);
            this.picBoxPendingGiro1.Name = "picBoxPendingGiro1";
            this.picBoxPendingGiro1.SizeF = new System.Drawing.SizeF(57.39584F, 52.70831F);
            this.picBoxPendingGiro1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPendingGiro1.StylePriority.UseBorders = false;
            this.picBoxPendingGiro1.Visible = false;
            // 
            // xrTableCell36
            // 
            this.xrTableCell36.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.picBoxPendingGiro3,
            this.picBoxPendingGiro4,
            this.lblPendingGiro3,
            this.lblPendingGiro4});
            this.xrTableCell36.Name = "xrTableCell36";
            this.xrTableCell36.Weight = 1D;
            // 
            // picBoxPendingGiro3
            // 
            this.picBoxPendingGiro3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPendingGiro3.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPendingGiro3.Image")));
            this.picBoxPendingGiro3.LocationFloat = new DevExpress.Utils.PointFloat(10.5505F, 9.999946F);
            this.picBoxPendingGiro3.Name = "picBoxPendingGiro3";
            this.picBoxPendingGiro3.SizeF = new System.Drawing.SizeF(57.39584F, 52.70831F);
            this.picBoxPendingGiro3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPendingGiro3.StylePriority.UseBorders = false;
            this.picBoxPendingGiro3.Visible = false;
            // 
            // picBoxPendingGiro4
            // 
            this.picBoxPendingGiro4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPendingGiro4.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPendingGiro4.Image")));
            this.picBoxPendingGiro4.LocationFloat = new DevExpress.Utils.PointFloat(10.00002F, 9.421268F);
            this.picBoxPendingGiro4.Name = "picBoxPendingGiro4";
            this.picBoxPendingGiro4.SizeF = new System.Drawing.SizeF(57.39584F, 52.70831F);
            this.picBoxPendingGiro4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPendingGiro4.StylePriority.UseBorders = false;
            this.picBoxPendingGiro4.Visible = false;
            // 
            // lblPendingGiro3
            // 
            this.lblPendingGiro3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPendingGiro3.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPendingGiro3.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPendingGiro3.LocationFloat = new DevExpress.Utils.PointFloat(38.03889F, 63.28683F);
            this.lblPendingGiro3.Name = "lblPendingGiro3";
            this.lblPendingGiro3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPendingGiro3.SizeF = new System.Drawing.SizeF(122.6614F, 13.62504F);
            this.lblPendingGiro3.StylePriority.UseBorders = false;
            this.lblPendingGiro3.StylePriority.UseFont = false;
            this.lblPendingGiro3.StylePriority.UseForeColor = false;
            this.lblPendingGiro3.Text = "Approve datetime";
            this.lblPendingGiro3.Visible = false;
            // 
            // lblPendingGiro4
            // 
            this.lblPendingGiro4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPendingGiro4.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPendingGiro4.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPendingGiro4.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 76.91199F);
            this.lblPendingGiro4.Name = "lblPendingGiro4";
            this.lblPendingGiro4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPendingGiro4.SizeF = new System.Drawing.SizeF(150.7003F, 33.66089F);
            this.lblPendingGiro4.StylePriority.UseBorders = false;
            this.lblPendingGiro4.StylePriority.UseFont = false;
            this.lblPendingGiro4.StylePriority.UseForeColor = false;
            this.lblPendingGiro4.Text = "Note";
            this.lblPendingGiro4.Visible = false;
            // 
            // xrTableCell37
            // 
            this.xrTableCell37.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.picBoxPendingGiro5,
            this.picBoxPendingGiro6,
            this.lblPendingGiro5,
            this.lblPendingGiro6});
            this.xrTableCell37.Name = "xrTableCell37";
            this.xrTableCell37.Weight = 1D;
            // 
            // picBoxPendingGiro5
            // 
            this.picBoxPendingGiro5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPendingGiro5.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPendingGiro5.Image")));
            this.picBoxPendingGiro5.LocationFloat = new DevExpress.Utils.PointFloat(10.00004F, 9.99999F);
            this.picBoxPendingGiro5.Name = "picBoxPendingGiro5";
            this.picBoxPendingGiro5.SizeF = new System.Drawing.SizeF(57.39584F, 52.70831F);
            this.picBoxPendingGiro5.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPendingGiro5.StylePriority.UseBorders = false;
            this.picBoxPendingGiro5.Visible = false;
            // 
            // picBoxPendingGiro6
            // 
            this.picBoxPendingGiro6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPendingGiro6.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPendingGiro6.Image")));
            this.picBoxPendingGiro6.LocationFloat = new DevExpress.Utils.PointFloat(8.14724F, 9.421242F);
            this.picBoxPendingGiro6.Name = "picBoxPendingGiro6";
            this.picBoxPendingGiro6.SizeF = new System.Drawing.SizeF(57.39584F, 52.70831F);
            this.picBoxPendingGiro6.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPendingGiro6.StylePriority.UseBorders = false;
            this.picBoxPendingGiro6.Visible = false;
            // 
            // lblPendingGiro5
            // 
            this.lblPendingGiro5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPendingGiro5.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPendingGiro5.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPendingGiro5.LocationFloat = new DevExpress.Utils.PointFloat(31.41006F, 62.70816F);
            this.lblPendingGiro5.Name = "lblPendingGiro5";
            this.lblPendingGiro5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPendingGiro5.SizeF = new System.Drawing.SizeF(126.8868F, 13.62503F);
            this.lblPendingGiro5.StylePriority.UseBorders = false;
            this.lblPendingGiro5.StylePriority.UseFont = false;
            this.lblPendingGiro5.StylePriority.UseForeColor = false;
            this.lblPendingGiro5.Text = "Approve datetime";
            this.lblPendingGiro5.Visible = false;
            // 
            // lblPendingGiro6
            // 
            this.lblPendingGiro6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPendingGiro6.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPendingGiro6.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPendingGiro6.LocationFloat = new DevExpress.Utils.PointFloat(8.147367F, 76.3333F);
            this.lblPendingGiro6.Name = "lblPendingGiro6";
            this.lblPendingGiro6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPendingGiro6.SizeF = new System.Drawing.SizeF(150.1494F, 34.23958F);
            this.lblPendingGiro6.StylePriority.UseBorders = false;
            this.lblPendingGiro6.StylePriority.UseFont = false;
            this.lblPendingGiro6.StylePriority.UseForeColor = false;
            this.lblPendingGiro6.Text = "Note";
            this.lblPendingGiro6.Visible = false;
            // 
            // xrTableRow9
            // 
            this.xrTableRow9.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.lblGiroPemohonName,
            this.lblGiroReviewName1,
            this.lblGiroReviewName2,
            this.lblGiroMenyetujuiName});
            this.xrTableRow9.Name = "xrTableRow9";
            this.xrTableRow9.StylePriority.UseBorders = false;
            this.xrTableRow9.Weight = 0.300448306627737D;
            // 
            // lblGiroPemohonName
            // 
            this.lblGiroPemohonName.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MemoFrom]")});
            this.lblGiroPemohonName.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiroPemohonName.Name = "lblGiroPemohonName";
            this.lblGiroPemohonName.StylePriority.UseFont = false;
            this.lblGiroPemohonName.StylePriority.UseTextAlignment = false;
            this.lblGiroPemohonName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.lblGiroPemohonName.Weight = 1D;
            // 
            // lblGiroReviewName1
            // 
            this.lblGiroReviewName1.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiroReviewName1.Name = "lblGiroReviewName1";
            this.lblGiroReviewName1.StylePriority.UseFont = false;
            this.lblGiroReviewName1.StylePriority.UseTextAlignment = false;
            this.lblGiroReviewName1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.lblGiroReviewName1.Weight = 1D;
            // 
            // lblGiroReviewName2
            // 
            this.lblGiroReviewName2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiroReviewName2.Name = "lblGiroReviewName2";
            this.lblGiroReviewName2.StylePriority.UseFont = false;
            this.lblGiroReviewName2.StylePriority.UseTextAlignment = false;
            this.lblGiroReviewName2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.lblGiroReviewName2.Weight = 1D;
            // 
            // lblGiroMenyetujuiName
            // 
            this.lblGiroMenyetujuiName.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiroMenyetujuiName.Name = "lblGiroMenyetujuiName";
            this.lblGiroMenyetujuiName.StylePriority.UseFont = false;
            this.lblGiroMenyetujuiName.StylePriority.UseTextAlignment = false;
            this.lblGiroMenyetujuiName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.lblGiroMenyetujuiName.Weight = 1D;
            // 
            // xrTableRow10
            // 
            this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.lblGiroPemohonJabatan,
            this.lblGiroReviewJabatan1,
            this.lblGiroReviewJabatan2,
            this.lblGiroMenyetujuiJabatan});
            this.xrTableRow10.Name = "xrTableRow10";
            this.xrTableRow10.Weight = 0.3167549772359699D;
            // 
            // lblGiroPemohonJabatan
            // 
            this.lblGiroPemohonJabatan.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lblGiroPemohonJabatan.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiroPemohonJabatan.Name = "lblGiroPemohonJabatan";
            this.lblGiroPemohonJabatan.StylePriority.UseBorders = false;
            this.lblGiroPemohonJabatan.StylePriority.UseFont = false;
            this.lblGiroPemohonJabatan.StylePriority.UseTextAlignment = false;
            this.lblGiroPemohonJabatan.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.lblGiroPemohonJabatan.Weight = 1D;
            // 
            // lblGiroReviewJabatan1
            // 
            this.lblGiroReviewJabatan1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lblGiroReviewJabatan1.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiroReviewJabatan1.Name = "lblGiroReviewJabatan1";
            this.lblGiroReviewJabatan1.StylePriority.UseBorders = false;
            this.lblGiroReviewJabatan1.StylePriority.UseFont = false;
            this.lblGiroReviewJabatan1.StylePriority.UseTextAlignment = false;
            this.lblGiroReviewJabatan1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.lblGiroReviewJabatan1.Weight = 1D;
            // 
            // lblGiroReviewJabatan2
            // 
            this.lblGiroReviewJabatan2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lblGiroReviewJabatan2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiroReviewJabatan2.Name = "lblGiroReviewJabatan2";
            this.lblGiroReviewJabatan2.StylePriority.UseBorders = false;
            this.lblGiroReviewJabatan2.StylePriority.UseFont = false;
            this.lblGiroReviewJabatan2.StylePriority.UseTextAlignment = false;
            this.lblGiroReviewJabatan2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.lblGiroReviewJabatan2.Weight = 1D;
            // 
            // lblGiroMenyetujuiJabatan
            // 
            this.lblGiroMenyetujuiJabatan.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lblGiroMenyetujuiJabatan.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiroMenyetujuiJabatan.Name = "lblGiroMenyetujuiJabatan";
            this.lblGiroMenyetujuiJabatan.StylePriority.UseBorders = false;
            this.lblGiroMenyetujuiJabatan.StylePriority.UseFont = false;
            this.lblGiroMenyetujuiJabatan.StylePriority.UseTextAlignment = false;
            this.lblGiroMenyetujuiJabatan.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.lblGiroMenyetujuiJabatan.Weight = 1D;
            // 
            // xrtblPendingGiroFinalApp
            // 
            this.xrtblPendingGiroFinalApp.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrtblPendingGiroFinalApp.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrtblPendingGiroFinalApp.LocationFloat = new DevExpress.Utils.PointFloat(35.7041F, 196.9062F);
            this.xrtblPendingGiroFinalApp.Name = "xrtblPendingGiroFinalApp";
            this.xrtblPendingGiroFinalApp.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow11,
            this.xrTableRow12,
            this.xrTableRow13,
            this.xrTableRow14});
            this.xrtblPendingGiroFinalApp.SizeF = new System.Drawing.SizeF(647.2584F, 176.9574F);
            this.xrtblPendingGiroFinalApp.StylePriority.UseBorders = false;
            this.xrtblPendingGiroFinalApp.StylePriority.UseFont = false;
            // 
            // xrTableRow11
            // 
            this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell17});
            this.xrTableRow11.Name = "xrTableRow11";
            this.xrTableRow11.Weight = 0.45799216731112036D;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.StylePriority.UseTextAlignment = false;
            this.xrTableCell17.Text = "Menyetujui,";
            this.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell17.Weight = 3D;
            // 
            // xrTableRow12
            // 
            this.xrTableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell38});
            this.xrTableRow12.Name = "xrTableRow12";
            this.xrTableRow12.Weight = 2.5009434725684119D;
            // 
            // xrTableCell38
            // 
            this.xrTableCell38.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.picBoxPendingGiro8,
            this.picBoxPendingGiro7,
            this.lblPendingGiro7,
            this.lblPendingGiro8});
            this.xrTableCell38.Name = "xrTableCell38";
            this.xrTableCell38.Weight = 3D;
            // 
            // picBoxPendingGiro8
            // 
            this.picBoxPendingGiro8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPendingGiro8.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPendingGiro8.Image")));
            this.picBoxPendingGiro8.LocationFloat = new DevExpress.Utils.PointFloat(172.5179F, 9.999466F);
            this.picBoxPendingGiro8.Name = "picBoxPendingGiro8";
            this.picBoxPendingGiro8.SizeF = new System.Drawing.SizeF(113.4179F, 104.9689F);
            this.picBoxPendingGiro8.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPendingGiro8.StylePriority.UseBorders = false;
            this.picBoxPendingGiro8.Visible = false;
            // 
            // picBoxPendingGiro7
            // 
            this.picBoxPendingGiro7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPendingGiro7.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPendingGiro7.Image")));
            this.picBoxPendingGiro7.LocationFloat = new DevExpress.Utils.PointFloat(171.4749F, 9.999593F);
            this.picBoxPendingGiro7.Name = "picBoxPendingGiro7";
            this.picBoxPendingGiro7.SizeF = new System.Drawing.SizeF(114.4608F, 104.9688F);
            this.picBoxPendingGiro7.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPendingGiro7.StylePriority.UseBorders = false;
            this.picBoxPendingGiro7.Visible = false;
            // 
            // lblPendingGiro7
            // 
            this.lblPendingGiro7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPendingGiro7.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPendingGiro7.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPendingGiro7.LocationFloat = new DevExpress.Utils.PointFloat(285.9358F, 73.33521F);
            this.lblPendingGiro7.Name = "lblPendingGiro7";
            this.lblPendingGiro7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPendingGiro7.SizeF = new System.Drawing.SizeF(358.8466F, 13.62505F);
            this.lblPendingGiro7.StylePriority.UseBorders = false;
            this.lblPendingGiro7.StylePriority.UseFont = false;
            this.lblPendingGiro7.StylePriority.UseForeColor = false;
            this.lblPendingGiro7.Text = "Approve datetime";
            this.lblPendingGiro7.Visible = false;
            // 
            // lblPendingGiro8
            // 
            this.lblPendingGiro8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPendingGiro8.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPendingGiro8.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPendingGiro8.LocationFloat = new DevExpress.Utils.PointFloat(285.9357F, 86.96041F);
            this.lblPendingGiro8.Name = "lblPendingGiro8";
            this.lblPendingGiro8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPendingGiro8.SizeF = new System.Drawing.SizeF(358.8467F, 28.00795F);
            this.lblPendingGiro8.StylePriority.UseBorders = false;
            this.lblPendingGiro8.StylePriority.UseFont = false;
            this.lblPendingGiro8.StylePriority.UseForeColor = false;
            this.lblPendingGiro8.Text = "Note";
            this.lblPendingGiro8.Visible = false;
            // 
            // xrTableRow13
            // 
            this.xrTableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.lblGiroMenyetujuiName2});
            this.xrTableRow13.Name = "xrTableRow13";
            this.xrTableRow13.Weight = 0.29122183456250811D;
            // 
            // lblGiroMenyetujuiName2
            // 
            this.lblGiroMenyetujuiName2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.lblGiroMenyetujuiName2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiroMenyetujuiName2.Name = "lblGiroMenyetujuiName2";
            this.lblGiroMenyetujuiName2.StylePriority.UseBorders = false;
            this.lblGiroMenyetujuiName2.StylePriority.UseFont = false;
            this.lblGiroMenyetujuiName2.StylePriority.UseTextAlignment = false;
            this.lblGiroMenyetujuiName2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.lblGiroMenyetujuiName2.Weight = 3D;
            // 
            // xrTableRow14
            // 
            this.xrTableRow14.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.lblGiroMenyetujuiJabatan2});
            this.xrTableRow14.Name = "xrTableRow14";
            this.xrTableRow14.Weight = 0.2912203872474739D;
            // 
            // lblGiroMenyetujuiJabatan2
            // 
            this.lblGiroMenyetujuiJabatan2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiroMenyetujuiJabatan2.Name = "lblGiroMenyetujuiJabatan2";
            this.lblGiroMenyetujuiJabatan2.StylePriority.UseFont = false;
            this.lblGiroMenyetujuiJabatan2.StylePriority.UseTextAlignment = false;
            this.lblGiroMenyetujuiJabatan2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.lblGiroMenyetujuiJabatan2.Weight = 3D;
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
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(32.57913F, 0F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(188.5749F, 54.1174F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // docInternalMemoPendingGiro
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader1,
            this.DetailReport,
            this.GroupFooter1,
            this.ReportFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "InternalMemo";
            this.DataSource = this.sqlDataSource1;
            this.Margins = new System.Drawing.Printing.Margins(49, 51, 54, 52);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.DocKey,
            this.DocNo});
            this.Version = "17.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrtblPendingGiroFinalApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
