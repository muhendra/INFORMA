using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DXMNCGUI_INFORMA.Transaction.InternalMemo
{
    public class InternalMemoPemakaianCashCollDetailRecord
    {
        private DataRow myRow;
        private InternalMemoEntity myInternalMemo;

        public DataRow Row
        {
            get
            {
                return this.myRow;
            }
        }
        public int DtlKey
        {
            get
            {
                return Convert.ToInt32(this.myRow["DtlKey"]);
            }
        }
        public int DocKey
        {
            get
            {
                return Convert.ToInt32(this.myRow["DocKey"]);
            }
        }
        public int Seq
        {
            get
            {
                return Convert.ToInt32(this.myRow["Seq"]);
            }
        }
        public string AssetDesc
        {
            get
            {
                return System.Convert.ToString(this.myRow["AssetDesc"]);
            }
            set
            {
                this.myRow["AssetDesc"] = (object)(value);
            }
        }
        public string NoRangka
        {
            get
            {
                return Convert.ToString(this.myRow["NoRangka"]);
            }
            set
            {
                this.myRow["NoRangka"] = (object)(value);
            }
        }
        public string NoMesin
        {
            get
            {
                return Convert.ToString(this.myRow["NoMesin"]);
            }
            set
            {
                this.myRow["NoMesin"] = (object)(value);
            }
        }
        public string Tahun
        {
            get
            {
                return Convert.ToString(this.myRow["Tahun"]);
            }
            set
            {
                this.myRow["Tahun"] = (object)(value);
            }
        }

        internal InternalMemoPemakaianCashCollDetailRecord(DataRow row, InternalMemoEntity InternalMemoEntity)
        {
            this.myRow = row;
            this.myInternalMemo = InternalMemoEntity;
        }
    }
}