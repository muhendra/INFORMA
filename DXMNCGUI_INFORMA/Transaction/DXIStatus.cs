using DXMNCGUI_INFORMA.Controllers.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DXMNCGUI_INFORMA.Transaction
{
    [StringIdAttribute("DXMNCGUI_INFORMA.Tools.Localization")]
    public enum DXIStatus
    {
        [DefaultString("Incomplete")]
        Incomplete,
        [DefaultString("Submit")]
        Submit,
        [DefaultString("Reject")]
        Reject,
        [DefaultString("Need Approval Required")]
        NeedApproval,
        [DefaultString("Complete")]
        Complete,
        [DefaultString("Reserve")]
        Reserve,
    }
}