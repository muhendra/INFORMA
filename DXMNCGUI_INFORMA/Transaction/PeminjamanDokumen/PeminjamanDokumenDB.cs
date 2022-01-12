using DXMNCGUI_INFORMA.Controllers;
using DXMNCGUI_INFORMA.Controllers.Data;
using DXMNCGUI_INFORMA.Controllers.Registry;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DXMNCGUI_INFORMA.Transaction.PeminjamanDokumen
{
    public class PeminjamanDokumenDB
    {
        protected internal SqlDBSetting myDBSetting;
        protected internal SqlLocalDBSetting myLocalDBSetting;
        protected SqlDBSession myDBSession;
        protected DataTable myBrowseTable;
        protected DBRegistry myDBReg;
        protected DataTable myDataTableAllMaster;
        protected DataTable myNoKontrakTable;
        protected DataTable myApprovalListTable;

        internal PeminjamanDokumenDB()
        {
            myBrowseTable = new DataTable();
            myNoKontrakTable = new DataTable();
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
        protected virtual DataSet LoadData(long headerid, string docno)
        {
            return null;
        }

        public long DocKeyUniqueKey()
        {
            return this.myDBReg.IncOne((IRegistryID)new PeminjamanDokumenHeaderDocKey());
        }
        public long DtlKeyUniqueKey()
        {
            return this.myDBReg.IncOne((IRegistryID)new PeminjamanDokumenDtlKey());
        }
        public long DtlAppKeyUniqueKey()
        {
            return this.myDBReg.IncOne((IRegistryID)new PeminjamanDokApprovalDtlKey());
        }
        public static PeminjamanDokumenDB Create(SqlDBSetting dbSetting, SqlLocalDBSetting localdbsetting, SqlDBSession dbSession)
        {
            PeminjamanDokumenDB aPeminjamanDokumenDB = (PeminjamanDokumenDB)null;
            aPeminjamanDokumenDB = new PeminjamanDokumenSql();
            aPeminjamanDokumenDB.myDBSetting = dbSetting;
            aPeminjamanDokumenDB.myLocalDBSetting = localdbsetting;
            aPeminjamanDokumenDB.myDBSession = dbSession;
            return aPeminjamanDokumenDB;
        }

        private void InitHeaderRow(DataRow row, DXIType type, string sDocTypeValue)
        {
            row.BeginEdit();
            DateTime mydate = myLocalDBSetting.GetServerTime();
            row["DocKey"] = DocKeyUniqueKey();
            row["DocNo"] = "NEW";
            row["DocDate"] = mydate;
            row["DocCategory"] = "";
            row["Department"] = "";
            row["Status"] = "OPEN";
            row["Keperluan"] = DBNull.Value;
            row["Remark"] = DBNull.Value;
            row["TglPeminjaman"] = DBNull.Value;
            row["TglPengembalian"] = DBNull.Value;
            row["CreatedBy"] = DBNull.Value;
            row["CreatedDateTime"] = DBNull.Value;
            row["LastModifiedBy"] = DBNull.Value;
            row["LastModifiedDateTime"] = DBNull.Value;
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

        public PeminjamanDokumenEntity Entity(DXIType type, string sDocTypeValue)
        {
            myDBReg = DBRegistry.Create(myLocalDBSetting);
            DataSet dataSet = LoadData(0, "");
            DataRow row = dataSet.Tables["Header"].NewRow();
            this.InitHeaderRow(row, type, sDocTypeValue);
            dataSet.Tables["Header"].Rows.Add(row);
            return new PeminjamanDokumenEntity(this, dataSet, DXIAction.New);
        }
        public PeminjamanDokumenEntity GetEntity(long headerid, string docno)
        {
            myDBReg = DBRegistry.Create(myLocalDBSetting);

            DataSet ds = LoadData(headerid, docno);
            if (ds.Tables[0].Rows.Count == 0)
                return null;
            return new PeminjamanDokumenEntity(this, ds, DXIAction.Edit);
        }
        public PeminjamanDokumenEntity Edit(long headerid, string docno, DXIAction action)
        {
            myDBReg = DBRegistry.Create(myLocalDBSetting);
            return this.InternalEdit(this.LoadData(headerid, docno));
        }
        public PeminjamanDokumenEntity View(long headerid, string docno, DXIAction action)
        {
            myDBReg = DBRegistry.Create(myLocalDBSetting);
            return this.InternalView(this.LoadData(headerid, docno));
        }
        public PeminjamanDokumenEntity Approve(long headerid, string docno)
        {
            myDBReg = DBRegistry.Create(myLocalDBSetting);
            return this.InternalApprove(this.LoadData(headerid, docno));
        }

        private PeminjamanDokumenEntity InternalView(DataSet newDataSet)
        {
            if (newDataSet.Tables["Header"].Rows.Count == 0)
            {
                return (PeminjamanDokumenEntity)null;
            }
            else
            {
                long docKey = Convert.ToInt64(newDataSet.Tables["Header"].Rows[0]["DocKey"]);
                return new PeminjamanDokumenEntity(this, newDataSet, DXIAction.View);
            }
        }
        private PeminjamanDokumenEntity InternalEdit(DataSet newDataSet)
        {
            if (newDataSet.Tables["Header"].Rows.Count == 0)
            {
                return (PeminjamanDokumenEntity)null;
            }
            else
            {
                long docKey = Convert.ToInt64(newDataSet.Tables["Header"].Rows[0]["DocKey"]);
                return new PeminjamanDokumenEntity(this, newDataSet, DXIAction.Edit);
            }
        }
        private PeminjamanDokumenEntity InternalApprove(DataSet newDataSet)
        {
            if (newDataSet.Tables["Header"].Rows.Count == 0)
            {
                return (PeminjamanDokumenEntity)null;
            }
            else
            {
                long docKey = Convert.ToInt64(newDataSet.Tables["Header"].Rows[0]["DocKey"]);
                return new PeminjamanDokumenEntity(this, newDataSet, DXIAction.Approve);
            }
        }

        public virtual DataTable LoadDataKontrak()
        {
            return null;
        }
        public virtual DataTable LoadApprovalList(string strUserID)
        {
            return null;
        }
        public void SaveEntity(PeminjamanDokumenEntity entity, string strDocName, string strUserID, DXISaveAction saveaction, string strApprovalNote)
        {
            if (entity.DocNo.ToString().Length == 0)
                throw new PeminjamanDokumenCodeException();


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
                        foreach (DataColumn col in entity.PeminjamanDokumentable.Columns)
                        {
                            if (myBrowseTable.Columns.Contains(col.ColumnName))
                                r[col.ColumnName] = entity.Row[col];
                        }
                        myBrowseTable.Rows.Add(r);
                    }
                    else
                    {
                        foreach (DataColumn col in entity.PeminjamanDokumentable.Columns)
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
        protected virtual void SaveData(PeminjamanDokumenEntity PeminjamanDokumenEntity, DataSet ds, string strDocName, string strUserID, DXISaveAction saveaction, string strApprovalNote)
        {
        }
        protected virtual void SaveDataDetail(DataSet ds, DXISaveAction saveaction)
        {
        }
    }
}