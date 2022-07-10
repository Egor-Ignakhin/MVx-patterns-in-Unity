namespace MVxPatternsInUnity.Scripts.MVC
{
    public interface IPlayerView
    {
        public void LevelUp();
        public void OnInit(IPlayerModel m, IPlayerController c);

        public void OnModelChanged();
    }
}
