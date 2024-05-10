
using ClassLibrary.LightHTML;
using System.Collections;

namespace ClassLibrary.Iterator
{
    public class HTMLDocument : IEnumerable<LightNode>
    {
        private LightNode root;
        private bool useBreadthFirstIterator;

        public HTMLDocument(LightNode root, bool useBreadthFirstIterator = false)
        {
            this.root = root;
            this.useBreadthFirstIterator = useBreadthFirstIterator;
        }

        public IEnumerator<LightNode> GetEnumerator()
        {
            if (useBreadthFirstIterator)
                return (IEnumerator<LightNode>)new BreadthFirstHTMLIterator(root);
            else
                return (IEnumerator<LightNode>)new DepthFirstHTMLIterator(root);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
