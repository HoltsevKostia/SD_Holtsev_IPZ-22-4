using ClassLibrary.Players;

namespace ClassLibrary.GameStates
{
    public class GameContext
    {
        private IGameState _state;
        public Player CurrentPlayer { get; set; }
        public PlayerManager PlayerManager { get; set; }

        public GameContext()
        {
            PlayerManager = new PlayerManager();
            _state = new LoginState();
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
