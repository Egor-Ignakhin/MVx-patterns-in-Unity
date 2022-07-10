using System;

namespace MVxPatternsInUnity.Scripts.MVC
{
    public class ConcretePlayerModelMvc : IPlayerModel
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
