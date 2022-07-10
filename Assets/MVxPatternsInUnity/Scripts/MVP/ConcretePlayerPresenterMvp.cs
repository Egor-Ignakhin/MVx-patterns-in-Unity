namespace MVxPatternsInUnity.Scripts.MVP
{
    public class ConcretePlayerPresenterMvp : IPlayerPresenter
    {
        private readonly IPlayerView view;
        private readonly IPlayerModel model;

        public ConcretePlayerPresenterMvp(IPlayerModel model, IPlayerView view)
        {
            this.model = model;
            this.view = view;
        }

        public void LevelUp()
        {
            var additionalLevel = 1;
            model.SetLevel(model.GetLevel() + additionalLevel);
            view.UpdateLevelLabel(model.GetLevel());
        }
    }
}
