namespace MVxPatternsInUnity.Scripts.MVC
{
    public class PlayerController
    {
        private readonly PlayerModel model;
        private readonly PlayerView view;

        public PlayerController(PlayerModel model, PlayerView view)
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
