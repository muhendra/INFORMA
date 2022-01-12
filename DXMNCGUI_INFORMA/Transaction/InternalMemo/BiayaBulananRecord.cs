using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DXMNCGUI_INFORMA.Transaction.InternalMemo
{
    public class BiayaBulananRecord
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
        public string Keterangan
        {
            get
            {
                return Convert.ToString(this.myRow["Keterangan"]);
            }
            set
            {
                this.myRow["Keterangan"] = (object)(value);
            }
        }
        public string Periode
        {
            get
            {
                return Convert.ToString(this.myRow["Periode"]);
            }
            set
            {
                this.myRow["Periode"] = (object)(value);
            }
        }
        public string Remark1
        {
            get
            {
                return Convert.ToString(this.myRow["Remark1"]);
            }
            set
            {
                this.myRow["Remark1"] = (object)(value);
            }
        }
        public string Remark2
        {
            get
            {
                return Convert.ToString(this.myRow["Remark2"]);
            }
            set
            {
                this.myRow["Remark2"] = (object)(value);
            }
        }
        public decimal Total
        {
            get
            {
                return Convert.ToDecimal(this.myRow["Total"]);
            }
            set
            {
                this.myRow["Total"] = (object)(value);
            }
        }

        internal BiayaBulananRecord(DataRow row, InternalMemoEntity InternalMemoEntity)
        {
            this.myRow = row;
            this.myInternalMemo = InternalMemoEntity;
        }
    }
}