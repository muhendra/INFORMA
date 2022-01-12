﻿using System;
using System.Runtime.Serialization;

namespace DXMNCGUI_INFORMA.Controllers.Data
{
    [Serializable]
    public class PrimaryKeyException : DataAccessException
    {
        private string myConstraintName;

        public string ConstraintName
        {
            get
            {
                return this.myConstraintName;
            }
        }

        public PrimaryKeyException(string message)
          : base(message)
        {
        }

        public PrimaryKeyException(string message, string constraintName)
          : base(message)
        {
            this.myConstraintName = constraintName;
        }

        public PrimaryKeyException(string message, string constraintName, Exception innerException)
          : base(message, innerException)
        {
            this.myConstraintName = constraintName;
        }

        protected PrimaryKeyException(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
}