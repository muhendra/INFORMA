using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DXMNCGUI_INFORMA.Transaction.InternalMemo
{
    public class PurchaseRequestRecord
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
        public string NamaBarang
        {
            get
            {
                return Convert.ToString(this.myRow["NamaBarang"]);
            }
            set
            {
                this.myRow["NamaBarang"] = (object)(value);
            }
        }
        public string Kategori
        {
            get
            {
                return Convert.ToString(this.myRow["Kategori"]);
            }
            set
            {
                this.myRow["Kategori"] = (object)(value);
            }
        }
        public decimal Qty
        {
            get
            {
                return Convert.ToDecimal(this.myRow["Qty"]);
            }
            set
            {
                this.myRow["Qty"] = Convert.ToDecimal(value);
            }
        }
        public string Spesifikasi
        {
            get
            {
                return Convert.ToString(this.myRow["Spesifikasi"]);
            }
            set
            {
                this.myRow["Spesifikasi"] = (object)(value);
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
        public string IsBudget
        {
            get
            {
                return Convert.ToString(this.myRow["IsBudget"]);
            }
            set
            {
                this.myRow["IsBudget"] = (object)(value);
            }
        }

        internal PurchaseRequestRecord(DataRow row, InternalMemoEntity InternalMemoEntity)
        {
            this.myRow = row;
            this.myInternalMemo = InternalMemoEntity;
        }
    }
}