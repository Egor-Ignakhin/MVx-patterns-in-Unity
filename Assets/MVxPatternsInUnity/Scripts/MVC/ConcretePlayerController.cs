namespace MVxPatternsInUnity.Scripts.MVC
{
    public class ConcretePlayerController : IPlayerController
    {
        private readonly IPlayerModel model;
        private readonly IPlayerView view;

        public ConcretePlayerController(IPlayerModel model, IPlayerView view)
        {
            this.model = model;
            this.view = view;
        }

        public void LevelUp()
        {
            model.LevelUp();
        }
    }
}
