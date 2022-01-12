using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DXMNCGUI_INFORMA.Transaction.InternalMemo
{
    public class PendingGiroRecord
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
        public string NamaDebitur
        {
            get
            {
                return Convert.ToString(this.myRow["NamaDebitur"]);
            }
            set
            {
                this.myRow["NamaDebitur"] = (object)(value);
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
        public string NamaBank
        {
            get
            {
                return Convert.ToString(this.myRow["NamaBank"]);
            }
            set
            {
                this.myRow["NamaBank"] = (object)(value);
            }
        }
        public string NoGiro
        {
            get
            {
                return Convert.ToString(this.myRow["NoGiro"]);
            }
            set
            {
                this.myRow["NoGiro"] = (object)(value);
            }
        }
        public decimal NominalGiro
        {
            get
            {
                return Convert.ToDecimal(this.myRow["NominalGiro"]);
            }
            set
            {
                this.myRow["NominalGiro"] = Convert.ToDecimal(value);
            }
        }
        public string AngsuranDarike
        {
            get
            {
                return Convert.ToString(this.myRow["AngsuranDarike"]);
            }
            set
            {
                this.myRow["AngsuranDarike"] = (object)(value);
            }
        }
        public DateTime TglJatuhTempo
        {
            get
            {
                return Convert.ToDateTime(this.myRow["TglJatuhTempo"]);
            }
            set
            {
                this.myRow["TglJatuhTempo"] = Convert.ToDateTime(value);
            }
        }
        public decimal LamaPenundaan
        {
            get
            {
                return Convert.ToDecimal(this.myRow["LamaPenundaan"]);
            }
            set
            {
                this.myRow["LamaPenundaan"] = Convert.ToDecimal(value);
            }
        }
        public DateTime TglDijalankanKembali
        {
            get
            {
                return Convert.ToDateTime(this.myRow["TglDijalankanKembali"]);
            }
            set
            {
                this.myRow["TglDijalankanKembali"] = Convert.ToDateTime(value);
            }
        }

        internal PendingGiroRecord(DataRow row, InternalMemoEntity InternalMemoEntity)
        {
            this.myRow = row;
            this.myInternalMemo = InternalMemoEntity;
        }
    }
}