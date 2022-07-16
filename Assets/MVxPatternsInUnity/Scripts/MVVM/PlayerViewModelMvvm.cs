using System;

namespace MVxPatternsInUnity.Scripts.MVVM
{
    public class PlayerViewModelMvvm
    {
        public event Action Changed;
        private readonly PlayerModelMvvm playerModel;

        public PlayerViewModelMvvm(PlayerModelMvvm playerModel)
        {
            this.playerModel = playerModel;
            playerModel.Changed += PlayerModel_Changed;
        }

        private void PlayerModel_Changed()
        {
            Changed?.Invoke();
        }

        public int GetLevel()
        {
            return playerModel.GetLevel();
        }

        public void LevelUp()
        {
            playerModel.LevelUp();
        }

        ~PlayerViewModelMvvm()
        {
            playerModel.Changed -= PlayerModel_Changed;
        }
    }
}
