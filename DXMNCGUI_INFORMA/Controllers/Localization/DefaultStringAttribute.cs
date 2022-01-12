using System;

namespace DXMNCGUI_INFORMA.Controllers.Localization
{
    [AttributeUsage(AttributeTargets.Field)]
    public sealed class DefaultStringAttribute : Attribute
    {
        private string myText;

        public string Text
        {
            get
            {
                return this.myText;
            }
        }

        public DefaultStringAttribute(string text)
        {
            if (text == null)
                throw new ArgumentNullException(nameof(text));
            this.myText = text;
        }
    }
}