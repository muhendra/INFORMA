using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DXMNCGUI_INFORMA.Transaction.InternalMemo.FreeTemplate
{
    public class FreeTemplateCodeException : Exception
    {
        public FreeTemplateCodeException()
            : base("Empty DocNo  is not allowed.")
        {
        }
    }
}