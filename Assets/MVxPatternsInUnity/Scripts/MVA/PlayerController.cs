namespace MVxPatternsInUnity.Scripts.MVA
{
    public class PlayerController
    {
        private readonly PlayerModel model;
        private readonly PlayerView view;

        public PlayerController(PlayerModel model, PlayerView view)
        {
            this.model = model;
            this.view = view;

            model.Changed += Model_Changed;
        }

        private void Model_Changed()
        {
            int playerLevel = model.GetLevel();
            view.UpdateLevelLabel(playerLevel);
        }

        public void LevelUp()
        {
            model.LevelUp();
        }

        ~PlayerController()
        {
            model.Changed -= Model_Changed;
        }
    }
}
