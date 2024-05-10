using ClassLibrary.Iterator;

namespace ClassLibrary.State
{
    public class ViewModeContext
    {
        private IViewModeState _state;

        public void SetState(IViewModeState state)
        {
            _state = state;
        }

        public void Render(HTMLDocument document)
        {
            _state.Render(document);
        }
    }
}
