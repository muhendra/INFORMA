using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for docInternalMemoPemakaianCashColl
/// </summary>
public class docInternalMemoPemakaianCashColl : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private ReportHeaderBand ReportHeader;
    private XRLabel xrLabel1;
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
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell17;
    private XRTableCell xrTableCell18;
    private XRLabel xrLabel2;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    private DevExpress.XtraReports.Parameters.Parameter DocNo;
    private XRLine xrLine1;
    private DetailReportBand DetailReport;
    private DetailBand Detail1;
    private XRTable xrTable3;
    private XRTableRow xrTableRow14;
    private XRTableCell xrTableCell41;
    private XRTableCell xrTableCell42;
    private XRTableCell xrTableCell43;
    private XRTableCell xrTableCell35;
    private XRLabel xrLabel6;
    private XRLabel xrLabel4;
    private XRLabel xrLabel3;
    private XRTable xrTable2;
    private XRTableRow xrTableRow7;
    private XRTableCell xrTableCell19;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell22;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell24;
    private XRTableRow xrTableRow9;
    private XRTableCell xrTableCell25;
    private XRTableCell xrTableCell26;
    private XRTableCell xrTableCell27;
    private XRTableRow xrTableRow10;
    private XRTableCell xrTableCell28;
    private XRTableCell xrTableCell29;
    private XRTableCell xrTableCell30;
    private XRTableRow xrTableRow11;
    private XRTableCell xrTableCell31;
    private XRTableCell xrTableCell32;
    private XRTableCell xrTableCell33;
    private GroupHeaderBand GroupHeader1;
    private XRTable xrTable4;
    private XRTableRow xrTableRow15;
    private XRTableCell xrTableCell21;
    private XRTableRow xrTableRow16;
    private XRTableCell xrTableCell45;
    private XRTableCell xrTableCell46;
    private XRTableCell xrTableCell47;
    private XRTableCell xrTableCell48;
    private DevExpress.XtraReports.Parameters.Parameter DocKey;
    private XRLabel xrLabel7;
    private XRLabel xrLabel5;
    private GroupFooterBand GroupFooter;
    private XRLabel xrLabel9;
    private XRLabel xrLabel8;
    private XRPageInfo xrPageInfo1;
    private ReportFooterBand ReportFooter;
    private XRLabel xrLabel10;
    private XRTable xrTable5;
    private XRTableRow xrTableRow12;
    private XRTableCell xrTableCell20;
    private XRTableCell xrTableCell34;
    private XRTableRow xrTableRow13;
    private XRTableCell xrTableCell37;
    private XRTableCell xrTableCell38;
    private XRTableCell xrTableCell39;
    private XRTableRow xrTableRow17;
    private XRTableCell xrTableCell40;
    private XRTableCell xrTableCell44;
    private XRTableCell xrTableCell49;
    private XRLabel xrLabel13;
    private XRLabel xrLabel12;
    private XRLabel xrLabel11;
    private XRTable xrTable6;
    private XRTableRow xrTableRow18;
    private XRTableCell xrTableCell36;
    private XRTableCell xrTableCell50;
    private XRTableCell xrTableCell51;
    private XRTableRow xrTableRow19;
    private XRTableCell xrTableCell52;
    private XRTableCell xrTableCell53;
    private XRTableCell xrTableCell54;
    private XRTableRow xrTableRow20;
    private XRTableCell xrTableCell55;
    private XRTableCell xrTableCell56;
    private XRTableCell xrTableCell57;
    private XRTableRow xrTableRow21;
    private XRTableCell xrTableCell581;
    private XRTableCell xrTableCell59;
    private XRTableCell xrTableCell60;
    private XRLabel xrLabel14;
    private XRTableRow xrTableRow22;
    private XRTableCell xrTableCell61;
    private XRTableCell xrTableCell62;
    private XRTableCell xrTableCell63;
    private XRTableRow xrTableRow23;
    private XRTableCell xrTableCell641;
    private XRTableCell xrTableCell65;
    private XRTableCell xrTableCell66;
    private XRTableRow xrTableRow24;
    private XRTableCell xrTableCell58;
    private XRTableCell xrTableCell68;
    private XRTableCell xrTableCell69;
    private XRTableRow xrTableRow25;
    private XRTableCell xrTableCell70;
    private XRTableCell xrTableCell71;
    private XRTableCell xrTableCell72;
    private XRLabel xrLabel15;
    private XRPictureBox picBoxPemakaianCashColl6;
    private XRPictureBox picBoxPemakaianCashColl5;
    private XRLabel lblPemakaianCashColl5;
    private XRLabel lblPemakaianCashColl6;
    private XRPictureBox picBoxPemakaianCashColl2;
    private XRPictureBox picBoxPemakaianCashColl1;
    private XRPictureBox picBoxPemakaianCashColl4;
    private XRPictureBox picBoxPemakaianCashColl3;
    private XRPictureBox picBoxPemakaianCashColl8;
    private XRPictureBox picBoxPemakaianCashColl7;
    private XRLabel lblPemakaianCashColl8;
    private XRLabel lblPemakaianCashColl7;
    private XRPictureBox picBoxPemakaianCashColl10;
    private XRPictureBox picBoxPemakaianCashColl9;
    private XRLabel lblPemakaianCashColl10;
    private XRLabel lblPemakaianCashColl9;
    private XRLabel lblPemakaianCashColl1;
    private XRLabel lblPemakaianCashColl2;
    private XRLabel lblPemakaianCashColl3;
    private XRLabel lblPemakaianCashColl4;
    private XRTableRow xrTableRow26;
    private XRTableCell xrTableCell73;
    private XRTableCell xrTableCell74;
    private XRTableCell xrTableCell75;
    private XRTableRow xrTableRow27;
    private XRTableCell xrTableCell64;
    private XRTableCell xrTableCell77;
    private XRTableCell xrTableCell78;
    private XRTableRow xrTableRow28;
    private XRTableCell xrTableCell67;
    private XRTableCell xrTableCell79;
    private XRTableCell xrTableCell80;
    private XRPictureBox picBoxMySign1;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public docInternalMemoPemakaianCashColl()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(docInternalMemoPemakaianCashColl));
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
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
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
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.DocNo = new DevExpress.XtraReports.Parameters.Parameter();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow14 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell41 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell42 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell43 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow15 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow16 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell45 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell46 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell47 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell48 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.DocKey = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupFooter = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
            this.picBoxMySign1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblPemakaianCashColl1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblPemakaianCashColl2 = new DevExpress.XtraReports.UI.XRLabel();
            this.picBoxPemakaianCashColl2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.picBoxPemakaianCashColl1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblPemakaianCashColl3 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblPemakaianCashColl4 = new DevExpress.XtraReports.UI.XRLabel();
            this.picBoxPemakaianCashColl4 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.picBoxPemakaianCashColl3 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableRow17 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell44 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell49 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow25 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell70 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell71 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell72 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow18 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell50 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell51 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow26 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell73 = new DevExpress.XtraReports.UI.XRTableCell();
            this.picBoxPemakaianCashColl5 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.picBoxPemakaianCashColl6 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableCell74 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblPemakaianCashColl5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell75 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblPemakaianCashColl6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow19 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell52 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell53 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell54 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow22 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell61 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell62 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell63 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow23 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell641 = new DevExpress.XtraReports.UI.XRTableCell();
            this.picBoxPemakaianCashColl8 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.picBoxPemakaianCashColl7 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableCell65 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblPemakaianCashColl7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell66 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblPemakaianCashColl8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow27 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell64 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell77 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell78 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow20 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell55 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell56 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell57 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow21 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell581 = new DevExpress.XtraReports.UI.XRTableCell();
            this.picBoxPemakaianCashColl10 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.picBoxPemakaianCashColl9 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableCell59 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblPemakaianCashColl9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell60 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblPemakaianCashColl10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow24 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell58 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell68 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell69 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow28 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell67 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell79 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell80 = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Expanded = false;
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StylePriority.UsePadding = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel15,
            this.xrLabel9});
            this.TopMargin.HeightF = 70F;
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
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(39.29275F, 25.70836F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(265.625F, 15.70835F);
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseForeColor = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "xrLabel8";
            // 
            // xrLabel9
            // 
            this.xrLabel9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DocNo]")});
            this.xrLabel9.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.xrLabel9.ForeColor = System.Drawing.Color.DarkGray;
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(39.29148F, 10.00001F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(133.3333F, 15.70835F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseForeColor = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "xrLabel8";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel14,
            this.xrLabel8,
            this.xrPageInfo1});
            this.BottomMargin.HeightF = 76F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel14
            // 
            this.xrLabel14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MemoPerihal]")});
            this.xrLabel14.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.xrLabel14.ForeColor = System.Drawing.Color.DarkGray;
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(39.29275F, 39.62428F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(320.5804F, 13.62502F);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseForeColor = false;
            this.xrLabel14.Text = "xrLabel14";
            // 
            // xrLabel8
            // 
            this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DocNo]")});
            this.xrLabel8.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.xrLabel8.ForeColor = System.Drawing.Color.DarkGray;
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(39.29148F, 23.91599F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(133.3333F, 15.70835F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseForeColor = false;
            this.xrLabel8.Text = "xrLabel8";
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(359.873F, 23.91599F);
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
            this.xrLabel2,
            this.xrLabel1,
            this.xrTable1,
            this.xrLine1});
            this.ReportHeader.HeightF = 270F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrLabel2
            // 
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DocNo]")});
            this.xrLabel2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(99.99997F, 29.87499F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(550F, 25.08332F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "INTERNAL MEMORANDUM";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Tahoma", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(211.4583F, 3.750006F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(321.875F, 26.12499F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "INTERNAL MEMORANDUM";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTable1
            // 
            this.xrTable1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(39.29274F, 105.1389F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1,
            this.xrTableRow3,
            this.xrTableRow4,
            this.xrTableRow2,
            this.xrTableRow5,
            this.xrTableRow6});
            this.xrTable1.SizeF = new System.Drawing.SizeF(647.2585F, 125F);
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
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell16,
            this.xrTableCell17,
            this.xrTableCell18});
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.Weight = 1D;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.StylePriority.UseFont = false;
            this.xrTableCell16.Text = "No. Kontrak";
            this.xrTableCell16.Weight = 1.1096236359843479D;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.StylePriority.UseFont = false;
            this.xrTableCell17.Text = ":";
            this.xrTableCell17.Weight = 0.15524725618000446D;
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MemoRefNo]")});
            this.xrTableCell18.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.StylePriority.UseFont = false;
            this.xrTableCell18.Text = "xrTableCell18";
            this.xrTableCell18.Weight = 6.2551291078356472D;
            // 
            // xrLine1
            // 
            this.xrLine1.LineWidth = 2;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(39.29274F, 240.8388F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(647.2585F, 7.142548F);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "SqlLocalConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.MetaSerializable = "<Meta X=\"20\" Y=\"20\" Width=\"100\" Height=\"649\" />";
            customSqlQuery1.Name = "InternalMemo";
            queryParameter1.Name = "DocNo";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.DocNo]", typeof(string));
            customSqlQuery1.Parameters.Add(queryParameter1);
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            customSqlQuery2.MetaSerializable = "<Meta X=\"140\" Y=\"20\" Width=\"100\" Height=\"156\" />";
            customSqlQuery2.Name = "InternalMemoDetailPemakaianCashColl";
            queryParameter2.Name = "DocKey";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.DocKey]", typeof(int));
            customSqlQuery2.Parameters.Add(queryParameter2);
            customSqlQuery2.Sql = resources.GetString("customSqlQuery2.Sql");
            customSqlQuery3.MetaSerializable = "<Meta X=\"260\" Y=\"20\" Width=\"100\" Height=\"139\" />";
            customSqlQuery3.Name = "InternalMemoApprovalList";
            queryParameter3.Name = "DocKey";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.DocKey]", typeof(int));
            customSqlQuery3.Parameters.Add(queryParameter3);
            customSqlQuery3.Sql = resources.GetString("customSqlQuery3.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1,
            customSqlQuery2,
            customSqlQuery3});
            masterDetailInfo1.DetailQueryName = "InternalMemoDetailPemakaianCashColl";
            relationColumnInfo1.NestedKeyColumn = "DocKey";
            relationColumnInfo1.ParentKeyColumn = "DocKey";
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo1);
            masterDetailInfo1.MasterQueryName = "InternalMemo";
            masterDetailInfo2.DetailQueryName = "InternalMemoApprovalList";
            relationColumnInfo2.NestedKeyColumn = "DocKey";
            relationColumnInfo2.ParentKeyColumn = "DocKey";
            masterDetailInfo2.KeyColumns.Add(relationColumnInfo2);
            masterDetailInfo2.MasterQueryName = "InternalMemo";
            this.sqlDataSource1.Relations.AddRange(new DevExpress.DataAccess.Sql.MasterDetailInfo[] {
            masterDetailInfo1,
            masterDetailInfo2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
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
            this.DetailReport.DataMember = "InternalMemoDetailPemakaianCashColl";
            this.DetailReport.DataSource = this.sqlDataSource1;
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3});
            this.Detail1.HeightF = 24.99999F;
            this.Detail1.Name = "Detail1";
            // 
            // xrTable3
            // 
            this.xrTable3.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(39.29257F, 0F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow14});
            this.xrTable3.SizeF = new System.Drawing.SizeF(647.2587F, 24.99999F);
            this.xrTable3.StylePriority.UseFont = false;
            // 
            // xrTableRow14
            // 
            this.xrTableRow14.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell41,
            this.xrTableCell42,
            this.xrTableCell43,
            this.xrTableCell35});
            this.xrTableRow14.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrTableRow14.Name = "xrTableRow14";
            this.xrTableRow14.StylePriority.UseFont = false;
            this.xrTableRow14.StylePriority.UseTextAlignment = false;
            this.xrTableRow14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableRow14.Weight = 1D;
            // 
            // xrTableCell41
            // 
            this.xrTableCell41.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell41.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AssetDesc]")});
            this.xrTableCell41.Multiline = true;
            this.xrTableCell41.Name = "xrTableCell41";
            this.xrTableCell41.StylePriority.UseBorders = false;
            this.xrTableCell41.Text = "xrTableCell41";
            this.xrTableCell41.Weight = 2.4764483753087787D;
            // 
            // xrTableCell42
            // 
            this.xrTableCell42.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell42.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NoRangka]")});
            this.xrTableCell42.Multiline = true;
            this.xrTableCell42.Name = "xrTableCell42";
            this.xrTableCell42.StylePriority.UseBorders = false;
            this.xrTableCell42.Text = "xrTableCell42";
            this.xrTableCell42.Weight = 0.85940961583030029D;
            // 
            // xrTableCell43
            // 
            this.xrTableCell43.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell43.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NoMesin]")});
            this.xrTableCell43.Multiline = true;
            this.xrTableCell43.Name = "xrTableCell43";
            this.xrTableCell43.StylePriority.UseBorders = false;
            this.xrTableCell43.Text = "xrTableCell43";
            this.xrTableCell43.Weight = 0.86721880069665991D;
            // 
            // xrTableCell35
            // 
            this.xrTableCell35.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell35.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Tahun]")});
            this.xrTableCell35.Multiline = true;
            this.xrTableCell35.Name = "xrTableCell35";
            this.xrTableCell35.StylePriority.UseBorders = false;
            this.xrTableCell35.Text = "xrTableCell35";
            this.xrTableCell35.Weight = 0.79692320816426054D;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(39.29274F, 0F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(349.6527F, 19.79488F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "A. DATA ASSET & KEWAJIBAN DEBITUR";
            // 
            // xrTable2
            // 
            this.xrTable2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(39.29258F, 38.82643F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow7,
            this.xrTableRow8,
            this.xrTableRow9,
            this.xrTableRow10,
            this.xrTableRow11});
            this.xrTable2.SizeF = new System.Drawing.SizeF(647.2585F, 108.3334F);
            this.xrTable2.StylePriority.UseFont = false;
            this.xrTable2.StylePriority.UseTextAlignment = false;
            this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell19});
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.Weight = 1D;
            // 
            // xrTableCell19
            // 
            this.xrTableCell19.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrTableCell19.Name = "xrTableCell19";
            this.xrTableCell19.StylePriority.UseFont = false;
            this.xrTableCell19.Text = "1. Rincian Debitur";
            this.xrTableCell19.Weight = 3D;
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell22,
            this.xrTableCell23,
            this.xrTableCell24});
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.Weight = 1D;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.StylePriority.UseFont = false;
            this.xrTableCell22.Text = "Nama";
            this.xrTableCell22.Weight = 0.44592676392331232D;
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.StylePriority.UseFont = false;
            this.xrTableCell23.Text = ":";
            this.xrTableCell23.Weight = 0.062944371511665542D;
            // 
            // xrTableCell24
            // 
            this.xrTableCell24.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DebiturName]")});
            this.xrTableCell24.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrTableCell24.Name = "xrTableCell24";
            this.xrTableCell24.StylePriority.UseFont = false;
            this.xrTableCell24.Text = "xrTableCell24";
            this.xrTableCell24.Weight = 2.491128864565022D;
            // 
            // xrTableRow9
            // 
            this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell25,
            this.xrTableCell26,
            this.xrTableCell27});
            this.xrTableRow9.Name = "xrTableRow9";
            this.xrTableRow9.Weight = 1D;
            // 
            // xrTableCell25
            // 
            this.xrTableCell25.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrTableCell25.Name = "xrTableCell25";
            this.xrTableCell25.StylePriority.UseFont = false;
            this.xrTableCell25.Text = "No. Client";
            this.xrTableCell25.Weight = 0.44592676392331232D;
            // 
            // xrTableCell26
            // 
            this.xrTableCell26.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrTableCell26.Name = "xrTableCell26";
            this.xrTableCell26.StylePriority.UseFont = false;
            this.xrTableCell26.Text = ":";
            this.xrTableCell26.Weight = 0.062944371511665542D;
            // 
            // xrTableCell27
            // 
            this.xrTableCell27.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DebiturCIF]")});
            this.xrTableCell27.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrTableCell27.Name = "xrTableCell27";
            this.xrTableCell27.StylePriority.UseFont = false;
            this.xrTableCell27.Text = "xrTableCell27";
            this.xrTableCell27.Weight = 2.491128864565022D;
            // 
            // xrTableRow10
            // 
            this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell28,
            this.xrTableCell29,
            this.xrTableCell30});
            this.xrTableRow10.Name = "xrTableRow10";
            this.xrTableRow10.Weight = 1D;
            // 
            // xrTableCell28
            // 
            this.xrTableCell28.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrTableCell28.Name = "xrTableCell28";
            this.xrTableCell28.StylePriority.UseFont = false;
            this.xrTableCell28.Text = "Alamat";
            this.xrTableCell28.Weight = 0.44592676392331232D;
            // 
            // xrTableCell29
            // 
            this.xrTableCell29.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrTableCell29.Name = "xrTableCell29";
            this.xrTableCell29.StylePriority.UseFont = false;
            this.xrTableCell29.Text = ":";
            this.xrTableCell29.Weight = 0.062944371511665542D;
            // 
            // xrTableCell30
            // 
            this.xrTableCell30.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DebiturAddress]")});
            this.xrTableCell30.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrTableCell30.Name = "xrTableCell30";
            this.xrTableCell30.StylePriority.UseFont = false;
            this.xrTableCell30.Text = "xrTableCell30";
            this.xrTableCell30.Weight = 2.491128864565022D;
            // 
            // xrTableRow11
            // 
            this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell31,
            this.xrTableCell32,
            this.xrTableCell33});
            this.xrTableRow11.Name = "xrTableRow11";
            this.xrTableRow11.Weight = 1D;
            // 
            // xrTableCell31
            // 
            this.xrTableCell31.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrTableCell31.Name = "xrTableCell31";
            this.xrTableCell31.StylePriority.UseFont = false;
            this.xrTableCell31.Text = "Angsuran";
            this.xrTableCell31.Weight = 0.44592676392331232D;
            // 
            // xrTableCell32
            // 
            this.xrTableCell32.Name = "xrTableCell32";
            this.xrTableCell32.Text = ":";
            this.xrTableCell32.Weight = 0.062944371511665542D;
            // 
            // xrTableCell33
            // 
            this.xrTableCell33.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DebiturAngsuran]")});
            this.xrTableCell33.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrTableCell33.Name = "xrTableCell33";
            this.xrTableCell33.StylePriority.UseFont = false;
            this.xrTableCell33.Text = "xrTableCell33";
            this.xrTableCell33.TextFormatString = "{0:Rp #,##.00}";
            this.xrTableCell33.Weight = 2.491128864565022D;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable4,
            this.xrTable2,
            this.xrLabel3});
            this.GroupHeader1.HeightF = 211.8125F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrTable4
            // 
            this.xrTable4.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(39.29257F, 161.8125F);
            this.xrTable4.Name = "xrTable4";
            this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow15,
            this.xrTableRow16});
            this.xrTable4.SizeF = new System.Drawing.SizeF(647.2585F, 49.99997F);
            this.xrTable4.StylePriority.UseFont = false;
            // 
            // xrTableRow15
            // 
            this.xrTableRow15.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell21});
            this.xrTableRow15.Name = "xrTableRow15";
            this.xrTableRow15.Weight = 1D;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.Text = "2. Data Asset";
            this.xrTableCell21.Weight = 8D;
            // 
            // xrTableRow16
            // 
            this.xrTableRow16.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell45,
            this.xrTableCell46,
            this.xrTableCell47,
            this.xrTableCell48});
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
            this.xrTableCell45.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrTableCell45.Name = "xrTableCell45";
            this.xrTableCell45.StylePriority.UseBorders = false;
            this.xrTableCell45.StylePriority.UseFont = false;
            this.xrTableCell45.Text = "Asset Description";
            this.xrTableCell45.Weight = 2.4764483753087787D;
            // 
            // xrTableCell46
            // 
            this.xrTableCell46.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell46.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrTableCell46.Name = "xrTableCell46";
            this.xrTableCell46.StylePriority.UseBorders = false;
            this.xrTableCell46.StylePriority.UseFont = false;
            this.xrTableCell46.Text = "No. Rangka";
            this.xrTableCell46.Weight = 0.85940961583030029D;
            // 
            // xrTableCell47
            // 
            this.xrTableCell47.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell47.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrTableCell47.Name = "xrTableCell47";
            this.xrTableCell47.StylePriority.UseBorders = false;
            this.xrTableCell47.StylePriority.UseFont = false;
            this.xrTableCell47.Text = "No. Mesin";
            this.xrTableCell47.Weight = 0.86721880069665991D;
            // 
            // xrTableCell48
            // 
            this.xrTableCell48.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell48.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrTableCell48.Name = "xrTableCell48";
            this.xrTableCell48.StylePriority.UseBorders = false;
            this.xrTableCell48.StylePriority.UseFont = false;
            this.xrTableCell48.Text = "Tahun";
            this.xrTableCell48.Weight = 0.79692320816426054D;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(39.29147F, 15.27149F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(349.6528F, 21.95834F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.Text = "B. LATAR BELAKANG";
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(39.29211F, 150.6345F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(349.6528F, 19.87503F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.Text = "C. COST & BENEFIT ANALYSIS";
            // 
            // DocKey
            // 
            this.DocKey.Description = "DocKey";
            this.DocKey.Name = "DocKey";
            this.DocKey.Type = typeof(int);
            this.DocKey.ValueInfo = "0";
            this.DocKey.Visible = false;
            // 
            // xrLabel5
            // 
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BackgroundText]")});
            this.xrLabel5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(39.29258F, 37.22986F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(647.2585F, 100F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "xrLabel5";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
            // 
            // xrLabel7
            // 
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CostBenefitAnalysisText]")});
            this.xrLabel7.Font = new System.Drawing.Font("Tahoma", 9F);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(39.29211F, 170.5095F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(647.2589F, 100F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "xrLabel5";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
            // 
            // GroupFooter
            // 
            this.GroupFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel7});
            this.GroupFooter.HeightF = 278.1674F;
            this.GroupFooter.Name = "GroupFooter";
            this.GroupFooter.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel13,
            this.xrLabel12,
            this.xrLabel10,
            this.xrTable5,
            this.xrLabel11,
            this.xrTable6});
            this.ReportFooter.HeightF = 987.5878F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrLabel13
            // 
            this.xrLabel13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DocDate]")});
            this.xrLabel13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(162.7982F, 344.0486F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(384.2504F, 18.83331F);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "xrLabel13";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel13.TextFormatString = "{0:dd/MM/yyyy}";
            // 
            // xrLabel12
            // 
            this.xrLabel12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DocNo]")});
            this.xrLabel12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(162.7982F, 325.2152F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(384.2504F, 18.83334F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "xrLabel12";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel10
            // 
            this.xrLabel10.Font = new System.Drawing.Font("Tahoma", 9F);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(39.29275F, 10.00001F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(647.2583F, 34.45832F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = resources.GetString("xrLabel10.Text");
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
            // 
            // xrTable5
            // 
            this.xrTable5.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable5.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(39.29275F, 63.54167F);
            this.xrTable5.Name = "xrTable5";
            this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow12,
            this.xrTableRow13,
            this.xrTableRow17,
            this.xrTableRow25});
            this.xrTable5.SizeF = new System.Drawing.SizeF(647.2585F, 226.0417F);
            this.xrTable5.StylePriority.UseBorders = false;
            this.xrTable5.StylePriority.UseFont = false;
            // 
            // xrTableRow12
            // 
            this.xrTableRow12.BackColor = System.Drawing.Color.Gainsboro;
            this.xrTableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell20,
            this.xrTableCell34});
            this.xrTableRow12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableRow12.Name = "xrTableRow12";
            this.xrTableRow12.StylePriority.UseBackColor = false;
            this.xrTableRow12.StylePriority.UseFont = false;
            this.xrTableRow12.StylePriority.UseTextAlignment = false;
            this.xrTableRow12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableRow12.Weight = 0.37288139731197034D;
            // 
            // xrTableCell20
            // 
            this.xrTableCell20.Name = "xrTableCell20";
            this.xrTableCell20.Text = "Diajukan Oleh";
            this.xrTableCell20.Weight = 1D;
            // 
            // xrTableCell34
            // 
            this.xrTableCell34.Name = "xrTableCell34";
            this.xrTableCell34.StylePriority.UseTextAlignment = false;
            this.xrTableCell34.Text = "Mengetahui";
            this.xrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell34.Weight = 2D;
            // 
            // xrTableRow13
            // 
            this.xrTableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell37,
            this.xrTableCell38,
            this.xrTableCell39});
            this.xrTableRow13.Name = "xrTableRow13";
            this.xrTableRow13.Weight = 1.8671186183130306D;
            // 
            // xrTableCell37
            // 
            this.xrTableCell37.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.picBoxMySign1});
            this.xrTableCell37.Name = "xrTableCell37";
            this.xrTableCell37.Weight = 1D;
            // 
            // picBoxMySign1
            // 
            this.picBoxMySign1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxMySign1.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMySign1.Image")));
            this.picBoxMySign1.LocationFloat = new DevExpress.Utils.PointFloat(22.91667F, 75.58746F);
            this.picBoxMySign1.Name = "picBoxMySign1";
            this.picBoxMySign1.SizeF = new System.Drawing.SizeF(164.5833F, 56.15431F);
            this.picBoxMySign1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxMySign1.StylePriority.UseBorders = false;
            // 
            // xrTableCell38
            // 
            this.xrTableCell38.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblPemakaianCashColl1,
            this.lblPemakaianCashColl2,
            this.picBoxPemakaianCashColl2,
            this.picBoxPemakaianCashColl1});
            this.xrTableCell38.Name = "xrTableCell38";
            this.xrTableCell38.Weight = 1D;
            // 
            // lblPemakaianCashColl1
            // 
            this.lblPemakaianCashColl1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPemakaianCashColl1.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPemakaianCashColl1.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPemakaianCashColl1.LocationFloat = new DevExpress.Utils.PointFloat(72.86177F, 104.4918F);
            this.lblPemakaianCashColl1.Name = "lblPemakaianCashColl1";
            this.lblPemakaianCashColl1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPemakaianCashColl1.SizeF = new System.Drawing.SizeF(132.8911F, 13.62502F);
            this.lblPemakaianCashColl1.StylePriority.UseBorders = false;
            this.lblPemakaianCashColl1.StylePriority.UseFont = false;
            this.lblPemakaianCashColl1.StylePriority.UseForeColor = false;
            this.lblPemakaianCashColl1.Text = "Approve datetime";
            this.lblPemakaianCashColl1.Visible = false;
            // 
            // lblPemakaianCashColl2
            // 
            this.lblPemakaianCashColl2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPemakaianCashColl2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPemakaianCashColl2.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPemakaianCashColl2.LocationFloat = new DevExpress.Utils.PointFloat(72.86177F, 118.1168F);
            this.lblPemakaianCashColl2.Name = "lblPemakaianCashColl2";
            this.lblPemakaianCashColl2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPemakaianCashColl2.SizeF = new System.Drawing.SizeF(132.8911F, 13.62502F);
            this.lblPemakaianCashColl2.StylePriority.UseBorders = false;
            this.lblPemakaianCashColl2.StylePriority.UseFont = false;
            this.lblPemakaianCashColl2.StylePriority.UseForeColor = false;
            this.lblPemakaianCashColl2.Text = "Note";
            this.lblPemakaianCashColl2.Visible = false;
            // 
            // picBoxPemakaianCashColl2
            // 
            this.picBoxPemakaianCashColl2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPemakaianCashColl2.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPemakaianCashColl2.Image")));
            this.picBoxPemakaianCashColl2.LocationFloat = new DevExpress.Utils.PointFloat(9.332848F, 10.0001F);
            this.picBoxPemakaianCashColl2.Name = "picBoxPemakaianCashColl2";
            this.picBoxPemakaianCashColl2.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxPemakaianCashColl2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPemakaianCashColl2.StylePriority.UseBorders = false;
            this.picBoxPemakaianCashColl2.Visible = false;
            // 
            // picBoxPemakaianCashColl1
            // 
            this.picBoxPemakaianCashColl1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPemakaianCashColl1.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPemakaianCashColl1.Image")));
            this.picBoxPemakaianCashColl1.LocationFloat = new DevExpress.Utils.PointFloat(9.332848F, 10.00005F);
            this.picBoxPemakaianCashColl1.Name = "picBoxPemakaianCashColl1";
            this.picBoxPemakaianCashColl1.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxPemakaianCashColl1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPemakaianCashColl1.StylePriority.UseBorders = false;
            this.picBoxPemakaianCashColl1.Visible = false;
            // 
            // xrTableCell39
            // 
            this.xrTableCell39.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblPemakaianCashColl3,
            this.lblPemakaianCashColl4,
            this.picBoxPemakaianCashColl4,
            this.picBoxPemakaianCashColl3});
            this.xrTableCell39.Name = "xrTableCell39";
            this.xrTableCell39.Weight = 1D;
            // 
            // lblPemakaianCashColl3
            // 
            this.lblPemakaianCashColl3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPemakaianCashColl3.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPemakaianCashColl3.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPemakaianCashColl3.LocationFloat = new DevExpress.Utils.PointFloat(72.8618F, 104.4917F);
            this.lblPemakaianCashColl3.Name = "lblPemakaianCashColl3";
            this.lblPemakaianCashColl3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPemakaianCashColl3.SizeF = new System.Drawing.SizeF(132.8911F, 13.62502F);
            this.lblPemakaianCashColl3.StylePriority.UseBorders = false;
            this.lblPemakaianCashColl3.StylePriority.UseFont = false;
            this.lblPemakaianCashColl3.StylePriority.UseForeColor = false;
            this.lblPemakaianCashColl3.Text = "Approve datetime";
            this.lblPemakaianCashColl3.Visible = false;
            // 
            // lblPemakaianCashColl4
            // 
            this.lblPemakaianCashColl4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPemakaianCashColl4.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPemakaianCashColl4.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPemakaianCashColl4.LocationFloat = new DevExpress.Utils.PointFloat(72.8618F, 118.1167F);
            this.lblPemakaianCashColl4.Name = "lblPemakaianCashColl4";
            this.lblPemakaianCashColl4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPemakaianCashColl4.SizeF = new System.Drawing.SizeF(132.8911F, 13.62502F);
            this.lblPemakaianCashColl4.StylePriority.UseBorders = false;
            this.lblPemakaianCashColl4.StylePriority.UseFont = false;
            this.lblPemakaianCashColl4.StylePriority.UseForeColor = false;
            this.lblPemakaianCashColl4.Text = "Note";
            this.lblPemakaianCashColl4.Visible = false;
            // 
            // picBoxPemakaianCashColl4
            // 
            this.picBoxPemakaianCashColl4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPemakaianCashColl4.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPemakaianCashColl4.Image")));
            this.picBoxPemakaianCashColl4.LocationFloat = new DevExpress.Utils.PointFloat(10.00004F, 10.00005F);
            this.picBoxPemakaianCashColl4.Name = "picBoxPemakaianCashColl4";
            this.picBoxPemakaianCashColl4.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxPemakaianCashColl4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPemakaianCashColl4.StylePriority.UseBorders = false;
            this.picBoxPemakaianCashColl4.Visible = false;
            // 
            // picBoxPemakaianCashColl3
            // 
            this.picBoxPemakaianCashColl3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPemakaianCashColl3.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPemakaianCashColl3.Image")));
            this.picBoxPemakaianCashColl3.LocationFloat = new DevExpress.Utils.PointFloat(10.0001F, 10.00004F);
            this.picBoxPemakaianCashColl3.Name = "picBoxPemakaianCashColl3";
            this.picBoxPemakaianCashColl3.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxPemakaianCashColl3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPemakaianCashColl3.StylePriority.UseBorders = false;
            this.picBoxPemakaianCashColl3.Visible = false;
            // 
            // xrTableRow17
            // 
            this.xrTableRow17.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableRow17.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell40,
            this.xrTableCell44,
            this.xrTableCell49});
            this.xrTableRow17.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrTableRow17.Name = "xrTableRow17";
            this.xrTableRow17.StylePriority.UseBorders = false;
            this.xrTableRow17.StylePriority.UseFont = false;
            this.xrTableRow17.StylePriority.UseTextAlignment = false;
            this.xrTableRow17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableRow17.Weight = 0.31999998620345649D;
            // 
            // xrTableCell40
            // 
            this.xrTableCell40.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MemoFrom]")});
            this.xrTableCell40.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.xrTableCell40.Name = "xrTableCell40";
            this.xrTableCell40.StylePriority.UseFont = false;
            this.xrTableCell40.StylePriority.UseTextAlignment = false;
            this.xrTableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableCell40.Weight = 1D;
            // 
            // xrTableCell44
            // 
            this.xrTableCell44.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.xrTableCell44.Name = "xrTableCell44";
            this.xrTableCell44.StylePriority.UseFont = false;
            this.xrTableCell44.StylePriority.UseTextAlignment = false;
            this.xrTableCell44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableCell44.Weight = 1D;
            // 
            // xrTableCell49
            // 
            this.xrTableCell49.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.xrTableCell49.Name = "xrTableCell49";
            this.xrTableCell49.StylePriority.UseFont = false;
            this.xrTableCell49.StylePriority.UseTextAlignment = false;
            this.xrTableCell49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableCell49.Weight = 1D;
            // 
            // xrTableRow25
            // 
            this.xrTableRow25.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableRow25.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell70,
            this.xrTableCell71,
            this.xrTableCell72});
            this.xrTableRow25.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrTableRow25.Name = "xrTableRow25";
            this.xrTableRow25.StylePriority.UseBorders = false;
            this.xrTableRow25.StylePriority.UseFont = false;
            this.xrTableRow25.StylePriority.UseTextAlignment = false;
            this.xrTableRow25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableRow25.Weight = 0.33333338458554851D;
            // 
            // xrTableCell70
            // 
            this.xrTableCell70.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrTableCell70.Name = "xrTableCell70";
            this.xrTableCell70.StylePriority.UseFont = false;
            this.xrTableCell70.StylePriority.UseTextAlignment = false;
            this.xrTableCell70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell70.Weight = 1D;
            // 
            // xrTableCell71
            // 
            this.xrTableCell71.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell71.Name = "xrTableCell71";
            this.xrTableCell71.StylePriority.UseFont = false;
            this.xrTableCell71.StylePriority.UseTextAlignment = false;
            this.xrTableCell71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell71.Weight = 1D;
            // 
            // xrTableCell72
            // 
            this.xrTableCell72.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell72.Name = "xrTableCell72";
            this.xrTableCell72.StylePriority.UseFont = false;
            this.xrTableCell72.StylePriority.UseTextAlignment = false;
            this.xrTableCell72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell72.Weight = 1D;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(162.7982F, 307.4236F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(384.2503F, 17.79166F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "LEMBAR PERSETUJUAN INTERNAL MEMORANDUM";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTable6
            // 
            this.xrTable6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(39.29277F, 378.7325F);
            this.xrTable6.Name = "xrTable6";
            this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow18,
            this.xrTableRow26,
            this.xrTableRow19,
            this.xrTableRow22,
            this.xrTableRow23,
            this.xrTableRow27,
            this.xrTableRow20,
            this.xrTableRow21,
            this.xrTableRow24,
            this.xrTableRow28});
            this.xrTable6.SizeF = new System.Drawing.SizeF(647.2585F, 608.8553F);
            this.xrTable6.StylePriority.UseBorders = false;
            this.xrTable6.StylePriority.UseFont = false;
            this.xrTable6.StylePriority.UseTextAlignment = false;
            this.xrTable6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow18
            // 
            this.xrTableRow18.BackColor = System.Drawing.Color.Gainsboro;
            this.xrTableRow18.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell36,
            this.xrTableCell50,
            this.xrTableCell51});
            this.xrTableRow18.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableRow18.Name = "xrTableRow18";
            this.xrTableRow18.StylePriority.UseBackColor = false;
            this.xrTableRow18.StylePriority.UseFont = false;
            this.xrTableRow18.Weight = 0.33496361958647147D;
            // 
            // xrTableCell36
            // 
            this.xrTableCell36.Name = "xrTableCell36";
            this.xrTableCell36.Text = "Nama & Tanda Tangan";
            this.xrTableCell36.Weight = 1D;
            // 
            // xrTableCell50
            // 
            this.xrTableCell50.Name = "xrTableCell50";
            this.xrTableCell50.Text = "Tanggal";
            this.xrTableCell50.Weight = 1D;
            // 
            // xrTableCell51
            // 
            this.xrTableCell51.Name = "xrTableCell51";
            this.xrTableCell51.Text = "Disposisi";
            this.xrTableCell51.Weight = 1D;
            // 
            // xrTableRow26
            // 
            this.xrTableRow26.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell73,
            this.xrTableCell74,
            this.xrTableCell75});
            this.xrTableRow26.Name = "xrTableRow26";
            this.xrTableRow26.Weight = 1.3261611804842071D;
            // 
            // xrTableCell73
            // 
            this.xrTableCell73.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.picBoxPemakaianCashColl5,
            this.picBoxPemakaianCashColl6});
            this.xrTableCell73.Name = "xrTableCell73";
            this.xrTableCell73.Text = " ";
            this.xrTableCell73.Weight = 1D;
            // 
            // picBoxPemakaianCashColl5
            // 
            this.picBoxPemakaianCashColl5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPemakaianCashColl5.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPemakaianCashColl5.Image")));
            this.picBoxPemakaianCashColl5.LocationFloat = new DevExpress.Utils.PointFloat(60.70722F, 26.22662F);
            this.picBoxPemakaianCashColl5.Name = "picBoxPemakaianCashColl5";
            this.picBoxPemakaianCashColl5.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxPemakaianCashColl5.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPemakaianCashColl5.StylePriority.UseBorders = false;
            this.picBoxPemakaianCashColl5.Visible = false;
            // 
            // picBoxPemakaianCashColl6
            // 
            this.picBoxPemakaianCashColl6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPemakaianCashColl6.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPemakaianCashColl6.Image")));
            this.picBoxPemakaianCashColl6.LocationFloat = new DevExpress.Utils.PointFloat(60.70722F, 26.22655F);
            this.picBoxPemakaianCashColl6.Name = "picBoxPemakaianCashColl6";
            this.picBoxPemakaianCashColl6.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxPemakaianCashColl6.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPemakaianCashColl6.StylePriority.UseBorders = false;
            this.picBoxPemakaianCashColl6.Visible = false;
            // 
            // xrTableCell74
            // 
            this.xrTableCell74.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblPemakaianCashColl5});
            this.xrTableCell74.Name = "xrTableCell74";
            this.xrTableCell74.Text = " ";
            this.xrTableCell74.Weight = 1D;
            // 
            // lblPemakaianCashColl5
            // 
            this.lblPemakaianCashColl5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPemakaianCashColl5.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPemakaianCashColl5.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPemakaianCashColl5.LocationFloat = new DevExpress.Utils.PointFloat(10.00004F, 52.96605F);
            this.lblPemakaianCashColl5.Name = "lblPemakaianCashColl5";
            this.lblPemakaianCashColl5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPemakaianCashColl5.SizeF = new System.Drawing.SizeF(195.7528F, 13.62499F);
            this.lblPemakaianCashColl5.StylePriority.UseBorders = false;
            this.lblPemakaianCashColl5.StylePriority.UseFont = false;
            this.lblPemakaianCashColl5.StylePriority.UseForeColor = false;
            this.lblPemakaianCashColl5.StylePriority.UseTextAlignment = false;
            this.lblPemakaianCashColl5.Text = "Approve datetime";
            this.lblPemakaianCashColl5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblPemakaianCashColl5.Visible = false;
            // 
            // xrTableCell75
            // 
            this.xrTableCell75.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblPemakaianCashColl6});
            this.xrTableCell75.Name = "xrTableCell75";
            this.xrTableCell75.Text = " ";
            this.xrTableCell75.Weight = 1D;
            // 
            // lblPemakaianCashColl6
            // 
            this.lblPemakaianCashColl6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPemakaianCashColl6.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPemakaianCashColl6.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPemakaianCashColl6.LocationFloat = new DevExpress.Utils.PointFloat(12.33139F, 52.96618F);
            this.lblPemakaianCashColl6.Name = "lblPemakaianCashColl6";
            this.lblPemakaianCashColl6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPemakaianCashColl6.SizeF = new System.Drawing.SizeF(193.4216F, 14.39873F);
            this.lblPemakaianCashColl6.StylePriority.UseBorders = false;
            this.lblPemakaianCashColl6.StylePriority.UseFont = false;
            this.lblPemakaianCashColl6.StylePriority.UseForeColor = false;
            this.lblPemakaianCashColl6.StylePriority.UseTextAlignment = false;
            this.lblPemakaianCashColl6.Text = "Note";
            this.lblPemakaianCashColl6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblPemakaianCashColl6.Visible = false;
            // 
            // xrTableRow19
            // 
            this.xrTableRow19.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell52,
            this.xrTableCell53,
            this.xrTableCell54});
            this.xrTableRow19.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrTableRow19.Name = "xrTableRow19";
            this.xrTableRow19.StylePriority.UseFont = false;
            this.xrTableRow19.StylePriority.UseTextAlignment = false;
            this.xrTableRow19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableRow19.Weight = 0.21418133076930235D;
            // 
            // xrTableCell52
            // 
            this.xrTableCell52.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell52.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.xrTableCell52.Name = "xrTableCell52";
            this.xrTableCell52.StylePriority.UseBorders = false;
            this.xrTableCell52.StylePriority.UseFont = false;
            this.xrTableCell52.StylePriority.UseTextAlignment = false;
            this.xrTableCell52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableCell52.Weight = 1D;
            // 
            // xrTableCell53
            // 
            this.xrTableCell53.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell53.Name = "xrTableCell53";
            this.xrTableCell53.StylePriority.UseBorders = false;
            this.xrTableCell53.Weight = 1D;
            // 
            // xrTableCell54
            // 
            this.xrTableCell54.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell54.Name = "xrTableCell54";
            this.xrTableCell54.StylePriority.UseBorders = false;
            this.xrTableCell54.Weight = 1D;
            // 
            // xrTableRow22
            // 
            this.xrTableRow22.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell61,
            this.xrTableCell62,
            this.xrTableCell63});
            this.xrTableRow22.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrTableRow22.Name = "xrTableRow22";
            this.xrTableRow22.StylePriority.UseFont = false;
            this.xrTableRow22.StylePriority.UseTextAlignment = false;
            this.xrTableRow22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableRow22.Weight = 0.21760327302164578D;
            // 
            // xrTableCell61
            // 
            this.xrTableCell61.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell61.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell61.Name = "xrTableCell61";
            this.xrTableCell61.StylePriority.UseBorders = false;
            this.xrTableCell61.StylePriority.UseFont = false;
            this.xrTableCell61.StylePriority.UseTextAlignment = false;
            this.xrTableCell61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell61.Weight = 1D;
            // 
            // xrTableCell62
            // 
            this.xrTableCell62.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell62.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell62.Name = "xrTableCell62";
            this.xrTableCell62.StylePriority.UseBorders = false;
            this.xrTableCell62.StylePriority.UseFont = false;
            this.xrTableCell62.StylePriority.UseTextAlignment = false;
            this.xrTableCell62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell62.Weight = 1D;
            // 
            // xrTableCell63
            // 
            this.xrTableCell63.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell63.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell63.Name = "xrTableCell63";
            this.xrTableCell63.StylePriority.UseBorders = false;
            this.xrTableCell63.StylePriority.UseFont = false;
            this.xrTableCell63.StylePriority.UseTextAlignment = false;
            this.xrTableCell63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell63.Weight = 1D;
            // 
            // xrTableRow23
            // 
            this.xrTableRow23.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableRow23.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell641,
            this.xrTableCell65,
            this.xrTableCell66});
            this.xrTableRow23.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrTableRow23.Name = "xrTableRow23";
            this.xrTableRow23.StylePriority.UseBorders = false;
            this.xrTableRow23.StylePriority.UseFont = false;
            this.xrTableRow23.StylePriority.UseTextAlignment = false;
            this.xrTableRow23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableRow23.Weight = 1.3031778163753085D;
            // 
            // xrTableCell641
            // 
            this.xrTableCell641.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.picBoxPemakaianCashColl8,
            this.picBoxPemakaianCashColl7});
            this.xrTableCell641.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.xrTableCell641.Name = "xrTableCell641";
            this.xrTableCell641.StylePriority.UseFont = false;
            this.xrTableCell641.StylePriority.UseTextAlignment = false;
            this.xrTableCell641.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableCell641.Weight = 1D;
            // 
            // picBoxPemakaianCashColl8
            // 
            this.picBoxPemakaianCashColl8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPemakaianCashColl8.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPemakaianCashColl8.Image")));
            this.picBoxPemakaianCashColl8.LocationFloat = new DevExpress.Utils.PointFloat(60.70722F, 24.58324F);
            this.picBoxPemakaianCashColl8.Name = "picBoxPemakaianCashColl8";
            this.picBoxPemakaianCashColl8.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxPemakaianCashColl8.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPemakaianCashColl8.StylePriority.UseBorders = false;
            this.picBoxPemakaianCashColl8.Visible = false;
            // 
            // picBoxPemakaianCashColl7
            // 
            this.picBoxPemakaianCashColl7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPemakaianCashColl7.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPemakaianCashColl7.Image")));
            this.picBoxPemakaianCashColl7.LocationFloat = new DevExpress.Utils.PointFloat(60.70722F, 24.58331F);
            this.picBoxPemakaianCashColl7.Name = "picBoxPemakaianCashColl7";
            this.picBoxPemakaianCashColl7.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxPemakaianCashColl7.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPemakaianCashColl7.StylePriority.UseBorders = false;
            this.picBoxPemakaianCashColl7.Visible = false;
            // 
            // xrTableCell65
            // 
            this.xrTableCell65.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblPemakaianCashColl7});
            this.xrTableCell65.Name = "xrTableCell65";
            this.xrTableCell65.Weight = 1D;
            // 
            // lblPemakaianCashColl7
            // 
            this.lblPemakaianCashColl7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPemakaianCashColl7.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPemakaianCashColl7.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPemakaianCashColl7.LocationFloat = new DevExpress.Utils.PointFloat(10.00004F, 58.53119F);
            this.lblPemakaianCashColl7.Name = "lblPemakaianCashColl7";
            this.lblPemakaianCashColl7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPemakaianCashColl7.SizeF = new System.Drawing.SizeF(195.7528F, 13.62495F);
            this.lblPemakaianCashColl7.StylePriority.UseBorders = false;
            this.lblPemakaianCashColl7.StylePriority.UseFont = false;
            this.lblPemakaianCashColl7.StylePriority.UseForeColor = false;
            this.lblPemakaianCashColl7.StylePriority.UseTextAlignment = false;
            this.lblPemakaianCashColl7.Text = "Approve datetime";
            this.lblPemakaianCashColl7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblPemakaianCashColl7.Visible = false;
            // 
            // xrTableCell66
            // 
            this.xrTableCell66.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblPemakaianCashColl8});
            this.xrTableCell66.Name = "xrTableCell66";
            this.xrTableCell66.Weight = 1D;
            // 
            // lblPemakaianCashColl8
            // 
            this.lblPemakaianCashColl8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPemakaianCashColl8.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPemakaianCashColl8.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPemakaianCashColl8.LocationFloat = new DevExpress.Utils.PointFloat(12.33139F, 58.53106F);
            this.lblPemakaianCashColl8.Name = "lblPemakaianCashColl8";
            this.lblPemakaianCashColl8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPemakaianCashColl8.SizeF = new System.Drawing.SizeF(193.4215F, 13.62502F);
            this.lblPemakaianCashColl8.StylePriority.UseBorders = false;
            this.lblPemakaianCashColl8.StylePriority.UseFont = false;
            this.lblPemakaianCashColl8.StylePriority.UseForeColor = false;
            this.lblPemakaianCashColl8.StylePriority.UseTextAlignment = false;
            this.lblPemakaianCashColl8.Text = "Note";
            this.lblPemakaianCashColl8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblPemakaianCashColl8.Visible = false;
            // 
            // xrTableRow27
            // 
            this.xrTableRow27.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell64,
            this.xrTableCell77,
            this.xrTableCell78});
            this.xrTableRow27.Name = "xrTableRow27";
            this.xrTableRow27.Weight = 0.24694500151341417D;
            // 
            // xrTableCell64
            // 
            this.xrTableCell64.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell64.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell64.Name = "xrTableCell64";
            this.xrTableCell64.StylePriority.UseBorders = false;
            this.xrTableCell64.StylePriority.UseFont = false;
            this.xrTableCell64.StylePriority.UseTextAlignment = false;
            this.xrTableCell64.Text = " ";
            this.xrTableCell64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableCell64.Weight = 1D;
            // 
            // xrTableCell77
            // 
            this.xrTableCell77.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell77.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell77.Name = "xrTableCell77";
            this.xrTableCell77.StylePriority.UseBorders = false;
            this.xrTableCell77.StylePriority.UseFont = false;
            this.xrTableCell77.StylePriority.UseTextAlignment = false;
            this.xrTableCell77.Text = " ";
            this.xrTableCell77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell77.Weight = 1D;
            // 
            // xrTableCell78
            // 
            this.xrTableCell78.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell78.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell78.Name = "xrTableCell78";
            this.xrTableCell78.StylePriority.UseBorders = false;
            this.xrTableCell78.StylePriority.UseFont = false;
            this.xrTableCell78.StylePriority.UseTextAlignment = false;
            this.xrTableCell78.Text = " ";
            this.xrTableCell78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell78.Weight = 1D;
            // 
            // xrTableRow20
            // 
            this.xrTableRow20.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableRow20.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell55,
            this.xrTableCell56,
            this.xrTableCell57});
            this.xrTableRow20.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrTableRow20.Name = "xrTableRow20";
            this.xrTableRow20.StylePriority.UseBorders = false;
            this.xrTableRow20.StylePriority.UseFont = false;
            this.xrTableRow20.StylePriority.UseTextAlignment = false;
            this.xrTableRow20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableRow20.Weight = 0.24694500151341417D;
            // 
            // xrTableCell55
            // 
            this.xrTableCell55.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell55.Name = "xrTableCell55";
            this.xrTableCell55.StylePriority.UseFont = false;
            this.xrTableCell55.StylePriority.UseTextAlignment = false;
            this.xrTableCell55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell55.Weight = 1D;
            // 
            // xrTableCell56
            // 
            this.xrTableCell56.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell56.Name = "xrTableCell56";
            this.xrTableCell56.StylePriority.UseFont = false;
            this.xrTableCell56.StylePriority.UseTextAlignment = false;
            this.xrTableCell56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell56.Weight = 1D;
            // 
            // xrTableCell57
            // 
            this.xrTableCell57.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell57.Name = "xrTableCell57";
            this.xrTableCell57.StylePriority.UseFont = false;
            this.xrTableCell57.StylePriority.UseTextAlignment = false;
            this.xrTableCell57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell57.Weight = 1D;
            // 
            // xrTableRow21
            // 
            this.xrTableRow21.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableRow21.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell581,
            this.xrTableCell59,
            this.xrTableCell60});
            this.xrTableRow21.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrTableRow21.Name = "xrTableRow21";
            this.xrTableRow21.StylePriority.UseBorders = false;
            this.xrTableRow21.StylePriority.UseFont = false;
            this.xrTableRow21.StylePriority.UseTextAlignment = false;
            this.xrTableRow21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableRow21.Weight = 1.312956660701514D;
            // 
            // xrTableCell581
            // 
            this.xrTableCell581.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.picBoxPemakaianCashColl10,
            this.picBoxPemakaianCashColl9});
            this.xrTableCell581.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.xrTableCell581.Name = "xrTableCell581";
            this.xrTableCell581.StylePriority.UseFont = false;
            this.xrTableCell581.StylePriority.UseTextAlignment = false;
            this.xrTableCell581.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableCell581.Weight = 1D;
            // 
            // picBoxPemakaianCashColl10
            // 
            this.picBoxPemakaianCashColl10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPemakaianCashColl10.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPemakaianCashColl10.Image")));
            this.picBoxPemakaianCashColl10.LocationFloat = new DevExpress.Utils.PointFloat(60.70724F, 24.75696F);
            this.picBoxPemakaianCashColl10.Name = "picBoxPemakaianCashColl10";
            this.picBoxPemakaianCashColl10.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxPemakaianCashColl10.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPemakaianCashColl10.StylePriority.UseBorders = false;
            this.picBoxPemakaianCashColl10.Visible = false;
            // 
            // picBoxPemakaianCashColl9
            // 
            this.picBoxPemakaianCashColl9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPemakaianCashColl9.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPemakaianCashColl9.Image")));
            this.picBoxPemakaianCashColl9.LocationFloat = new DevExpress.Utils.PointFloat(60.70722F, 24.75696F);
            this.picBoxPemakaianCashColl9.Name = "picBoxPemakaianCashColl9";
            this.picBoxPemakaianCashColl9.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxPemakaianCashColl9.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPemakaianCashColl9.StylePriority.UseBorders = false;
            this.picBoxPemakaianCashColl9.Visible = false;
            // 
            // xrTableCell59
            // 
            this.xrTableCell59.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblPemakaianCashColl9});
            this.xrTableCell59.Name = "xrTableCell59";
            this.xrTableCell59.Weight = 1D;
            // 
            // lblPemakaianCashColl9
            // 
            this.lblPemakaianCashColl9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPemakaianCashColl9.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPemakaianCashColl9.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPemakaianCashColl9.LocationFloat = new DevExpress.Utils.PointFloat(9.332789F, 62.69794F);
            this.lblPemakaianCashColl9.Name = "lblPemakaianCashColl9";
            this.lblPemakaianCashColl9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPemakaianCashColl9.SizeF = new System.Drawing.SizeF(196.42F, 13.62498F);
            this.lblPemakaianCashColl9.StylePriority.UseBorders = false;
            this.lblPemakaianCashColl9.StylePriority.UseFont = false;
            this.lblPemakaianCashColl9.StylePriority.UseForeColor = false;
            this.lblPemakaianCashColl9.StylePriority.UseTextAlignment = false;
            this.lblPemakaianCashColl9.Text = "Approve datetime";
            this.lblPemakaianCashColl9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblPemakaianCashColl9.Visible = false;
            // 
            // xrTableCell60
            // 
            this.xrTableCell60.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblPemakaianCashColl10});
            this.xrTableCell60.Name = "xrTableCell60";
            this.xrTableCell60.Weight = 1D;
            // 
            // lblPemakaianCashColl10
            // 
            this.lblPemakaianCashColl10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPemakaianCashColl10.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPemakaianCashColl10.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPemakaianCashColl10.LocationFloat = new DevExpress.Utils.PointFloat(12.33138F, 62.69794F);
            this.lblPemakaianCashColl10.Name = "lblPemakaianCashColl10";
            this.lblPemakaianCashColl10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPemakaianCashColl10.SizeF = new System.Drawing.SizeF(193.4215F, 13.62493F);
            this.lblPemakaianCashColl10.StylePriority.UseBorders = false;
            this.lblPemakaianCashColl10.StylePriority.UseFont = false;
            this.lblPemakaianCashColl10.StylePriority.UseForeColor = false;
            this.lblPemakaianCashColl10.StylePriority.UseTextAlignment = false;
            this.lblPemakaianCashColl10.Text = "Note";
            this.lblPemakaianCashColl10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblPemakaianCashColl10.Visible = false;
            // 
            // xrTableRow24
            // 
            this.xrTableRow24.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableRow24.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell58,
            this.xrTableCell68,
            this.xrTableCell69});
            this.xrTableRow24.Name = "xrTableRow24";
            this.xrTableRow24.StylePriority.UseBorders = false;
            this.xrTableRow24.StylePriority.UseTextAlignment = false;
            this.xrTableRow24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableRow24.Weight = 0.25672871938243014D;
            // 
            // xrTableCell58
            // 
            this.xrTableCell58.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell58.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell58.Name = "xrTableCell58";
            this.xrTableCell58.StylePriority.UseBorders = false;
            this.xrTableCell58.StylePriority.UseFont = false;
            this.xrTableCell58.StylePriority.UseTextAlignment = false;
            this.xrTableCell58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableCell58.Weight = 1D;
            // 
            // xrTableCell68
            // 
            this.xrTableCell68.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell68.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell68.Name = "xrTableCell68";
            this.xrTableCell68.StylePriority.UseBorders = false;
            this.xrTableCell68.StylePriority.UseFont = false;
            this.xrTableCell68.StylePriority.UseTextAlignment = false;
            this.xrTableCell68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell68.Weight = 1D;
            // 
            // xrTableCell69
            // 
            this.xrTableCell69.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell69.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell69.Name = "xrTableCell69";
            this.xrTableCell69.StylePriority.UseBorders = false;
            this.xrTableCell69.StylePriority.UseFont = false;
            this.xrTableCell69.StylePriority.UseTextAlignment = false;
            this.xrTableCell69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell69.Weight = 1D;
            // 
            // xrTableRow28
            // 
            this.xrTableRow28.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell67,
            this.xrTableCell79,
            this.xrTableCell80});
            this.xrTableRow28.Name = "xrTableRow28";
            this.xrTableRow28.Weight = 0.25672871938243014D;
            // 
            // xrTableCell67
            // 
            this.xrTableCell67.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell67.Name = "xrTableCell67";
            this.xrTableCell67.StylePriority.UseFont = false;
            this.xrTableCell67.StylePriority.UseTextAlignment = false;
            this.xrTableCell67.Text = " ";
            this.xrTableCell67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell67.Weight = 1D;
            // 
            // xrTableCell79
            // 
            this.xrTableCell79.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell79.Name = "xrTableCell79";
            this.xrTableCell79.StylePriority.UseFont = false;
            this.xrTableCell79.StylePriority.UseTextAlignment = false;
            this.xrTableCell79.Text = " ";
            this.xrTableCell79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell79.Weight = 1D;
            // 
            // xrTableCell80
            // 
            this.xrTableCell80.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell80.Name = "xrTableCell80";
            this.xrTableCell80.StylePriority.UseFont = false;
            this.xrTableCell80.StylePriority.UseTextAlignment = false;
            this.xrTableCell80.Text = " ";
            this.xrTableCell80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell80.Weight = 1D;
            // 
            // docInternalMemoPemakaianCashColl
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.DetailReport,
            this.GroupHeader1,
            this.GroupFooter,
            this.ReportFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "InternalMemo";
            this.DataSource = this.sqlDataSource1;
            this.Margins = new System.Drawing.Printing.Margins(50, 50, 70, 76);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.DocNo,
            this.DocKey});
            this.ScriptsSource = "private void xrTableCell44_BeforePrint(object sender, System.Drawing.Printing.Pri" +
    "ntEventArgs e) \r\n{\r\n}\r\n";
            this.Version = "17.2";
            this.Watermark.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold);
            this.Watermark.TextTransparency = 172;
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
