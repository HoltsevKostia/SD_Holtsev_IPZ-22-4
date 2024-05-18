namespace ClassLibrary.GameStates
{
    public class GameContext
    {
        private IGameState _state;

        public GameContext()
        {
            _state = new MainMenuState();
        }

        public void SetState(IGameState state)
        {
            _state = state;
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }
}
