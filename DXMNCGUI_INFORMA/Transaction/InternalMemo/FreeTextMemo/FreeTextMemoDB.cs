using DXMNCGUI_INFORMA.Controllers;
using DXMNCGUI_INFORMA.Controllers.Data;
using DXMNCGUI_INFORMA.Controllers.Registry;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DXMNCGUI_INFORMA.Transaction.InternalMemo.FreeTextMemo
{
    public class FreeTextMemoDB
    {
        protected internal SqlDBSetting myDBSetting;
        protected internal SqlLocalDBSetting myLocalDBSetting;
        protected SqlDBSession myDBSession;
        protected DataTable myBrowseTable;
        protected DBRegistry myDBReg;
        protected DataTable myApprovalListTable;

        internal FreeTextMemoDB()
        {
            myBrowseTable = new DataTable();
            myApprovalListTable = new DataTable();
        }
        public SqlDBSetting DBSetting
        {
            get { return myDBSetting; }
        }
        public SqlLocalDBSetting localDBSetting
        {
            get { return myLocalDBSetting; }
        }
        public SqlDBSession DBSession
        {
            get { return myDBSession; }
        }
        public DBRegistry DBReg
        {
            get
            {
                return this.myDBReg;
            }
        }
        public DataTable BrowseTable
        {
            get { return myBrowseTable; }
        }
        public virtual DataTable LoadBrowseTable(bool bViewAll, string userID)
        {
            return null;
        }
        protected virtual DataSet LoadData(long headerid, string docno)
        {
            return null;
        }
        public long DocKeyUniqueKey()
        {
            return this.myDBReg.IncOne((IRegistryID)new FreeTextMemoDocKey());
        }
        public long DtlAppKeyUniqueKey()
        {
            return this.myDBReg.IncOne((IRegistryID)new FreeTextMemoApprovalDtlKey());
        }

        public static FreeTextMemoDB Create(SqlDBSetting dbSetting, SqlLocalDBSetting localdbsetting, SqlDBSession dbSession)
        {
            FreeTextMemoDB aFTMemoDB = (FreeTextMemoDB)null;
            aFTMemoDB = new FreeTextMemoSql();
            aFTMemoDB.myDBSetting = dbSetting;
            aFTMemoDB.myLocalDBSetting = localdbsetting;
            aFTMemoDB.myDBSession = dbSession;
            return aFTMemoDB;
        }

        private void InitHeaderRow(DataRow row)
        {
            row.BeginEdit();
            DateTime mydate = myLocalDBSetting.GetServerTime();
            row["DocKey"] = DocKeyUniqueKey();
            row["DocNo"] = "NEW";
            row["DocDate"] = mydate;
            row["DocFile"] = DBNull.Value;
            row["DocFile"] = DBNull.Value;
            row["Status"] = "NEW";
            row["Remarks"] = DBNull.Value;
            row["IsApprove"] = DBNull.Value;
            row["NextApprover"] = DBNull.Value;
            row["CreatedBy"] = DBNull.Value;
            row["CreatedDate"] = DBNull.Value;
            row["LastModifiedBy"] = DBNull.Value;
            row["LastModifiedDate"] = DBNull.Value;
            
            row.EndEdit();
        }

        public FreeTextMemoEntity Entity()
        {
            myDBReg = DBRegistry.Create(myLocalDBSetting);
            DataSet dataSet = LoadData(0, "");
            DataRow row = dataSet.Tables["Header"].NewRow();
            this.InitHeaderRow(row);
            dataSet.Tables["Header"].Rows.Add(row);
            return new FreeTextMemoEntity(this, dataSet, DXIAction.New);
        }
        public FreeTextMemoEntity GetEntity(long headerid, string docno)
        {
            myDBReg = DBRegistry.Create(myLocalDBSetting);

            DataSet ds = LoadData(headerid, docno);
            if (ds.Tables[0].Rows.Count == 0)
                return null;
            return new FreeTextMemoEntity(this, ds, DXIAction.Edit);
        }
        public FreeTextMemoEntity Edit(long headerid, string docno, DXIAction action)
        {
            myDBReg = DBRegistry.Create(myLocalDBSetting);
            return this.FreeTextEdit(this.LoadData(headerid, docno));
        }
        public FreeTextMemoEntity View(long headerid, string docno, DXIAction action)
        {
            myDBReg = DBRegistry.Create(myLocalDBSetting);
            return this.FreeTextView(this.LoadData(headerid, docno));
        }
        public FreeTextMemoEntity Approve(long headerid, string docno)
        {
            myDBReg = DBRegistry.Create(myLocalDBSetting);
            return this.FreeTextApprove(this.LoadData(headerid, docno));
        }

        private FreeTextMemoEntity FreeTextView(DataSet newDataSet)
        {
            if (newDataSet.Tables["Header"].Rows.Count == 0)
            {
                return (FreeTextMemoEntity)null;
            }
            else
            {
                long docKey = Convert.ToInt64(newDataSet.Tables["Header"].Rows[0]["DocKey"]);
                return new FreeTextMemoEntity(this, newDataSet, DXIAction.View);
            }
        }
        private FreeTextMemoEntity FreeTextEdit(DataSet newDataSet)
        {
            if (newDataSet.Tables["Header"].Rows.Count == 0)
            {
                return (FreeTextMemoEntity)null;
            }
            else
            {
                long docKey = Convert.ToInt64(newDataSet.Tables["Header"].Rows[0]["DocKey"]);
                return new FreeTextMemoEntity(this, newDataSet, DXIAction.Edit);
            }
        }
        private FreeTextMemoEntity FreeTextApprove(DataSet newDataSet)
        {
            if (newDataSet.Tables["Header"].Rows.Count == 0)
            {
                return (FreeTextMemoEntity)null;
            }
            else
            {
                long docKey = Convert.ToInt64(newDataSet.Tables["Header"].Rows[0]["DocKey"]);
                return new FreeTextMemoEntity(this, newDataSet, DXIAction.Approve);
            }
        }
        public virtual DataTable LoadApprovalList(string strUserID)
        {
            return null;
        }
        public void SaveEntity(FreeTextMemoEntity entity, string strDocName, string strUserID, DXISaveAction saveaction, string strApprovalNote)
        {
            if (entity.DocNo.ToString().Length == 0)
                throw new InternalMemoCodeException();


            SaveData(entity, entity.myDataSet, strDocName, strUserID, saveaction, strApprovalNote);
            LoadBrowseTable(false, myDBSession.LoginUserID);
            try
            {
                if (myBrowseTable.Rows.Count > 0)
                {
                    DataRow r = myBrowseTable.Rows.Find(entity.DocKey);
                    if (r == null)
                    {
                        r = myBrowseTable.NewRow();
                        foreach (DataColumn col in entity.FreeTextMemotable.Columns)
                        {
                            if (myBrowseTable.Columns.Contains(col.ColumnName))
                                r[col.ColumnName] = entity.Row[col];
                        }
                        myBrowseTable.Rows.Add(r);
                    }
                    else
                    {
                        foreach (DataColumn col in entity.FreeTextMemotable.Columns)
                        {
                            if (myBrowseTable.Columns.Contains(col.ColumnName))
                                r[col.ColumnName] = entity.Row[col];
                        }
                    }
                    myBrowseTable.AcceptChanges();
                }
            }
            catch { }
        }
        public virtual void Delete(long headerid)
        {
        }
        protected virtual void SaveData(FreeTextMemoEntity InternalMemo, DataSet ds, string strDocName, string strUserID, DXISaveAction saveaction, string strApprovalNote)
        {
        }
        protected virtual void SaveDataApproval(DataSet ds, DXISaveAction saveaction)
        {
        }
    }
}