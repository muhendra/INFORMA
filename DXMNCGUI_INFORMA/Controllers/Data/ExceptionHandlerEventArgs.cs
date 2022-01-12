using System;

namespace DXMNCGUI_INFORMA.Controllers.Data
{
    public class ExceptionHandlerEventArgs
    {
        private Exception myException;
        private bool myHandled;

        public ExceptionHandlerEventArgs(Exception ex)
        {
            this.myException = ex;
        }

        public Exception Exception
        {
            get
            {
                return this.myException;
            }
            set
            {
                this.myException = value;
            }
        }

        public bool Handled
        {
            get
            {
                return this.myHandled;
            }
            set
            {
                this.myHandled = value;
            }
        }
    }
}