using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DXMNCGUI_INFORMA.Transaction.InternalMemo
{
    public class CrossCollRecord
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
        public string AgreementNo
        {
            get
            {
                return Convert.ToString(this.myRow["AgreementNo"]);
            }
            set
            {
                this.myRow["AgreementNo"] = (object)(value);
            }
        }
        public string AssetDesc
        {
            get
            {
                return Convert.ToString(this.myRow["AssetDesc"]);
            }
            set
            {
                this.myRow["AssetDesc"] = (object)(value);
            }
        }
        public decimal ValueAsset
        {
            get
            {
                return Convert.ToDecimal(this.myRow["ValueAsset"]);
            }
            set
            {
                this.myRow["ValueAsset"] = (object)(value);
            }
        }
        public decimal OSPH
        {
            get
            {
                return Convert.ToDecimal(this.myRow["OSPH"]);
            }
            set
            {
                this.myRow["OSPH"] = (object)(value);
            }
        }
        public string CicilanTenor
        {
            get
            {
                return Convert.ToString(this.myRow["CicilanTenor"]);
            }
            set
            {
                this.myRow["CicilanTenor"] = (object)(value);
            }
        }
        public decimal DendaBerjalan
        {
            get
            {
                return Convert.ToDecimal(this.myRow["DendaBerjalan"]);
            }
            set
            {
                this.myRow["DendaBerjalan"] = (object)(value);
            }
        }

        internal CrossCollRecord(DataRow row, InternalMemoEntity InternalMemoEntity)
        {
            this.myRow = row;
            this.myInternalMemo = InternalMemoEntity;
        }
    }
}