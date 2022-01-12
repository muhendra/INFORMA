using DXMNCGUI_INFORMA.Controllers.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DXMNCGUI_INFORMA.Transaction.InternalMemo.FreeTemplate
{
    public class FreeTemplateEntity
    {
        private FreeTemplateDB myFreeTemplateDBCommand;
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
        public FreeTemplateDB InternalFreeTemplateDBCommand
        {
            get
            {
                return this.myFreeTemplateDBCommand;
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
        public DataSet FreeTemplateDataSet
        {
            get
            {
                return this.myDataSet;
            }
        }

        public FreeTemplateEntity(FreeTemplateDB aFreeTemplate, DataSet ds, DXIAction action)
        {
            myFreeTemplateDBCommand = aFreeTemplate;
            myDataSet = ds;
            this.myAction = action;
            this.myHeaderTable = this.myDataSet.Tables["Header"];
            this.myApprovalTable = this.myDataSet.Tables["Approval"];
            myRow = myHeaderTable.Rows[0];
            this.myHeaderTable.ColumnChanged += new DataColumnChangeEventHandler(this.myHeaderTable_ColumnChanged);
        }
        private void myHeaderTable_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {

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
                    this.myRow["LastModifiedDateTime"] = (object)this.myFreeTemplateDBCommand.DBSetting.GetServerTime();
                    if (this.myRow["CreatedBy"].ToString().Length == 0)
                        this.myRow["CreatedBy"] = (object)userID;
                    this.myRow.EndEdit();
                    myFreeTemplateDBCommand.SaveEntity(this, strDocName, userID, saveaction, strApprovalNote);
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
        public FreeTemplateApprovalRecord AddApprovals()
        {
            if (this.myAction == DXIAction.View)
                throw new Exception("Cannot edit read-only Application Lines");
            else
                return this.InternalAddApprovals(SeqUtils.GetLastSeq(this.ValidApprovalRows));
        }
        private FreeTemplateApprovalRecord InternalAddApprovals(int seq)
        {
            DataRow row = this.myApprovalTable.NewRow();
            DateTime myDate = myFreeTemplateDBCommand.localDBSetting.GetServerTime();
            string iUserID = myFreeTemplateDBCommand.DBSession.LoginUserID;
            row["DtlAppKey"] = myFreeTemplateDBCommand.DtlAppKeyUniqueKey();
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
            return new FreeTemplateApprovalRecord(row, this);
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
        public object DocValue
        {
            get { return myRow["DocValue"]; }
            set { myRow["DocValue"] = value; }
        }
        public object DocBinary
        {
            get { return myRow["DocBinary"]; }
            set { myRow["DocBinary"] = value; }
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

        public DataTable FreeTemplatetable
        {
            get { return myDataSet.Tables[0]; }
        }
    }
}