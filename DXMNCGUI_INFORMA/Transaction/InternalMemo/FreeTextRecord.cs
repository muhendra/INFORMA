using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DXMNCGUI_INFORMA.Transaction.InternalMemo
{
    public class FreeTextRecord
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
        public byte FreeTextFile
        {
            get
            {
                return Convert.ToByte(this.myRow["FreeTextFile"]);
            }
            set
            {
                this.myRow["FreeTextFile"] = (object)(value);
            }
        }

        internal FreeTextRecord(DataRow row, InternalMemoEntity InternalMemoEntity)
        {
            this.myRow = row;
            this.myInternalMemo = InternalMemoEntity;
        }


    }
}