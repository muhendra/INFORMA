using DXMNCGUI_INFORMA.Controllers.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DXMNCGUI_INFORMA.Transaction.PeminjamanDokumen
{
    public class PeminjamanDokumenEntity
    {
        private PeminjamanDokumenDB myPeminjamanDokumenDBcommand;
        internal DataSet myDataSet;
        private DataRow myRow;
        private DataTable myHeaderTable;
        private DataTable myDetailTable;
        private DataTable myApprovalTable;
        private DXIAction myAction;
        private DXIType myDocType;
        public string strErrorGenMemo;

        internal DataRow Row
        {
            get { return myRow; }
        }

        public PeminjamanDokumenDB PeminjamanDokumenDBcommand
        {
            get
            {
                return this.myPeminjamanDokumenDBcommand;
            }
        }
        public DataTable DataTableHeader
        {
            get
            {
                return this.myHeaderTable;
            }
        }
        public DataTable DataTableDetail
        {
            get
            {
                return this.myDetailTable;
            }
        }
        public DataTable DataTableApproval
        {
            get
            {
                return this.myApprovalTable;
            }
        }
        public DataSet PeminjamanDokumenDataSet
        {
            get
            {
                return this.myDataSet;
            }
        }

        public PeminjamanDokumenEntity(PeminjamanDokumenDB aPeminjamanDokumen, DataSet ds, DXIAction action)
        {
            myPeminjamanDokumenDBcommand = aPeminjamanDokumen;
            myDataSet = ds;
            this.myAction = action;
            this.myHeaderTable = this.myDataSet.Tables["Header"];
            this.myDetailTable = this.myDataSet.Tables["Detail"];
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
            mytable = myPeminjamanDokumenDBcommand.DBSetting.GetDataTable("select * from DocNoFormat where DOCTYPE='LCW'", false);
            return mytable;
        }
        public DataTable LoadCategoryTable()
        {
            DataTable mytable = new DataTable();
            mytable = myPeminjamanDokumenDBcommand.DBSetting.GetDataTable("select Category from [dbo].[Category] where DocType='LCW'", false);
            return mytable;
        }
        public DataTable LoadCategorySubTable(string category)
        {
            DataTable mytable = new DataTable();
            string strQuery = "select Category, SubCategory from CategorySub where Category=? order by SubCategory";
            mytable = myPeminjamanDokumenDBcommand.DBSetting.GetDataTable(strQuery, false, category);
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
                    this.myRow["LastModifiedDateTime"] = (object)this.myPeminjamanDokumenDBcommand.DBSetting.GetServerTime();
                    if (this.myRow["CreatedBy"].ToString().Length == 0)
                        this.myRow["CreatedBy"] = (object)userID;
                    this.myRow.EndEdit();
                    myPeminjamanDokumenDBcommand.SaveEntity(this, strDocName, userID, saveaction, strApprovalNote);
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

        internal DataRow[] ValidDetailRows
        {
            get
            {
                return this.myDetailTable.Select("", "Seq", DataViewRowState.Unchanged | DataViewRowState.Added | DataViewRowState.ModifiedCurrent);
            }
        }
        public PeminjamanDokumenDetailRecord AddDetails()
        {
            if (this.myAction == DXIAction.View)
                throw new Exception("Cannot edit read-only Application Lines");
            else
                return this.InternalAddApprovals(SeqUtils.GetLastSeq(this.ValidDetailRows));
        }

        private PeminjamanDokumenDetailRecord InternalAddApprovals(int seq)
        {
            DataRow row = this.myDetailTable.NewRow();
            DateTime myDate = myPeminjamanDokumenDBcommand.localDBSetting.GetServerTime();
            string iUserID = myPeminjamanDokumenDBcommand.DBSession.LoginUserID;
            row["DtlKey"] = myPeminjamanDokumenDBcommand.DtlKeyUniqueKey();
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
            this.myDetailTable.Rows.Add(row);
            return new PeminjamanDokumenDetailRecord(row, this);
        }
        public bool IsDetailModified()
        {
            if (this.myDetailTable.GetChanges() != null)
                return true;
            else
                return false;
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
                return this.PeminjamanAddApprovals(SeqUtils.GetLastSeq(this.ValidApprovalRows));
        }
        private ApprovalRecord PeminjamanAddApprovals(int seq)
        {
            DataRow row = this.myApprovalTable.NewRow();
            DateTime myDate = myPeminjamanDokumenDBcommand.localDBSetting.GetServerTime();
            string iUserID = myPeminjamanDokumenDBcommand.DBSession.LoginUserID;
            row["DtlAppKey"] = myPeminjamanDokumenDBcommand.DtlAppKeyUniqueKey();
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
        public object DocCategory
        {
            get { return myRow["DocCategory"]; }
            set { myRow["DocCategory"] = value; }
        }
        public object Department
        {
            get { return myRow["Department"]; }
            set { myRow["Department"] = value; }
        }
        public object Status
        {
            get { return myRow["Status"]; }
            set { myRow["Status"] = value; }
        }
        public object Keperluan
        {
            get { return myRow["Keperluan"]; }
            set { myRow["Keperluan"] = value; }
        }
        public object Remark
        {
            get { return myRow["Remark"]; }
            set { myRow["Remark"] = value; }
        }
        public object TglPeminjaman
        {
            get { return myRow["TglPeminjaman"]; }
            set { myRow["TglPeminjaman"] = value; }
        }
        public object TglPengembalian
        {
            get { return myRow["TglPengembalian"]; }
            set { myRow["TglPengembalian"] = value; }
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

        public DataTable PeminjamanDokumentable
        {
            get { return myDataSet.Tables[0]; }
        }
    }
}