using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for docInternalMemoPelepasanCrossColl
/// </summary>
public class docInternalMemoPelepasanCrossColl : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private ReportHeaderBand ReportHeader;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    private DevExpress.XtraReports.Parameters.Parameter DocNo;
    private DevExpress.XtraReports.Parameters.Parameter DocKey;
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
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell17;
    private XRTableCell xrTableCell18;
    private XRLabel xrLabel1;
    private XRLabel xrLabel2;
    private XRLabel xrLabel3;
    private GroupHeaderBand GroupHeader1;
    private XRLabel xrLabel4;
    private XRTable xrTable2;
    private XRTableRow xrTableRow7;
    private XRTableCell xrTableCell19;
    private XRTableCell xrTableCell20;
    private XRTableCell xrTableCell21;
    private XRTableCell xrTableCell22;
    private XRTableCell xrTableCell24;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell25;
    private XRTableCell xrTableCell26;
    private XRTableCell xrTableCell27;
    private XRTableCell xrTableCell28;
    private XRTableCell xrTableCell29;
    private XRTableCell xrTableCell30;
    private DetailReportBand DetailReport;
    private DetailBand Detail1;
    private XRTable xrTable3;
    private XRTableRow xrTableRow10;
    private XRTableCell xrTableCell35;
    private XRTableCell xrTableCell36;
    private XRTableCell xrTableCell37;
    private XRTableCell xrTableCell38;
    private XRTableCell xrTableCell39;
    private XRTableCell xrTableCell40;
    private GroupFooterBand GroupFooter1;
    private XRLabel xrLabel5;
    private GroupHeaderBand GroupHeader2;
    private ReportFooterBand ReportFooter;
    private XRTable xrTable5;
    private XRTableRow xrTableRow12;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell34;
    private XRTableRow xrTableRow13;
    private XRTableCell xrTableCell31;
    private XRTableCell xrTableCell33;
    private XRTableRow xrTableRow17;
    private XRTableCell xrTableCell41;
    private XRTableCell xrTableCell49;
    private XRTableRow xrTableRow25;
    private XRTableCell xrTableCell72;
    private XRTable xrTable4;
    private XRTableRow xrTableRow9;
    private XRTableCell xrTableCell43;
    private XRTableRow xrTableRow11;
    private XRTableCell xrTableCell47;
    private XRTableRow xrTableRow15;
    private XRTableCell xrTableCell42;
    private XRTableCell xrTableCell45;
    private XRTableCell xrTableCell46;
    private XRPageBreak xrPageBreak1;
    private XRTable xrTable8;
    private XRTableRow xrTableRow23;
    private XRTableCell xrTableCell68;
    private XRTableCell xrTableCell69;
    private XRTableCell xrTableCell73;
    private XRTableRow xrTableRow24;
    private XRTableCell xrTableCell74;
    private XRTableCell xrTableCell75;
    private XRTableCell xrTableCell76;
    private XRTableRow xrTableRow26;
    private XRTableCell xrTableCell77;
    private XRTableCell xrTableCell78;
    private XRTableCell xrTableCell79;
    private XRTable xrTable7;
    private XRTableRow xrTableRow20;
    private XRTableCell xrTableCell59;
    private XRTableCell xrTableCell60;
    private XRTableCell xrTableCell61;
    private XRTableRow xrTableRow21;
    private XRTableCell xrTableCell62;
    private XRTableCell xrTableCell63;
    private XRTableCell xrTableCell64;
    private XRTableRow xrTableRow22;
    private XRTableCell xrTableCell65;
    private XRTableCell xrTableCell66;
    private XRTableCell xrTableCell67;
    private XRTable xrTable6;
    private XRTableRow xrTableRow16;
    private XRTableCell xrTableCell48;
    private XRTableCell xrTableCell50;
    private XRTableCell xrTableCell51;
    private XRTableRow xrTableRow18;
    private XRTableCell xrTableCell53;
    private XRTableCell xrTableCell54;
    private XRTableCell xrTableCell55;
    private XRTableRow xrTableRow19;
    private XRTableCell xrTableCell56;
    private XRTableCell xrTableCell57;
    private XRTableCell xrTableCell58;
    private XRTable xrTable9;
    private XRTableRow xrTableRow27;
    private XRTableCell xrTableCell80;
    private XRTableCell xrTableCell81;
    private XRTableCell xrTableCell82;
    private XRTableRow xrTableRow28;
    private XRTableCell xrTableCell83;
    private XRTableCell xrTableCell84;
    private XRTableCell xrTableCell85;
    private XRTableRow xrTableRow29;
    private XRTableCell xrTableCell86;
    private XRTableCell xrTableCell87;
    private XRTableCell xrTableCell88;
    private XRPageInfo xrPageInfo1;
    private XRLabel xrLabel8;
    private XRLabel xrLabel14;
    private XRLabel xrLabel15;
    private XRPictureBox picBoxPelepasanCrossColl1;
    private XRPictureBox picBoxPelepasanCrossColl2;
    private XRLabel lblPelepasanCrossColl1;
    private XRLabel lblPelepasanCrossColl2;
    private XRPictureBox picBoxPelepasanCrossColl9;
    private XRPictureBox picBoxPelepasanCrossColl10;
    private XRLabel lblPelepasanCrossColl9;
    private XRLabel lblPelepasanCrossColl10;
    private XRPictureBox picBoxPelepasanCrossColl7;
    private XRPictureBox picBoxPelepasanCrossColl8;
    private XRLabel lblPelepasanCrossColl7;
    private XRLabel lblPelepasanCrossColl8;
    private XRPictureBox picBoxPelepasanCrossColl5;
    private XRPictureBox picBoxPelepasanCrossColl6;
    private XRLabel lblPelepasanCrossColl5;
    private XRLabel lblPelepasanCrossColl6;
    private XRPictureBox picBoxPelepasanCrossColl3;
    private XRPictureBox picBoxPelepasanCrossColl4;
    private XRLabel lblPelepasanCrossColl3;
    private XRLabel lblPelepasanCrossColl4;
    private XRLabel xrLabel6;
    private XRPictureBox picBoxMySign1;
    private XRTableCell xrTableCell70;
    private XRTable xrTable10;
    private XRTableRow xrTableRow14;
    private XRTableCell xrTableCell32;
    private XRPictureBox picBoxPelepasanCrossColl11;
    private XRPictureBox picBoxPelepasanCrossColl12;
    private XRTableCell xrTableCell44;
    private XRLabel lblPelepasanCrossColl11;
    private XRTableCell xrTableCell52;
    private XRLabel lblPelepasanCrossColl12;
    private XRTableRow xrTableRow30;
    private XRTableCell xrTableCell71;
    private XRTableCell xrTableCell89;
    private XRTableCell xrTableCell90;
    private XRTableRow xrTableRow31;
    private XRTableCell xrTableCell91;
    private XRTableCell xrTableCell92;
    private XRTableCell xrTableCell93;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public docInternalMemoPelepasanCrossColl()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(docInternalMemoPelepasanCrossColl));
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
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
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
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.DocNo = new DevExpress.XtraReports.Parameters.Parameter();
            this.DocKey = new DevExpress.XtraReports.Parameters.Parameter();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable9 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow27 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell80 = new DevExpress.XtraReports.UI.XRTableCell();
            this.picBoxPelepasanCrossColl9 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.picBoxPelepasanCrossColl10 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableCell81 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblPelepasanCrossColl9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell82 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblPelepasanCrossColl10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow28 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell83 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell84 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell85 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow29 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell86 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell87 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell88 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable8 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow23 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell68 = new DevExpress.XtraReports.UI.XRTableCell();
            this.picBoxPelepasanCrossColl7 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.picBoxPelepasanCrossColl8 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableCell69 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblPelepasanCrossColl7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell73 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblPelepasanCrossColl8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow24 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell74 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell75 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell76 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow26 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell77 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell78 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell79 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable7 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow20 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell59 = new DevExpress.XtraReports.UI.XRTableCell();
            this.picBoxPelepasanCrossColl5 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.picBoxPelepasanCrossColl6 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableCell60 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblPelepasanCrossColl5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell61 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblPelepasanCrossColl6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow21 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell62 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell63 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell64 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow22 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell65 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell66 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell67 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
            this.picBoxMySign1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblPelepasanCrossColl1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblPelepasanCrossColl2 = new DevExpress.XtraReports.UI.XRLabel();
            this.picBoxPelepasanCrossColl1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.picBoxPelepasanCrossColl2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableRow17 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell41 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell49 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow25 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell70 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell72 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell43 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell47 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow15 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell42 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell45 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell46 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrPageBreak1 = new DevExpress.XtraReports.UI.XRPageBreak();
            this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow16 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell48 = new DevExpress.XtraReports.UI.XRTableCell();
            this.picBoxPelepasanCrossColl3 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.picBoxPelepasanCrossColl4 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableCell50 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblPelepasanCrossColl3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell51 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblPelepasanCrossColl4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow18 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell53 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell54 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell55 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow19 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell56 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell57 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell58 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable10 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow14 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
            this.picBoxPelepasanCrossColl11 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.picBoxPelepasanCrossColl12 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableCell44 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblPelepasanCrossColl11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell52 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblPelepasanCrossColl12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow30 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell71 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell89 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell90 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow31 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell91 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell92 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell93 = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable10)).BeginInit();
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
            this.xrLabel3});
            this.TopMargin.HeightF = 49.16666F;
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
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(35.41667F, 25.70833F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(265.625F, 15.70835F);
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseForeColor = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "xrLabel8";
            // 
            // xrLabel3
            // 
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DocNo]")});
            this.xrLabel3.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.xrLabel3.ForeColor = System.Drawing.Color.DarkGray;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(35.41667F, 10.00001F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(166.6666F, 15.70832F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "INTERNAL MEMORANDUM";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1,
            this.xrLabel8,
            this.xrLabel14});
            this.BottomMargin.HeightF = 69F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold);
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(355.9969F, 10.42811F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(26.04166F, 16.75002F);
            this.xrPageInfo1.StylePriority.UseFont = false;
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel8
            // 
            this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DocNo]")});
            this.xrLabel8.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.xrLabel8.ForeColor = System.Drawing.Color.DarkGray;
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(35.41667F, 28.13644F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(133.3333F, 15.70835F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseForeColor = false;
            this.xrLabel8.Text = "xrLabel8";
            // 
            // xrLabel14
            // 
            this.xrLabel14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MemoPerihal]")});
            this.xrLabel14.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.xrLabel14.ForeColor = System.Drawing.Color.DarkGray;
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(35.41797F, 43.8446F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(320.5804F, 13.62502F);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseForeColor = false;
            this.xrLabel14.Text = "xrLabel14";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.xrTable1,
            this.xrLabel1,
            this.xrLabel2});
            this.ReportHeader.HeightF = 195.5208F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrLine1
            // 
            this.xrLine1.LineWidth = 2;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(35.41924F, 178.2646F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(647.2585F, 7.142548F);
            // 
            // xrTable1
            // 
            this.xrTable1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(35.41924F, 51.20831F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1,
            this.xrTableRow3,
            this.xrTableRow4,
            this.xrTableRow2,
            this.xrTableRow5,
            this.xrTableRow6});
            this.xrTable1.SizeF = new System.Drawing.SizeF(647.2572F, 116.6667F);
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
            this.xrTableCell16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.StylePriority.UseFont = false;
            this.xrTableCell16.Text = "No. Kontrak";
            this.xrTableCell16.Weight = 1.1096236359843479D;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.StylePriority.UseFont = false;
            this.xrTableCell17.Text = ":";
            this.xrTableCell17.Weight = 0.15524725618000446D;
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MemoRefNo]")});
            this.xrTableCell18.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.StylePriority.UseFont = false;
            this.xrTableCell18.Text = "xrTableCell18";
            this.xrTableCell18.Weight = 6.2551291078356472D;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Tahoma", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(35.41667F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(647.2585F, 26.12499F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "INTERNAL MEMORANDUM";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrLabel2
            // 
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DocNo]")});
            this.xrLabel2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(35.41797F, 26.12499F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(647.2572F, 25.08332F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "INTERNAL MEMORANDUM";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "SqlLocalConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "InternalMemo";
            queryParameter1.Name = "DocNo";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.DocNo]", typeof(string));
            customSqlQuery1.Parameters.Add(queryParameter1);
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            customSqlQuery2.Name = "InternalMemoApprovalList";
            queryParameter2.Name = "DocKey";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.DocKey]", typeof(int));
            customSqlQuery2.Parameters.Add(queryParameter2);
            customSqlQuery2.Sql = resources.GetString("customSqlQuery2.Sql");
            customSqlQuery3.Name = "InternalMemoDetailPelepasanCrossColl";
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
            masterDetailInfo2.DetailQueryName = "InternalMemoDetailPelepasanCrossColl";
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
            // DocKey
            // 
            this.DocKey.Description = "DocKey";
            this.DocKey.Name = "DocKey";
            this.DocKey.Type = typeof(int);
            this.DocKey.ValueInfo = "0";
            this.DocKey.Visible = false;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.GroupHeader1.HeightF = 60.00001F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrTable2
            // 
            this.xrTable2.BackColor = System.Drawing.Color.Gainsboro;
            this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(35.4167F, 10.00001F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow7,
            this.xrTableRow8});
            this.xrTable2.SizeF = new System.Drawing.SizeF(647.2585F, 50F);
            this.xrTable2.StylePriority.UseBackColor = false;
            this.xrTable2.StylePriority.UseBorders = false;
            this.xrTable2.StylePriority.UseFont = false;
            this.xrTable2.StylePriority.UseTextAlignment = false;
            this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell19,
            this.xrTableCell20,
            this.xrTableCell21,
            this.xrTableCell22,
            this.xrTableCell24});
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.Weight = 1D;
            // 
            // xrTableCell19
            // 
            this.xrTableCell19.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell19.Name = "xrTableCell19";
            this.xrTableCell19.StylePriority.UseBorders = false;
            this.xrTableCell19.Weight = 1D;
            // 
            // xrTableCell20
            // 
            this.xrTableCell20.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell20.Name = "xrTableCell20";
            this.xrTableCell20.StylePriority.UseBorders = false;
            this.xrTableCell20.Weight = 1D;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.StylePriority.UseBorders = false;
            this.xrTableCell21.Weight = 1D;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.StylePriority.UseBorders = false;
            this.xrTableCell22.Weight = 1D;
            // 
            // xrTableCell24
            // 
            this.xrTableCell24.Name = "xrTableCell24";
            this.xrTableCell24.StylePriority.UseTextAlignment = false;
            this.xrTableCell24.Text = "Kondisi Pembayaran";
            this.xrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell24.Weight = 2D;
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell25,
            this.xrTableCell26,
            this.xrTableCell27,
            this.xrTableCell28,
            this.xrTableCell29,
            this.xrTableCell30});
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.Weight = 1D;
            // 
            // xrTableCell25
            // 
            this.xrTableCell25.Name = "xrTableCell25";
            this.xrTableCell25.Text = "Agreement";
            this.xrTableCell25.Weight = 1D;
            // 
            // xrTableCell26
            // 
            this.xrTableCell26.Name = "xrTableCell26";
            this.xrTableCell26.Text = "Asset Desc";
            this.xrTableCell26.Weight = 1D;
            // 
            // xrTableCell27
            // 
            this.xrTableCell27.Name = "xrTableCell27";
            this.xrTableCell27.Text = "Market Values";
            this.xrTableCell27.Weight = 1D;
            // 
            // xrTableCell28
            // 
            this.xrTableCell28.Name = "xrTableCell28";
            this.xrTableCell28.Text = "OSPH";
            this.xrTableCell28.Weight = 1D;
            // 
            // xrTableCell29
            // 
            this.xrTableCell29.Name = "xrTableCell29";
            this.xrTableCell29.Text = "Cicilan Ke / Tenor";
            this.xrTableCell29.Weight = 1D;
            // 
            // xrTableCell30
            // 
            this.xrTableCell30.Name = "xrTableCell30";
            this.xrTableCell30.Text = "Denda Berjalan";
            this.xrTableCell30.Weight = 1D;
            // 
            // xrLabel4
            // 
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[HeaderText]")});
            this.xrLabel4.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(35.41671F, 0F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(647.2585F, 33.15624F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "xrLabel4";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1});
            this.DetailReport.DataMember = "InternalMemoDetailPelepasanCrossColl";
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
            this.xrTable3.Font = new System.Drawing.Font("Tahoma", 6.75F);
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(35.41667F, 0F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow10});
            this.xrTable3.SizeF = new System.Drawing.SizeF(647.2585F, 25F);
            this.xrTable3.StylePriority.UseBorders = false;
            this.xrTable3.StylePriority.UseFont = false;
            this.xrTable3.StylePriority.UseTextAlignment = false;
            this.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow10
            // 
            this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell35,
            this.xrTableCell36,
            this.xrTableCell37,
            this.xrTableCell38,
            this.xrTableCell39,
            this.xrTableCell40});
            this.xrTableRow10.Name = "xrTableRow10";
            this.xrTableRow10.Weight = 1D;
            // 
            // xrTableCell35
            // 
            this.xrTableCell35.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AgreementNo]")});
            this.xrTableCell35.Name = "xrTableCell35";
            this.xrTableCell35.Text = "Agreement";
            this.xrTableCell35.Weight = 1D;
            // 
            // xrTableCell36
            // 
            this.xrTableCell36.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AssetDesc]")});
            this.xrTableCell36.Name = "xrTableCell36";
            this.xrTableCell36.Text = "Asset Desc";
            this.xrTableCell36.Weight = 1D;
            // 
            // xrTableCell37
            // 
            this.xrTableCell37.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ValueAsset]")});
            this.xrTableCell37.Name = "xrTableCell37";
            this.xrTableCell37.Text = "Market Values";
            this.xrTableCell37.TextFormatString = "{0:Rp #,##.00}";
            this.xrTableCell37.Weight = 1D;
            // 
            // xrTableCell38
            // 
            this.xrTableCell38.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OSPH]")});
            this.xrTableCell38.Name = "xrTableCell38";
            this.xrTableCell38.Text = "OSPH";
            this.xrTableCell38.TextFormatString = "{0:Rp #,##.00}";
            this.xrTableCell38.Weight = 1D;
            // 
            // xrTableCell39
            // 
            this.xrTableCell39.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CicilanTenor]")});
            this.xrTableCell39.Name = "xrTableCell39";
            this.xrTableCell39.Text = "Cicilan Ke / Tenor";
            this.xrTableCell39.Weight = 1D;
            // 
            // xrTableCell40
            // 
            this.xrTableCell40.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DendaBerjalan]")});
            this.xrTableCell40.Name = "xrTableCell40";
            this.xrTableCell40.Text = "Denda Berjalan";
            this.xrTableCell40.TextFormatString = "{0:Rp #,##.00}";
            this.xrTableCell40.Weight = 1D;
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5});
            this.GroupFooter1.HeightF = 36.87499F;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // xrLabel5
            // 
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FooterText]")});
            this.xrLabel5.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(35.41667F, 8.041636F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(647.2585F, 18.83335F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "xrLabel5";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4});
            this.GroupHeader2.HeightF = 33.15624F;
            this.GroupHeader2.Level = 1;
            this.GroupHeader2.Name = "GroupHeader2";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable10,
            this.xrLabel6,
            this.xrTable9,
            this.xrTable8,
            this.xrTable7,
            this.xrTable5,
            this.xrTable4,
            this.xrPageBreak1,
            this.xrTable6});
            this.ReportFooter.HeightF = 1108.239F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrLabel6
            // 
            this.xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel6.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.xrLabel6.ForeColor = System.Drawing.Color.DarkGray;
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(35.41924F, 1065.864F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(647.2585F, 13.62506F);
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseForeColor = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "** Internal Memo ini tidak memerlukan tanda tangan basah, semua proses aproval di" +
    "lakukan by system.";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTable9
            // 
            this.xrTable9.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable9.LocationFloat = new DevExpress.Utils.PointFloat(35.4167F, 749.2106F);
            this.xrTable9.Name = "xrTable9";
            this.xrTable9.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow27,
            this.xrTableRow28,
            this.xrTableRow29});
            this.xrTable9.SizeF = new System.Drawing.SizeF(647.2585F, 149.8105F);
            this.xrTable9.StylePriority.UseBorders = false;
            this.xrTable9.StylePriority.UseFont = false;
            this.xrTable9.StylePriority.UseTextAlignment = false;
            this.xrTable9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrTableRow27
            // 
            this.xrTableRow27.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell80,
            this.xrTableCell81,
            this.xrTableCell82});
            this.xrTableRow27.Name = "xrTableRow27";
            this.xrTableRow27.Weight = 1.9671304719991394D;
            // 
            // xrTableCell80
            // 
            this.xrTableCell80.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell80.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.picBoxPelepasanCrossColl9,
            this.picBoxPelepasanCrossColl10});
            this.xrTableCell80.Name = "xrTableCell80";
            this.xrTableCell80.StylePriority.UseBorders = false;
            this.xrTableCell80.Weight = 1.0000003536173594D;
            // 
            // picBoxPelepasanCrossColl9
            // 
            this.picBoxPelepasanCrossColl9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPelepasanCrossColl9.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPelepasanCrossColl9.Image")));
            this.picBoxPelepasanCrossColl9.LocationFloat = new DevExpress.Utils.PointFloat(82.525F, 3.933843F);
            this.picBoxPelepasanCrossColl9.Name = "picBoxPelepasanCrossColl9";
            this.picBoxPelepasanCrossColl9.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxPelepasanCrossColl9.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPelepasanCrossColl9.StylePriority.UseBorders = false;
            this.picBoxPelepasanCrossColl9.Visible = false;
            // 
            // picBoxPelepasanCrossColl10
            // 
            this.picBoxPelepasanCrossColl10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPelepasanCrossColl10.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPelepasanCrossColl10.Image")));
            this.picBoxPelepasanCrossColl10.LocationFloat = new DevExpress.Utils.PointFloat(82.52499F, 3.933834F);
            this.picBoxPelepasanCrossColl10.Name = "picBoxPelepasanCrossColl10";
            this.picBoxPelepasanCrossColl10.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxPelepasanCrossColl10.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPelepasanCrossColl10.StylePriority.UseBorders = false;
            this.picBoxPelepasanCrossColl10.Visible = false;
            // 
            // xrTableCell81
            // 
            this.xrTableCell81.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell81.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblPelepasanCrossColl9});
            this.xrTableCell81.Name = "xrTableCell81";
            this.xrTableCell81.StylePriority.UseBorders = false;
            this.xrTableCell81.Weight = 0.64959235462295306D;
            // 
            // lblPelepasanCrossColl9
            // 
            this.lblPelepasanCrossColl9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPelepasanCrossColl9.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPelepasanCrossColl9.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPelepasanCrossColl9.LocationFloat = new DevExpress.Utils.PointFloat(0F, 42.30366F);
            this.lblPelepasanCrossColl9.Name = "lblPelepasanCrossColl9";
            this.lblPelepasanCrossColl9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPelepasanCrossColl9.SizeF = new System.Drawing.SizeF(130.1514F, 13.62502F);
            this.lblPelepasanCrossColl9.StylePriority.UseBorders = false;
            this.lblPelepasanCrossColl9.StylePriority.UseFont = false;
            this.lblPelepasanCrossColl9.StylePriority.UseForeColor = false;
            this.lblPelepasanCrossColl9.StylePriority.UseTextAlignment = false;
            this.lblPelepasanCrossColl9.Text = "Approve datetime";
            this.lblPelepasanCrossColl9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblPelepasanCrossColl9.Visible = false;
            // 
            // xrTableCell82
            // 
            this.xrTableCell82.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell82.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblPelepasanCrossColl10});
            this.xrTableCell82.Name = "xrTableCell82";
            this.xrTableCell82.StylePriority.UseBorders = false;
            this.xrTableCell82.Weight = 1.3504072917596877D;
            // 
            // lblPelepasanCrossColl10
            // 
            this.lblPelepasanCrossColl10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPelepasanCrossColl10.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPelepasanCrossColl10.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPelepasanCrossColl10.LocationFloat = new DevExpress.Utils.PointFloat(24.27651F, 42.30359F);
            this.lblPelepasanCrossColl10.Name = "lblPelepasanCrossColl10";
            this.lblPelepasanCrossColl10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPelepasanCrossColl10.SizeF = new System.Drawing.SizeF(242.8012F, 13.62508F);
            this.lblPelepasanCrossColl10.StylePriority.UseBorders = false;
            this.lblPelepasanCrossColl10.StylePriority.UseFont = false;
            this.lblPelepasanCrossColl10.StylePriority.UseForeColor = false;
            this.lblPelepasanCrossColl10.StylePriority.UseTextAlignment = false;
            this.lblPelepasanCrossColl10.Text = "Note";
            this.lblPelepasanCrossColl10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblPelepasanCrossColl10.Visible = false;
            // 
            // xrTableRow28
            // 
            this.xrTableRow28.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell83,
            this.xrTableCell84,
            this.xrTableCell85});
            this.xrTableRow28.Name = "xrTableRow28";
            this.xrTableRow28.Weight = 0.52591626753516818D;
            // 
            // xrTableCell83
            // 
            this.xrTableCell83.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell83.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.xrTableCell83.Name = "xrTableCell83";
            this.xrTableCell83.StylePriority.UseBorders = false;
            this.xrTableCell83.StylePriority.UseFont = false;
            this.xrTableCell83.Weight = 1.0000003536173594D;
            // 
            // xrTableCell84
            // 
            this.xrTableCell84.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell84.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrTableCell84.Name = "xrTableCell84";
            this.xrTableCell84.StylePriority.UseBorders = false;
            this.xrTableCell84.StylePriority.UseFont = false;
            this.xrTableCell84.Weight = 0.64959235462295306D;
            // 
            // xrTableCell85
            // 
            this.xrTableCell85.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell85.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrTableCell85.Name = "xrTableCell85";
            this.xrTableCell85.StylePriority.UseBorders = false;
            this.xrTableCell85.StylePriority.UseFont = false;
            this.xrTableCell85.Weight = 1.3504072917596877D;
            // 
            // xrTableRow29
            // 
            this.xrTableRow29.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell86,
            this.xrTableCell87,
            this.xrTableCell88});
            this.xrTableRow29.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.xrTableRow29.Name = "xrTableRow29";
            this.xrTableRow29.StylePriority.UseFont = false;
            this.xrTableRow29.StylePriority.UseTextAlignment = false;
            this.xrTableRow29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableRow29.Weight = 0.50695326046569233D;
            // 
            // xrTableCell86
            // 
            this.xrTableCell86.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell86.Name = "xrTableCell86";
            this.xrTableCell86.StylePriority.UseFont = false;
            this.xrTableCell86.Weight = 1.0000003536173594D;
            // 
            // xrTableCell87
            // 
            this.xrTableCell87.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell87.Name = "xrTableCell87";
            this.xrTableCell87.StylePriority.UseFont = false;
            this.xrTableCell87.Weight = 0.64959235462295306D;
            // 
            // xrTableCell88
            // 
            this.xrTableCell88.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell88.Name = "xrTableCell88";
            this.xrTableCell88.StylePriority.UseFont = false;
            this.xrTableCell88.Weight = 1.3504072917596877D;
            // 
            // xrTable8
            // 
            this.xrTable8.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable8.LocationFloat = new DevExpress.Utils.PointFloat(35.4167F, 599.4F);
            this.xrTable8.Name = "xrTable8";
            this.xrTable8.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow23,
            this.xrTableRow24,
            this.xrTableRow26});
            this.xrTable8.SizeF = new System.Drawing.SizeF(647.2585F, 149.8105F);
            this.xrTable8.StylePriority.UseBorders = false;
            // 
            // xrTableRow23
            // 
            this.xrTableRow23.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell68,
            this.xrTableCell69,
            this.xrTableCell73});
            this.xrTableRow23.Name = "xrTableRow23";
            this.xrTableRow23.Weight = 1.9671304719991394D;
            // 
            // xrTableCell68
            // 
            this.xrTableCell68.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell68.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.picBoxPelepasanCrossColl7,
            this.picBoxPelepasanCrossColl8});
            this.xrTableCell68.Name = "xrTableCell68";
            this.xrTableCell68.StylePriority.UseBorders = false;
            this.xrTableCell68.Weight = 1.0000003536173594D;
            // 
            // picBoxPelepasanCrossColl7
            // 
            this.picBoxPelepasanCrossColl7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPelepasanCrossColl7.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPelepasanCrossColl7.Image")));
            this.picBoxPelepasanCrossColl7.LocationFloat = new DevExpress.Utils.PointFloat(82.525F, 3.933779F);
            this.picBoxPelepasanCrossColl7.Name = "picBoxPelepasanCrossColl7";
            this.picBoxPelepasanCrossColl7.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxPelepasanCrossColl7.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPelepasanCrossColl7.StylePriority.UseBorders = false;
            this.picBoxPelepasanCrossColl7.Visible = false;
            // 
            // picBoxPelepasanCrossColl8
            // 
            this.picBoxPelepasanCrossColl8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPelepasanCrossColl8.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPelepasanCrossColl8.Image")));
            this.picBoxPelepasanCrossColl8.LocationFloat = new DevExpress.Utils.PointFloat(82.52499F, 3.933834F);
            this.picBoxPelepasanCrossColl8.Name = "picBoxPelepasanCrossColl8";
            this.picBoxPelepasanCrossColl8.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxPelepasanCrossColl8.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPelepasanCrossColl8.StylePriority.UseBorders = false;
            this.picBoxPelepasanCrossColl8.Visible = false;
            // 
            // xrTableCell69
            // 
            this.xrTableCell69.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell69.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblPelepasanCrossColl7});
            this.xrTableCell69.Name = "xrTableCell69";
            this.xrTableCell69.StylePriority.UseBorders = false;
            this.xrTableCell69.Weight = 0.64959235462295306D;
            // 
            // lblPelepasanCrossColl7
            // 
            this.lblPelepasanCrossColl7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPelepasanCrossColl7.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPelepasanCrossColl7.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPelepasanCrossColl7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 42.30359F);
            this.lblPelepasanCrossColl7.Name = "lblPelepasanCrossColl7";
            this.lblPelepasanCrossColl7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPelepasanCrossColl7.SizeF = new System.Drawing.SizeF(130.1514F, 13.62502F);
            this.lblPelepasanCrossColl7.StylePriority.UseBorders = false;
            this.lblPelepasanCrossColl7.StylePriority.UseFont = false;
            this.lblPelepasanCrossColl7.StylePriority.UseForeColor = false;
            this.lblPelepasanCrossColl7.StylePriority.UseTextAlignment = false;
            this.lblPelepasanCrossColl7.Text = "Approve datetime";
            this.lblPelepasanCrossColl7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblPelepasanCrossColl7.Visible = false;
            // 
            // xrTableCell73
            // 
            this.xrTableCell73.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell73.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblPelepasanCrossColl8});
            this.xrTableCell73.Name = "xrTableCell73";
            this.xrTableCell73.StylePriority.UseBorders = false;
            this.xrTableCell73.Weight = 1.3504072917596877D;
            // 
            // lblPelepasanCrossColl8
            // 
            this.lblPelepasanCrossColl8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPelepasanCrossColl8.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPelepasanCrossColl8.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPelepasanCrossColl8.LocationFloat = new DevExpress.Utils.PointFloat(24.27651F, 42.30359F);
            this.lblPelepasanCrossColl8.Name = "lblPelepasanCrossColl8";
            this.lblPelepasanCrossColl8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPelepasanCrossColl8.SizeF = new System.Drawing.SizeF(242.8012F, 13.62508F);
            this.lblPelepasanCrossColl8.StylePriority.UseBorders = false;
            this.lblPelepasanCrossColl8.StylePriority.UseFont = false;
            this.lblPelepasanCrossColl8.StylePriority.UseForeColor = false;
            this.lblPelepasanCrossColl8.StylePriority.UseTextAlignment = false;
            this.lblPelepasanCrossColl8.Text = "Note";
            this.lblPelepasanCrossColl8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblPelepasanCrossColl8.Visible = false;
            // 
            // xrTableRow24
            // 
            this.xrTableRow24.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell74,
            this.xrTableCell75,
            this.xrTableCell76});
            this.xrTableRow24.Name = "xrTableRow24";
            this.xrTableRow24.Weight = 0.52591626753516818D;
            // 
            // xrTableCell74
            // 
            this.xrTableCell74.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell74.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.xrTableCell74.Name = "xrTableCell74";
            this.xrTableCell74.StylePriority.UseBorders = false;
            this.xrTableCell74.StylePriority.UseFont = false;
            this.xrTableCell74.StylePriority.UseTextAlignment = false;
            this.xrTableCell74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableCell74.Weight = 1.0000003536173594D;
            // 
            // xrTableCell75
            // 
            this.xrTableCell75.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell75.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell75.Name = "xrTableCell75";
            this.xrTableCell75.StylePriority.UseBorders = false;
            this.xrTableCell75.StylePriority.UseFont = false;
            this.xrTableCell75.Weight = 0.64959235462295306D;
            // 
            // xrTableCell76
            // 
            this.xrTableCell76.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell76.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell76.Name = "xrTableCell76";
            this.xrTableCell76.StylePriority.UseBorders = false;
            this.xrTableCell76.StylePriority.UseFont = false;
            this.xrTableCell76.Weight = 1.3504072917596877D;
            // 
            // xrTableRow26
            // 
            this.xrTableRow26.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell77,
            this.xrTableCell78,
            this.xrTableCell79});
            this.xrTableRow26.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableRow26.Name = "xrTableRow26";
            this.xrTableRow26.StylePriority.UseFont = false;
            this.xrTableRow26.StylePriority.UseTextAlignment = false;
            this.xrTableRow26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableRow26.Weight = 0.50695326046569233D;
            // 
            // xrTableCell77
            // 
            this.xrTableCell77.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell77.Name = "xrTableCell77";
            this.xrTableCell77.StylePriority.UseFont = false;
            this.xrTableCell77.Weight = 1.0000003536173594D;
            // 
            // xrTableCell78
            // 
            this.xrTableCell78.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell78.Name = "xrTableCell78";
            this.xrTableCell78.StylePriority.UseFont = false;
            this.xrTableCell78.Weight = 0.64959235462295306D;
            // 
            // xrTableCell79
            // 
            this.xrTableCell79.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell79.Name = "xrTableCell79";
            this.xrTableCell79.StylePriority.UseFont = false;
            this.xrTableCell79.Weight = 1.3504072917596877D;
            // 
            // xrTable7
            // 
            this.xrTable7.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable7.LocationFloat = new DevExpress.Utils.PointFloat(35.4167F, 449.5896F);
            this.xrTable7.Name = "xrTable7";
            this.xrTable7.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow20,
            this.xrTableRow21,
            this.xrTableRow22});
            this.xrTable7.SizeF = new System.Drawing.SizeF(647.2585F, 149.8105F);
            this.xrTable7.StylePriority.UseBorders = false;
            this.xrTable7.StylePriority.UseFont = false;
            this.xrTable7.StylePriority.UseTextAlignment = false;
            this.xrTable7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrTableRow20
            // 
            this.xrTableRow20.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell59,
            this.xrTableCell60,
            this.xrTableCell61});
            this.xrTableRow20.Name = "xrTableRow20";
            this.xrTableRow20.Weight = 1.9671304719991394D;
            // 
            // xrTableCell59
            // 
            this.xrTableCell59.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell59.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.picBoxPelepasanCrossColl5,
            this.picBoxPelepasanCrossColl6});
            this.xrTableCell59.Name = "xrTableCell59";
            this.xrTableCell59.StylePriority.UseBorders = false;
            this.xrTableCell59.Weight = 1.000000070723472D;
            // 
            // picBoxPelepasanCrossColl5
            // 
            this.picBoxPelepasanCrossColl5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPelepasanCrossColl5.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPelepasanCrossColl5.Image")));
            this.picBoxPelepasanCrossColl5.LocationFloat = new DevExpress.Utils.PointFloat(82.525F, 3.933843F);
            this.picBoxPelepasanCrossColl5.Name = "picBoxPelepasanCrossColl5";
            this.picBoxPelepasanCrossColl5.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxPelepasanCrossColl5.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPelepasanCrossColl5.StylePriority.UseBorders = false;
            this.picBoxPelepasanCrossColl5.Visible = false;
            // 
            // picBoxPelepasanCrossColl6
            // 
            this.picBoxPelepasanCrossColl6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPelepasanCrossColl6.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPelepasanCrossColl6.Image")));
            this.picBoxPelepasanCrossColl6.LocationFloat = new DevExpress.Utils.PointFloat(82.52496F, 3.933834F);
            this.picBoxPelepasanCrossColl6.Name = "picBoxPelepasanCrossColl6";
            this.picBoxPelepasanCrossColl6.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxPelepasanCrossColl6.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPelepasanCrossColl6.StylePriority.UseBorders = false;
            this.picBoxPelepasanCrossColl6.Visible = false;
            // 
            // xrTableCell60
            // 
            this.xrTableCell60.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell60.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblPelepasanCrossColl5});
            this.xrTableCell60.Name = "xrTableCell60";
            this.xrTableCell60.StylePriority.UseBorders = false;
            this.xrTableCell60.Weight = 0.6495926375168406D;
            // 
            // lblPelepasanCrossColl5
            // 
            this.lblPelepasanCrossColl5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPelepasanCrossColl5.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPelepasanCrossColl5.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPelepasanCrossColl5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 42.30359F);
            this.lblPelepasanCrossColl5.Name = "lblPelepasanCrossColl5";
            this.lblPelepasanCrossColl5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPelepasanCrossColl5.SizeF = new System.Drawing.SizeF(130.1515F, 13.62499F);
            this.lblPelepasanCrossColl5.StylePriority.UseBorders = false;
            this.lblPelepasanCrossColl5.StylePriority.UseFont = false;
            this.lblPelepasanCrossColl5.StylePriority.UseForeColor = false;
            this.lblPelepasanCrossColl5.StylePriority.UseTextAlignment = false;
            this.lblPelepasanCrossColl5.Text = "Approve datetime";
            this.lblPelepasanCrossColl5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblPelepasanCrossColl5.Visible = false;
            // 
            // xrTableCell61
            // 
            this.xrTableCell61.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell61.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblPelepasanCrossColl6});
            this.xrTableCell61.Name = "xrTableCell61";
            this.xrTableCell61.StylePriority.UseBorders = false;
            this.xrTableCell61.Weight = 1.3504072917596877D;
            // 
            // lblPelepasanCrossColl6
            // 
            this.lblPelepasanCrossColl6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPelepasanCrossColl6.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPelepasanCrossColl6.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPelepasanCrossColl6.LocationFloat = new DevExpress.Utils.PointFloat(24.27651F, 42.30359F);
            this.lblPelepasanCrossColl6.Name = "lblPelepasanCrossColl6";
            this.lblPelepasanCrossColl6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPelepasanCrossColl6.SizeF = new System.Drawing.SizeF(242.8012F, 13.62508F);
            this.lblPelepasanCrossColl6.StylePriority.UseBorders = false;
            this.lblPelepasanCrossColl6.StylePriority.UseFont = false;
            this.lblPelepasanCrossColl6.StylePriority.UseForeColor = false;
            this.lblPelepasanCrossColl6.StylePriority.UseTextAlignment = false;
            this.lblPelepasanCrossColl6.Text = "Note";
            this.lblPelepasanCrossColl6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblPelepasanCrossColl6.Visible = false;
            // 
            // xrTableRow21
            // 
            this.xrTableRow21.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell62,
            this.xrTableCell63,
            this.xrTableCell64});
            this.xrTableRow21.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrTableRow21.Name = "xrTableRow21";
            this.xrTableRow21.StylePriority.UseFont = false;
            this.xrTableRow21.StylePriority.UseTextAlignment = false;
            this.xrTableRow21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableRow21.Weight = 0.52591626753516818D;
            // 
            // xrTableCell62
            // 
            this.xrTableCell62.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell62.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.xrTableCell62.Name = "xrTableCell62";
            this.xrTableCell62.StylePriority.UseBorders = false;
            this.xrTableCell62.StylePriority.UseFont = false;
            this.xrTableCell62.StylePriority.UseTextAlignment = false;
            this.xrTableCell62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableCell62.Weight = 1.000000070723472D;
            // 
            // xrTableCell63
            // 
            this.xrTableCell63.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell63.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrTableCell63.Name = "xrTableCell63";
            this.xrTableCell63.StylePriority.UseBorders = false;
            this.xrTableCell63.StylePriority.UseFont = false;
            this.xrTableCell63.Weight = 0.6495926375168406D;
            // 
            // xrTableCell64
            // 
            this.xrTableCell64.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell64.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrTableCell64.Name = "xrTableCell64";
            this.xrTableCell64.StylePriority.UseBorders = false;
            this.xrTableCell64.StylePriority.UseFont = false;
            this.xrTableCell64.Weight = 1.3504072917596877D;
            // 
            // xrTableRow22
            // 
            this.xrTableRow22.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell65,
            this.xrTableCell66,
            this.xrTableCell67});
            this.xrTableRow22.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.xrTableRow22.Name = "xrTableRow22";
            this.xrTableRow22.StylePriority.UseFont = false;
            this.xrTableRow22.StylePriority.UseTextAlignment = false;
            this.xrTableRow22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableRow22.Weight = 0.50695326046569233D;
            // 
            // xrTableCell65
            // 
            this.xrTableCell65.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell65.Name = "xrTableCell65";
            this.xrTableCell65.StylePriority.UseFont = false;
            this.xrTableCell65.Weight = 1.000000070723472D;
            // 
            // xrTableCell66
            // 
            this.xrTableCell66.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell66.Name = "xrTableCell66";
            this.xrTableCell66.StylePriority.UseFont = false;
            this.xrTableCell66.Weight = 0.6495926375168406D;
            // 
            // xrTableCell67
            // 
            this.xrTableCell67.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell67.Name = "xrTableCell67";
            this.xrTableCell67.StylePriority.UseFont = false;
            this.xrTableCell67.Weight = 1.3504072917596877D;
            // 
            // xrTable5
            // 
            this.xrTable5.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom;
            this.xrTable5.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable5.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(35.41667F, 0F);
            this.xrTable5.Name = "xrTable5";
            this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow12,
            this.xrTableRow13,
            this.xrTableRow17,
            this.xrTableRow25});
            this.xrTable5.SizeF = new System.Drawing.SizeF(647.2585F, 133.3334F);
            this.xrTable5.StylePriority.UseBorders = false;
            this.xrTable5.StylePriority.UseFont = false;
            // 
            // xrTableRow12
            // 
            this.xrTableRow12.BackColor = System.Drawing.Color.Gainsboro;
            this.xrTableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell23,
            this.xrTableCell34});
            this.xrTableRow12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableRow12.Name = "xrTableRow12";
            this.xrTableRow12.StylePriority.UseBackColor = false;
            this.xrTableRow12.StylePriority.UseFont = false;
            this.xrTableRow12.StylePriority.UseTextAlignment = false;
            this.xrTableRow12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableRow12.Weight = 0.37288139731197034D;
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.CanGrow = false;
            this.xrTableCell23.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.StylePriority.UseFont = false;
            this.xrTableCell23.Text = "Diajukan Oleh";
            this.xrTableCell23.Weight = 1D;
            // 
            // xrTableCell34
            // 
            this.xrTableCell34.CanGrow = false;
            this.xrTableCell34.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell34.Name = "xrTableCell34";
            this.xrTableCell34.StylePriority.UseFont = false;
            this.xrTableCell34.StylePriority.UseTextAlignment = false;
            this.xrTableCell34.Text = "Mengetahui";
            this.xrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell34.Weight = 2D;
            // 
            // xrTableRow13
            // 
            this.xrTableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell31,
            this.xrTableCell33});
            this.xrTableRow13.Name = "xrTableRow13";
            this.xrTableRow13.Weight = 1.4647347363929502D;
            // 
            // xrTableCell31
            // 
            this.xrTableCell31.CanGrow = false;
            this.xrTableCell31.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.picBoxMySign1});
            this.xrTableCell31.Name = "xrTableCell31";
            this.xrTableCell31.Weight = 1D;
            // 
            // picBoxMySign1
            // 
            this.picBoxMySign1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxMySign1.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMySign1.Image")));
            this.picBoxMySign1.LocationFloat = new DevExpress.Utils.PointFloat(33.85289F, 20.9959F);
            this.picBoxMySign1.Name = "picBoxMySign1";
            this.picBoxMySign1.SizeF = new System.Drawing.SizeF(144.1666F, 36.01211F);
            this.picBoxMySign1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxMySign1.StylePriority.UseBorders = false;
            // 
            // xrTableCell33
            // 
            this.xrTableCell33.CanGrow = false;
            this.xrTableCell33.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblPelepasanCrossColl1,
            this.lblPelepasanCrossColl2,
            this.picBoxPelepasanCrossColl1,
            this.picBoxPelepasanCrossColl2});
            this.xrTableCell33.Name = "xrTableCell33";
            this.xrTableCell33.Weight = 2D;
            // 
            // lblPelepasanCrossColl1
            // 
            this.lblPelepasanCrossColl1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPelepasanCrossColl1.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPelepasanCrossColl1.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPelepasanCrossColl1.LocationFloat = new DevExpress.Utils.PointFloat(192.8363F, 29.75794F);
            this.lblPelepasanCrossColl1.Name = "lblPelepasanCrossColl1";
            this.lblPelepasanCrossColl1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPelepasanCrossColl1.SizeF = new System.Drawing.SizeF(153.2179F, 13.62502F);
            this.lblPelepasanCrossColl1.StylePriority.UseBorders = false;
            this.lblPelepasanCrossColl1.StylePriority.UseFont = false;
            this.lblPelepasanCrossColl1.StylePriority.UseForeColor = false;
            this.lblPelepasanCrossColl1.Text = "Approve datetime";
            this.lblPelepasanCrossColl1.Visible = false;
            // 
            // lblPelepasanCrossColl2
            // 
            this.lblPelepasanCrossColl2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPelepasanCrossColl2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPelepasanCrossColl2.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPelepasanCrossColl2.LocationFloat = new DevExpress.Utils.PointFloat(192.8363F, 43.38296F);
            this.lblPelepasanCrossColl2.Name = "lblPelepasanCrossColl2";
            this.lblPelepasanCrossColl2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPelepasanCrossColl2.SizeF = new System.Drawing.SizeF(153.2179F, 13.62502F);
            this.lblPelepasanCrossColl2.StylePriority.UseBorders = false;
            this.lblPelepasanCrossColl2.StylePriority.UseFont = false;
            this.lblPelepasanCrossColl2.StylePriority.UseForeColor = false;
            this.lblPelepasanCrossColl2.Text = "Note";
            this.lblPelepasanCrossColl2.Visible = false;
            // 
            // picBoxPelepasanCrossColl1
            // 
            this.picBoxPelepasanCrossColl1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPelepasanCrossColl1.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPelepasanCrossColl1.Image")));
            this.picBoxPelepasanCrossColl1.LocationFloat = new DevExpress.Utils.PointFloat(120.2562F, 3.178914E-05F);
            this.picBoxPelepasanCrossColl1.Name = "picBoxPelepasanCrossColl1";
            this.picBoxPelepasanCrossColl1.SizeF = new System.Drawing.SizeF(72.58F, 65.77F);
            this.picBoxPelepasanCrossColl1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPelepasanCrossColl1.StylePriority.UseBorders = false;
            this.picBoxPelepasanCrossColl1.Visible = false;
            // 
            // picBoxPelepasanCrossColl2
            // 
            this.picBoxPelepasanCrossColl2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPelepasanCrossColl2.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPelepasanCrossColl2.Image")));
            this.picBoxPelepasanCrossColl2.LocationFloat = new DevExpress.Utils.PointFloat(120.2583F, 6.357829E-05F);
            this.picBoxPelepasanCrossColl2.Name = "picBoxPelepasanCrossColl2";
            this.picBoxPelepasanCrossColl2.SizeF = new System.Drawing.SizeF(72.57791F, 65.77355F);
            this.picBoxPelepasanCrossColl2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPelepasanCrossColl2.StylePriority.UseBorders = false;
            this.picBoxPelepasanCrossColl2.Visible = false;
            // 
            // xrTableRow17
            // 
            this.xrTableRow17.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableRow17.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell41,
            this.xrTableCell49});
            this.xrTableRow17.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrTableRow17.Name = "xrTableRow17";
            this.xrTableRow17.StylePriority.UseBorders = false;
            this.xrTableRow17.StylePriority.UseFont = false;
            this.xrTableRow17.StylePriority.UseTextAlignment = false;
            this.xrTableRow17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableRow17.Weight = 0.30083832770478852D;
            // 
            // xrTableCell41
            // 
            this.xrTableCell41.CanGrow = false;
            this.xrTableCell41.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MemoFrom]")});
            this.xrTableCell41.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell41.Multiline = true;
            this.xrTableCell41.Name = "xrTableCell41";
            this.xrTableCell41.StylePriority.UseFont = false;
            this.xrTableCell41.StylePriority.UseTextAlignment = false;
            this.xrTableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableCell41.Weight = 1D;
            // 
            // xrTableCell49
            // 
            this.xrTableCell49.CanGrow = false;
            this.xrTableCell49.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.xrTableCell49.Name = "xrTableCell49";
            this.xrTableCell49.StylePriority.UseFont = false;
            this.xrTableCell49.StylePriority.UseTextAlignment = false;
            this.xrTableCell49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableCell49.Weight = 2D;
            // 
            // xrTableRow25
            // 
            this.xrTableRow25.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableRow25.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell70,
            this.xrTableCell72});
            this.xrTableRow25.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrTableRow25.Name = "xrTableRow25";
            this.xrTableRow25.StylePriority.UseBorders = false;
            this.xrTableRow25.StylePriority.UseFont = false;
            this.xrTableRow25.StylePriority.UseTextAlignment = false;
            this.xrTableRow25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableRow25.Weight = 0.3141731294909762D;
            // 
            // xrTableCell70
            // 
            this.xrTableCell70.CanGrow = false;
            this.xrTableCell70.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrTableCell70.Name = "xrTableCell70";
            this.xrTableCell70.StylePriority.UseFont = false;
            this.xrTableCell70.StylePriority.UseTextAlignment = false;
            this.xrTableCell70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell70.Weight = 1D;
            // 
            // xrTableCell72
            // 
            this.xrTableCell72.CanGrow = false;
            this.xrTableCell72.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell72.Name = "xrTableCell72";
            this.xrTableCell72.StylePriority.UseFont = false;
            this.xrTableCell72.StylePriority.UseTextAlignment = false;
            this.xrTableCell72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell72.Weight = 2D;
            // 
            // xrTable4
            // 
            this.xrTable4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(35.41667F, 233.3333F);
            this.xrTable4.Name = "xrTable4";
            this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow9,
            this.xrTableRow11,
            this.xrTableRow15});
            this.xrTable4.SizeF = new System.Drawing.SizeF(647.2585F, 66.44576F);
            this.xrTable4.StylePriority.UseBorders = false;
            this.xrTable4.StylePriority.UseFont = false;
            this.xrTable4.StylePriority.UseTextAlignment = false;
            this.xrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow9
            // 
            this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell43});
            this.xrTableRow9.Name = "xrTableRow9";
            this.xrTableRow9.Weight = 0.31309647523408746D;
            // 
            // xrTableCell43
            // 
            this.xrTableCell43.Name = "xrTableCell43";
            this.xrTableCell43.Text = "LEMBAR DISPOSISI INTERNAL MEMO";
            this.xrTableCell43.Weight = 3D;
            // 
            // xrTableRow11
            // 
            this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell47});
            this.xrTableRow11.Name = "xrTableRow11";
            this.xrTableRow11.Weight = 0.40676510911675745D;
            // 
            // xrTableCell47
            // 
            this.xrTableCell47.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DocNo]")});
            this.xrTableCell47.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell47.Name = "xrTableCell47";
            this.xrTableCell47.StylePriority.UseFont = false;
            this.xrTableCell47.Text = "xrTableCell47";
            this.xrTableCell47.Weight = 3D;
            // 
            // xrTableRow15
            // 
            this.xrTableRow15.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell42,
            this.xrTableCell45,
            this.xrTableCell46});
            this.xrTableRow15.Name = "xrTableRow15";
            this.xrTableRow15.Weight = 0.37554227308113397D;
            // 
            // xrTableCell42
            // 
            this.xrTableCell42.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell42.Name = "xrTableCell42";
            this.xrTableCell42.StylePriority.UseFont = false;
            this.xrTableCell42.Text = "Komite";
            this.xrTableCell42.Weight = 1.0000002339439842D;
            // 
            // xrTableCell45
            // 
            this.xrTableCell45.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell45.Name = "xrTableCell45";
            this.xrTableCell45.StylePriority.UseFont = false;
            this.xrTableCell45.Text = "Tanggal";
            this.xrTableCell45.Weight = 0.64959261542895763D;
            // 
            // xrTableCell46
            // 
            this.xrTableCell46.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell46.Name = "xrTableCell46";
            this.xrTableCell46.StylePriority.UseFont = false;
            this.xrTableCell46.Text = "Rekomendasi";
            this.xrTableCell46.Weight = 1.3504071506270581D;
            // 
            // xrPageBreak1
            // 
            this.xrPageBreak1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 154.7917F);
            this.xrPageBreak1.Name = "xrPageBreak1";
            // 
            // xrTable6
            // 
            this.xrTable6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(35.41667F, 299.7791F);
            this.xrTable6.Name = "xrTable6";
            this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow16,
            this.xrTableRow18,
            this.xrTableRow19});
            this.xrTable6.SizeF = new System.Drawing.SizeF(647.2585F, 149.8105F);
            this.xrTable6.StylePriority.UseBorders = false;
            this.xrTable6.StylePriority.UseFont = false;
            this.xrTable6.StylePriority.UseTextAlignment = false;
            this.xrTable6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrTableRow16
            // 
            this.xrTableRow16.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell48,
            this.xrTableCell50,
            this.xrTableCell51});
            this.xrTableRow16.Name = "xrTableRow16";
            this.xrTableRow16.Weight = 1.9671304719991394D;
            // 
            // xrTableCell48
            // 
            this.xrTableCell48.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell48.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.picBoxPelepasanCrossColl3,
            this.picBoxPelepasanCrossColl4});
            this.xrTableCell48.Name = "xrTableCell48";
            this.xrTableCell48.StylePriority.UseBorders = false;
            this.xrTableCell48.Weight = 0.99999992927652814D;
            // 
            // picBoxPelepasanCrossColl3
            // 
            this.picBoxPelepasanCrossColl3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPelepasanCrossColl3.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPelepasanCrossColl3.Image")));
            this.picBoxPelepasanCrossColl3.LocationFloat = new DevExpress.Utils.PointFloat(82.52503F, 3.933843F);
            this.picBoxPelepasanCrossColl3.Name = "picBoxPelepasanCrossColl3";
            this.picBoxPelepasanCrossColl3.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxPelepasanCrossColl3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPelepasanCrossColl3.StylePriority.UseBorders = false;
            this.picBoxPelepasanCrossColl3.Visible = false;
            // 
            // picBoxPelepasanCrossColl4
            // 
            this.picBoxPelepasanCrossColl4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPelepasanCrossColl4.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPelepasanCrossColl4.Image")));
            this.picBoxPelepasanCrossColl4.LocationFloat = new DevExpress.Utils.PointFloat(82.52495F, 3.933834F);
            this.picBoxPelepasanCrossColl4.Name = "picBoxPelepasanCrossColl4";
            this.picBoxPelepasanCrossColl4.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxPelepasanCrossColl4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPelepasanCrossColl4.StylePriority.UseBorders = false;
            this.picBoxPelepasanCrossColl4.Visible = false;
            // 
            // xrTableCell50
            // 
            this.xrTableCell50.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell50.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblPelepasanCrossColl3});
            this.xrTableCell50.Name = "xrTableCell50";
            this.xrTableCell50.StylePriority.UseBorders = false;
            this.xrTableCell50.Weight = 0.649592885048992D;
            // 
            // lblPelepasanCrossColl3
            // 
            this.lblPelepasanCrossColl3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPelepasanCrossColl3.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPelepasanCrossColl3.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPelepasanCrossColl3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 42.30359F);
            this.lblPelepasanCrossColl3.Name = "lblPelepasanCrossColl3";
            this.lblPelepasanCrossColl3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPelepasanCrossColl3.SizeF = new System.Drawing.SizeF(130.1515F, 13.62505F);
            this.lblPelepasanCrossColl3.StylePriority.UseBorders = false;
            this.lblPelepasanCrossColl3.StylePriority.UseFont = false;
            this.lblPelepasanCrossColl3.StylePriority.UseForeColor = false;
            this.lblPelepasanCrossColl3.StylePriority.UseTextAlignment = false;
            this.lblPelepasanCrossColl3.Text = "Approve datetime";
            this.lblPelepasanCrossColl3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblPelepasanCrossColl3.Visible = false;
            // 
            // xrTableCell51
            // 
            this.xrTableCell51.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell51.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblPelepasanCrossColl4});
            this.xrTableCell51.Name = "xrTableCell51";
            this.xrTableCell51.StylePriority.UseBorders = false;
            this.xrTableCell51.Weight = 1.35040718567448D;
            // 
            // lblPelepasanCrossColl4
            // 
            this.lblPelepasanCrossColl4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPelepasanCrossColl4.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPelepasanCrossColl4.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPelepasanCrossColl4.LocationFloat = new DevExpress.Utils.PointFloat(27.40138F, 42.30359F);
            this.lblPelepasanCrossColl4.Name = "lblPelepasanCrossColl4";
            this.lblPelepasanCrossColl4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPelepasanCrossColl4.SizeF = new System.Drawing.SizeF(242.8012F, 13.62508F);
            this.lblPelepasanCrossColl4.StylePriority.UseBorders = false;
            this.lblPelepasanCrossColl4.StylePriority.UseFont = false;
            this.lblPelepasanCrossColl4.StylePriority.UseForeColor = false;
            this.lblPelepasanCrossColl4.StylePriority.UseTextAlignment = false;
            this.lblPelepasanCrossColl4.Text = "Note";
            this.lblPelepasanCrossColl4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblPelepasanCrossColl4.Visible = false;
            // 
            // xrTableRow18
            // 
            this.xrTableRow18.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell53,
            this.xrTableCell54,
            this.xrTableCell55});
            this.xrTableRow18.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrTableRow18.Name = "xrTableRow18";
            this.xrTableRow18.StylePriority.UseFont = false;
            this.xrTableRow18.StylePriority.UseTextAlignment = false;
            this.xrTableRow18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableRow18.Weight = 0.52591626753516818D;
            // 
            // xrTableCell53
            // 
            this.xrTableCell53.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell53.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.xrTableCell53.Name = "xrTableCell53";
            this.xrTableCell53.StylePriority.UseBorders = false;
            this.xrTableCell53.StylePriority.UseFont = false;
            this.xrTableCell53.StylePriority.UseTextAlignment = false;
            this.xrTableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableCell53.Weight = 0.99999992927652814D;
            // 
            // xrTableCell54
            // 
            this.xrTableCell54.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell54.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrTableCell54.Name = "xrTableCell54";
            this.xrTableCell54.StylePriority.UseBorders = false;
            this.xrTableCell54.StylePriority.UseFont = false;
            this.xrTableCell54.StylePriority.UseTextAlignment = false;
            this.xrTableCell54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell54.Weight = 0.649592885048992D;
            // 
            // xrTableCell55
            // 
            this.xrTableCell55.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell55.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrTableCell55.Name = "xrTableCell55";
            this.xrTableCell55.StylePriority.UseBorders = false;
            this.xrTableCell55.StylePriority.UseFont = false;
            this.xrTableCell55.StylePriority.UseTextAlignment = false;
            this.xrTableCell55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell55.Weight = 1.35040718567448D;
            // 
            // xrTableRow19
            // 
            this.xrTableRow19.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell56,
            this.xrTableCell57,
            this.xrTableCell58});
            this.xrTableRow19.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableRow19.Name = "xrTableRow19";
            this.xrTableRow19.StylePriority.UseFont = false;
            this.xrTableRow19.StylePriority.UseTextAlignment = false;
            this.xrTableRow19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableRow19.Weight = 0.50695326046569233D;
            // 
            // xrTableCell56
            // 
            this.xrTableCell56.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell56.Name = "xrTableCell56";
            this.xrTableCell56.StylePriority.UseFont = false;
            this.xrTableCell56.Weight = 0.99999992927652814D;
            // 
            // xrTableCell57
            // 
            this.xrTableCell57.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrTableCell57.Name = "xrTableCell57";
            this.xrTableCell57.StylePriority.UseFont = false;
            this.xrTableCell57.Weight = 0.649592885048992D;
            // 
            // xrTableCell58
            // 
            this.xrTableCell58.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrTableCell58.Name = "xrTableCell58";
            this.xrTableCell58.StylePriority.UseFont = false;
            this.xrTableCell58.Weight = 1.35040718567448D;
            // 
            // xrTable10
            // 
            this.xrTable10.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable10.LocationFloat = new DevExpress.Utils.PointFloat(35.41667F, 899.0212F);
            this.xrTable10.Name = "xrTable10";
            this.xrTable10.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow14,
            this.xrTableRow30,
            this.xrTableRow31});
            this.xrTable10.SizeF = new System.Drawing.SizeF(647.2585F, 149.8105F);
            this.xrTable10.StylePriority.UseBorders = false;
            this.xrTable10.StylePriority.UseFont = false;
            this.xrTable10.StylePriority.UseTextAlignment = false;
            this.xrTable10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrTableRow14
            // 
            this.xrTableRow14.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell32,
            this.xrTableCell44,
            this.xrTableCell52});
            this.xrTableRow14.Name = "xrTableRow14";
            this.xrTableRow14.Weight = 1.9671304719991394D;
            // 
            // xrTableCell32
            // 
            this.xrTableCell32.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell32.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.picBoxPelepasanCrossColl11,
            this.picBoxPelepasanCrossColl12});
            this.xrTableCell32.Name = "xrTableCell32";
            this.xrTableCell32.StylePriority.UseBorders = false;
            this.xrTableCell32.Weight = 1.0000003536173594D;
            // 
            // picBoxPelepasanCrossColl11
            // 
            this.picBoxPelepasanCrossColl11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPelepasanCrossColl11.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPelepasanCrossColl11.Image")));
            this.picBoxPelepasanCrossColl11.LocationFloat = new DevExpress.Utils.PointFloat(82.525F, 3.933843F);
            this.picBoxPelepasanCrossColl11.Name = "picBoxPelepasanCrossColl11";
            this.picBoxPelepasanCrossColl11.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxPelepasanCrossColl11.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPelepasanCrossColl11.StylePriority.UseBorders = false;
            this.picBoxPelepasanCrossColl11.Visible = false;
            // 
            // picBoxPelepasanCrossColl12
            // 
            this.picBoxPelepasanCrossColl12.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxPelepasanCrossColl12.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPelepasanCrossColl12.Image")));
            this.picBoxPelepasanCrossColl12.LocationFloat = new DevExpress.Utils.PointFloat(82.52499F, 3.933834F);
            this.picBoxPelepasanCrossColl12.Name = "picBoxPelepasanCrossColl12";
            this.picBoxPelepasanCrossColl12.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxPelepasanCrossColl12.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxPelepasanCrossColl12.StylePriority.UseBorders = false;
            this.picBoxPelepasanCrossColl12.Visible = false;
            // 
            // xrTableCell44
            // 
            this.xrTableCell44.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell44.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblPelepasanCrossColl11});
            this.xrTableCell44.Name = "xrTableCell44";
            this.xrTableCell44.StylePriority.UseBorders = false;
            this.xrTableCell44.Weight = 0.64959235462295306D;
            // 
            // lblPelepasanCrossColl11
            // 
            this.lblPelepasanCrossColl11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPelepasanCrossColl11.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPelepasanCrossColl11.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPelepasanCrossColl11.LocationFloat = new DevExpress.Utils.PointFloat(0F, 42.30366F);
            this.lblPelepasanCrossColl11.Name = "lblPelepasanCrossColl11";
            this.lblPelepasanCrossColl11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPelepasanCrossColl11.SizeF = new System.Drawing.SizeF(130.1514F, 13.62502F);
            this.lblPelepasanCrossColl11.StylePriority.UseBorders = false;
            this.lblPelepasanCrossColl11.StylePriority.UseFont = false;
            this.lblPelepasanCrossColl11.StylePriority.UseForeColor = false;
            this.lblPelepasanCrossColl11.StylePriority.UseTextAlignment = false;
            this.lblPelepasanCrossColl11.Text = "Approve datetime";
            this.lblPelepasanCrossColl11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblPelepasanCrossColl11.Visible = false;
            // 
            // xrTableCell52
            // 
            this.xrTableCell52.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell52.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblPelepasanCrossColl12});
            this.xrTableCell52.Name = "xrTableCell52";
            this.xrTableCell52.StylePriority.UseBorders = false;
            this.xrTableCell52.Weight = 1.3504072917596877D;
            // 
            // lblPelepasanCrossColl12
            // 
            this.lblPelepasanCrossColl12.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPelepasanCrossColl12.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblPelepasanCrossColl12.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPelepasanCrossColl12.LocationFloat = new DevExpress.Utils.PointFloat(24.27651F, 42.30359F);
            this.lblPelepasanCrossColl12.Name = "lblPelepasanCrossColl12";
            this.lblPelepasanCrossColl12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPelepasanCrossColl12.SizeF = new System.Drawing.SizeF(242.8012F, 13.62508F);
            this.lblPelepasanCrossColl12.StylePriority.UseBorders = false;
            this.lblPelepasanCrossColl12.StylePriority.UseFont = false;
            this.lblPelepasanCrossColl12.StylePriority.UseForeColor = false;
            this.lblPelepasanCrossColl12.StylePriority.UseTextAlignment = false;
            this.lblPelepasanCrossColl12.Text = "Note";
            this.lblPelepasanCrossColl12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblPelepasanCrossColl12.Visible = false;
            // 
            // xrTableRow30
            // 
            this.xrTableRow30.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell71,
            this.xrTableCell89,
            this.xrTableCell90});
            this.xrTableRow30.Name = "xrTableRow30";
            this.xrTableRow30.Weight = 0.52591626753516818D;
            // 
            // xrTableCell71
            // 
            this.xrTableCell71.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell71.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.xrTableCell71.Name = "xrTableCell71";
            this.xrTableCell71.StylePriority.UseBorders = false;
            this.xrTableCell71.StylePriority.UseFont = false;
            this.xrTableCell71.Weight = 1.0000003536173594D;
            // 
            // xrTableCell89
            // 
            this.xrTableCell89.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell89.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrTableCell89.Name = "xrTableCell89";
            this.xrTableCell89.StylePriority.UseBorders = false;
            this.xrTableCell89.StylePriority.UseFont = false;
            this.xrTableCell89.Weight = 0.64959235462295306D;
            // 
            // xrTableCell90
            // 
            this.xrTableCell90.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell90.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrTableCell90.Name = "xrTableCell90";
            this.xrTableCell90.StylePriority.UseBorders = false;
            this.xrTableCell90.StylePriority.UseFont = false;
            this.xrTableCell90.Weight = 1.3504072917596877D;
            // 
            // xrTableRow31
            // 
            this.xrTableRow31.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell91,
            this.xrTableCell92,
            this.xrTableCell93});
            this.xrTableRow31.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.xrTableRow31.Name = "xrTableRow31";
            this.xrTableRow31.StylePriority.UseFont = false;
            this.xrTableRow31.StylePriority.UseTextAlignment = false;
            this.xrTableRow31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableRow31.Weight = 0.50695326046569233D;
            // 
            // xrTableCell91
            // 
            this.xrTableCell91.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell91.Name = "xrTableCell91";
            this.xrTableCell91.StylePriority.UseFont = false;
            this.xrTableCell91.Weight = 1.0000003536173594D;
            // 
            // xrTableCell92
            // 
            this.xrTableCell92.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell92.Name = "xrTableCell92";
            this.xrTableCell92.StylePriority.UseFont = false;
            this.xrTableCell92.Weight = 0.64959235462295306D;
            // 
            // xrTableCell93
            // 
            this.xrTableCell93.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell93.Name = "xrTableCell93";
            this.xrTableCell93.StylePriority.UseFont = false;
            this.xrTableCell93.Weight = 1.3504072917596877D;
            // 
            // docInternalMemoPelepasanCrossColl
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader1,
            this.DetailReport,
            this.GroupFooter1,
            this.GroupHeader2,
            this.ReportFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "InternalMemo";
            this.DataSource = this.sqlDataSource1;
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margins = new System.Drawing.Printing.Margins(60, 54, 49, 69);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.DocNo,
            this.DocKey});
            this.Version = "17.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
