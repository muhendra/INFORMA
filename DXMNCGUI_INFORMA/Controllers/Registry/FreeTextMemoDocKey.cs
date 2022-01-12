using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DXMNCGUI_INFORMA.Controllers.Registry
{
    public class FreeTextMemoDocKey : BaseRegistryID
    {
        protected override void Init()
        {
            this.myID = 20030;
            this.myDefaultValue = (object)1;
        }
    }
}