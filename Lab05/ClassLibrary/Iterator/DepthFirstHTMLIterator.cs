
using ClassLibrary.LightHTML;
using System.Collections;

namespace ClassLibrary.Iterator
{
    public class DepthFirstHTMLIterator : IEnumerator<LightNode>
    {
        private Stack<LightNode> stack = new Stack<LightNode>();

        public DepthFirstHTMLIterator(LightNode root)
        {
            stack.Push(root);
        }

        public LightNode Current
        {
            get { return stack.Peek(); }
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            if (stack.Count == 0)
                return false;

            var currentNode = stack.Pop();

            if (currentNode is LightElementNode)
            {
                var children = ((LightElementNode)currentNode).Children;
                for (int i = children.Count - 1; i >= 0; i--)
                {
                    stack.Push(children[i]);
                }
            }

            return stack.Count > 0;
        }

        public void Reset()
        {
            
        }
    }
}
