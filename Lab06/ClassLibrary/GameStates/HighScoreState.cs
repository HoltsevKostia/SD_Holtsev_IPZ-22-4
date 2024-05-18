namespace ClassLibrary.GameStates
{
    public class HighScoreState : IGameState
    {
        public void Handle(GameContext context)
        {
            Console.Clear();
            // Показ таблиці рекордів
            Console.WriteLine("High Scores");
            //метод для виведення таблиці рекордів

            context.SetState(new MainMenuState());
        }
    }
}
