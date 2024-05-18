using ClassLibrary.GameTemplate;

namespace ClassLibrary.GameStates
{
    public class PlayGameState : IGameState
    {
        public void Handle(GameContext context)
        {
            Console.Clear();
            BlackjackGame game = new ConsoleBlackjackGame();
            game.Play();

            context.SetState(new MainMenuState());
        }
    }
}
