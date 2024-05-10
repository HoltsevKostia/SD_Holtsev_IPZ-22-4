
using System.Collections;
using System.Collections.Generic;
using ClassLibrary.LightHTML;

namespace ClassLibrary.Iterator
{
    public class BreadthFirstHTMLIterator : IEnumerator<LightNode>
    {
        private Queue<LightNode> queue = new Queue<LightNode>();

        public BreadthFirstHTMLIterator(LightNode root)
        {
            queue.Enqueue(root);
        }

        public LightNode Current
        {
            get { return queue.Peek(); }
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            if (queue.Count == 0)
                return false;

            var currentNode = queue.Dequeue();

            if (currentNode is LightElementNode)
            {
                var children = ((LightElementNode)currentNode).Children;
                foreach (var child in children)
                {
                    queue.Enqueue(child);
                }
            }

            return queue.Count > 0;
        }

        public void Reset()
        {
            
        }
    }
}
