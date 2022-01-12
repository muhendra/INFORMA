using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DXMNCGUI_INFORMA.Transaction.InternalMemo
{
    public class InternalMemoCodeException : Exception
    {
        public InternalMemoCodeException()
            : base("Empty DocNo  is not allowed.")
        {
        }
    }
}