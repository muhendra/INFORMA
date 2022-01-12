using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DXMNCGUI_INFORMA.Controllers.Registry
{
    public class FreeTemplateHeaderDocKey : BaseRegistryID
    {
        protected override void Init()
        {
            this.myID = 11010;
            this.myDefaultValue = (object)1;
        }
    }
}