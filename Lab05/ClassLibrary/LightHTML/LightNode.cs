
namespace ClassLibrary.LightHTML
{
    public abstract class LightNode
    {
        public abstract string OuterHTML { get; }
        public abstract string InnerHTML { get; }
        public abstract string ToHTML();

        public void ExecuteLifecycle()
        {
            OnCreated();
            OnInserted();
            OnRemoved();
        }

        public virtual void OnCreated() { }
        public virtual void OnInserted() { }
        public virtual void OnRemoved() { }
    }
}
