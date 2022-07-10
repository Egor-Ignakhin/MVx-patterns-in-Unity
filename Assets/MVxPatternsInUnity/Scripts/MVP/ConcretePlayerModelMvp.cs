namespace MVxPatternsInUnity.Scripts.MVP
{
    public class ConcretePlayerModelMvp : IPlayerModel
    {
        private int level;

        public void SetLevel(int v)
        {
            level = v;
        }

        public int GetLevel()
        {
            return level;
        }
    }
}
