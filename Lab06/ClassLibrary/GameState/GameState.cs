
namespace ClassLibrary.GameState
{
    public abstract class GameState
    {
        public virtual void StartGame() { }
        public virtual void DealCards() { }
        public virtual void PlayerTurn() { }
        public virtual void DealerTurn() { }
        public virtual void EndGame() { }
    }
}
