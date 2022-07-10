using System;

namespace MVxPatternsInUnity.Scripts.MVC
{
    public interface IPlayerModel
    {
        public event Action Changed;

        public int GetLevel();

        public void LevelUp();
    }
}
