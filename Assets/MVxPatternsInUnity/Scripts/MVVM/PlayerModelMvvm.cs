using System;

namespace MVxPatternsInUnity.Scripts.MVVM
{
    public class PlayerModelMvvm
    {
        public event Action Changed;
        public PlayerViewModel playerViewModel;

        private int level;

        public void SetPlayerViewModel(PlayerViewModel playerViewModel)
        {
            this.playerViewModel = playerViewModel;
        }

        public void LevelUp()
        {
            level++;
            Changed?.Invoke();
        }

        public int GetLevel()
        {
            return level;
        }
    }
}
