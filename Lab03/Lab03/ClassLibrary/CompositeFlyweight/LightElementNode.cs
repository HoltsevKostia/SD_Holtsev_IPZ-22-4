﻿using System.Text;


namespace ClassLibrary.Composite
{
    public class LightElementNode : LightNode
    {
        private string _tagName;
        private string _displayType;
        private string _closingType;
        private List<string> _classes;
        private List<LightNode> _children;
        private string _text;

        public LightElementNode(string tagName, string displayType, string closingType, List<string> classes)
        {
            _tagName = tagName;
            _displayType = displayType;
            _closingType = closingType;
            _classes = classes;
            _children = new List<LightNode>();
        }

        public LightElementNode(string tagName, string text)
        {
            _tagName = tagName;
            _text = text;
        }

        public void AddChild(LightNode node)
        {
            _children.Add(node);
        }

        public override string OuterHTML
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"<{_tagName} class=\"{string.Join(" ", _classes)}\">");
                foreach (var child in _children)
                {
                    sb.Append(child.OuterHTML);
                }
                if (_closingType == "closing")
                    sb.Append($"</{_tagName}>");
                else if (_closingType == "selfClosing")
                    sb.Append("/>");
                return sb.ToString();
            }
        }

        public override string InnerHTML
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (var child in _children)
                {
                    sb.Append(child.OuterHTML);
                }
                return sb.ToString();
            }
        }
        public override string ToHTML()
        {
            return $"<{_tagName}>{_text}</{_tagName}>";
        }
    }
}

