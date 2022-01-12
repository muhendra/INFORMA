using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DXMNCGUI_INFORMA.Transaction.PeminjamanDokumen
{
    public class PeminjamanDokumenCodeException : Exception
    {
        public PeminjamanDokumenCodeException()
            : base("Empty DocNo  is not allowed.")
        {
        }
    }
}