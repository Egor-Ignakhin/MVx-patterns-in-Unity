namespace MVxPatternsInUnity.Scripts.MVP
{
    public class MvpPlayer : IPlayer
    {
        private readonly IPlayerView concretePlayerView;

        public MvpPlayer(IPlayerView playerView)
        {
            this.concretePlayerView = playerView;
        }

        public void LevelUp()
        {
            concretePlayerView.LevelUp();
        }

        public int GetLevel()
        {
            throw new System.NotImplementedException();
        }
    }
}
