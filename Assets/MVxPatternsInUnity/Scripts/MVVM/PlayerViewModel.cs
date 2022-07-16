using System;

namespace MVxPatternsInUnity.Scripts.MVVM
{
    public class PlayerViewModel
    {
        public event Action Changed;
        private readonly PlayerModelMvvm playerModel;

        public PlayerViewModel(PlayerModelMvvm playerModel)
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

        ~PlayerViewModel()
        {
            playerModel.Changed -= PlayerModel_Changed;
        }
    }
}
