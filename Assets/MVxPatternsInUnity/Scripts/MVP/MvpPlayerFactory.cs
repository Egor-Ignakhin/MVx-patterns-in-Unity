using UnityEngine;

namespace MVxPatternsInUnity.Scripts.MVP
{
    public class MvpPlayerFactory : IPlayerFactory
    {
        public void CreatePlayer()
        {
            PlayerModel model = new PlayerModel();
            var playerView = Object.FindObjectOfType<PlayerView>();
            PlayerPresenter playerPresenter = new PlayerPresenter(playerView, model);
            playerView.OnInit(playerPresenter);
        }
    }
}
