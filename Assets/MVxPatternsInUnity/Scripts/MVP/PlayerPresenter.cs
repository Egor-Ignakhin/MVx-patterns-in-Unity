namespace MVxPatternsInUnity.Scripts.MVP
{
    public class PlayerPresenter
    {
        private readonly PlayerView view;
        private readonly PlayerModel model;

        public PlayerPresenter(PlayerView view, PlayerModel model)
        {
            this.view = view;
            this.model = model;
        }

        public void LevelUp()
        {
            var additionalLevel = 1;
            model.SetLevel(model.GetLevel() + additionalLevel);
            view.UpdateLevelLabel(model.GetLevel());
        }
    }
}
