using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DXMNCGUI_INFORMA.Transaction.InternalMemo.FreeTextMemo
{
    public class FreeTextMemoCodeException : Exception
    {
        public FreeTextMemoCodeException()
            : base("Empty DocNo  is not allowed.")
        {
        }
    }
}