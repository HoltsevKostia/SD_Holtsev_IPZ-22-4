﻿
namespace ClassLibrary.Composite
{
    public abstract class LightNode
    {
        public abstract string OuterHTML { get; }
        public abstract string InnerHTML { get; }
        public abstract string ToHTML();
    }
}
