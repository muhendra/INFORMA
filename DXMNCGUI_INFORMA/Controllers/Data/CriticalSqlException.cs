using System;
using System.Runtime.Serialization;

namespace DXMNCGUI_INFORMA.Controllers.Data
{
    [Serializable]
    public class CriticalSqlException : DataAccessException
    {
        public CriticalSqlException(string message)
            : base(message)
        {
        }

        public CriticalSqlException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected CriticalSqlException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}