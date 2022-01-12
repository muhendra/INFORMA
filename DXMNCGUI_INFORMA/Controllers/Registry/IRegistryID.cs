using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DXMNCGUI_INFORMA.Controllers.Registry
{
    public interface IRegistryID
    {
        int ID { get; }

        object DefaultValue { get; }

        object NewValue { get; }
    }
}