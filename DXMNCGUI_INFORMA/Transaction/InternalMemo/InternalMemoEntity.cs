using DXMNCGUI_INFORMA.Controllers.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DXMNCGUI_INFORMA.Transaction.InternalMemo
{
    public class InternalMemoEntity
    {
        private InternalMemoDB myInternalMemoDBcommand;
        internal DataSet myDataSet;
        private DataRow myRow;
        private DataTable myHeaderTable;
        private DataTable myDetailPemakaianCashCollTable;
        private DataTable myDetailPelepasanCrossCollTable;
        private DataTable myDetailPendingGiroTable;
        private DataTable myDetailPurchaseRequestTable;
        private DataTable myDetailBiayaBulananTable;
        private DataTable myDetailFreeTextTable;
        private DataTable myApprovalTable;
        private DXIAction myAction;
        private DXIType myDocType;
        public string strErrorGenMemo;

        internal DataRow Row
        {
            get { return myRow; }
        }

        public InternalMemoDB InternalMemoDBcommand
        {
            get
            {
                return this.myInternalMemoDBcommand;
            }
        }
        public DataTable DataTableHeader
        {
            get
            {
                return this.myHeaderTable;
            }
        }
        public DataTable DataTableDetailPemakaianCashColl
        {
            get
            {
                return this.myDetailPemakaianCashCollTable;
            }
        }
        public DataTable DataTableDetailPelepasanCrossColl
        {
            get
            {
                return this.myDetailPelepasanCrossCollTable;
            }
        }
        public DataTable DataTableDetailPendingGiro
        {
            get
            {
                return this.myDetailPendingGiroTable;
            }
        }
        public DataTable DataTableDetailPurchaseRequest
        {
            get
            {
                return this.myDetailPurchaseRequestTable;
            }
        }
        public DataTable DataTableDetailBiayaBulanan
        {
            get
            {
                return this.myDetailBiayaBulananTable;
            }
        }
        public DataTable DataTableDetailFreeText
        {
            get
            {
                return this.myDetailFreeTextTable;
            }
        }
        public DataTable DataTableApproval
        {
            get
            {
                return this.myApprovalTable;
            }
        }
        public DataSet InternalMemoDataSet
        {
            get
            {
                return this.myDataSet;
            }
        }

        public InternalMemoEntity(InternalMemoDB aMemo, DataSet ds, DXIAction action)
        {
            myInternalMemoDBcommand = aMemo;
            myDataSet = ds;
            this.myAction = action;
            this.myHeaderTable = this.myDataSet.Tables["Header"];
            this.myDetailPemakaianCashCollTable = this.myDataSet.Tables["DetailPemakaianCashColl"];
            this.myDetailPelepasanCrossCollTable = this.myDataSet.Tables["DetailPelepasanCrossColl"];
            this.myDetailPendingGiroTable = this.myDataSet.Tables["DetailPendingGiro"];
            this.myDetailPurchaseRequestTable = this.myDataSet.Tables["DetailPurchaseRequest"];
            this.myDetailBiayaBulananTable = this.myDataSet.Tables["DetailBiayaBulanan"];
            this.myDetailFreeTextTable = this.myDataSet.Tables["DetailFreeText"];
            this.myApprovalTable = this.myDataSet.Tables["Approval"];
            myRow = myHeaderTable.Rows[0];
            this.myHeaderTable.ColumnChanged += new DataColumnChangeEventHandler(this.myHeaderTable_ColumnChanged);
        }
        private void myLinesTable_RowChanged(object sender, DataRowChangeEventArgs e)
        {

        }
        private void myLinesTable_ColumnChanging(object sender, DataColumnChangeEventArgs e)
        {

        }
        private void myHeaderTable_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {

        }
        private void DetailDataRowDeletedEventHandler(object sender, DataRowChangeEventArgs e)
        {
        }
        private void myLinesTable_RowDeleting(object sender, DataRowChangeEventArgs e)
        {

        }
        private void DetailDataColumnChangeEventHandler(object sender, DataColumnChangeEventArgs e)
        {
        }
        public DataTable LoadDocNoFormatTable()
        {
            DataTable mytable = new DataTable();
            mytable = myInternalMemoDBcommand.DBSetting.GetDataTable("select * from DocNoFormat where DOCTYPE='LCW'", false);
            return mytable;
        }
        public DataTable LoadCategoryTable()
        {
            DataTable mytable = new DataTable();
            mytable = myInternalMemoDBcommand.DBSetting.GetDataTable("select Category from [dbo].[Category] where DocType='LCW'", false);
            return mytable;
        }
        public DataTable LoadCategorySubTable(string category)
        {
            DataTable mytable = new DataTable();
            string strQuery = "select Category, SubCategory from CategorySub where Category=? order by SubCategory";
            mytable = myInternalMemoDBcommand.DBSetting.GetDataTable(strQuery, false, category);
            return mytable;
        }
        public DXIAction Action
        {
            get
            {
                return this.myAction;
            }
        }
        public DXIType DocType
        {
            get
            {
                return this.myDocType;
            }
        }

        public void Save(string userID, string userName, string strDocName, DXISaveAction saveaction, string strApprovalNote)
        {
            if (saveaction == DXISaveAction.Cancel)
            {
                this.myAction = DXIAction.Cancel;
            }
            {

                bool flag = this.myRow.RowState != DataRowState.Unchanged;
                if (flag)
                {
                    this.myRow["LastModifiedBy"] = (object)userID;
                    this.myRow["LastModifiedDateTime"] = (object)this.myInternalMemoDBcommand.DBSetting.GetServerTime();
                    if (this.myRow["CreatedBy"].ToString().Length == 0)
                        this.myRow["CreatedBy"] = (object)userID;
                    this.myRow.EndEdit();
                    myInternalMemoDBcommand.SaveEntity(this, strDocName, userID, saveaction, strApprovalNote);
                }
                this.myAction = DXIAction.View;

            }

        }
        public void Edit()
        {
            if (this.myAction == DXIAction.View)
            {
                this.myAction = DXIAction.Edit;
            }
        }

        internal DataRow[] ValidApprovalRows
        {
            get
            {
                return this.myApprovalTable.Select("", "Seq", DataViewRowState.Unchanged | DataViewRowState.Added | DataViewRowState.ModifiedCurrent);
            }
        }
        public ApprovalRecord AddApprovals()
        {
            if (this.myAction == DXIAction.View)
                throw new Exception("Cannot edit read-only Application Lines");
            else
                return this.InternalAddApprovals(SeqUtils.GetLastSeq(this.ValidApprovalRows));
        }
        private ApprovalRecord InternalAddApprovals(int seq)
        {
            DataRow row = this.myApprovalTable.NewRow();
            DateTime myDate = myInternalMemoDBcommand.localDBSetting.GetServerTime();
            string iUserID = myInternalMemoDBcommand.DBSession.LoginUserID;
            row["DtlAppKey"] = myInternalMemoDBcommand.DtlAppKeyUniqueKey();
            row["DocKey"] = this.myRow["DocKey"];
            row["Seq"] = (object)seq;
            row["Name"] = DBNull.Value;
            row["Jabatan"] = DBNull.Value;
            row["IsDecision"] = DBNull.Value;
            row["DecisionState"] = DBNull.Value;
            row["DecisionDate"] = DBNull.Value;
            row["DecisionNote"] = DBNull.Value;
            row["Email"] = DBNull.Value;
            row.EndEdit();
            this.myApprovalTable.Rows.Add(row);
            return new ApprovalRecord(row, this);
        }
        public bool IsApprovalModified()
        {
            if (this.myApprovalTable.GetChanges() != null)
                return true;
            else
                return false;
        }

        internal DataRow[] ValidPelepasanCrossCollRows
        {
            get
            {
                return this.myDetailPelepasanCrossCollTable.Select("", "Seq", DataViewRowState.Unchanged | DataViewRowState.Added | DataViewRowState.ModifiedCurrent);
            }
        }
        public CrossCollRecord AddPelepasanCrossColls()
        {
            if (this.myAction == DXIAction.View)
                throw new Exception("Cannot edit read-only Application Lines");
            else
                return this.InternalAddPelepasanCrossColls(SeqUtils.GetLastSeq(this.ValidPelepasanCrossCollRows));
        }
        private CrossCollRecord InternalAddPelepasanCrossColls(int seq)
        {
            DataRow row = this.myDetailPelepasanCrossCollTable.NewRow();
            DateTime myDate = myInternalMemoDBcommand.localDBSetting.GetServerTime();
            string iUserID = myInternalMemoDBcommand.DBSession.LoginUserID;
            row["DtlKey"] = myInternalMemoDBcommand.PelepasanCrossCollDtlKeyUniqueKey();
            row["DocKey"] = this.myRow["DocKey"];
            row["Seq"] = (object)seq;
            row["AgreementNo"] = DBNull.Value;
            row["AssetDesc"] = DBNull.Value;
            row["ValueAsset"] = DBNull.Value;
            row["OSPH"] = DBNull.Value;
            row["CicilanTenor"] = DBNull.Value;
            row["DendaBerjalan"] = DBNull.Value;
            row.EndEdit();
            this.myDetailPelepasanCrossCollTable.Rows.Add(row);
            return new CrossCollRecord(row, this);
        }
        public bool IsPelepasanCrossCollModified()
        {
            if (this.myDetailPelepasanCrossCollTable.GetChanges() != null)
                return true;
            else
                return false;
        }

        internal DataRow[] ValidPendingGiroRows
        {
            get
            {
                return this.myDetailPendingGiroTable.Select("", "Seq", DataViewRowState.Unchanged | DataViewRowState.Added | DataViewRowState.ModifiedCurrent);
            }
        }
        public PendingGiroRecord AddPendingGiros()
        {
            if (this.myAction == DXIAction.View)
                throw new Exception("Cannot edit read-only Application Lines");
            else
                return this.InternalAddPendingGiros(SeqUtils.GetLastSeq(this.ValidPendingGiroRows));
        }
        private PendingGiroRecord InternalAddPendingGiros(int seq)
        {
            DataRow row = this.myDetailPendingGiroTable.NewRow();
            DateTime myDate = myInternalMemoDBcommand.localDBSetting.GetServerTime();
            string iUserID = myInternalMemoDBcommand.DBSession.LoginUserID;
            row["DtlKey"] = myInternalMemoDBcommand.PendingGiroDtlKeyUniqueKey();
            row["DocKey"] = this.myRow["DocKey"];
            row["Seq"] = (object)seq;
            row["NamaDebitur"] = DBNull.Value;
            row["NoKontrak"] = DBNull.Value;
            row["NamaBank"] = DBNull.Value;
            row["NoGiro"] = DBNull.Value;
            row["NominalGiro"] = DBNull.Value;
            row["AngsuranDariKe"] = DBNull.Value;
            row["TglJatuhTempo"] = DBNull.Value;
            row["LamaPenundaan"] = DBNull.Value;
            row["TglDiJalankanKembali"] = DBNull.Value;
            row.EndEdit();
            this.myDetailPendingGiroTable.Rows.Add(row);
            return new PendingGiroRecord(row, this);
        }
        public bool IsPendingGiroModified()
        {
            if (this.myDetailPendingGiroTable.GetChanges() != null)
                return true;
            else
                return false;
        }

        internal DataRow[] ValidFreeTextRows
        {
            get
            {
                return this.myDetailFreeTextTable.Select("", "Seq", DataViewRowState.Unchanged | DataViewRowState.Added | DataViewRowState.ModifiedCurrent);
            }
        }
        public PendingGiroRecord AddFreeTexts()
        {
            if (this.myAction == DXIAction.View)
                throw new Exception("Cannot edit read-only Application Lines");
            else
                return this.InternalAddFreeTexts(SeqUtils.GetLastSeq(this.ValidFreeTextRows));
        }
        private PendingGiroRecord InternalAddFreeTexts(int seq)
        {
            DataRow row = this.myDetailFreeTextTable.NewRow();
            DateTime myDate = myInternalMemoDBcommand.localDBSetting.GetServerTime();
            string iUserID = myInternalMemoDBcommand.DBSession.LoginUserID;
            row["DtlKey"] = myInternalMemoDBcommand.FreeTextDtlKeyUniqueKey();
            row["DocKey"] = this.myRow["DocKey"];
            row["Seq"] = (object)seq;
            row["FreeTextFile"] = DBNull.Value;
            row.EndEdit();
            this.myDetailFreeTextTable.Rows.Add(row);
            return new PendingGiroRecord(row, this);
        }
        public bool IsFreeTextModified()
        {
            if (this.myDetailPendingGiroTable.GetChanges() != null)
                return true;
            else
                return false;
        }

        internal DataRow[] ValidPurchaseRequestRows
        {
            get
            {
                return this.myDetailPurchaseRequestTable.Select("", "Seq", DataViewRowState.Unchanged | DataViewRowState.Added | DataViewRowState.ModifiedCurrent);
            }
        }
        public PurchaseRequestRecord AddPurchaseRequests()
        {
            if (this.myAction == DXIAction.View)
                throw new Exception("Cannot edit read-only Application Lines");
            else
                return this.InternalAddPurchaseRequests(SeqUtils.GetLastSeq(this.ValidPurchaseRequestRows));
        }
        private PurchaseRequestRecord InternalAddPurchaseRequests(int seq)
        {
            DataRow row = this.myDetailPurchaseRequestTable.NewRow();
            DateTime myDate = myInternalMemoDBcommand.localDBSetting.GetServerTime();
            string iUserID = myInternalMemoDBcommand.DBSession.LoginUserID;
            row["DtlKey"] = myInternalMemoDBcommand.PurchaseRequestDtlKeyUniqeKey();
            row["DocKey"] = this.myRow["DocKey"];
            row["Seq"] = (object)seq;
            row["NamaBarang"] = DBNull.Value;
            row["Kategori"] = DBNull.Value;
            row["Qty"] = DBNull.Value;
            row["Spesifikasi"] = DBNull.Value;
            row["Keterangan"] = DBNull.Value;
            row["IsBudget"] = DBNull.Value;
            row.EndEdit();
            this.myDetailPurchaseRequestTable.Rows.Add(row);
            return new PurchaseRequestRecord(row, this);
        }
        public bool IsPurchaseRequestModified()
        {
            if (this.myDetailPurchaseRequestTable.GetChanges() != null)
                return true;
            else
                return false;
        }

        internal DataRow[] ValidBiayaBulananRows
        {
            get
            {
                return this.myDetailBiayaBulananTable.Select("", "Seq", DataViewRowState.Unchanged | DataViewRowState.Added | DataViewRowState.ModifiedCurrent);
            }
        }
        public BiayaBulananRecord AddBiayaBulanans()
        {
            if (this.myAction == DXIAction.View)
                throw new Exception("Cannot edit read-only Application Lines");
            else
                return this.InternalAddBiayaBulanans(SeqUtils.GetLastSeq(this.ValidBiayaBulananRows));
        }
        private BiayaBulananRecord InternalAddBiayaBulanans(int seq)
        {
            DataRow row = this.myDetailBiayaBulananTable.NewRow();
            DateTime myDate = myInternalMemoDBcommand.localDBSetting.GetServerTime();
            string iUserID = myInternalMemoDBcommand.DBSession.LoginUserID;
            row["DtlKey"] = myInternalMemoDBcommand.BiayaBulananDtlKeyUniqeKey();
            row["DocKey"] = this.myRow["DocKey"];
            row["Seq"] = (object)seq;
            row["Keterangan"] = DBNull.Value;
            row["Periode"] = DBNull.Value;
            row["Remark1"] = "test";
            row["Remark2"] = DBNull.Value;
            row["Total"] = DBNull.Value;
            row.EndEdit();
            this.myDetailBiayaBulananTable.Rows.Add(row);
            return new BiayaBulananRecord(row, this);
        }
        public bool IsBiayaBulananModified()
        {
            if (this.myDetailBiayaBulananTable.GetChanges() != null)
                return true;
            else
                return false;
        }

        public object DocKey
        {
            get { return myRow["DocKey"]; }
            set { myRow["DocKey"] = value; }
        }
        public object DocNo
        {
            get { return myRow["DocNo"]; }
            set { myRow["DocNo"] = value; }
        }
        public object DocDate
        {
            get { return myRow["DocDate"]; }
            set { myRow["DocDate"] = value; }
        }
        public object DocValue
        {
            get { return myRow["DocValue"]; }
            set { myRow["DocValue"] = value; }
        }
        public object Status
        {
            get { return myRow["Status"]; }
            set { myRow["Status"] = value; }
        }
        public object IsApprove
        {
            get { return myRow["IsApprove"]; }
            set { myRow["IsApprove"] = value; }
        }
        public object MemoBranch
        {
            get { return myRow["MemoBranch"]; }
            set { myRow["MemoBranch"] = value; }
        }
        public object MemoFrom
        {
            get { return myRow["MemoFrom"]; }
            set { myRow["MemoFrom"] = value; }
        }
        public object MemoTo
        {
            get { return myRow["MemoTo"]; }
            set { myRow["MemoTo"] = value; }
        }
        public object MemoCC
        {
            get { return myRow["MemoCC"]; }
            set { myRow["MemoCC"] = value; }
        }
        public object MemoPerihal
        {
            get { return myRow["MemoPerihal"]; }
            set { myRow["MemoPerihal"] = value; }
        }
        public object MemoLampiran
        {
            get { return myRow["MemoLampiran"]; }
            set { myRow["MemoLampiran"] = value; }
        }
        public object MemoRefNo
        {
            get { return myRow["MemoRefNo"]; }
            set { myRow["MemoRefNo"] = value; }
        }
        public object DebiturName
        {
            get { return myRow["DebiturName"]; }
            set { myRow["DebiturName"] = value; }
        }
        public object DebiturCIF
        {
            get { return myRow["DebiturCIF"]; }
            set { myRow["DebiturCIF"] = value; }
        }
        public object DebiturAddress
        {
            get { return myRow["DebiturAddress"]; }
            set { myRow["DebiturAddress"] = value; }
        }
        public object DebiturAngsuran
        {
            get { return myRow["DebiturAngsuran"]; }
            set { myRow["DebiturAngsuran"] = value; }
        }
        public object BackgroundText
        {
            get { return myRow["BackgroundText"]; }
            set { myRow["BackgroundText"] = value; }
        }
        public object CostBenefitAnalysisText
        {
            get { return myRow["CostBenefitAnalysisText"]; }
            set { myRow["CostBenefitAnalysisText"] = value; }
        }
        public object GiroReason
        {
            get { return myRow["GiroReason"]; }
            set { myRow["GiroReason"] = value; }
        }
        public object GiroTolakanKe
        {
            get { return myRow["GiroTolakanKe"]; }
            set { myRow["GiroTolakanKe"] = value; }
        }
        public object GiroPreviousApplyDate
        {
            get { return myRow["GiroPreviousApplyDate"]; }
            set { myRow["GiroPreviousApplyDate"] = value; }
        }
        public object CreatedBy
        {
            get { return myRow["CreatedBy"]; }
            set { myRow["CreatedBy"] = value; }
        }
        public object CreatedDateTime
        {
            get { return myRow["CreatedDateTime"]; }
            set { myRow["CreatedDateTime"] = value; }
        }
        public object SubmitBy
        {
            get { return myRow["SubmitBy"]; }
            set { myRow["SubmitBy"] = value; }
        }
        public object SubmitDateTime
        {
            get { return myRow["SubmitDateTime"]; }
            set { myRow["SubmitDateTime"] = value; }
        }
        public object LastModifiedBy
        {
            get { return myRow["LastModifiedBy"]; }
            set { myRow["LastModifiedBy"] = value; }
        }
        public object LastModifiedDateTime
        {
            get { return myRow["LastModifiedDateTime"]; }
            set { myRow["LastModifiedDateTime"] = value; }
        }
        public object HeaderText
        {
            get { return myRow["HeaderText"]; }
            set { myRow["HeaderText"] = value; }
        }
        public object FooterText
        {
            get { return myRow["FooterText"]; }
            set { myRow["FooterText"] = value; }
        }
        public object Note
        {
            get { return myRow["Note"]; }
            set { myRow["Note"] = value; }
        }
        public object Remark1
        {
            get { return myRow["Remark1"]; }
            set { myRow["Remark1"] = value; }
        }
        public object Remark2
        {
            get { return myRow["Remark2"]; }
            set { myRow["Remark2"] = value; }
        }
        public object Remark3
        {
            get { return myRow["Remark3"]; }
            set { myRow["Remark3"] = value; }
        }
        public object Remark4
        {
            get { return myRow["Remark4"]; }
            set { myRow["Remark4"] = value; }
        }
        public object NextApprover
        {
            get { return myRow["NextApprover"]; }
            set { myRow["NextApprover"] = value; }
        }

        public DataTable InternalMemotable
        {
            get { return myDataSet.Tables[0]; }
        }
    }
}