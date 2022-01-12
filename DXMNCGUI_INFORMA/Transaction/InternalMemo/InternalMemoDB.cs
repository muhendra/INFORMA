using DXMNCGUI_INFORMA.Controllers;
using DXMNCGUI_INFORMA.Controllers.Data;
using DXMNCGUI_INFORMA.Controllers.Registry;
using System;
using System.Data;

namespace DXMNCGUI_INFORMA.Transaction.InternalMemo
{
    public class InternalMemoDB
    {
        protected internal SqlDBSetting myDBSetting;
        protected internal SqlLocalDBSetting myLocalDBSetting;
        protected SqlDBSession myDBSession;
        protected DataTable myBrowseTable;
        protected DBRegistry myDBReg;
        protected DataTable myDataTableAllMaster;
        protected DataTable myNoKontrakTable;
        protected DataTable myDebiturTable;
        protected DataTable myDetailAssetTable;
        protected DataTable myBranchTable;
        protected DataTable myApprovalListTable;

        internal InternalMemoDB()
        {
            myBrowseTable = new DataTable();
            myNoKontrakTable = new DataTable();
            myDebiturTable = new DataTable();
            myDetailAssetTable = new DataTable();
            myApprovalListTable = new DataTable();
            myBranchTable = new DataTable();
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
        public DataTable DataTableAllMaster
        {
            get
            {
                return this.myDataTableAllMaster;
            }
        }
        public virtual DataTable LoadBrowseTable(bool bViewAll, string userID)
        {
            return null;
        }
        protected virtual DataSet LoadData(long headerid, string docno, string debiturname)
        {
            return null;
        }
        public long DocKeyUniqueKey()
        {
            return this.myDBReg.IncOne((IRegistryID)new InternalMemoHeaderDocKey());
        }
        public long PelepasanCrossCollDtlKeyUniqueKey()
        {
            return this.myDBReg.IncOne((IRegistryID)new InternalMemoPelepasanCrossCollDtlKey());
        }
        public long PendingGiroDtlKeyUniqueKey()
        {
            return this.myDBReg.IncOne((IRegistryID)new InternalMemoPendingGiroDtlKey());
        }
        public long FreeTextDtlKeyUniqueKey()
        {
            return this.myDBReg.IncOne((IRegistryID)new FreeTextMemoApprovalDtlKey());
        }
        public long DtlAppKeyUniqueKey()
        {
            return this.myDBReg.IncOne((IRegistryID)new InternalMemoApprovalDtlKey());
        }
        public long PurchaseRequestDtlKeyUniqeKey()
        {
            return this.myDBReg.IncOne((IRegistryID)new InternalMemoPurchaseRequestDtlKey());
        }
        public long BiayaBulananDtlKeyUniqeKey()
        {
            return this.myDBReg.IncOne((IRegistryID)new InternalMemoBiayaBulananDtlKey());
        }

        public static InternalMemoDB Create(SqlDBSetting dbSetting, SqlLocalDBSetting localdbsetting, SqlDBSession dbSession)
        {
            InternalMemoDB aInternalMemoDB = (InternalMemoDB)null;
            aInternalMemoDB = new InternalMemoSql();
            aInternalMemoDB.myDBSetting = dbSetting;
            aInternalMemoDB.myLocalDBSetting = localdbsetting;
            aInternalMemoDB.myDBSession = dbSession;
            return aInternalMemoDB;
        }
     
        private void InitHeaderRow(DataRow row, DXIType type, string sDocTypeValue)
        {
            row.BeginEdit();
            DateTime mydate = myLocalDBSetting.GetServerTime();
            row["DocKey"] = DocKeyUniqueKey();
            row["DocNo"] = "NEW";
            row["DocDate"] = mydate;
            row["DocType"] = "";
            row["DocValue"] = sDocTypeValue;
            row["Status"] = "NEW";
            row["IsApprove"] = DBNull.Value;
            row["MemoBranch"] = DBNull.Value;
            row["MemoFrom"] = DBNull.Value;
            row["MemoTo"] = DBNull.Value;
            row["MemoCC"] = DBNull.Value;
            row["MemoPerihal"] = DBNull.Value;
            row["MemoLampiran"] = DBNull.Value;
            row["MemoRefNo"] = DBNull.Value;
            row["DebiturName"] = DBNull.Value;
            row["DebiturCIF"] = DBNull.Value;
            row["DebiturAddress"] = DBNull.Value;
            row["DebiturAngsuran"] = DBNull.Value;
            row["BackgroundText"] = DBNull.Value;
            row["CostBenefitAnalysisText"] = DBNull.Value;
            row["GiroReason"] = DBNull.Value;
            row["GiroTolakanKe"] = DBNull.Value;
            row["GiroPreviousApplyDate"] = DBNull.Value;
            row["CreatedBy"] = DBNull.Value;
            row["CreatedDateTime"] = DBNull.Value;
            row["SubmitBy"] = DBNull.Value;
            row["SubmitDateTime"] = DBNull.Value;
            row["LastModifiedBy"] = DBNull.Value;
            row["LastModifiedDateTime"] = DBNull.Value;
            row["HeaderText"] = DBNull.Value;
            row["FooterText"] = DBNull.Value;
            row["Note"] = DBNull.Value;
            row["Remark1"] = DBNull.Value;
            row["Remark2"] = DBNull.Value;
            row["Remark3"] = DBNull.Value;
            row["Remark4"] = DBNull.Value;
            row.EndEdit();
        }
        public void UpdateAllMaster(DataTable sourceTable)
        {
            if (this.myDataTableAllMaster.PrimaryKey.Length != 0)
            {
                DataRow row = this.myDataTableAllMaster.Rows.Find(sourceTable.Rows[0]["DocKey"]) ?? this.myDataTableAllMaster.NewRow();
                foreach (DataColumn index1 in (InternalDataCollectionBase)row.Table.Columns)
                {
                    int index2 = sourceTable.Columns.IndexOf(index1.ColumnName);
                    if (index2 >= 0)
                        row[index1] = sourceTable.Rows[0][index2];
                }
                row.EndEdit();
                if (row.RowState == DataRowState.Detached)
                    this.myDataTableAllMaster.Rows.Add(row);
            }
        }
        public void DeleteAllMaster(long docKey)
        {
            if (this.myDataTableAllMaster.PrimaryKey.Length != 0)
            {
                DataRow dataRow = this.myDataTableAllMaster.Rows.Find((object)docKey);
                if (dataRow != null)
                    dataRow.Delete();
            }
        }

        public InternalMemoEntity Entity(DXIType type, string sDocTypeValue)
        {
            myDBReg = DBRegistry.Create(myLocalDBSetting);
            DataSet dataSet = LoadData(0, "", "");
            DataRow row = dataSet.Tables["Header"].NewRow();
            this.InitHeaderRow(row, type, sDocTypeValue);
            dataSet.Tables["Header"].Rows.Add(row);
            return new InternalMemoEntity(this, dataSet, DXIAction.New);
        }
        public InternalMemoEntity GetEntity(long headerid, string docno, string debiturname)
        {
            myDBReg = DBRegistry.Create(myLocalDBSetting);

            DataSet ds = LoadData(headerid, docno, debiturname);
            if (ds.Tables[0].Rows.Count == 0)
                return null;
            return new InternalMemoEntity(this, ds, DXIAction.Edit);
        }
        public InternalMemoEntity Edit(long headerid, string docno, string debiturname, DXIAction action)
        {
            myDBReg = DBRegistry.Create(myLocalDBSetting);
            return this.InternalEdit(this.LoadData(headerid, docno, debiturname));
        }
        public InternalMemoEntity View(long headerid, string docno, string debiturname, DXIAction action)
        {
            myDBReg = DBRegistry.Create(myLocalDBSetting);
            return this.InternalView(this.LoadData(headerid, docno, debiturname));
        }
        public InternalMemoEntity Approve(long headerid, string docno, string debiturname)
        {
            myDBReg = DBRegistry.Create(myLocalDBSetting);
            return this.InternalApprove(this.LoadData(headerid, docno, debiturname));
        }

        private InternalMemoEntity InternalView(DataSet newDataSet)
        {
            if (newDataSet.Tables["Header"].Rows.Count == 0)
            {
                return (InternalMemoEntity)null;
            }
            else
            {
                long docKey = Convert.ToInt64(newDataSet.Tables["Header"].Rows[0]["DocKey"]);
                return new InternalMemoEntity(this, newDataSet, DXIAction.View);
            }
        }
        private InternalMemoEntity InternalEdit(DataSet newDataSet)
        {
            if (newDataSet.Tables["Header"].Rows.Count == 0)
            {
                return (InternalMemoEntity)null;
            }
            else
            {
                long docKey = Convert.ToInt64(newDataSet.Tables["Header"].Rows[0]["DocKey"]);
                return new InternalMemoEntity(this, newDataSet, DXIAction.Edit);
            }
        }
        private InternalMemoEntity InternalApprove(DataSet newDataSet)
        {
            if (newDataSet.Tables["Header"].Rows.Count == 0)
            {
                return (InternalMemoEntity)null;
            }
            else
            {
                long docKey = Convert.ToInt64(newDataSet.Tables["Header"].Rows[0]["DocKey"]);
                return new InternalMemoEntity(this, newDataSet, DXIAction.Approve);
            }
        }

        public virtual DataTable LoadDataKontrak()
        {
            return null;
        }
        public virtual DataTable LoadDataDebitur()
        {
            return null;
        }
        public virtual DataTable LoadDataDetailAsset(string scontract)
        {
            return null;
        }
        public virtual DataTable LoadDataBranch(string strUserID)
        {
            return null;
        }
        public virtual DataTable LoadApprovalList(string strUserID)
        {
            return null;
        }
        public void SaveEntity(InternalMemoEntity entity, string strDocName, string strUserID, DXISaveAction saveaction, string strApprovalNote)
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
                        foreach (DataColumn col in entity.InternalMemotable.Columns)
                        {
                            if (myBrowseTable.Columns.Contains(col.ColumnName))
                                r[col.ColumnName] = entity.Row[col];
                        }
                        myBrowseTable.Rows.Add(r);
                    }
                    else
                    {
                        foreach (DataColumn col in entity.InternalMemotable.Columns)
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
        protected virtual void SaveData(InternalMemoEntity InternalMemo, DataSet ds, string strDocName, string strUserID, DXISaveAction saveaction, string strApprovalNote)
        {
        }
        protected virtual void SaveDataApproval(DataSet ds, DXISaveAction saveaction)
        {
        }
        protected virtual void SaveDataDetailPemakaianCashColl(DataSet ds, DXISaveAction saveaction)
        {
        }
        protected virtual void SaveDataDetailPelepasanCrossColl(DataSet ds, DXISaveAction saveaction)
        {
        }
        protected virtual void SaveDataDetailPendingGiro(DataSet ds, DXISaveAction saveaction)
        {
        }
        protected virtual void SaveDataDetailPurchaseRequest(DataSet ds, DXISaveAction saveaction)
        {
        }
        protected virtual void SaveDataDetailBiayaBulanan(DataSet ds, DXISaveAction saveaction)
        {
        }
        protected virtual void SaveDataDetailFreeText(DataSet ds, DXISaveAction saveaction)
        {
        }
    }
}