using DXMNCGUI_INFORMA.Controllers.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DXMNCGUI_INFORMA.Transaction.InternalMemo.FreeTextMemo
{
    public class FreeTextMemoEntity
    {
        private FreeTextMemoDB myFreeTextMemoDBcommand;
        internal DataSet myDataSet;
        private DataRow myRow;
        private DataTable myHeaderTable;
        private DataTable myApprovalTable;
        private DXIAction myAction;
        private DXIType myDocType;
        public string strErrorGenMemo;

        internal DataRow Row
        {
            get { return myRow; }
        }
        public FreeTextMemoDB FreeTextMemoDBcommand
        {
            get
            {
                return this.myFreeTextMemoDBcommand;
            }
        }
        public DataTable DataTableHeader
        {
            get
            {
                return this.myHeaderTable;
            }
        }
        public DataTable DataTableApproval
        {
            get
            {
                return this.myApprovalTable;
            }
        }
        public DataSet FreeTextMemoDataSet
        {
            get
            {
                return this.myDataSet;
            }
        }
        public FreeTextMemoEntity(FreeTextMemoDB aMemo, DataSet ds, DXIAction action)
        {
            myFreeTextMemoDBcommand = aMemo;
            myDataSet = ds;
            this.myAction = action;
            this.myHeaderTable = this.myDataSet.Tables["Header"];
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
            mytable = myFreeTextMemoDBcommand.DBSetting.GetDataTable("select * from DocNoFormat where DOCTYPE='LCW'", false);
            return mytable;
        }
        public DXIAction Action
        {
            get
            {
                return this.myAction;
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
                    this.myRow["LastModifiedDate"] = (object)this.myFreeTextMemoDBcommand.DBSetting.GetServerTime();
                    if (this.myRow["CreatedBy"].ToString().Length == 0)
                        this.myRow["CreatedBy"] = (object)userID;
                    this.myRow.EndEdit();
                    myFreeTextMemoDBcommand.SaveEntity(this, strDocName, userID, saveaction, strApprovalNote);
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
            DateTime myDate = myFreeTextMemoDBcommand.localDBSetting.GetServerTime();
            string iUserID = myFreeTextMemoDBcommand.DBSession.LoginUserID;
            row["DtlAppKey"] = myFreeTextMemoDBcommand.DtlAppKeyUniqueKey();
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
        public object DocFile
        {
            get { return myRow["DocFile"]; }
            set { myRow["DocFile"] = value; }
        }
        public object Status
        {
            get { return myRow["Status"]; }
            set { myRow["Status"] = value; }
        }
        public object Remarks
        {
            get { return myRow["Remarks"]; }
            set { myRow["Remarks"] = value; }
        }
        public object IsApprove
        {
            get { return myRow["IsApprove"]; }
            set { myRow["IsApprove"] = value; }
        }
        public object NextApprover
        {
            get { return myRow["NextApprover"]; }
            set { myRow["NextApprover"] = value; }
        }
        public object CreatedBy
        {
            get { return myRow["CreatedBy"]; }
            set { myRow["CreatedBy"] = value; }
        }
        public object CreatedDate
        {
            get { return myRow["CreatedDate"]; }
            set { myRow["CreatedDate"] = value; }
        }
        public object LastModifiedBy
        {
            get { return myRow["LastModifiedBy"]; }
            set { myRow["LastModifiedBy"] = value; }
        }
        public object LastModifiedDate
        {
            get { return myRow["LastModifiedDate"]; }
            set { myRow["LastModifiedDate"] = value; }
        }
        

        public DataTable FreeTextMemotable
        {
            get { return myDataSet.Tables[0]; }
        }
    }
}