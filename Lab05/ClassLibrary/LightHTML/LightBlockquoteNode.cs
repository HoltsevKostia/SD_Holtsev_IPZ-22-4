﻿
using ClassLibrary.LightHTML;

namespace ClassLibrary.LightHTML
{
    public class LightBlockquoteNode : LightNode
    {
        private string _text;

        public LightBlockquoteNode(string text)
        {
            _text = text;
        }

        public override string OuterHTML => throw new NotImplementedException();

        public override string InnerHTML => throw new NotImplementedException();

        public override string ToHTML()
        {
            return $"<blockquote>{_text}</blockquote>";
        }
    }
}
