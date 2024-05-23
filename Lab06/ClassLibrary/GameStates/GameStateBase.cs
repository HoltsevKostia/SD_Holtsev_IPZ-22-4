using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.GameStates
{
    public abstract class GameStateBase : IGameState
    {
        protected void ChangeState(GameContext context, IGameState newState)
        {
            context.SetState(newState);
        }

        public abstract void Handle(GameContext context);
    }
}
