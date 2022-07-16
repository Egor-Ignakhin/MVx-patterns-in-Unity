using System;

namespace MVxPatternsInUnity.Scripts.MVC
{
    public class PlayerModel
    {
        public event Action Changed;
        private int level;

        public int GetLevel()
        {
            return level;
        }

        public void LevelUp()
        {
            level++;

            Changed?.Invoke();
        }
    }
}
