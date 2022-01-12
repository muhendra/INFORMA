using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DXMNCGUI_INFORMA.Controllers.Registry
{
    public class InternalMemoApprovalDtlKey : BaseRegistryID
    {
        protected override void Init()
        {
            this.myID = 10030;
            this.myDefaultValue = (object)1;
        }
    }
}